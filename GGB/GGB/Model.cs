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

        public Student (string name, string surname, string patronymic)
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
    };
    
    public class Students
    {
        //public List<Student> students = new List<Student>();
        
        private List<Student> students;

        public Students()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        
    };
}
