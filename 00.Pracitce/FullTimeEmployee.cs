using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce
{
    internal class FullTimeEmployee : Employee
    {
        private double salaryOfYear;

        public double SalaryOfYear
        {
            get
            {
                return salaryOfYear + (salaryOfYear * 0.04);
            }
            set
            {
                if (value <= 0 )
                {
                    salaryOfYear = 0;
                }
                else
                {
                    salaryOfYear = value;
                }
            }
        }

        public override double CalcSalary()
        {
            if (SalaryOfYear == 0)
            {
                return 0;
            }
            else
            {
                return SalaryOfYear / 12;
            }
        }
        public override void ShowSalary()
        {
            if (CalcSalary() == 0)
            {
                Console.WriteLine("Sizin maash teyin olunmayib");
            }
            else
            {
                Console.WriteLine($"Sizin maashinin : {Math.Ceiling(CalcSalary())}");
            }
        }

        public override void Add()
        {
            Console.WriteLine($"{Id}\t- {FirstName}\t- {LastName}  Tam shtat isci statusundadir");
        }
    }
}
