using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CVgenerator
{
    class EducationManager
    {
        public BindingList<Education> educationList = new BindingList<Education>();

        public void AddEducation(Education education)
        {
            if (int.Parse(education.StartYearEd) > int.Parse(education.EndYearEd))
                throw new ArgumentException("Start year must not be greater than end year!");            
            educationList.Add(education);
        }

        public List<string> GetEducationList()
        {
            List<string> education = new List<string>();
            var request_1 = from edu in educationList
                            where int.Parse(edu.StartYearEd) != int.Parse(edu.EndYearEd)
                            orderby int.Parse(edu.EndYearEd) descending
                            select edu.ToString();
            var request_2 = from edu in educationList
                            where int.Parse(edu.StartYearEd) == int.Parse(edu.EndYearEd)
                            orderby int.Parse(edu.EndYearEd) descending
                            select edu.ToString();
            foreach (var element in request_1)
            {
                education.Add(element);
            }
            foreach (var element in request_2)
            {                
                education.Add(element);                
            }
            return education;
        }
    }
}
