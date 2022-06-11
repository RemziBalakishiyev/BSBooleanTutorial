using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Ders_Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPerson person = new IPerson();
            //person.ShowLastName();


            Employee employee = new Employee();
            employee.FirstName = "Bruce";
            employee.LastName = "Wayne";
            employee.Show();
            employee.ShowLastName();
            employee.ShowConnection(123);


            IPerson emp = new Employee();
            IPerson std = new Student();
            IPerson tch = new Teacher();

             
            Person std2 = new Student();

            std2.SayHi(); //

            emp.LastName = "Remzi";

            Console.ReadLine();
        }
    }


    class Person
    {
        public virtual void  SayHi()
        {
            Console.WriteLine("Hello");
        }

        public  void SayHi(string text)
        {
            Console.WriteLine(text);
        }
    }

    interface IPerson
    {
        string LastName { get; set; }
        void ShowLastName();
        void ShowConnection(int key);
    }
    class Employee : IPerson//ctrl + .
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Show()
        {
            Console.WriteLine(FirstName);
        }

        public void ShowConnection(int key)
        {
            Console.WriteLine("Key : "+key);
        }




        public void ShowLastName()
        {
            Console.WriteLine(LastName);
        }
    }


    class Student : Person,IPerson
    {
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowConnection(int key)
        {
            throw new NotImplementedException();
        }

        public void ShowLastName()
        {
            throw new NotImplementedException();
        }

        public override void SayHi()
        {
            Console.WriteLine("Hello");
        }
    }
    class Teacher : IPerson
    {
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowConnection(int key)
        {
            throw new NotImplementedException();
        }

        public void ShowLastName()
        {
            throw new NotImplementedException();
        }
    }
}
