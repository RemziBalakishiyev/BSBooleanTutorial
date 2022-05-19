using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.Id = 1;
            fullTimeEmployee.FirstName = "Bruce";
            fullTimeEmployee.LastName = "Wayne";
            fullTimeEmployee.SalaryOfYear = 50000;
            fullTimeEmployee.ShowSalary();


            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.Id = 1;
            partTimeEmployee.FirstName = "Walter";
            partTimeEmployee.LastName = "White";
            partTimeEmployee.Hour = 6;
            partTimeEmployee.HourOfSalary = 35;
            partTimeEmployee.ShowSalary();


            RemoteEmployee remoteEmployee = new RemoteEmployee();
            remoteEmployee.Id = 1;
            remoteEmployee.FirstName = "Jamie";
            remoteEmployee.LastName = "Lannister";
            remoteEmployee.Hour = 8;
            remoteEmployee.HourOfSalary = 40;
            remoteEmployee.Country = "Azerbaycan";

            remoteEmployee.Add();
            remoteEmployee.ShowSalary();

            


            Console.ReadLine();
        }
    }
}
