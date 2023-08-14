using LooseCouplingPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingPrinciple.Model
{
    internal class ClassMain
    {
        public int GetCalculate(ICalculate iclt, int p1, int p2)
        {
            return iclt.Calculate(p1, p2);
        }
    }
}
