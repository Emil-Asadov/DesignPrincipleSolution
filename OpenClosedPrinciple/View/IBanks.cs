using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.View
{
    internal interface IBanks
    {
        bool AmountTransfer(int sendAmount, string account);
    }
}
