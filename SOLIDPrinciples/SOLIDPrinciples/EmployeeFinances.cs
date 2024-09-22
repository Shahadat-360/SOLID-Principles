using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLIDPrinciples.Employee;

namespace SOLIDPrinciples
{
    public class EmployeeFinances
    {
        public virtual double CalculatePay(Employee employee)
        {
            return 10;
        }
    }
}
