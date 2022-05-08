using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ders_Operators_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama 

            //int ededBir = 13;

            //int ededIki = 12;


            //int ededUc = 5;  // e3 =  10;


            //int ededDord = 12 + 15; // e4 = 27

            ////ededDord = ededDord + ededDord + 6; // e4 = (e4) 27 + (e4) 27 + 6  = 60;

            //ededDord = ededDord - ededBir - ededUc + ededIki + 5;// 27 - 13 - 5 + 12 + 5 = 26;


            //ededBir = ededIki + ededDord + ededUc - 2;// e1 = 12 + 26 + 5 - 2=41



            //Console.WriteLine(ededBir + ededIki);// e1 + e2 = 41 + 12;


            //int qismet = 15 / 4; // qiymet 3 qaliqda  3


            //int qismetIki = 13 * 3;  // qiymet 4 qaliq 1 

            ////float qismetUc = 13 / 3;






            //Console.WriteLine(qismetIki);

            //Console.WriteLine(ededBir + ededIki);


            // Toplamam isharesinin birterefi metinsel ifade olarsa + isharesi
            // toplama emeliyyatini yox birlesdirme edecekdir 

            // Metinsel ifade dirnaq isharesi icinde olan her hansi bir simvol ola biler


            //int telebeYash = 19;

            //string telebeAd = "Heshim";
            //string telebeSoyad = "Hebiyev";

            //Console.WriteLine("Telebenin yashi : " + telebeYash);
            //Console.WriteLine("Telebenin adi : "+telebeAd);
            //Console.WriteLine("Telebenin Soyadi : "+telebeSoyad);

            string muellimAd = "Remzi";
            string muellimSoyad = "Balakishiyev";
            string ixtisas = "Developer";

            // I usul output console writeline
            Console.WriteLine("Salam men "+muellimAd +" "+ muellimSoyad+" ve men "+ixtisas + " olaraq calishiram");
            int yash = 22;

            // II usul

            Console.WriteLine("Salam men {1} {0} ve men {2} olaraq calishiram ve menim  {3} yashim var",
               muellimSoyad, muellimAd,ixtisas,yash);
            /// 0               1          2


            // III usul strin interpolation // strin ifadenin qarshisan $ isharesini qoyacaqsiz

            Console.WriteLine($"Salam men {muellimAd} {muellimSoyad} ve men {ixtisas} menim {yash} yashim var");

            Console.ReadLine();
        }
    }
}
