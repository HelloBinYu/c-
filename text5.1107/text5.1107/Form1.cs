using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLi;

namespace text5._1107
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] stu = new Student[100];
        public void Display(Student stu)
        {
            string type = "";
            if(stu is CollegeStu)
            { type = "大学生"; }
            if (stu is MaiddleStu)
            { type = "中学生"; }
            if (stu is Pupil)
            { type = "小学生"; }
            lblShow.Text += string.Format("总人数：{0}，姓名：{1},年龄：{2},{3},平均成绩：{4}\n",Student.count,stu.StuNanme,stu.StuAge,type,stu.GetAuerage());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPupil_Click(object sender, EventArgs e)
        {
            Pupil pl = new Pupil(txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToDouble(txtChinese.Text), Convert.ToDouble(txtMath.Text));
            Display(pl);
        }

        private void txtChinese_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            MaiddleStu mds = new MaiddleStu(txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToDouble(txtChinese.Text), Convert.ToDouble(txtMath.Text),Convert.ToDouble(txtEnglish.Text));
            Display(mds);
        }

        private void btnCollege_Click(object sender, EventArgs e)
        {
            CollegeStu cls = new CollegeStu(txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToDouble(txtChinese.Text), Convert.ToDouble(txtMath.Text), Convert.ToDouble(txtEnglish.Text));
            Display(cls);
        }
    }
}
