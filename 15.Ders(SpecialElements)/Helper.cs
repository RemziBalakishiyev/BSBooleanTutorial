using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Ders_SpecialElements_
{
    static class Helper
    {

        public  enum Title
        {
            MR,
            MRS,
            DR
        }
        public static void ShowFullName(string firstName="Unknown",string lastName="Unknown")
        {
            Console.WriteLine($"{firstName} {lastName}" );
        }

        public static void ShowFullName(Title title,string firstName = "Unknown", string lastName = "Unknown")
        {
            Console.WriteLine($" {title} {firstName} {lastName}");
        }

    }
}
