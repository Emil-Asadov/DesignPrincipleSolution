using InterfaceSegregationPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Model
{
    internal class ClassHPPrinter : IPrint, IScan, IFax, IPrintDuplex
    {
        public string Fax()
        {
            return "ClassHPPrinter Fax method";
        }

        public string Print()
        {
            return "ClassHPPrinter Print method";
        }

        public string PrintDuplex()
        {
            return "ClassHPPrinter PrintDuplex method";
        }

        public string Scan()
        {
            return "ClassHPPrinter Scan method";
        }
    }
}
