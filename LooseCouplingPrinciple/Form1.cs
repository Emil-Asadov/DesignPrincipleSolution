using LooseCouplingPrinciple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LooseCouplingPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly ClassMain cls = new ClassMain();
        int p1, p2, res;

        private void btnVur_Click(object sender, EventArgs e)
        {
            p1 = int.Parse(txtInp1.Text);
            p2 = int.Parse(txtInp2.Text);
            res = cls.GetCalculate(new ClassVur(), p1, p2);
            lblResult.Text = res.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            p1 = int.Parse(txtInp1.Text);
            p2 = int.Parse(txtInp2.Text);
            res = cls.GetCalculate(new ClassBol(), p1, p2);
            lblResult.Text = res.ToString();
        }

        private void btnCix_Click(object sender, EventArgs e)
        {
            p1 = int.Parse(txtInp1.Text);
            p2 = int.Parse(txtInp2.Text);
            res = cls.GetCalculate(new ClassCix(), p1, p2);
            lblResult.Text = res.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            p1 = int.Parse(txtInp1.Text);
            p2 = int.Parse(txtInp2.Text);
            res = cls.GetCalculate(new ClassTopla(), p1, p2);
            lblResult.Text = res.ToString();
        }
    }
}
