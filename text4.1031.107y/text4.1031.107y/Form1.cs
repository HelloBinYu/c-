using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text4._1031._107y
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            student stu = new student(stuNo.Text, stuName.Text, stuSex.Text,Convert.ToInt32(stuAge.Text) , stuSpecialty.Text);
            label7.Text = stu.GetMessage().ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class student
    {
        private string stuNO;    // 学号
        private string stuName;    //姓名
        private string stuSex;
        private int stuAge;
        private string stuSpecialty;
        public student(string myNO, string myName2, string mySex, int myAge, string stuSpecialty)
        {
            this.stuNO = myNO;
            this.stuName = myName2;
            this.stuSex = mySex;
            this.stuAge = myAge;
            this.stuSpecialty = stuSpecialty;
        }
        public string StuNO
        {
            get { return stuNO; }
        }
        public string StuName
        {
            get { return stuName; }
        }
        public string StuSex
        {
            get { return stuSex; }
        }
        public int StuAge
        {
            get
            {
                if (stuAge <= 0) { return 0; }
                else { return stuAge; }
            }
            set { stuAge = value; }
        }
        public string StuSpecialty
        {
            get
            {
                if (stuSpecialty == null) { return "未输入"; }
                else { return stuSpecialty; }
            }
            set { stuSpecialty = value; }
        }
        public string GetMessage()
        {
            return string.Format("添加学生信息为：\n学号：{0}\n姓名：{1}\n性别：{2}\n年龄：{3}\n专业：{4}\n", StuNO, StuName, StuSex, StuAge, StuSpecialty);
        }
    }
}
