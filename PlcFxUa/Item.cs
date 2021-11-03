using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PlcFxUa
{
    public class Item
    {
        public int ID { get; set; }

        public string nodeId { get; set; }
        public string displayName { get; set; }
        public string dataType { get; set; }
        public ICollection<Measurement> measurements { get; set; }
    }
}
