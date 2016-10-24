using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class RangeDate
    {
        public RangeDate(DateTime st,DateTime et) 
        {
            StartDate = st;
            EndDate = et;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}