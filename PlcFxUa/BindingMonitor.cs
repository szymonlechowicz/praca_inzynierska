﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcFxUa
{
    class BindingMonitor
    {
        public string nodeId { get; set; }
        public string displayName { get; set; }
        public string type { get; set; }
        public DateTime time { get; set; }
        public object value { get; set; } 
    }
}
