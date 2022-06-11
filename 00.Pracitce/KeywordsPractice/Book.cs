using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.KeywordsPractice
{
    internal class Book:IOperation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Writer Writer { get; set; }//Writer = new Writer()
        public double Price { get; set; }

        public void Add()
        {
            Console.WriteLine($"{Name} kitab sisteme əlavə olundu");
        }

        public void Delete()
        {
            Console.WriteLine($"{Name} kitab sistemden silindi");
        }

        public void Show()
        {
            Console.WriteLine($"Kitabin Adi : {Name}  Yazici: {Writer.FirstName} {Writer.LastName} Qiymeti : {Price}");
        }
    }

    enum Genre
    {
        Dedecctive,
        Romantic,
        Dram
    }
}
