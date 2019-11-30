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
        public int GetRating { get; }
        public int GetAge { get; }

        public Student(string name, string surname, string patronymic, int id, int rating, int age)
        {
            this.GetName = name;
            this.GetSurname = surname;
            this.GetPatronymic = patronymic;
            this.GetID = id;
            this.GetRating = rating;
            this.GetAge = age;
        }

    }
}
