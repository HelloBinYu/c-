using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text6._1128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProvince.SelectedIndex)
            {
                case 0:
                    cmbCity.Items.Clear();
                    cmbCity.Items.Add("武汉市");
                    cmbCity.Items.Add("宜昌市");
                    cmbCity.Items.Add("黄石市");
                    cmbCity.Items.Add("荆州市");
                    break;
                case 1:
                    cmbCity.Items.Clear();
                    cmbCity.Items.Add("长沙市");
                    cmbCity.Items.Add("岳阳市");
                    cmbCity.Items.Add("浏阳市");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbProvince.SelectedIndex = 0;
            cmbProvince.Items.Add("湖北省");
            cmbProvince.Items.Add("湖南省");
            cmbType.Items.Add("管理员");
            cmbType.Items.Add("教师");
            cmbType.Items.Add("学生");

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //if(txtName.Text==string.Empty)
            //{
            //    MessageBox.Show("用户名不得为空，请输入！");
            //    txtName.Focus();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text !=txtRePwd.Text)
            {
                MessageBox.Show("前后两次输入的密码不一致，请重新输入！");
            }

            string type = string.Empty;
            switch(cmbType.SelectedIndex)
            {
                case 0: type = "管理员";break;
                case 1: type = "教师"; break;
                case 2: type = "学生"; break;
            }

            string sex = string.Empty;
            if (rdoMale.Checked) { sex = rdoMale.Text; }
            else { sex = rdoFemale.Text; }

            string address = string.Empty;
            address = cmbProvince.SelectedItem.ToString() + ":" + cmbCity.SelectedItem.ToString();

            CheckBox[] body = new CheckBox[] { chkMusic, chkSport, chkFilm, chkInterent };
            string mes = string.Empty;
            for(int i=0;i<body.Length;i++)
            {
                if(body[i].Checked)
                {
                    mes += body[i].Text + "";
                }
            }

            string message = string.Format("用户名：{0}\n 用户类型：{1}\n 性别：{2}\n 地址：{3}\n 业余爱好：{4}\n",txtName.Text,type,sex,address,mes);
            DialogResult result = MessageBox.Show(message, "确认信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRePwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("用户名不得为空，请输入！");
                txtName.Focus();
            }
        }
    }
}
