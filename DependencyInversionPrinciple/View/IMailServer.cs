using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.View
{
    internal interface IMailServer
    {
        string SenMail(string mail, string subject, string body);
    }
}
