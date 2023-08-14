using OpenClosedPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Model
{
    internal class ClassABank : IBanks
    {
        public bool AmountTransfer(int sendAmount, string account)
        {
            try
            {
                GetAccountInfo(account);
                GetSendAmountComis(sendAmount);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private bool GetAccountInfo(string accountNo)
        {
            return true;
        }
        private bool GetSendAmountComis(int amount)
        {
            return true;
        }

    }
}
