﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;


namespace PlcFxUa
{
    public partial class FormMethod : Form
    {
        private Session session;
        private FormStart parent;
        private BrowsingClass browsing;
        private NodeId methodId;
        private NodeId objectId;

        public FormMethod()
        {
            InitializeComponent();
        }

        public FormMethod(FormStart formStart, Session mainSession)
        {
            InitializeComponent();

            this.parent = formStart;
            this.session = mainSession;
            if (this.session != null)
                this.browsing = new BrowsingClass(this.session);
            //dataGridView1.AutoGenerateColumns = false;

            //this.dataset = new DataSet();
            //dataset.Tables.Add("Arguments");
            //dataset.Tables[0].Columns.Add("Name", typeof(string));
            //dataset.Tables[0].Columns.Add("DataType", typeof(string));
            //dataset.Tables[0].Columns.Add("Value", typeof(Variant));

            //dataGridView1.DataSource = dataset.Tables[0];

            inputLV.View = View.Details;
            inputLV.GridLines = true;
            inputLV.FullRowSelect = true;


            inputLV.Columns.Add("Name", 100);
            inputLV.Columns.Add("DataType", 100);
            inputLV.Columns.Add("Value", 100);
            inputLV.Columns.Add("Description", 100);

            outputLV.View = View.Details;
            outputLV.GridLines = true;
            outputLV.FullRowSelect = true;


            outputLV.Columns.Add("Name", 100);
            outputLV.Columns.Add("DataType", 100);
            outputLV.Columns.Add("Value", 100);
            outputLV.Columns.Add("Description", 100);
        }

