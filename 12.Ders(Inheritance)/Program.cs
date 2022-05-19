using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Ders_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            student.FirstName = "Remzi";
            student.LastName = "Balakishiyev";
            student.Group = "655.18s";
            student.LogData();
            student.Add();


            Teacher teacher = new Teacher();
            teacher.Id = 1;
            teacher.FirstName = "Jon";
            teacher.LastName = "Snow";
            teacher.Salary = 5000;
            teacher.LogData();
            teacher.Add();


            teacher.ShowFullNameT();

            Console.ReadLine();

        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void LogData()
        {
            Console.WriteLine("First name is logging...");
        }

        public virtual void Add()
        {
            Console.WriteLine($"{FirstName} person table elave olundu");
        }


    }

    class Teacher : Person
    {
        public int Salary { get; set; }

        public void ShowFullNameT()
        {
            Console.WriteLine($"{FirstName} - {LastName}");
        }

        public override void Add()
        {
            Console.WriteLine($"{FirstName} {LastName} teacher cedeveline elave olundu..");
        }
    }


    class Student : Person
    {
        public string Group { get; set; }

        public void ShowFullNameS()
        {
            Console.WriteLine($"{FirstName} - {LastName}");
        }
        public override void Add()
        {
            Console.WriteLine($"{FirstName} {LastName} student cedeveline elave olundu..");
        }

    }
}
