using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.InterfacePractice
{
    internal class Computer : ProductEntity, IComputer
    {
        public string CPUMark { get; set; }
        public double calcProductPrice()
        {
            return InStock * Price * 0.05;

        }

        public void ShowCompCpuMark()
        {
            Console.WriteLine(CPUMark);
        }

        public void ShowProduct()
        {
            Console.WriteLine(Name);
        }
    }

   
}
