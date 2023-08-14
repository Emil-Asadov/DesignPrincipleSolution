using OpenClosedPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Model
{
    internal class ClassMain
    {
        public bool SendOperation(IBanks ic, string acount, int amount)
        {
            return ic.AmountTransfer(amount, acount);
        }
    }
}
