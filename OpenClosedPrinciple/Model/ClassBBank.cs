using OpenClosedPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OpenClosedPrinciple.Model
{
    internal class ClassBBank : IBanks
    {
        public bool AmountTransfer(int sendAmount, string account)
        {
            try
            {
                return SendAmount(sendAmount, account);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool SendAmount(int amount, string account)
        {
            return true;
        }
    }
}
