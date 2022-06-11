using _17.Ders_Generics_.Enitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_.Interfaces
{
    internal interface IStudent:IGeneric<Student>
    {
        bool StudentStatus();
    }
}
