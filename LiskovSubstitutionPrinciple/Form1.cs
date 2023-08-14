using LiskovSubstitutionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiskovSubstitutionPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAWS_Click(object sender, EventArgs e)
        {
            var cls = new AWS();
            var machine = cls.MachineLearning();
            var translate = cls.Translate();
        }

        private void btnAzure_Click(object sender, EventArgs e)
        {
            var cls = new Azure();
            var machine = cls.MachineLearning();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            var cls = new Google();
            var machine = cls.MachineLearning();
            var translate = cls.Translate();
        }
    }
}
