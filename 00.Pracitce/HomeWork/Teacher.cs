using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.HomeWork
{
    internal class Teacher
    {
        public int Id { get; private set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }


        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value>0 && value < 10000)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }
            }
        }

        private int count;

        public int Count
        {
            get { if (count <= 0) { return -1; } else { return count; }; }
            private set { count = value; }
        }


        public void CreateTeacher()
        {
            Id++;
            Console.WriteLine($"{Id} - {FirstName} -  {LastName}");
        }


        public void ApplyGroup()
        {
            count = 10;
        }



    }
}
