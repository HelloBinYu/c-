using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassSY;

namespace text5._2._1114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            Waiter wt = new Waiter(Convert.ToInt32(txtCount.Text), Convert.ToDouble(txtWage.Text), txtId.Text, txtName.Text, txtIdNumber.Text, txtHealth.Text, txtPhone.Text);
            lblShow.Text += wt.ToSalary() + "\n 工资: " + wt.GetSalary() + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cook ck = new Cook(txtLevel.Text,Convert.ToDouble(txtsalary.Text),txtId.Text,txtName.Text,txtIdNumber.Text,txtHealth.Text,txtPhone.Text);
            lblShow.Text += ck.ToSalary() + "\n" + ck.GetSalary();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
