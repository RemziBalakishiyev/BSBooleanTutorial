using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.CollectionPractice
{
    internal interface ICustomer
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        List<Customer> GetAll();
    }
}
