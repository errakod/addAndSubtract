using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addAndSubtract
{
    public partial class Form1 : Form
    {
        int sum;
        public Form1()
        {
            InitializeComponent();
            sum = 0;
            lblSum.Text = sum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sum++;
            lblSum.Text = sum.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            sum--;
            lblSum.Text = sum.ToString();

        }
    }
}
