using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVgenerator
{
    class Education
    {
        public string Degree { get; set; }

        public string School { get; set; }

        public string CityOfSchool { get; set; }

        public string StartYearEd { get; set; }

        public string EndYearEd { get; set; }

        public Education(string degree, string school, string cityOfSchool, string startYearEd, string endYearEd)
        {            
            Degree = degree; School = school; CityOfSchool = cityOfSchool; StartYearEd = startYearEd; EndYearEd = endYearEd;
        }

        public override string ToString()
        {
            if (int.Parse(StartYearEd) == int.Parse(EndYearEd)) return StartYearEd + ":" + Degree + "!" + School + "!" + CityOfSchool;
            return StartYearEd + " - " + EndYearEd + ":" + Degree + "!" + School + "!" + CityOfSchool;
        }
    }
}
