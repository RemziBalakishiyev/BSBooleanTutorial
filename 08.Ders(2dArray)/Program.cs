using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace _08.Ders_2dArray_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region 2d array
        //string[] oneDArray = { "Jon", "Tyrion", "Jamie" };

        //string[,] twoDArray = new string[3, 3];

        ////twoDArray[0, 0] = "Remzi";
        ////twoDArray[0, 1] = "Bruce"; 
        ////twoDArray[0, 2] = "Walter";

        ////twoDArray[1, 0] = "Jessie";

        //int[,] twoDNumbers = {
        //                        { 12, 3, 14 },
        //                        { -1, 0, -6 },
        //                        { -77, 0, 9 }
        //                     };


        //Console.WriteLine(twoDNumbers[2,2]); 
        #endregion

        #region Nested For Loop
        //for (int i = 0; i < 5; i++) //2
        //{
        //    for (int j = 0; j < 3; j++) //j = 0
        //    {
        //        WriteLine($"i = {i} j = {j} ");//i = 1 , j =2
        //    }
        //    WriteLine("------------------");
        //} 
        #endregion

        #region Vurma Cedveli

        //for (int i = 1; i < 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        WriteLine($"{i} x {j} = {i*j}");//1
        //    }
        //    WriteLine("-------------------");
        //} 
        #endregion

        #region Floyd Triangle
        //for (int i = 1; i <= 5; i++) //2
        //{
        //    for (int j = 1; j <= i; j++) //j = 2 ; j <= 2
        //    {
        //        Write("* ");
        //    }
        //    WriteLine("");
        //} 
        #endregion

        #region 2d array nested for loop
        //int[,] twoDNumbers = {
        //                        { 12, 3, 14 },
        //                        { -1, 0, -6 },
        //                        { -77, 0, 9 }
        //                     };



        //for (int i = 0; i < 3; i++)//1
        //{
        //    for (int j = 0; j < 3; j++)//j
        //    {
        //        Write($"{twoDNumbers[i,j]} \t");
        //    }
        //    WriteLine("");
        //}

        #endregion

        #region Sum of 2d array
        //int[,] twoDNumbersOne = {
        //                        { 12, 3, 14 },
        //                        { -1, 0, -6 },
        //                        { -77, 0, 9 }
        //                     };

        //int[,] twoDNumbersTwo = {
        //                        { 2, 0, 4 },
        //                        { 1, 1, 6 },
        //                        { 7, 0, 10 }
        //                     };



        //int[,] sumTwoDArray = new int[
        //                                twoDNumbersOne.GetLength(0),
        //                                twoDNumbersOne.GetLength(1)
        //                             ];



        //for (int i = 0; i <  twoDNumbersTwo.GetLength(0); i++)
        //{
        //    for (int j = 0; j < twoDNumbersTwo.GetLength(1); j++)
        //    {
        //        sumTwoDArray[i, j] = twoDNumbersOne[i, j] + twoDNumbersTwo[i, j];
        //    }
        //}


        //for (int i = 0; i < sumTwoDArray.GetLength(0); i++)
        //{
        //    for (int j = 0; j < sumTwoDArray.GetLength(1); j++)
        //    {
        //        Write($"{sumTwoDArray[i,j]} ");
        //    }
        //    WriteLine("");
        //} 
        #endregion

        start:
            int[] hesablarim = { 1200, 1400, 5000, 3000 };
            WriteLine("1 - Hesablari goster");
            WriteLine("2 - Pul Cixar");
            WriteLine("3 - Pul kocurr");
            WriteLine("Zehmet olmasa edeceyiniz emeliyyati daxil edin");


            Write("Emeliyyat: ");
            int emeliyyat = ToInt32(ReadLine());
            string stopStart = "";

            switch (emeliyyat)
            {
                case 1:
                    foreach (var hesab in hesablarim)
                    {
                        WriteLine($"{Array.IndexOf(hesablarim, hesab) + 1} . - {hesab}");
                    }

                    WriteLine("Emeliyyattlari Davam etmek isteyirsizse Y duymesine sixin. Dayandirmaq ucun  her hansi bir duymeye sixin");

                    stopStart = ReadLine();
                    if (stopStart == "Y" || stopStart == "y")
                    {
                        goto start;
                    }
                    else
                    {
                        break;
                    }
                case 2:
                    WriteLine("Zehmet olmasa pul cixaracaginiz hesabin nomresini yazin ");
                    Write("Hesab Nomresi  : ");
                    int hesabNo = ToInt32(ReadLine()); //2
                    Write("Cekeceyiniz miqdari qeyd edin : ");
                    int meblegh = ToInt32(ReadLine()); // 400
                                    //1
                    if (hesablarim[hesabNo - 1] - meblegh >0) //hesablarim[1] -> 1400 
                    {
                        WriteLine($"{hesabNo} hesabda qalan meblegh {hesablarim[hesabNo -1] -meblegh} ");
                    }
                    else
                    {
                        WriteLine("Hesabinizda Yeteri Qeder meblegh yoxdur");
                    }
                    WriteLine("Emeliyyattlari Davam etmek isteyirsizse Y duymesine sixin. Dayandirmaq ucun  her hansi bir duymeye sixin");
                    stopStart = ReadLine();
                    if (stopStart == "Y" || stopStart == "y")
                    {
                        goto start;
                    }
                    else
                    {
                        break;
                    }
                default:
                    break;
            }

            Console.ReadLine();

        }
    }
}
