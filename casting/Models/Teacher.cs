using System;
using System.Collections.Generic;
using System.Text;

namespace casting.Models
{
    class Teacher : Person
    {
        public Teacher(string Name, string Surname, int salary,int Age):base(Name,Surname,Age)
        {
            Salary = salary;
        }
        private float _salary;

        public float Salary
        {
            get => _salary;
            set { if (value >= 0) _salary = value; }
        }

        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }
        public static bool operator <(Teacher t1, Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }

        public override string ShowInfo()
        {
            return $"ID: {ID } \nName: {Name} \nSurname: {Surname} \nAge: {Age} \nSalary: {Salary}";
        }
    }
}
