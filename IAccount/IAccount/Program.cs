using IAccount.Models;
using System;

namespace IAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";
            string email = "";
            string password = "";
            int studentLimit=0;
            string groupNo = "";
            double point = 0;
            //User u = new User("jhsed","kjd","ahsjdjr2345A");
            //Console.WriteLine(u.PasswordChecker("ahsjdjr2345"));
            //Grop g = new Grop("AP205", 18);
            //Console.WriteLine(g.CheckGroupNo("AP205"));
                InputUser(ref fullname,ref email, ref password);
                User u = new User(fullname, email, password);
                Console.WriteLine(u.PasswordChecker(password));
            int key;
            do
            {
                Console.WriteLine("Reqem daxil edin");
                Console.WriteLine("1. Show info\n2.Create new group");
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                    u.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("Grup melumatlarini qeyd edin");
                        InputGroupNo(ref groupNo);
                        Grop g = new Grop(groupNo, studentLimit);
                        Console.WriteLine( g.CheckGroupNo(groupNo)); 
                        InputStudentLimit(ref studentLimit);
                        do
                        {
                            Console.WriteLine("Reqem daxil edin");
                            Console.WriteLine("  1. Show all students\n  2.Get student by id\n  3.Add student\n  0.Quit");
                            switch (key)
                            {
                                case 1:
                                    g.GetAllStudents();
                                    break;
                                case 2:
                                    int? studentId = null;
                                        Console.WriteLine("Studentin idsin qeyd edin");
                                    studentId = Convert.ToInt32(Console.ReadLine());
                                    g.GetStudent(studentId);

                                    break;
                                case 3:
                                    Console.WriteLine("Student melumatlarin daxil dedin");
                                    InputStudent(ref fullname, ref point);
                                   Student stu1 = new Student(fullname,point);
                                    g.AddStudent(stu1);

                                    break;
                                default:
                                    break;
                            }

                        } while (key !=4);
                        break;

                    default:
                        break;
                }
               
            } while (key != 3);



        }

        static void InputUser(ref string fullname, ref string email, ref string password)
        {
            InputFullname(ref fullname);
            InputEmail(ref email);
            InputPassword(ref password);
        }
        static void InputFullname(ref string fullname)
        {
            Console.WriteLine("Fullname");
            fullname = Console.ReadLine();
        }
        static void InputEmail(ref string email)
        {
            Console.WriteLine("Email");
            email = Console.ReadLine();
        }
        static void InputPassword(ref string password)
        {
            do
            {
                Console.WriteLine("Password");
             password = Console.ReadLine();
                if (password == "false")
                {
                    Console.WriteLine("Parol yanlis daxil deildi");
                }
            } while (password == "false");

        }

        static void InputStudentLimit(ref int studentLimit)
        {
            do
            {
                Console.WriteLine("StudentLimit");
                studentLimit = Convert.ToInt32(Console.ReadLine());
                if (studentLimit<5&& studentLimit>18)
                {
                    Console.WriteLine("Limit asildi");
                }
            } while (studentLimit < 5 && studentLimit > 18);
           
        }

        static void InputGroupNo(ref string groupNo)
        {
            Console.WriteLine("GroupNo");
            groupNo = Console.ReadLine();
        }
        static void InputStudent(ref string fullname, ref double point)
        {
            InputstuFullname(ref fullname);
            InputPoint(ref point);
        }

        private static void InputPoint(ref double point)
        {
            Console.WriteLine("Student point");
            point =Convert.ToDouble(Console.ReadLine());
        }

        private static void InputstuFullname(ref string fullname)
        {
            Console.WriteLine("Fullname");
            fullname = Console.ReadLine();
        }
    }
}
