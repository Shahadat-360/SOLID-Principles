using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public interface IStockOptions:IEmployeeFinances
    {
        double CalculateStockOptions(Employee employee);
    }
}
