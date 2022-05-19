using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVgenerator
{
    public class Employment
    {
        public string JobTitle { get; set; }

        public string Employer { get; set; }

        public string City { get; set; }

        public string StartMonth { get; set; }

        public string EndMonth { get; set; }

        public string StartYear { get; set; }

        public string EndYear { get; set; }

        public Employment(string jobTitle, string employer, string city, string startMonth, string endMonth, string startYear, string endYear)
        {
            JobTitle = jobTitle; Employer = employer; City = city; StartMonth = startMonth; EndMonth = endMonth; StartYear = startYear; EndYear = endYear;
        }

        public override string ToString()
        {
            return StartMonth + " " + StartYear + "-" + EndMonth + " " + EndYear + ":" + JobTitle + "!" + Employer + "!" + City;
        }
    }
}
