using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace _07.Ders_Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro Arrays
            //    string[] kitablar = new string[4];

            //    kitablar[0] = "1984";
            //    kitablar[1] = "Sehra Ciceyi";
            //    kitablar[2] = "Olu canlar";
            //    kitablar[3] = "Martin Iden";




            //    int[] tamEdedler = {12,13,151,17,19,20,21 };


            //    tamEdedler[2] = 15;
            //    WriteLine(tamEdedler[2]);


            //    string[] filmler = { "Fight Club", "Pulp Fiction", "Once upon tim Holywood", "Godfather","The Dark Knight"};


            //    WriteLine($"Massivin uzunlugu :{filmler.Length}");
            //    for (int i = 0; i < filmler.Length; i++)
            //    {
            //        WriteLine(filmler[i]); //4
            //    } 
            #endregion

            #region Arrays Initializing 

            //string[] seriallar = new string[5];

            //for (int i = 0; i < seriallar.Length; i++)
            //{
            //    Write("Serial Adi : ");
            //    seriallar[i] = ReadLine(); //Breaking Bad seraillar[0] =  "Breaking Bad"
            //}
            //WriteLine("-----------------------");

            //foreach (string serial in seriallar)
            //{
            //    WriteLine(serial);
            //}

            #endregion

            #region Telebe Ortalama Proqrami

            // 5 telebenin  qiymetlerini istifadeciden alib ortalamasini tapan proqram
            //int[] telebeQiymetleri = new int[5];

            //for (int i = 0; i < telebeQiymetleri.Length; i++)
            //{
            //    Write($"{i+1}. telebenin qiymeti : ");
            //    telebeQiymetleri[i] = ToInt32(ReadLine());//
            //}
            //int say = 0;
            //int cem = 0;
            //double ortalama;

            //foreach (var telebeQiymet in telebeQiymetleri)
            //{
            //    cem += telebeQiymet; //70 + 60 + 99 + 51 + 47
            //    say++;
            //}

            //ortalama = cem / say; 

            //WriteLine($"Say : {say} Cem : {cem}");
            //WriteLine($"Ortalama Qiymet : {ortalama}"); 
            #endregion
            #region Exercise

            // Bu kodlarda hazir metodlardan istifade etmeyin!!
            //Tapsiriq 1. Yerliedebiyyat adinda masssiv teyin edin bu massivin elementlerini istifadeciden alin
            // tapsiriq 2. verilmis massivin en kicik elementinin indexini ve deyerini tapin

            //iki massiv verilib AMassivi ve BMasssivi bu iki A massvinin en boyuk elementi ile B massivinin en kicik elementini tapib  yerlerini deyishin
            // { 1,2,3,-2} = A
            // {2,-4,3 , 10} = B
            /*
             * Deyisdirildikden sonra A massivi ve B Masivi
             * a deyerleri  a = { 1,2,-4,-2}
             * b deyerleri b = { 2, 3, 3, 10} 
             * 
             */
            #endregion
            #region En boyuk elementi
            //int[] ededler = { 12, 13, 20, -4, 33, 1, 0, -2 };

            //int enBoyukDeyer = ededler[0]; //enB = 12;
            //int index = 0;
            //for (int i = 0; i < ededler.Length; i++) //i=5
            //{
            //    if (enBoyukDeyer<ededler[i]) // 33 < 1
            //    {
            //        index = i;
            //        enBoyukDeyer = ededler[i]; //enB = 33
            //    }
            //}




            //WriteLine($"massivin en boyuk elementi : {enBoyukDeyer)}");

            #endregion


            //double[] qiymetler = { 12.3, 2.4, 4.6, 3 };

            //WriteLine("4.6 qiymetinin index nomresi - "+Array.IndexOf(qiymetler,4.6));

            //string[] telebeler = { "Gunel", "Heshim", "Aynur", "Servet", "Sevil" };


            ////string telebeAdi = ReadLine();

            ////WriteLine($"{telebeAdi} adli telebenin index nomresi - {Array.IndexOf(telebeler, telebeAdi)}");

            //string[] digerTelebeler = new string[7];
            //digerTelebeler[0] = "Mircamal";
            //digerTelebeler[1] = "Kenan";

            //telebeler.CopyTo(digerTelebeler,1);

            //foreach (var item in digerTelebeler)
            //{
            //    WriteLine(item);
            //}
            //ReadLine();

        }
    }
}
