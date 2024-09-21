using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPriciples
{
    public class Employee
    {
        public double CalculatePay(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee employee) 
        {
            try
            {
                //Code for saving 
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogError(ex.Message);
            }
        }

        public void ReportHours(Employee employee) 
        {
            throw new NotImplementedException();
        }
    }
}
