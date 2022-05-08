using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _04.Ders_ConditionalStatement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conditional St 1

            //bool isCheck = false;


            //int ededBir = 10, ededIki = 10;


            //// 20 > 10 -- true 

            //     //10   <     10 -- false
            //if (ededIki <  ededBir)// isCheck = true/ { moterize icinde olan kodlar calscaqdiq}
            //{
            //    WriteLine("is Work");
            //}
            //else
            //{
            //    WriteLine("isn`t work");
            //}


            //WriteLine("Zehmet olmasa yashinizi daxil edin");
            //int yash = Convert.ToInt32(ReadLine()); // yash = 22

            //if (yash >= 18) // 18 >= 18 false
            //{
            //    WriteLine("Tebrikler siz shirketimize qebul oldunuz!");
            //}
            //else
            //{
            //    WriteLine("Teesssuf sizi shirkete qebul ede  bilmerik");
            //}



            //x, y, z, k --> x,z,k istifadeci terefinden alinsin eger x-z deyeri musbet olarsa 1ci ifadeni  menfi olarsa ikinci ifadeni alin


            //double x, y, z, k;

            //Write("x : ");
            //x = Convert.ToDouble(ReadLine());
            //Write("z : ");
            //z = Convert.ToDouble(ReadLine());
            //Write("k : ");
            //k = Convert.ToDouble(ReadLine());


            //if ((x-z) > 0)
            //{
            //    y = Math.Pow(x, 3) + Math.Pow(Math.Pow(k, x), 1.0 / 4) + Math.Sqrt(10 * k * x - Math.Pow(z, 2)); // Not a Number
            //    WriteLine("1ci ifade : "+y);
            //}
            //else
            //{
            //    y = Math.PI + x * z * k - Math.Sqrt(Math.Pow(x, 3));
            //     WriteLine("2ci ifade : " + y);
            //}




            #endregion

            #region Example 2

            //int staj = 5;
            //Ctrl + K +  D

            //string department = "Muhasibat";//hr


            //if (department == "IT")//hr=it false
            //{
            //    WriteLine("Bu shobede proqramcilar yerlesir");
            //}
            //else if (department == "HR")// hr=hr true
            //{
            //    WriteLine("Bu shobede hrlar yerlesir");
            //}
            //else if (department == "Marketing")
            //{
            //    WriteLine("Bu shobede marketingler yerlesir");
            //}
            //else if (department == "Testing")
            //{
            //    WriteLine("Bu shobede testerler  yerlesir");
            //}
            //else
            //{
            //    WriteLine("Shirketde bele bir shobe yoxdur");
            //}



            //int verilenEded = 0;

            //if (verilenEded > 0)
            //{
            //    WriteLine("Eded musbetdir");
            //}
            //else if (verilenEded <0 )
            //{
            //    WriteLine("Eded Menfidir");

            //}
            //else
            //{
            //    WriteLine("Eded sifirdir");

            //}


            ////Vakansiya proqrami
            //Write("Staj : ");
            //double staj = Convert.ToInt32(ReadLine());

            //double maash;//undefined

            // verilmis if shertinde shertlerin && ayrilibsa bu zaman && operatorunu sagida soluda true olmalidirki shert blokuna girish edilsin    

            //// verilmis if shertinde shertlerin ||  ayrilibsa bu zaman ||  operatorunu ya sagi yada solu en azi 1-i true olmalidi



            //if (staj > 0 &&  staj <= 2)
            //{
            //    maash = 1500;
            //}
            //else if (staj > 2 && staj <=5)
            //{
            //    maash = 3000; //maash = 3000
            //}
            //else if (staj>5 && staj <=7)
            //{
            //    maash = 5000;
            //}
            //else if (staj > 7)
            //{
            //    maash = 7000;
            //}
            //else
            //{
            //    maash = 0;
            //    WriteLine("Menfi eded daxil ede bilmezsiniz");
            //}


            //maash = 2000;//maash =2000;
            //WriteLine("Sizin maashiniz : "+maash);

            #endregion


            #region Example 3
            // eded1 eded2 eded3 e1 cutdurse ve e3 ve e2den her hansi biri 5 bolunurse ekrana
            // eded1 tek ededdirse ve eded3 ve eded 2 her ikisi 5 tam bolunurse ekrana front end  yazzin
            // eded1 cut ededdirse ve eded3 4 ve 5 e qaliqsiz bolunurse ekrana backend
            // eded1 tekdirse ve eded3 4e bolunmurse ve ya eded2 7e qaliqsiz bolunurse ekran software yazdir


            //int ededBir, ededIki, ededUc;
            //Write("Eded1 : ");
            //ededBir = Convert.ToInt32(ReadLine());
            //Write("Eded2 : ");
            //ededIki = Convert.ToInt32(ReadLine());
            //Write("Eded3 : ");
            //ededUc = Convert.ToInt32(ReadLine());

            //// 6 % 4 = y qaliq eger  olarsa
            //    //       false                           // true
            //if (ededBir % 2 == 0 && (ededIki % 5 == 0 || ededUc % 5 == 0))
            //{
            //    WriteLine("Software");
            //}         
            //else if (ededBir % 2 != 0 && ededIki % 5 == 0 && ededUc % 5 == 0)
            //{
            //    WriteLine("Front end");
            //}
            //else if (ededBir % 2 == 0 && ededUc % 5==0 && ededUc % 4==0)
            //{
            //    WriteLine("Back end");
            //}
            //else if (ededBir % 2 != 0 && ededUc % 4 !=0 || ededIki % 7==0)
            //{
            //    WriteLine("Full stack");
            //}




            //string titul = "Backend";
            //int staj = Convert.ToInt32(ReadLine());
            //double maash =0;


            //if (titul == "Front-end")
            //{
            //    WriteLine("Front end Developer");
            //    if (staj >0 && staj <5)
            //    {
            //        maash = 3000;
            //    }
            //    else if(staj > 5)
            //    {
            //        maash = 5000;

            //    }
            //    else
            //    {
            //        maash = 0;

            //    }
            //}
            //else if(titul == "Backend")
            //{
            //    WriteLine("Back end Developer");
            //    if (staj > 0 && staj < 5)
            //    {
            //        maash = 5000;
            //    }
            //    else if (staj > 5)
            //    {
            //        maash = 7000;

            //    }
            //    else
            //    {
            //        maash = 0;

            //    }
            //}
            //else if (titul == "Full-Stack")
            //{
            //    WriteLine("Full stack  Developer");
            //    if (staj > 0 && staj < 5)
            //    {
            //        maash = 5000;
            //    }
            //    else if (staj > 5)
            //    {
            //        maash = 7000;

            //    }
            //    else
            //    {
            //        maash = 0;

            //    }
            //}
            //else
            //{
            //    WriteLine("Bele bir ixtisas movcu deytildir");
            //}


            //WriteLine(maash); 
            #endregion



            #region Bank Kredit odeme Sistemi If else

            //WriteLine("|Boolean Bankina xosh gelmisiniz|");
            //WriteLine("|          BDB                  |");

            //WriteLine("Zehmett olmasa maahsinizi daxil edin");

            //Write("Maashiniz : ");
            //int maash = Convert.ToInt32(ReadLine());//maash = 1200
            //int ayliqOdeme;
            //int kreditMebleghi = 0; //undefined

            //// false
            //if (maash > 100 && maash <= 1000)
            //{
            //    WriteLine("Sizin ayliq odemenize gore Size 500 800 ve 1000 azn kredit verile biler");
            //    Write("Ayliq Odeme : ");
            //    ayliqOdeme = Convert.ToInt32(ReadLine());

            //    if (ayliqOdeme > 100 && ayliqOdeme <=300)
            //    {
            //        kreditMebleghi = 500;
            //    }
            //    else if (ayliqOdeme > 300 && ayliqOdeme <= 500)
            //    {
            //        kreditMebleghi = 800;
            //    }
            //    else if (ayliqOdeme > 500 && ayliqOdeme <=900)
            //    {
            //        kreditMebleghi = 1000;
            //    }
            //    else
            //    {
            //        kreditMebleghi = 0;
            //    }
            //}
            //else if (maash > 1000 && maash <= 1500)
            //{          //          T
            //    WriteLine("Sizin ayliq odemenize gore Size 1200 1500 ve 1700 azn kredit verile biler");
            //    Write("Ayliq Odeme : ");
            //    ayliqOdeme = Convert.ToInt32(ReadLine());
            //            // T        T               T
            //    if (ayliqOdeme > 1000 && ayliqOdeme <= 1200)
            //    {
            //        kreditMebleghi = 1200;
            //    }
            //    else if (ayliqOdeme > 1200 && ayliqOdeme <= 1300)
            //    {
            //        kreditMebleghi = 1500;
            //    }
            //    else if (ayliqOdeme > 1300 && ayliqOdeme <= 1450)
            //    {
            //        kreditMebleghi = 1700;
            //    }
            //    else
            //    {
            //        kreditMebleghi = 0;
            //    }
            //}
            //else if (maash > 1500)
            //{           // t
            //    WriteLine("Sizin ayliq odemenize gore Size 1900 2000 ve 2500 azn kredit verile biler");
            //    Write("Ayliq Odeme : ");
            //    ayliqOdeme = Convert.ToInt32(ReadLine());
            //        // t                    T
            //    if (ayliqOdeme > 1500 && ayliqOdeme <= 1800)
            //    {
            //        kreditMebleghi = 1600;
            //    }
            //    else if (ayliqOdeme > 1800 && ayliqOdeme <= 2000)
            //    {
            //        kreditMebleghi = 2000;
            //    }
            //    else if (ayliqOdeme >2000)
            //    {
            //        kreditMebleghi = 2500;
            //    }
            //    else
            //    {
            //        kreditMebleghi = 0;
            //    }
            //}
            //else
            //{
            //    WriteLine("Bu Shertler daxilinde size kredit vere bilmerik");

            //}


            //if (kreditMebleghi ==0)
            //{
            //    WriteLine("Size kredit verile bilmez");
            //}
            //else
            //{

            //    WriteLine($"Sizin kredit  mebleghiniz :{kreditMebleghi}");
            //}

            #endregion


            #region Switch Case izah ve Calculator
            //string telebeAdi = "Elvin";

            //switch (telebeAdi)
            //{
            //    case "Mircamal":
            //        WriteLine("Salam menim adim Mircamaldir");
            //        break;
            //    case "Gunel":
            //        WriteLine("Salam menim adim Guneldir");
            //        break;
            //    case "Elvin":
            //        WriteLine("Salam menim adim Elvindir");
            //        break;
            //    default:
            //        WriteLine("Bele bir telebe movcud deyiuldir");
            //        break;
            //}


            //int b, c;

            //b = Convert.ToInt32(ReadLine());
            //c = Convert.ToInt32(ReadLine());

            //WriteLine("Emeliyyati daxil edin");
            //WriteLine("+,-,*,/");
            //char opr = Convert.ToChar(ReadLine());


            //switch (opr)//*
            //{
            //    case '+'://false
            //        WriteLine(b + c);
            //        break;
            //    case '-': // false
            //        WriteLine(b - c);
            //        break;
            //    case '*': // true
            //        WriteLine(b * c);
            //        break;
            //    case '/':
            //        WriteLine(b / c);
            //        break;

            //    default:
            //        WriteLine("Bele bir emeliyyat movcud deyildir");
            //        break;
            //} 
            #endregion



            WriteLine("|Boolean Bankina xosh gelmisiniz|");
            WriteLine("|          BDB                  |");


        //shift + alt + asagi
        start:
            WriteLine("1. Pul Cekme Emeliyyati");
            WriteLine("2. Pul Kocurme Emeliyyati");
            WriteLine("3. Hesabi goster Emeliyyati");


            WriteLine("Zehmet olmasa emeliyyati secin");
            Write("Emeliyyat : ");

            int emeliyyat = Convert.ToInt32(ReadLine());

            int hesabMebleghi = 300;

            char dayandirmEmeliyyati;
            switch (emeliyyat)
            {
                case 1:
                    WriteLine("Salam siz pul cekmek emeliyyatina daxil oldunuz");
                    WriteLine("1. -  50 azn");
                    WriteLine("2. -  100 azn");
                    WriteLine("3. -  200 azn");

                    int cekeceyinizMeblegh = Convert.ToInt32(ReadLine()); // 2

                    switch (cekeceyinizMeblegh) //2
                    {
                        case 1: // false
                            WriteLine($"Siz kartinizdan 50 azn pul cekdiniz ve kartinizda qalan meblegh {hesabMebleghi - 50}");
                            break;
                        case 2: // true
                            WriteLine($"Siz kartinizdan 100 azn pul cekdiniz ve kartinizda qalan meblegh {hesabMebleghi - 100}");
                            break;
                        case 3:
                            WriteLine($"Siz kartinizdan 200 azn pul cekdiniz ve kartinizda qalan meblegh {hesabMebleghi - 200}");
                            break;
                        default:
                            WriteLine("Bele bir meblegh movcud deyildir");
                            break;
                    }

                    WriteLine("Emeliyyati sonlandirmaq ucun N duymesine click ede bilersiz");

                    dayandirmEmeliyyati = Convert.ToChar(ReadLine());
                    if (dayandirmEmeliyyati == 'N')
                    {
                        break;
                    }
                    else
                    {
                        goto start;
                    }



                case 2:
                    WriteLine("Salam siz pul kocurmek  emeliyyatina daxil oldunuz");
                    WriteLine("Kocureceyiniz hesabi secin");
                    WriteLine("1. -  113 pin");
                    WriteLine("2. -  109 pin");
                    WriteLine("3. -  101 pin");
                    WriteLine("Kocureceyiniz hesabi daxil edin");

                    int hesabNomresi = Convert.ToInt32(ReadLine());

                    switch (hesabNomresi)
                    {
                        case 1:
                            WriteLine("Siz 113 nomreli hesaba pul kocurdunuz");
                            break;
                        case 2:
                            WriteLine("Siz 109 nomreli hesaba pul kocurdunuz");
                            break;
                        case 3:
                            WriteLine("Siz 101 nomreli hesaba pul kocurdunuz");
                            break;

                        default:
                            WriteLine("Sizde bele bir hesab yoxdur");
                            break;
                    }

                    WriteLine("Emeliyyati sonlandirmaq ucun N duymesine click ede bilersiz");
                    dayandirmEmeliyyati = Convert.ToChar(ReadLine());
                    if (dayandirmEmeliyyati == 'N')
                    {
                        break;
                    }
                    else
                    {
                        goto start;
                    }


                case 3:
                    WriteLine($"Sizin hesabinizda olan meblegh : {hesabMebleghi}");

                    WriteLine("Emeliyyati sonlandirmaq ucun N duymesine click ede bilersiz");
                    dayandirmEmeliyyati = Convert.ToChar(ReadLine());
                    if (dayandirmEmeliyyati == 'N')
                    {
                        break;
                    }
                    else
                    {
                        goto start;
                    }


                default:
                    WriteLine("Bele bir emeliyyat movcud deyildir");
                    dayandirmEmeliyyati = Convert.ToChar(ReadLine());
                    if (dayandirmEmeliyyati == 'N')
                    {
                        break;
                    }
                    else
                    {
                        goto start;
                    }

            }




            ReadLine();

        }
    }
}
