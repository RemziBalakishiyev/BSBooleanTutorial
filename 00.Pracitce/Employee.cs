using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public  void EmployeeInformation()
        {
            Console.WriteLine($"{Id}\t- {FirstName}\t- {LastName} ");
        }

        public virtual void Add()
        {
            Console.WriteLine($"{Id}\t- {FirstName}\t- {LastName}  isci statusundadir");
        }


        public virtual double CalcSalary()
        {
            return 0;
        }

        public virtual void ShowSalary()
        {
            Console.WriteLine("Show salary");
        }



    }
}
