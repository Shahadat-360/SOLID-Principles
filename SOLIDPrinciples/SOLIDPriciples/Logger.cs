﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPriciples
{
    public class Logger
    {
        public void LogError(string message)
        {
            File.WriteAllText("log.txt",message);
        }
    }
}
