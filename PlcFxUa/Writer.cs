using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;
using System.Windows.Forms;
using System.Threading;

namespace PlcFxUa
{
    class Writer
    {
        #region Private Fields
        private Session session;
        private FormStart parent;
        private string dataType;
        private Control control;
        #endregion

        #region Constructors
        public Writer(Session mainSession, FormStart formStart)
        {
            this.session = mainSession;
            this.parent = formStart;
        }
        #endregion

        #region Public Interface
        public void SetWriter(string dataType, Control control)
        {
            this.dataType = dataType;
            this.control = control;
        }
        public void WriteNode(Form form, string nodeId)
        {
            try
            {
                WriteValue valueToWrite = new WriteValue();
                valueToWrite.NodeId = nodeId;
                valueToWrite.AttributeId = Attributes.Value;
                valueToWrite.Value.Value = SetTypeAndValue();
                valueToWrite.Value.StatusCode = StatusCodes.Good;
                valueToWrite.Value.ServerTimestamp = DateTime.Now;
                valueToWrite.Value.SourceTimestamp = DateTime.Now;

                WriteValueCollection valuesToWrite = new WriteValueCollection();
                valuesToWrite.Add(valueToWrite);

                StatusCodeCollection results = null;
                DiagnosticInfoCollection diagnosticInfos = null;

                this.session.Write(
                    null,
                    valuesToWrite,
                    out results,
                    out diagnosticInfos);

                ClientBase.ValidateResponse(results, valuesToWrite);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, valuesToWrite);

                if (StatusCode.IsBad(results[0]))
                {
                    throw new ServiceResultException(results[0]);
                }

                form.DialogResult = DialogResult.OK;
                Thread.Sleep(1000);

                parent.operationLabel.Text = "Writing completed.";
                parent.operationLabel.Visible = true;
                
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        #region Private Members
        private object SetTypeAndValue()
        {
            //object tempValue = (value != null) ? value.Value : null;
            object tempValue;

            switch (dataType)
            {
                case "Boolean":
                    {
                        tempValue = Convert.ToBoolean(control.Text);
                        break;
                    }

                case "SByte":
                    {
                        tempValue = Convert.ToSByte(control.Text);
                        break;
                    }

                case "Byte":
                    {
                        tempValue = Convert.ToByte(control.Text);
                        break;
                    }

                case "Int16":
                    {
                        tempValue = Convert.ToInt16(control.Text);
                        break;
                    }

                case "UInt16":
                    {
                        tempValue = Convert.ToUInt16(control.Text);
                        break;
                    }

                case "Int32":
                    {
                        tempValue = Convert.ToInt32(control.Text);
                        break;
                    }

                case "UInt32":
                    {
                        tempValue = Convert.ToUInt32(control.Text);
                        break;
                    }

                case "Int64":
                    {
                        tempValue = Convert.ToInt64(control.Text);
                        break;
                    }

                case "UInt64":
                    {
                        tempValue = Convert.ToUInt64(control.Text);
                        break;
                    }

                case "Float":
                    {
                        tempValue = Convert.ToSingle(control.Text);
                        break;
                    }

                case "Double":
                    {
                        tempValue = Convert.ToDouble(control.Text);
                        break;
                    }

                default:
                    {
                        tempValue = control.Text;
                        break;
                    }
            }

            return tempValue;
        }
        #endregion
    }
}
