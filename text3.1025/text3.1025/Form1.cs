using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text3._1025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string userPwd = textBox2.Text;
            if (userPwd.Length >= 6 && userPwd.Length <= 14)
            {
                MessageBox.Show("密码长度符合要求！");
            }
            else
            {
                MessageBox.Show("密码长度不符合要求！");
                return;
            }
            //判断前后两次输入的密码是否一致
            if (textBox2.Text == textBox3.Text)
            {
                MessageBox.Show("两次输入密码一致！");
            }
            else
            {
                MessageBox.Show("两次输入密码不一致！");
                return;
            }
            string userName = textBox1.Text;
            Regex regex = new Regex(@"^[A-Za-z]{6,}$");
            if (regex.IsMatch(userName))
            {
                MessageBox.Show("用户名格式正确！");
            }
            else
            {
                MessageBox.Show("用户名格式不正确！");
                return;
            }
            string email = textBox4.Text;
            regex = new Regex(@"^(\w)+(\.\w)*@(\w)+((\.\w+)+)+$");
            if (regex.IsMatch(email))
            {
                MessageBox.Show("邮箱格式正确！");
            }
            else
            {
                MessageBox.Show("邮箱格式不正确！");
                return;
            }
        }
    }
}
