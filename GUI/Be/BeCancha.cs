﻿using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeCancha : IEntity
    {
        public string id { get ; set ; }
        public string Nombre { get; set; }
        public string TipoPago { get; set; }
        
    }
}
