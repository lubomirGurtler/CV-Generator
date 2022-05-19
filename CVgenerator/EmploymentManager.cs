using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CVgenerator
{
    public class EmploymentManager
    {
        public BindingList<Employment> employmentsList = new BindingList<Employment>();
        
        public void AddEmployment(Employment employment)
        {            
            if (int.Parse(employment.StartYear) > int.Parse(employment.EndYear))
                throw new ArgumentException("Start year must not be greater than end year!");
            if (int.Parse(employment.StartYear) == int.Parse(employment.EndYear) && Auxiliary.GetMonthValue(employment.StartMonth) > Auxiliary.GetMonthValue(employment.EndMonth))
                throw new ArgumentException("Start month must be earlier than end month!");
            employmentsList.Add(employment);            
        }
        
        public List<string> GetEmployments()
        {
            List<string> employments = new List<string>();
            var request = from employment in employmentsList
                          orderby int.Parse(employment.EndYear) descending, Auxiliary.GetMonthValue(employment.EndMonth) descending
                          select employment.ToString();
            foreach (var element in request)
            {
                employments.Add(element);
            }
            return employments;
        }
    }
}
