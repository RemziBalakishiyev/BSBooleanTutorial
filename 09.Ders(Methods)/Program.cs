using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace _09.Ders_Methods_
{
    internal class Program
    {
        public static string[] user = new string[2];
        public static int firstSign = 0;
        static void Main(string[] args)
        {

            #region methods one

            ////Cem() --> 15
            //wTo("Verilmis iki deyerin cemi");
            //int cem = Cem(14, 1);
            //if (cem > 10)
            //{
            //    Console.WriteLine("Cem 10 dan boyukdur");
            //} 
            #endregion
            #region Metodlar Params

            //Console.WriteLine("Edeceyiniz Emeliyati daxil edin");
            //char emeliyyat = ToChar(ReadLine());
            //Console.WriteLine("Eded 1 : ");
            //int eded1 = ToInt32(ReadLine());
            //int eded2 = ToInt32(ReadLine());    
            //Calc(ededBir: eded1,
            //     opr: emeliyyat,
            //     ededIki: eded2);


            //int[] ededler = { 12, 13, 14, 15 };
            //PrintByOpr('+', SumArray(12,13));


            /*
             * 
             * Login parol sistemi:
             * Ilk olaraq istifadeci qeydiyyatdan kececeyini yada Girish edeceyini yoxlayor
             * eger qeydiyyatdirsa login parol ve shifreni tekrarla istesin
             * eger girishdirse password ve logini istesin
             * Login ve parolun yoxlanmasi edilsin
             * 
             */

            /*
           * 
           *Ucbucaq 
           *
           **/


            //Console.WriteLine("Edeceyiniz Emeliyati daxil edin");
            //char emeliyyat = ToChar(ReadLine());

            //int[] ededler = new int[5];

            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    Write($"{i + 1}. eded : ");
            //    ededler[i] = ToInt32(ReadLine());
            //}

            //Calc(emeliyyat, ededler);

            #endregion
            #region Referance and Data Typese

            //string[] azeSheherleri = { "Baku", "Sumqayit", "Masalli" };//111
            //string[] trSheherlleri = { "Istanbul", "Ankara", "Bursa" };//101

            //trSheherlleri = azeSheherleri;// tr = 111

            //trSheherlleri[0] = "Naxcivan";// tr[] -> 111[0] = "Naxcivan'

            //Console.WriteLine(trSheherlleri[0]);
            //Console.WriteLine(azeSheherleri[0]); 
            #endregion
            #region Ref Out
            // string Name = "asdasd";//101 --> "Wayne"
            // firstName =Name --> Bruce
            /* Update(out Name);*/// firstName = Name --> 101; 
            #endregion
            #region Overloading methods
            //string firstName = "Remzi";
            //string lastName = "Balakishiyev";
            //char sinifA = 'A';

            //Add(sinifA);//ctr+shift+space
            //Add(firstName);//ctr+shift+space
            //Add(firstName,lastName);
            //Add(firstName,21); 
            #endregion

            string login = "admin";
            string pssw = "123";

        start:
            AddUser(login, pssw);


            bool isSign = SignIn("user", "444");

            if (!isSign)
            {
                Update(ref login, ref pssw, "user", "444");
                goto start;
            }

            Console.ReadLine();
        }

        #region Methods One
        //public static void wTo(string text)
        //{
        //    Console.WriteLine($">>{text}");
        //}

        //public static  string some()
        //{
        //    return "ada";
        //}

        ////public static void Cem()
        ////{
        ////    Console.WriteLine(5 + 10);
        ////    return 5 + 10;
        ////}
        //public static int Cem(int ededBir, int ededIki)
        //{
        //    return ededBir + ededIki;
        //} 
        #endregion
        #region Calculater

        //public static void Calc(char opr,params int[] ededler)
        //{

        //    switch (opr)
        //    {
        //        case '+':
        //            PrintByOpr(opr,ArrayOpr(opr,ededler));
        //            break;
        //        case '-':
        //            PrintByOpr(opr, ArrayOpr(opr, ededler));
        //            break;
        //        case '*':
        //            PrintByOpr(opr, ArrayOpr(opr, ededler));
        //            break;

        //        default:
        //            Console.WriteLine("Belebir emeliyyat yoxdur");
        //            break;
        //    }
        //}

        //public static double Sum(int ededBir,int ededIki)
        //{
        //    return ededBir +  ededIki;
        //}

        //public static double Substract(int ededBir, int ededIki)
        //{
        //    return ededBir -  ededIki;
        //}

        //public static double Multiply(int ededBir, int ededIki)
        //{
        //    return ededBir *  ededIki;
        //}

        //public static void PrintByOpr(char opr,double result)
        //{
        //    if (opr == '+')
        //    {
        //        Console.WriteLine($"Verilen Ededlerin Cemi : {result}");
        //    }else if (opr == '-')
        //    {
        //        Console.WriteLine($"Verilen Ededlerin Ferqi : {result}");
        //    }else if(opr == '*')
        //    {
        //        Console.WriteLine($"Verilen Ededlerin Hasili : {result}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Bele bir emeliyyat movcud deyildir");
        //    }
        //}


        //public static double ArrayOpr(char opr,params int[] numbers)
        //{

        //    if (opr == '+')
        //    {
        //        double sum = 0;
        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            sum += numbers[i];
        //        }
        //        return sum;
        //    }else if (opr == '-')
        //    {
        //        double substract = numbers[0];
        //        for (int i = 1; i < numbers.Length; i++)
        //        {
        //            substract -= numbers[i];
        //        }
        //        return substract;
        //    }
        //    else if (opr == '*')
        //    {
        //        double multiply = 1;
        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            multiply *= numbers[i];
        //        }
        //        return multiply;
        //    }
        //    else
        //    {
        //        return 0;
        //    }



        //} 
        #endregion
        #region Ref Out
        //
        //public static void Add(string firstName)
        //{
        //    WriteLine($"{firstName} ad deyeri  elave edildi -- ");
        //}
        //public static void Update(out string firstName)//
        //{
        //    firstName = ""; // 101 --> "Wayne
        //} 
        #endregion
        #region Overloading Methods
        //public static void Add(string firstName)
        //{
        //    WriteLine($"{firstName} ad deyeri  elave edildi -- ");
        //}

        //public static void Add(char sinif)
        //{
        //    WriteLine($"{sinif} sinif deyeri elave edildi");
        //}

        //public static void Add(string firstName,string lastName)
        //{
        //    WriteLine($"{firstName} {lastName} ad soyadli deyer  elave edild ");
        //}
        //public static void Add(string firstName, int age)
        //{
        //    WriteLine($"{firstName} {age} Yashli  deyer  elave edildi ");
        //} 
        #endregion

        public static bool SignIn(string login, string password)
        {
            bool isValid = Valid(login, password);

            if (isValid)
            {
                Console.WriteLine("Sistem Daxil oldunuz");
                return true;
            }
            else
            {
                WriteLine("Sisteme Daxil ola bilmediniz");
                return false;

            }

        }


        public static void Update(ref string login, ref string password,
                                  string newLogin, string newPassword)
        {
            login = newLogin;
            password = newPassword;
        }
        public static bool Valid(string login, string password)
        {
            string[] getTrueuser = GetUser();

            if (login == getTrueuser[0] && password == getTrueuser[1]) //user[0]-->admin
            {
                return true;
            }/// user == admin
            else if (login != getTrueuser[0] && password == getTrueuser[1])//123 
            {
                WriteLine("Login Yanlishdir");
                return false;
            }
            else if (login == getTrueuser[0] && password != getTrueuser[1])
            {
                WriteLine("Password  Yanlishdir");
                return false;
            }
            else
            {
                return false;
            }
        }

        public static string[] AddUser(string login, string password)
        {
            user[0] = login;
            user[1] = password;
            return user;
        }

        public static string[] GetUser()
        {
            return user;
        }

    }
}
