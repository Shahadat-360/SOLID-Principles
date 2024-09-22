using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPriciples
{
    public class EmployeeFinanceForContractor:EmployeeFinances
    {
        public override double CalculatePay(Employee employee)
        {
            return 100;
        }
    }
}
