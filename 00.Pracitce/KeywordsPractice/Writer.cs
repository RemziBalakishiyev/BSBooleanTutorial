using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.KeywordsPractice
{
    internal class Writer:IOperation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
       

        public void Add()
        {
            Console.WriteLine($"{FirstName} {LastName} sisteme elave olundur");
        }

        public void Delete()
        {
            Console.WriteLine($"{FirstName} {LastName} sistemden silindi");
        }

        public void Show()
        {
            Console.WriteLine($"Adi :  {FirstName}  Soyad: {LastName}");
        }
    }
}
