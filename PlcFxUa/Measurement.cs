using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua.Client;
using Opc.Ua;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PlcFxUa
{
    public class Measurement
    {
        
        public int ID { get; set; }

        public DateTime time { get; set; }
        public string value { get; set; }


        public int monitoredId { get; set; }
        public Item monitoredItems { get; set; }
    }
}
