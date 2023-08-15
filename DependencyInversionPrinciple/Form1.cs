using DependencyInversionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInversionPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly ClassMailService cls = new ClassMailService();
        private void btnGmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cls.Mail(new ClassGmail(), "tete@gmail.com", "gdgd", "dgdgd"));
        }

        private void btnHotMail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cls.Mail(new ClassHotMail(), "tete@hotmail.com", "gdgd", "dgdgd"));
        }

        private void btnYandex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cls.Mail(new ClassYandex(), "tete@yandex.ru", "gdgd", "dgdgd"));
        }
    }
}
