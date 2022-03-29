using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_task.Models
{
    class Student:Person
    {
        public double Point { get; set; }

        public Student(string name, string surname, int age, double point) : base()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
        public Student(double point)
        {
            Point = point;
        }
        public static bool operator >(Student s1, Student s2)
        {
            return s1.Point > s2.Point;
        }
        public static bool operator <(Student s1, Student s2)
        {
            return s1.Point < s2.Point;
        }

        public override string ShowInfo()
        {
            return ($"ID: {İD} Name: {Name} Surname: {Surname} Age: {Age} Point: {Point}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }


    }
}
