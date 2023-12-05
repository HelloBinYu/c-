using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2._1017
{
    public partial class btnOK : Form
    {
        public btnOK()
        {
            InitializeComponent();
        }

        private void btnOK_Load(object sender, EventArgs e)
        {

        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = txtString.Text.Length;
            bool b = true;
            for (int i = 0; i < len; i++)
            {
                if (txtString.Text[i] != txtString.Text[len - 1 - i])
                {
                    b = false;
                    break;
                }
            }
            if (b == false)
            {
                lblShow.Text = txtString.Text + "不是回文数！";
            }
            else
            {
                lblShow.Text = txtString.Text + "是回文数！";
            }
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        { }
    }
}