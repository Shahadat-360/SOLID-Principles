using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLIDPrinciples.Employee;

namespace SOLIDPrinciples
{
    public class EmployeeFinances:IEmployeeFinances
    {
        public double CalculatePay(Employee employee)
        {
            return 10;
        }
        public double CalculateRewards(Employee employee)
        {
            return 200;
        }
    }
}
