using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Student
    {
        public string name { get; }
        public string surname { get; }
        public string patronymic { get; }
        public int id { get; }

        public Student(string name, string surname, string patronymic, int id)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.id = id;
        }

    }
}
