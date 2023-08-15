using DependencyInversionPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Model
{
    internal class ClassMailService
    {
        public string Mail(IMailServer mailServer, string mail, string subject, string body)
        {
            return mailServer.SenMail(mail, subject, body);
        }
    }
}
