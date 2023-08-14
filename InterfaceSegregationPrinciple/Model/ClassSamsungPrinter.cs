using InterfaceSegregationPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Model
{
    internal class ClassSamsungPrinter : IPrint, IFax
    {
        public string Fax()
        {
            return "ClassSamsungPrinter Fax method";
        }

        public string Print()
        {
            return "ClassSamsungPrinter Print method";
        }
    }
}
