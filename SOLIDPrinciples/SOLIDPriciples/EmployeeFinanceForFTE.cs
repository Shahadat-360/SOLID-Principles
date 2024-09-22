using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPriciples
{
    public class EmployeeFinanceForFTE:EmployeeFinances
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWorked * 10;
        }
    }
}
