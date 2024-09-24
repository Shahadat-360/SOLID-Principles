using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class EmployeeFinanceForFTE:IEmployeeFinances
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWorked * 10;
        }

        public double CalculateRewards(Employee employee)
        {
            return 200;
        }
    }
}
