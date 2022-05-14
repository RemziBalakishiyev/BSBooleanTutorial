using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Encapsualtion_
{
    class Employee
    {
        public int Id { get; private set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private double salary;

        public double Salary
        {
            get { return salary - (salary * (0.04)); }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }

        public DateTime StartDate { get; } = DateTime.Now;


        public void Add()
        {
            Id++;
            Console.WriteLine($"{Id} - {FirstName} {LastName} ishci {StartDate} tarixinde ishe qebul olundu");
        }


        public double CalcMonthlySalary()
        {
            if (Salary == 0)
            {
                return -1;
            }
            return Salary/12;
        }

    }
}
