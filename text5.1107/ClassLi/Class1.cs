using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLi
{
    public abstract class Student
    {
        private string stuName;
        private int stuAge;
        public static int count;
        public string StuNanme
        {
            get { return stuName; }
            set { stuName = value; }
        }
        public int StuAge
        {
            get
            {
                if (stuAge <= 0) { return 0; }
                else { return stuAge; }
            }
        }
        public Student(string Myname, int Myage)
        {
            this.stuName = Myname;
            this.stuAge = Myage;
            count++;
        }
        public abstract double GetAuerage();
        }
    public class Pupil : Student
    {
        private double chinese;
        private double math;
        public double Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }
        public double Math
        {
            get { return math; }
            set { math = value; }
        }
        public Pupil(string Myname,int Myage,double Mychinese, double Mymath)
            :base(Myname,Myage)
        {
            this.chinese = Mychinese;
            this.math = Mymath;
        }
        public override double GetAuerage()
        {
            return(chinese+math)/2;
        }
    }
    public class MaiddleStu : Student
    {
        private double chinese;
        private double math;
        private double english;
        public double Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }
        public double Math
        {
            get { return math; }
            set { math = value; }
        }
        public double English
        {
            get { return english; }
            set { english = value; }
        }
        public MaiddleStu(string Myname,int Myage,double Mychinese, double Mymath,double English)
            :base(Myname,Myage)
        {
            this.chinese = Mychinese;
            this.math = Mymath;
            this.english = English;
        }
        public override double GetAuerage()
        {
            return(chinese + math + english)/3;
        }
    }
    public class CollegeStu : Student
    {
        private double chinese;
        private double math;
        private double english;
        public double Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }
        public double Math
        {
            get { return math; }
            set { math = value; }
        }
        public double English
        {
            get { return english; }
            set { english = value; }
        }
        public CollegeStu(string Myname, int Myage, double Mychinese, double Mymath, double English)
            : base(Myname, Myage)
        {
            this.chinese = Mychinese;
            this.math = Mymath;
            this.english = English;
        }
        public override double GetAuerage()
        {
            return (chinese + math + english) / 3;
        }
    }
}
