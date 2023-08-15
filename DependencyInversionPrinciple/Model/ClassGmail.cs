using DependencyInversionPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Model
{
    internal class ClassGmail : IMailServer
    {
        public string SenMail(string mail, string subject, string body)
        {
            return $"ClassGmail-{mail}-{subject}-{body}";
        }
    }
}
