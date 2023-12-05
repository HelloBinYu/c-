using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLi
{
    public class Student
    {
        private string stuNo;
        private string stuName;
        private string stuSex;
        private int stuAge;
        private string stuSpec;

        public string StuNo
        {
            get { return stuNo; }
            set { stuNo = value; }
        }
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }
        public string StuSex
        {
            get { return stuSex; }
            set { stuSex = value; }
        }
        public int StuAge
        {
            get { return stuAge; }
            set { stuAge = value; }
        }
        public string StuSpec
        {
            get { return stuSpec; }
            set { stuSpec = value; }
        }

        public Student() { }
        public Student(string NO, string Name, string Sex, int Age, string Spec)
        {
            this.stuNo = NO;
            this.stuName = Name;
            this.stuSex = Sex;
            this.stuAge = Age;
            this.stuSpec = Spec;
        }

        public string Display()
        {
            return string.Format("学生信息：\n 学号：{0}\n 姓名：{1}\n 性别：{2}\n 年龄：{3}\n 专业：{4}", StuNo, StuName, StuSex, StuAge, StuSpec);
        }
    }
    interface IMessage
    {
        ///<summary>
        ///1.添加学生信息的方法
        ///</summary>
        ///<param name="stu"></param>
        ///<returns></returns>
        string AddStudent(Student stu);
    }
    public class Message : IMessage
    {
        private Student[] s = new Student[3];
        private static int count = 0;
        public string AddStudent(Student stu)
        {
            string mes = null;
            foreach (Student st in s)
            {
                if (st != null && st.StuNo == stu.StuNo)
                {
                    mes = string.Format("学生学号重复");
                }
            }
            if (count < s.Length)
            {
                s[count++] = stu;
                mes = string.Format("\n 添加成功！");
            }
            else
            {
                mes = string.Format("\n 学生信息已经录满！");
            }
            return mes;
        }
    }
}
