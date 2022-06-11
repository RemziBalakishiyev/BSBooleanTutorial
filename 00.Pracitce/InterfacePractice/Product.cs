using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.InterfacePractice
{
    internal class Product : ProductEntity, IProduct
    {
        public double calcProductPrice()
        {
            return InStock * Price;
        }

        public void ShowProduct()
        {
            Console.WriteLine("Product : "+Name);
        }
    }
}
