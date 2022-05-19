using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce
{
    internal class PartTimeEmployee:Employee
    {
        public double HourOfSalary { get; set; }
        public int Hour { get; set; }

        public override void Add()
        {
            Console.WriteLine($"{Id}\t- {FirstName}\t- {LastName}  Tam shtat isci statusundadir");
        }

        public override double CalcSalary()
        {
            return HourOfSalary * Hour * 26;
        }


        public override void ShowSalary()
        {
            if (CalcSalary() ==0)
            {
                Console.WriteLine("Sizin ayliq maashiniz  teyin olunmayib");
            }
            else
            {
                Console.WriteLine("Sizin ayliq maashiniz : "+CalcSalary());
            }
        }


    }
}
