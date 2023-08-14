using LiskovSubstitutionPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Model
{
    internal class AWS : Cloud, ITranslate
    {
        public override string MachineLearning()
        {
            return "AWS MachineLearning";
        }

        public string Translate()
        {
            return "AWS Translate";
        }
    }
}
