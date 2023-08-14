using OpenClosedPrinciple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClosedPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly ClassMain cls = new ClassMain();
        private void btnABank_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{cls.SendOperation(new ClassABank(), "123", 10)}");
        }

        private void btnBBank_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{cls.SendOperation(new ClassBBank(), "123", 10)}");
        }
    }
}
