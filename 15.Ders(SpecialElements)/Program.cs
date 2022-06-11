using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Ders_SpecialElements_
{
    internal class Program
    {
        

       
        static void Main(string[] args)
        {


            //Console.WriteLine((int)TypeClass.Product);
            //ShowClass((int)TypeClass.Employee);

            Users users = new Users();
            
            var ip = Users.ipAddress;

            Console.WriteLine(ip);

            Employee employee = new Employee();
            employee.FirstName = "Sevil";
            employee.LastName = "Memmedli";

            Helper.ShowFullName(Helper.Title.MRS,employee.FirstName,employee.LastName);
            Console.ReadLine();
        }


        //static void ShowClass(int id)
        //{
        //    if (id==1)
        //    {
        //        Employee employee = new Employee();
        //    }else if (id == 2)
        //    {
        //        Product product = new Product();
        //    }
        //    else if (id == 3)
        //    {
        //        Product product = new Product();
        //    }
        //}
        
    }
    enum TypeClass
    {
        Employee=1,
        Product=2,
        Other =3,
    }

    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee is work");
        }
    }

   

     class Users
     {
        public const string ipAddress = "192.179.37.81";
        public readonly string ipAddress2 = "192.179.37.81:2000";
        protected string FirstName { get; set; }
        public string LastName { get; set; }

         void Display()
        {
            FirstName = "Remzi";
           
        }
    }
}
