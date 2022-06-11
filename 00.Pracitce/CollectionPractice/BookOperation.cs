using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.CollectionPractice
{
    internal class BookOperation : IBook
    {
        List<Book> books;
        public BookOperation()
        {
            books = new List<Book>
            {
               new Book{Id=1,Name="1984",Genre="Dram" },
               new Book{Id=2,Name="Cinayet Ceza",Genre="Dram" },
               new Book{Id=3,Name="Herb ve Sulh",Genre="Muharibe" },
            };
        }
        public void Add(Book book) //new Book
        {
            books.Add(book);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public void Update(int id, Book book)
        {

            
            foreach (var item in books)
            {
                if (item.Id ==id)
                {
                    item.Id = book.Id;
                    item.Name = book.Name;
                    item.Genre = book.Genre;
                }
            }

            
        }
    }
}
