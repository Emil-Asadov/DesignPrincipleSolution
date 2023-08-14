using LiskovSubstitutionPrinciple.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Model
{
    internal class Google : Cloud, ITranslate
    {
        public override string MachineLearning()
        {
            return "Google MachineLearning";
        }

        public string Translate()
        {
            return "Google Translate";
        }
    }
}
