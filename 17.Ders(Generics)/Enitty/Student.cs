using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_.Enitty
{
    internal class Student:BaseEntity
    {
        public string GroupNumber { get; set; }
        public string Speciality { get; set; }
        public double UOQ { get; set; }
    }
}
