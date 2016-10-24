using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class SearchCriteria
    {

        public SearchCriteria() { }

        public int ReportTypeNum { get; set; }

        public DateTime ChooseDate { get; set; }

        public RangeDate DateRange { get; set; }
    }


    public enum ReportType
    {
        Daily = 0,
        Weekly = 1,
        Monthly = 2,
    };

}