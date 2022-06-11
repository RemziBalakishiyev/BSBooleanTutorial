using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.InterfacePractice
{
    internal class Watch : ProductEntity, IWatch
    {
        public void AddWatch()
        {

            Console.WriteLine("Watch added..");
        }

        public double calcProductPrice()
        {
            return InStock * Price * 0.02;
        }

        public void ShowProduct()
        {
            Console.WriteLine(Name);
        }
    }
}
