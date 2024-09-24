using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class Employee
    {
        public string EmployeeType {  get; set; }
        public double TotalHoursWorked {  get; set; }
        private readonly ILogger logger;
        public Employee(ILogger logger) 
        { 
            this.logger = logger;
        }
        public void Save(Employee employee) 
        {
            try
            {
                //Code for saving 
                throw new Exception();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
        }

        public enum empType
        {
            FullTime,
            HalfTime,
            Contractor,
            CLevel
        }
    }
}
