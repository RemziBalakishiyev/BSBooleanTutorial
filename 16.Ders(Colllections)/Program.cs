using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Ders_Colllections_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arrayList = new ArrayList
            //{
            //    "Remzi",
            //    false,
            //    'a'
            //};






            //Customer customer = new Customer();
            //customer.FirstName = "Remzi";
            //customer.Id = 1;





            //foreach (var item in arrayList)
            //{

            //}
            //Console.ReadLine();

            #endregion

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            List<Customer> customers = new List<Customer>()
            {
                new Customer {Id=1,FirstName="Remzi"},
                new Customer {Id=2,FirstName="Hesim"},
                new Customer {Id=3,FirstName="Elvin"},
            };


            customers.RemoveAt(2);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + "\t - " + customer.FirstName);
            }


            Dictionary<string, string> dictionaries = new Dictionary<string, string>();

            dictionaries.Add("Book", "Kitab");
            dictionaries.Add("Pencil", "Qelem");
            dictionaries.Add("Phone", "Telefon");


            Console.WriteLine(dictionaries["Phone"]);

            foreach (KeyValuePair<string, string> item in dictionaries)
            {
                Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            }

            Dictionary<double, string> groups = new Dictionary<double, string>
            {
                {655,"Komputer muhendisliyi" },
                {681,"Informasiya texnologiyalari" },
                {641,"Informasiya tehlukesizliyi" }

            };


            Console.WriteLine(groups[681]);




            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
