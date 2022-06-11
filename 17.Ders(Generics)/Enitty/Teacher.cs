using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_.Enitty
{
    public class Teacher:BaseEntity
    {
        private double salary;

        public double Salary
        {
            get { return (salary*0.04*12); }
            set
            {
                if (value<0)
                {
                    salary = 0;
                    throw new Exception();
                }
                else
                {
                    salary = value;
                }
            }
        }

        public List<string> Groups { get; set; }



    }
}
