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


        //TODO: добавить данные о рейтинге, факультете и универе ?


        public Student(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }


        /*
        string name, surname, patronymic;
        int id, age, rating, faculty, univer;
        //public ReadName(name);
        //public ReadSurname(surname);
        //public ReadPatronymic(patronymic);
        */

    }
}
