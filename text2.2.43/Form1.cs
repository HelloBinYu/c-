using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2._2._43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int unm = Convert.ToInt32(txtNumber.Text);

            if(unm % 4==0 && unm/ 100 !=0 || unm % 400==0)
            {
                lblShow.Text = string.Format("{0}年是闰年！", unm);
            }
            else
                {
                lblShow.Text = string.Format("{0}年是非闰年！", unm);
            }
        }
    }
}
