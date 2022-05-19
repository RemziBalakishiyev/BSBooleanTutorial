using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce
{
    internal class RemoteEmployee:PartTimeEmployee
    {
        public string Country { get; set; }

        public override void Add()
        {
            Console.WriteLine($"{FirstName} {LastName}  {Country} olkesinden olan ishci elave olundu");
        }
    }
}
