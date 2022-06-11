using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_AbstractClasses_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.BeginTransaction(); 
            customer.Add();

            Employee employee = new Employee();
            employee.BeginTransaction();
            employee.Add();



            Console.ReadLine();
        }
    }


    class Customer : BaseCustomerManager
    {
        public override void Add()
        {
            Console.WriteLine("Customer addedd..");
        }
    }

    class Employee : BaseCustomerManager
    {
        public override void Add()
        {
            Console.WriteLine("Employee addedd..");
        }
    }

    abstract class BaseCustomerManager
    {
        public void BeginTransaction()
        {
            Console.WriteLine("Transaction begining...");
        }
        public abstract void Add();
    }

 

  



}
