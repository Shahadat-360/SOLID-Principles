﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class EmployeeFinanceForPTE:IEmployeeFinances
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWorked * 5;
        }

        public double CalculateRewards(Employee employee)
        {
            return 150;
        }
    }
}
