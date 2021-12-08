using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;


namespace PlcFxUa
{
    class Reader
    {
        private Session session;
        private Form form;
        public Reader(Form mainForm, Session mainSession)
        {
            this.form = mainForm;
            this.session = mainSession;
        }
        public DataValueCollection ReadTag(string id)
        {
            ReadValueIdCollection readValues = new ReadValueIdCollection();
            readValues.Add(AddNode(id));

            return ReadDataValues(readValues);
        }
        public DataValueCollection ReadTags(string[] ids)
        {
            ReadValueIdCollection readValues = new ReadValueIdCollection();
            foreach (var id in ids)
            {
                readValues.Add(AddNode(id));
            }

            return ReadDataValues(readValues);
        }
        private DataValueCollection ReadDataValues(ReadValueIdCollection readValues)
        {
            DataValueCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;

            this.session.Read(null, Double.MaxValue, TimestampsToReturn.Both, readValues, out results, out diagnosticInfos);

            ClientBase.ValidateResponse(results, readValues);
            ClientBase.ValidateDiagnosticInfos(diagnosticInfos, readValues);

            if (DataValue.IsBad(results[0]))
            {
                throw new ServiceResultException("Error");
            }

            this.form.DialogResult = DialogResult.OK;

            return results;
        }
        private ReadValueId AddNode(string nodeId)
        {
            ReadValueId readValue = new ReadValueId();
            readValue.NodeId = nodeId;
            readValue.AttributeId = Attributes.Value;

            return readValue;
        }
    }
}
