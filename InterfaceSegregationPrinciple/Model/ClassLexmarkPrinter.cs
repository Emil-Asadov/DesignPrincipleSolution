using InterfaceSegregationPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Model
{
    internal class ClassLexmarkPrinter : IPrint, IScan, IFax
    {
        public string Fax()
        {
            return "ClassLexmarkPrinter Fax method";
        }

        public string Print()
        {
            return "ClassLexmarkPrinter Print method";
        }

        public string Scan()
        {
            return "ClassLexmarkPrinter Scan method";
        }
    }
}
