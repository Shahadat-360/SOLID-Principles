using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class EmployeeFinanceForCLevel : IStockOptions
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWorked * 12;
        }

        public double CalculateRewards(Employee employee)
        {
            return 250;
        }

        public double CalculateStockOptions(Employee employee)
        {
            return 30;
        }
    }
}