        private void UpdateParent()
        {
            parent.GetSession(session);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (session == null || !session.Connected)
                {
                    MethodTB.Text = "No session";
                    return;
                }

                methodId = NodeId.Parse(MethodTB.Text);
                objectId = NodeId.Parse(ObjectTB.Text);

                if (objectId == null || methodId == null)
                {
                    return;
                }
                //browsing.ReadMethodArguments(this.input, methodId);


                Display(true);
                Display(false);

                UpdateParent();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Display(bool isInput)
        {
            //dataset.tables[0].rows.clear();

            //if (input != null)
            //{
            //    foreach (var argument in this.input)
            //    {
            //        string[] row = new string[3];
            //        row = UpdateRow(row, argument, new Variant(argument.Value));
            //        var item = new ListViewItem(row);
            //        inputLV.Items.Add(item);
            //    }
            //}
            //else
            //    button1.Text = "No input";

            if (isInput)
                inputLV.Items.Clear();
            else
                outputLV.Items.Clear();

            MethodNode method = session.NodeCache.Find(methodId) as MethodNode;

            if (method == null)
                return;

            QualifiedName browseName = null;

            if (isInput)
                browseName = BrowseNames.InputArguments;
            else
                browseName = BrowseNames.OutputArguments;

            VariableNode argumentsNode = session.NodeCache.Find
                (methodId, ReferenceTypeIds.HasProperty, false, true, browseName) as VariableNode;

            if (argumentsNode == null)
                return;

            DataValue value = session.ReadValue(argumentsNode.NodeId);

            ExtensionObject[] argumentsList = value.Value as ExtensionObject[];

            if (argumentsList != null)
            {
                for (int i = 0; i < argumentsList.Length; i++)
                {
                    Argument argument = argumentsList[i].Body as Argument;
                    string[] row = new string[4];
                    row = UpdateRow(row, argument);
                    var item = new ListViewItem(row);
                    if (isInput)
                        inputLV.Items.Add(item);
                    else
                        outputLV.Items.Add(item);
                    item.Tag = argumentsList[i].Body;
                }
            }
            btnCall.Enabled = true;
        }

        private string[] UpdateRow(string[] row, Argument argument)
        {
            string dataType = this.session.NodeCache.GetDisplayText(argument.DataType);

            if (argument.ValueRank >= 0)
                dataType += "[]";

            row[0] = argument.Name;
            if (argument.ValueRank >= ValueRanks.OneOrMoreDimensions)
            {
                row[0] += "[]";
            }
            row[1] = dataType;
            
            if (argument.Value == null)
            {
                argument.Value = TypeInfo.GetDefaultValue(argument.DataType, argument.ValueRank, session.TypeTree);

                if (argument.Value == null)
                {
                    Type type = this.session.MessageContext.Factory.GetSystemType(argument.DataType);

                    if (type != null)
                    {
                        if (argument.ValueRank == ValueRanks.Scalar)
                        {
                            argument.Value = new ExtensionObject(Activator.CreateInstance(type));
                        }
                        else
                        {
                            argument.Value = new ExtensionObject[0];
                        }
                    }
                }
            }

            row[2] = String.Format("{0}", argument.Value);
            row[3] = String.Format("{0}", argument.Description.Text);

            return row;
        }
        
        private void btnCall_Click(object sender, EventArgs e)
        {
            try
            {
                VariantCollection inputs = GetInput();

                CallMethodRequest request = new CallMethodRequest();

                request.ObjectId = this.objectId;
                request.MethodId = this.methodId;
                request.InputArguments = inputs;

                CallMethodRequestCollection requests = new CallMethodRequestCollection();

                CallMethodResultCollection results;
                DiagnosticInfoCollection diagnosticInfos;

                ResponseHeader response = this.session.Call(null, requests, out results, out diagnosticInfos);

                if (StatusCode.IsBad(results[0].StatusCode))
                    throw new ServiceResultException(new ServiceResult(results[0].StatusCode, 0, diagnosticInfos, response.StringTable));

                SetOutput(results[0].OutputArguments);

                if (results[0].OutputArguments.Count == 0)
                    MessageBox.Show(this, "Calling method completed");

                Display(false);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private VariantCollection GetInput()
        {
            var inputs = new VariantCollection();

            foreach (ListViewItem item in inputLV.Items)
            {
                Argument argument = item.Tag as Argument;

                if (argument != null)
                {
                    inputs.Add(new Variant(argument.Value));
                }
            }
            return inputs;
        }

        private void SetOutput(VariantCollection outputs)
        {
            int i = 0;

            foreach (ListViewItem item in outputLV.Items)
            {
                Argument argument = item.Tag as Argument;

                if (argument != null)
                {
                    argument.Value = outputs[i++].Value;
                    item.SubItems[2].Text = argument.Value.ToString();
                }
            }
        }

        private void inputLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyTB.Enabled = true;
            btnModify.Enabled = true;

            if (inputLV.SelectedIndices.Count > 0) 
                modifyTB.Text = inputLV.SelectedItems[0].SubItems[2].Text;

            //FormChange formChange = new FormChange();
            //formChange.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            inputLV.SelectedItems[0].SubItems[2].Text = modifyTB.Text;
            if (inputLV.SelectedIndices.Count > 0)
                for (int i = 0; i < inputLV.SelectedIndices.Count; i++)
                {
                    inputLV.Items[inputLV.SelectedIndices[i]].Selected = false;
                }
            modifyTB.Enabled = false;
            modifyTB.Enabled = false;
        }
        private object AddTypeValue(Argument argument, ListViewItem item)
        {
            //object tempValue = (value != null) ? value.Value : null;
            object tempValue;

            switch (this.session.NodeCache.GetDisplayText(argument.DataType))
            {
                case "Boolean":
                    {
                        tempValue = Convert.ToBoolean(item.SubItems[2].Text);
                        break;
                    }

                case "SByte":
                    {
                        tempValue = Convert.ToSByte(item.SubItems[2].Text);
                        break;
                    }

                case "Byte":
                    {
                        tempValue = Convert.ToByte(item.SubItems[2].Text);
                        break;
                    }

                case "Int16":
                    {
                        tempValue = Convert.ToInt16(item.SubItems[2].Text);
                        break;
                    }

                case "UInt16":
                    {
                        tempValue = Convert.ToUInt16(item.SubItems[2].Text);
                        break;
                    }

                case "Int32":
                    {
                        tempValue = Convert.ToInt32(item.SubItems[2].Text);
                        break;
                    }

                case "UInt32":
                    {
                        tempValue = Convert.ToUInt32(item.SubItems[2].Text);
                        break;
                    }

                case "Int64":
                    {
                        tempValue = Convert.ToInt64(item.SubItems[2].Text);
                        break;
                    }

                case "UInt64":
                    {
                        tempValue = Convert.ToUInt64(item.SubItems[2].Text);
                        break;
                    }

                case "Float":
                    {
                        tempValue = Convert.ToSingle(item.SubItems[2].Text);
                        break;
                    }

                case "Double":
                    {
                        tempValue = Convert.ToDouble(item.SubItems[2].Text);
                        break;
                    }

                default:
                    {
                        tempValue = item.SubItems[2].Text;
                        break;
                    }
            }

            return tempValue;
        }
    }
}