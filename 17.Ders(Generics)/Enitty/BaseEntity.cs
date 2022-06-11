using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_.Enitty
{
    public abstract  class BaseEntity
    {
        public int Id { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Introduction()
        {
            Console.WriteLine($"Istifadeci\t - {FirstName}  {LastName}");
        }
    }
}
