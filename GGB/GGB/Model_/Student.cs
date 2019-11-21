using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Student
    {
        public string GetName { get; }
        public string GetSurname { get; }
        public string GetPatronymic { get; }
        public int GetID { get; }

        public Student(string name, string surname, string patronymic, int id)
        {
            this.GetName = name;
            this.GetSurname = surname;
            this.GetPatronymic = patronymic;
            this.GetID = id;
        }

    }
}
