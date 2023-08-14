using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Model
{
    internal class Azure : Cloud
    {
        public override string MachineLearning()
        {
            return "Azure MachineLearning";
        }
    }
}
