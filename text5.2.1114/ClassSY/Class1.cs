using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSY
{
    public abstract class Employee
    {
        private string empld;
        private string empName;
        private string empldNumber;
        private string empHealth;
        private string empPhone;

        public string Empld
        {
            get { return empld; }
            set { empld = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string EmpldNumber
        {
            get { return empldNumber; }
            set { empldNumber = value; }
        }
        public string EmpHealth
        {
            get { return empHealth; }
            set { empHealth = value; }
        }
        public string EmpPhone
        {
            get { return empPhone; }
            set { empPhone = value; }
        }

        public Employee(string id, string name, string idNumber, string health, string phone)
        {
            this.empld = id;
            this.empName = name;
            this.empldNumber = idNumber;
            this.EmpHealth = health;
            this.empPhone = phone;
        }
        public abstract double GetSalary();

        public string ToSalary()
        {
            return string.Format("员工编号：{0}\n员工姓名：{1}\n员工身份证：{2}\n员工健康证号：{3}\n电话：{4}", Empld, EmpName, EmpldNumber, EmpHealth, EmpPhone);
        }
    }
    public class Waiter : Employee
    {
        private int watCount;
        private double watWage;

        public int WatCount
        {
            get { return watCount; }
            set { watCount = value; }
        }
        public double WatWage
        {
            get { return watWage; }
            set { watWage = value; }
        }

        public Waiter(int count, double wage, string id, string name, string idNumber, string health, string phone)
                : base(id, name, idNumber, health, phone)
        {
            this.watCount = count;
            this.watWage = wage;
        }
        public override double GetSalary()
        {
            return WatCount * WatWage;
        }
    }
    public class Cook : Employee
    {
        private string ckLevel;
        private double ckSalary;

        public string CkLevel
        {
            get { return ckLevel; }
            set { ckLevel = value; }
        }
        public double CkSalary
        {
            get { return ckSalary; }
            set { ckSalary = value; }
        }

        public Cook(string level, double salary, string id, string name, string idNumber, string health, string phone)
            : base(id, name, idNumber, health, phone)
        {
            this.ckLevel = level;
            this.ckSalary = salary;
        }

        public override double GetSalary()
        {
            return ckSalary;
        }
    }
}
