﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_AcunMedyaAkademi
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
    }

}
