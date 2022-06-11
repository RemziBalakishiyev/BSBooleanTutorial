using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.InterfacePractice
{
    internal class Phones:ProductEntity,IPhone
    {
        public string Mark { get; set; }

        public double calcProductPrice()
        {
            return InStock * Price*0.02;
        }

        public void ShowMark()
        {
            Console.WriteLine(Mark);
        }

        public void ShowProduct()
        {
            Console.WriteLine(Name);
        }
    }
}
