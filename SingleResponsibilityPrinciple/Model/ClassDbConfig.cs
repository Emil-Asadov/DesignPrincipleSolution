using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Model
{
    internal class ClassDbConfig
    {
        public string GetConnectionString()
        {
            return string.Empty;
        }
        public bool CreateConnection()
        {
            return true;
        }
        public bool CloseConection()
        {
            return true;
        }
    }
}
