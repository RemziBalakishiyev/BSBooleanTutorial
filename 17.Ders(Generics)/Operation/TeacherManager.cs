using _17.Ders_Generics_.Enitty;
using _17.Ders_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ders_Generics_.Operation
{
    internal class TeacherManager : ITeacher
    {
        List<Teacher> _teachers;
        public TeacherManager()
        {
            _teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id=1,
                    FirstName="Remzi",
                    LastName="Balakishiyev",
                    Groups=new List<string>{"655.18","651.19","683.20" },
                    Salary=60000
                },
                new Teacher{
                    Id=2,
                    FirstName="Memmed",
                    LastName="Bedelov",
                    Groups=new List<string>{"621.20","611.19","685.20" },
                    Salary=50000
                }
            };
        }
        public void Add(Teacher entity)
        {
            _teachers.Add(entity);
        }

        public Teacher Get(int id)// 2
        {
            foreach (var teacher in _teachers)
            {
                if (teacher.Id == id)
                {
                    return teacher; // Id = 2, FirstName
                }
            }
            return null;
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public void Remove(Teacher entity)
        {
            _teachers.Remove(entity);
        }

        public void ShowMonthlySalary(int id)
        {
            Teacher teacher = Get(id);
            Console.WriteLine($"{teacher.FirstName} salary is {teacher.Salary / 12}..");
        }

        public void Update(int Id, Teacher entity)
        {
            foreach (var teacher in _teachers)
            {
                if (teacher.Id == Id)
                {
                    teacher.Id = entity.Id;
                    teacher.LastName = entity.LastName;
                    teacher.FirstName = entity.FirstName;
                    teacher.Salary = entity.Salary;
                    teacher.Groups = entity.Groups;
                }
            }

        }
    }
}
