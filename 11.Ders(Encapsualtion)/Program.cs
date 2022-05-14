using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Encapsualtion_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();


            //std.SetId(-2);

            //Console.WriteLine(std.GetId());


            //std.FirstName = "Jon";

            //std.OverPoint = -20;


            //Employee employee = new Employee();

            //Console.WriteLine("ID: "+employee.Id);
            //Console.WriteLine(std.OverPoint);
            ////std.Show();
            ///

            Employee employee = new Employee();

            employee.FirstName = "Jon";
            employee.LastName = "Snow";


            employee.Salary = 50000;
            Console.WriteLine("Qebul tarixi : "+employee.StartDate);

            employee.Add();

            if (employee.CalcMonthlySalary() <0)
            {
                Console.WriteLine("Maash Deyeri menfi daxil edile bilmez");
            }
            else
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} adli ischinin maashi {employee.CalcMonthlySalary()}");
            }
            


          


            Console.ReadLine();
        }
    }

    class Student
    {
        int _id; // 0
        string _firstName;//ctrl + r + e
        double _overPoint;//field

        public string FirstName
        {
            get
            {
                if (_firstName == "Empty")
                {
                    return "Empty";
                }
                else
                {
                    return "Mr." + _firstName;
                }
            }
            set
            {

                _firstName =value;

            }
        }

        public double OverPoint
        {
            get
            {
                if (_overPoint == 0)
                {
                    return 0;
                }
                else
                {
                    return _overPoint;
                }
            }
            set
            {
                if (value < 0)
                {
                    _overPoint = 0;
                }
                else
                {
                    _overPoint = value;
                }
            }
        }

        public Student()
        {
        }

        public void SetId(int id)//id=-2
        {
            if (id < 0) //-2 < 0
            {
                _id = 0;
            }
            else
            {
                _id = id;//_id = 2
            }
        }


        public int GetId()
        {
            if (_id == 0)
            {
                return -1;
            }
            else
            {
                return _id;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Id : {_id}");
            //Console.WriteLine($"FirstName : {_firstName}");
            //Console.WriteLine($"Over Point : {_overPoint}");
        }
    }
}
