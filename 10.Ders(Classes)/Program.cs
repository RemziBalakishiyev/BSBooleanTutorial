using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ders_Classes_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Class Intro
            //Student student1 = new Student();
            //student1.GetStudentData();
            //student1.PrintStudent("Std 1");


            //Student student2 = new Student();
            //student2.GetStudentData();
            //student2.PrintStudent("Std 2");
            //student2 = student1; 
            //Console.WriteLine(student2.firstName);
            #endregion


            Teacher teacher = new Teacher("Remzi", "Balakisiyev", "Software developer", 2500);


            teacher.GetTeacherData();
            teacher.Add("Remzi", "Balakisiyev", "Software developer", 2500);







            Console.ReadLine();
        }

    }

    class Student
    {
        public string firstName = "Jon";
        public string lastName = "Snow";
        public int age = 27;

        public Student()
        {
            Console.WriteLine("Student obyekti yaradildi, Constructor ishledi..");
        }

        public void GetStudentData()
        {
            Console.WriteLine($"{firstName} {lastName} is {age} y.o");
        }

        public void PrintStudent(string _firstName)
        {
            firstName = _firstName;
        }
    }

    class Teacher
    {
        string firstName;//firstName = Remzi
        string lastName;
        string speciality;
        double salary;


        public Teacher( string _firstName,
                        string _lastName,
                        string _speciality,
                        double _salary)

        {
            firstName = _firstName;
            lastName = _lastName;
            speciality = _speciality;
            salary = _salary;
        }
        public void GetTeacherData()
        {
            Console.WriteLine($"{firstName} {lastName} is {speciality} and your salary is {salary}");
        }

        public void Add(string _firstName,
                        string _lastName,
                        string _speciality,
                        double _salary
                        )
        {
            firstName = _firstName; /// firstName = Remzi
            lastName = _lastName;
            speciality = _speciality;
            salary = _salary;
        }
    }
}
