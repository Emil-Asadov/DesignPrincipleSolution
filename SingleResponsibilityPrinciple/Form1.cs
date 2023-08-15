using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibilityPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DB-nen elaqenin qurulmasini ve kesilmesini temin eden class-da musteri melumatlarini getiren metodun yazilmasi duzgun deyil. Hemin metod ayrica class-n icinde yazilmalidi.
    }
}
