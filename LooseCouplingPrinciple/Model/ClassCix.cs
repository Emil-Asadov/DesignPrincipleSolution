﻿using LooseCouplingPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingPrinciple.Model
{
    internal class ClassCix : ICalculate
    {
        public int Calculate(int p1, int p2)
        {
            return p1 - p2;
        }
    }
}
