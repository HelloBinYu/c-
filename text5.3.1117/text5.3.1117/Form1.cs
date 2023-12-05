using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLixsxxtj;

namespace text5._3._1117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            M ms = new M();
            Student stus = new Student(txtNo.Text, txtName.Text, txtSex.Text, Convert.ToInt32(txtAge.Text), txtSpecialty.Text);
            lblShow.Text += "\n" + ms.AddStudent(stus) + stus.Display();
        }
    }
}
