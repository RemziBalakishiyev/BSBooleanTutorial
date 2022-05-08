using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace _06.Ders_Loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Cemin Tapilmasi
            // -13-den 13-e qeder 2 artimla ekrana Booleanteach amma qarhisinda -14*2 - Booleanteach
            //for (int i =-13; i <= 13; i+=2)//16
            //{
            //    WriteLine($"{i*2} BooleanTeach");
            //}



            // 1-den 100-e qeder verilmish ededlerin cemini tapin
            //5!

            //int cem = 0; // 0X, 1X , 3X, 6X ,10X, 15

            //for (int i = 1; i <= 100; i++)//i = 6
            //{
            //    cem = cem + i;// cem = 10 + 5
            //}

            //WriteLine("Cem : "+cem);

            #endregion
            #region Shertlerle ishlenmesi cemin tapilmasi
            //for (int i = 1; i < 10; i++)
            //{
            //    WriteLine(i);
            //    if (i == 7)
            //    {
            //        WriteLine("Bu eded 7 -e beraberdir");
            //    }
            //}


            //1 den 50-e qeder cut ededlerin cemini tapin
            //int cem = 0;//2
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 2==0 ) // 4
            //    {
            //        cem += i;
            //        WriteLine(cem);
            //    }

            //} 
            #endregion
            #region Ededlerin Istifadeciden alinmasi

            // 1- 100 qeder cut ve 5e bolunen ededlerin sayini tapin 

            //int say = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2==0 && i%5==0)
            //    {
            //        WriteLine(i);
            //        say++;
            //    }
            //}

            //WriteLine("Say : "+say);

            // 1- den 40 qeder 2 ve 3 e bolunen ededlerin  cemini yalniz 3- bolunen ededlerin hasilini yerde qalan ededlerin sayini tapin


            //int eded = 0;
            //int cem = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    eded = ToInt32(ReadLine());//eded = 5
            //    cem += eded;
            //    WriteLine("Cem : " + cem);
            //}

            //WriteLine("Yekun Cem : " + cem);

            #endregion


            #region Stringle Adlarin elave olunmasi
            //string adlar = "";

            ////Kenan, Mehemmed

            //for (int i = 1; i <= 10; i++) //2
            //{
            //    Write("AD : ");
            //    string ad = ReadLine();
            //    if (i != 1)
            //    {
            //        adlar = adlar + ", " + ad;

            //    }
            //    else
            //    {
            //        adlar = adlar + ad; 

            //    }


            //}

            //WriteLine("---------"); 
            #endregion
            //WriteLine(adlar);
            #region While Cemin tapilmasi


            ////int eded = 0;
            ////int cem = 0;
            ////while (eded <=10) // 1<= 8
            ////{
            ////    cem += eded;
            ////    WriteLine(eded);
            ////    eded++; //7

            ////}


            //WriteLine(cem); 
            #endregion

            #region Ededin reqemlerinin sayinin tapilmasi
            //5421 --> 4
            // 5421 / 10 = 542, 542/10 =  54 / 10 = 5 / 10 = 0
            //        1              2           3       4             
            //int eded = 5421;
            //int say = 0;


            //while (eded > 0) // 0 > 0 false
            //{

            //    eded = eded/10; // 0
            //    say++; //4
            //    WriteLine($"eded : {eded} say : {say}");

            //} 
            #endregion

            #region  Ededin Reqemlerinin cemi
            //int eded = 5421;
            // 5421 / 10 --> say
            // 5421 % 10 =  1 --> 542 % 10 = 2 , 54 % 10 = 4
            //// 5 % 10 = 5

            //int cem = 0;
            //int qaliq =0;

            //while (eded > 0)// 0 -> false
            //{
            //    qaliq = eded % 10; //5
            //    cem += qaliq; // 12
            //    eded = eded / 10;// 0
            //}
            //WriteLine( $"cem :{cem}");

            #endregion

            #region While Soz oyunu
            //string axtarilanSoz = "Developer";
            //string daxilOlunanSoz = "";

            //WriteLine("Soz oyununa Xosh geldiniz");
            //WriteLine("Sozu daxil Edin ");

            //int sehvGedishSayi = 0;
            //int limit = 3;


            //bool netice = false;
            //// false
            //while (axtarilanSoz != daxilOlunanSoz)//false
            //{
            //    Write("Soz : ");
            //    daxilOlunanSoz = ReadLine();
            //    sehvGedishSayi++;
            //    if (sehvGedishSayi == limit)
            //    {
            //        netice = true;
            //    }
            //}


            //if (netice)
            //{
            //    WriteLine($"Siz meglub oldunuz Dogru soz : {axtarilanSoz}");
            //}
            //else
            //{
            //    WriteLine($"Siz qalib oldunuz gedish Sayi : {sehvGedishSayi}");
            //}


            #endregion


            //for (int i = 0; i < 10; i++)
            //{

            //    if (i == 3) // 
            //    {
            //        continue;
            //    }
            //    else if (i == 5)
            //    {
            //        break;
            //    }
            //    WriteLine(i);
            //}



            int eded = 50007;//--> 0--> 5 0 0 0 7
            int cem = 0, say = 0, qaliq;

            while (eded > 0)//
            {
                qaliq = eded % 10;
                eded = eded / 10;

                if (qaliq == 0)
                {
                    say++;
                }
                else if (qaliq != 0)
                {
                    cem += qaliq;
                }
            }

            WriteLine("Ededin musbet reqemlerinin cemi : "+cem);
            WriteLine("Ededin musbetve menfi olmayan reqemlerinin sayi : "+say);






            ReadLine();
        }
    }
}
