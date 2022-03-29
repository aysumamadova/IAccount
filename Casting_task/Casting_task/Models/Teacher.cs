using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_task.Models
{
    class Teacher:Person
    {
        public double Salary { get; set; }
        public Teacher(string name, string surname, int age, double salary) : base()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        public Teacher(double salary)
        {
            Salary = salary;
        }
        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }
        public static bool operator <(Teacher t1,Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }
        public override string ShowInfo()
        {
            return ($"ID{İD} Name: {Name} Surname: {Surname} Age: {Age} Point: {Salary}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
