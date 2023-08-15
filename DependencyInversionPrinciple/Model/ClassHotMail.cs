using DependencyInversionPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Model
{
    internal class ClassHotMail : IMailServer
    {
        public string SenMail(string mail, string subject, string body)
        {
            return $"ClassHotMail-{mail}-{subject}-{body}";
        }
    }
}
