using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class EmployeeFinanceForPTE:EmployeeFinances
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWorked * 5;
        }
    }
}
