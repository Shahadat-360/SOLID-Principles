﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public interface IEmployeeFinances:IEmployeeRewards
    {
        double CalculatePay(Employee employee);
    }
}
