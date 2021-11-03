using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua.Client;
using Opc.Ua;
using System.Xml;

namespace PlcFxUa
{
    class EncDec
    {
        private Variant value;
        private QualifiedName encodingName;
        private Session session;
        private bool isChanged;

        public EncDec(Session mainSession)
        {
            this.session = mainSession;
        }
        public EncDec(Session mainSession, Variant variant)
        {
            this.session = mainSession;
            SetValue(variant);
        }

        public Variant setVariant()
        {
            return GetValue();
        }        
        //public Variant ShowDialog(Session session, NodeId variableId, Variant value, string caption)
        //{
        //    if (caption != null)
        //    {
        //        this.Text = caption;
        //    }

        //    m_session = session;
        //    m_variableId = variableId;

        //    SetValue(value);

        //    if (ShowDialog() != DialogResult.OK)
        //    {
        //        return Variant.Null;
        //    }

        //    return GetValue();
        //}

        /// <summary>
        /// Sets the value shown in the control.
        /// </summary>
        private void SetValue(Variant value)
        {
            isChanged = false;

            // check for null.
            if (Variant.Null == value)
            {
                this.value = Variant.Null;
                return;
            }

            // get the source type.
            TypeInfo sourceType = value.TypeInfo;

            if (sourceType == null)
            {
                sourceType = TypeInfo.Construct(value.Value);
            }

            this.value = new Variant(value.Value, sourceType);

            // display value as text.
            StringBuilder buffer = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(buffer, new XmlWriterSettings() { Indent = true, OmitXmlDeclaration = true });
            XmlEncoder encoder = new XmlEncoder(new XmlQualifiedName("Value", Namespaces.OpcUaXsd), writer, session.MessageContext);
            encoder.WriteVariantContents(this.value.Value, this.value.TypeInfo);
            writer.Close();

            // extract the encoding id from the value.
            ExpandedNodeId encodingId = null;
            ExtensionObjectEncoding encoding = ExtensionObjectEncoding.None;

            if (sourceType.BuiltInType == BuiltInType.ExtensionObject)
            {
                ExtensionObject extension = null;

                if (sourceType.ValueRank == ValueRanks.Scalar)
                {
                    extension = (ExtensionObject)this.value.Value;
                }
                else
                {
                    // only use the first item in the list for arrays.
                    ExtensionObject[] list = (ExtensionObject[])this.value.Value;

                    if (list.Length > 0)
                    {
                        extension = list[0];
                    }
                }

                encodingId = extension.TypeId;
                encoding = extension.Encoding;
            }

            if (encodingId == null)
            {
                return;
            }

            // check if the encoding is known.
            IObject encodingNode = session.NodeCache.Find(encodingId) as IObject;

            if (encodingNode == null)
            {
                return;
            }

            // update the encoding shown.
            //if (encoding == ExtensionObjectEncoding.EncodeableObject)
            //{
            //    EncodingCB.Text = "(Converted to XML by Client)";
            //}
            //else
            //{
            //    EncodingCB.Text = m_session.NodeCache.GetDisplayText(encodingNode);
            //}

            encodingName = encodingNode.BrowseName;

            // find the data type for the encoding.
            IDataType dataTypeNode = null;

            foreach (INode node in session.NodeCache.Find(encodingNode.NodeId, Opc.Ua.ReferenceTypeIds.HasEncoding, true, false))
            {
                dataTypeNode = node as IDataType;

                if (dataTypeNode != null)
                {
                    break;
                }
            }

            if (dataTypeNode == null)
            {
                return;
            }
            isChanged = true;

            //// update data type display.
            //DataTypeTB.Text = m_session.NodeCache.GetDisplayText(dataTypeNode);
            //DataTypeTB.Tag = dataTypeNode;

            ////// update encoding drop down.
            ////EncodingCB.DropDownItems.Clear();

            //foreach (INode node in session.NodeCache.Find(dataTypeNode.NodeId, Opc.Ua.ReferenceTypeIds.HasEncoding, false, false))
            //{
            //    IObject encodingNode2 = node as IObject;

            //    if (encodingNode2 != null)
            //    {
            //        ToolStripMenuItem item = new ToolStripMenuItem(m_session.NodeCache.GetDisplayText(encodingNode2));
            //        item.Tag = encodingNode2;
            //        item.Click += new EventHandler(EncodingCB_Item_Click);
            //        EncodingCB.DropDownItems.Add(item);
            //    }
            //}

            //StatusCTRL.Visible = true;
        }

        /// <summary>
        /// Converts the XML back to a value.
        /// </summary>
        private Variant GetValue()
        {
            if (!isChanged)
            {
                return this.value;
            }

            XmlDocument document = new XmlDocument();
            
            // find the first element.
            XmlElement element = null;

            for (XmlNode node = document.DocumentElement.FirstChild; node != null; node = node.NextSibling)
            {
                element = node as XmlElement;

                if (element != null)
                {
                    break;
                }
            }

            XmlDecoder decoder = new XmlDecoder(element, session.MessageContext);

            decoder.PushNamespace(Namespaces.OpcUaXsd);
            TypeInfo typeInfo = null;
            object objValue = decoder.ReadVariantContents(out typeInfo);

            return new Variant(objValue, typeInfo);
        }
    }
}
