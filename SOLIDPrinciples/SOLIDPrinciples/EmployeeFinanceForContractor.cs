﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class EmployeeFinanceForContractor:EmployeeRewards
    {
        public override double CalculateRewards(Employee employee)
        {
            return 120;
        }
    }
}
