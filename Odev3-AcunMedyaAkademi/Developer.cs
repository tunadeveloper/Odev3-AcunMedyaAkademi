﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_AcunMedyaAkademi
{
    public class Developer : Employee
    {
        public string About { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }

}
