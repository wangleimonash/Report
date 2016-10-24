using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class HFMT
    {
        public HFMT()
        { 
        
        }

        public string TimeStamps { get; set; }
        public double CodValue { get; set; }
        public double Nh3Valye { get; set; }
        public double FlowS { get; set; }
        public double FlowL { get; set; }
    }
}