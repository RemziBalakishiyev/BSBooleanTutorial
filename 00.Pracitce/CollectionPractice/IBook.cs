using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.CollectionPractice
{
    internal interface IBook
    {
        void Add(Book book);
        void Update(int id,Book book);
        void Delete();
        List<Book> GetAll();
    }
}
