using _17.Ders_Generics_.Enitty;
using _17.Ders_Generics_.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            TeacherManager teacherManager = new TeacherManager();

            teacherManager.Add(new Teacher { Id = 3, FirstName = "Ulvi", LastName = "Ehmedli", Salary = 80000, Groups = new List<string> { "515.18", "620.20", "500.18" } });

            teacherManager.Update(2, new Teacher { Id = 2, FirstName = "Perviz", LastName = "Pirizade", Salary = 100000, Groups = new List<string> { "525.18", "620.20", "500.18" } });


            Teacher teacherById = teacherManager.Get(1);


            teacherManager.Remove(teacherById);

            foreach (var teacher in teacherManager.GetAll())
            {
                Console.WriteLine("FirstName : "+teacher.FirstName);
                Console.WriteLine("LastName : "+teacher.LastName);
                Console.WriteLine("Salary : "+teacher.Salary);
                foreach (var group in teacher.Groups)
                {
                    Console.Write(group+" ,");
                }
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine();

            }

            teacherManager.ShowMonthlySalary(3);

            Console.ReadLine();

        }
    }

   
}
