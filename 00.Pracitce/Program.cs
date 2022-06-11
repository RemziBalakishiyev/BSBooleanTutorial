using _00.Pracitce.AbstractPractice;
using _00.Pracitce.CollectionPractice;
using _00.Pracitce.HomeWork;
using _00.Pracitce.InterfacePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //DatabaseManager databaseManager = new DatabaseManager();
            //databaseManager.SetConnectServer(new MySql());

            //InheritanceOperation();
            //InterfaceOperation();


            //Dordbucaq dordbucaq = new Dordbucaq();

            //dordbucaq.Uzunluq = 5;
            //dordbucaq.En = 2;

            //dordbucaq.ShowResult();
            //KeyOperation(TypeOperation.Book);

            //Teacher teacher = new Teacher();
            //teacher.FirstName = "Remzi";
            //teacher.LastName = "Balakishiyev";
            //teacher.Salary = 5000;
            //teacher.ApplyGroup();

            //Console.WriteLine(teacher.Count);
            //teacher.CreateTeacher();

            BookCollectionOperation();

            Console.ReadLine();
        }

        public static void InheritanceOperation()
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.Id = 1;
            fullTimeEmployee.FirstName = "Bruce";
            fullTimeEmployee.LastName = "Wayne";
            fullTimeEmployee.SalaryOfYear = 50000;
            fullTimeEmployee.ShowSalary();


            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.Id = 1;
            partTimeEmployee.FirstName = "Walter";
            partTimeEmployee.LastName = "White";
            partTimeEmployee.Hour = 6;
            partTimeEmployee.HourOfSalary = 35;
            partTimeEmployee.ShowSalary();


            RemoteEmployee remoteEmployee = new RemoteEmployee();
            remoteEmployee.Id = 1;
            remoteEmployee.FirstName = "Jamie";
            remoteEmployee.LastName = "Lannister";
            remoteEmployee.Hour = 8;
            remoteEmployee.HourOfSalary = 40;
            remoteEmployee.Country = "Azerbaycan";

            remoteEmployee.Add();
            remoteEmployee.ShowSalary();

        }

        public static void InterfaceOperation()
        {
            //Product product = new Product();
            //product.Name = "Apple Watch";
            //product.InStock = 10;
            //product.Price = 20;
            //double price =   product.calcProductPrice();
            //Console.WriteLine("Price : "+price);
            //product.ShowProduct();


            Computer computer = new Computer();
            computer.Name = "Lenova";
            computer.Price = 120;
            computer.InStock = 20;

            Watch watch = new Watch();
            watch.Name = "mi band";
            watch.Price = 120;
            watch.InStock = 20;


            Phones phones = new Phones();
            phones.Name = "Iphone";
            phones.Price = 120;
            phones.InStock = 20;

            ProductOperation opr = new ProductOperation(computer);

            opr.ShowProduct();


        }


        public static void KeyOperation()
        {
            // Book book = new Book();
            // Writer writer = new Writer
            // {
            //     Id = 1,
            //     FirstName = "George",
            //     LastName = "Orwel",
            //     Age = 50,
            // };



            //book.Name = "1984";
            //book.Price = 200;
            //book.Id = 1;
            //book.Writer = writer;

            //if (TypeOperation.Writer==typeOperation)
            //{
            //    Operation operation = new Operation(writer);
            //    operation.Add();
            //    operation.Show();
            //    operation.Delete();
            //}
            //else
            //{
            //    Operation operation = new Operation(book);
            //    operation.Add();
            //    operation.Show();
            //    operation.Delete();
            //}



        }

        public static void BookCollectionOperation()
        {
            BookOperation bookOperation = new BookOperation();

            List<Book> books = bookOperation.GetAll();
            Console.WriteLine($"Id\t Name\t Genre");
            Console.WriteLine($"-------------------");

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}\t {book.Name}\t {book.Genre}");
            }

            //Console.WriteLine($"-------------------");
            //Console.WriteLine("");

            //bookOperation.Add(new Book { Id = 4, Name = "Sefiller", Genre = "Dram" });

            bookOperation.Update(2, new Book { Id = 2, Name = "Heyvanistan", Genre = "Dram" });
            Console.WriteLine($"Id\t Name\t Genre");

            Console.WriteLine($"-------------------");

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}\t {book.Name}\t {book.Genre}");
            }

        }

    }

    class ProductOperation : IProduct
    {
        IProduct _product;


        public ProductOperation(IProduct product)
        {
            _product = product;
        }

        public double calcProductPrice()
        {
            return _product.calcProductPrice();
        }

        public void ShowProduct()
        {
            _product.ShowProduct();
        }
    }
}
