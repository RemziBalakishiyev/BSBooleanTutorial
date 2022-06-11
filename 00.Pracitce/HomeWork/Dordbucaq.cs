using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.HomeWork
{
    internal class Dordbucaq
    {
        private int en;

        public int En
        {
            get { return en; }
            set
            {
                if (value < 0)
                {
                    en = 1;
                    Console.WriteLine("En menfi ola bilmez");
                }
                else
                {
                    en = value;
                }
            }
        }

        private int uzunluq;

        public int Uzunluq
        {
            get { return uzunluq; }
            set
            {
                if (value < 0)
                {
                    uzunluq = 1;
                    Console.WriteLine("Uzunluq menfi ola bilmez");
                }
                else
                {
                    uzunluq = value;
                }
            }
        }



        public double Perimetr()
        {
            double perimetr = 2 * (En + Uzunluq);
            return perimetr; 
        }

        public double Sahe()
        {
            double sahe = En * Uzunluq;
            return sahe;
        }


        public void ShowResult()
        {
            Console.WriteLine($"Perimetr: {Perimetr()}");
            Console.WriteLine($"Sahe: {Sahe()}");
        }


    }
}
