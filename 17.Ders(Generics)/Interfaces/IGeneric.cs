using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_.Interfaces
{
    internal interface IGeneric<T> //Teac
    {
        void Add(T entity);
        void Update(int Id, T entity);
        void Remove(T entity);
        List<T> GetAll();
        T Get(int id);
    }
}
