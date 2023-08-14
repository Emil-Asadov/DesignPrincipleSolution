using InterfaceSegregationPrinciple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceSegregationPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHPPrinter_Click(object sender, EventArgs e)
        {
            var cls = new ClassHPPrinter();
            MessageBox.Show($"{cls.Print()}-{cls.Fax()}-{cls.Scan()}-{cls.PrintDuplex()}");
        }

        private void btnSamsugPrinter_Click(object sender, EventArgs e)
        {
            var cls = new ClassSamsungPrinter();
            MessageBox.Show($"{cls.Print()}-{cls.Fax()}");
        }

        private void btnLexmarkPrinter_Click(object sender, EventArgs e)
        {
            var cls = new ClassLexmarkPrinter();
            MessageBox.Show($"{cls.Print()}-{cls.Scan()}-{cls.Fax()}");
        }
    }
}
