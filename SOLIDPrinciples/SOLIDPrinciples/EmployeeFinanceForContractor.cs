using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class EmployeeFinanceForContractor:IEmployeeRewards
    {
        public double CalculateRewards(Employee employee)
        {
            return 120;
        }
    }
}
