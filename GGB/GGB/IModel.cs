using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IModel
    {
        List<Student> allStudent { get; }

        //TODO: добавить классы университета и факультета, которые хранят структуры БД и интерфейсы этих классов
        //List<University> allUniversity { get; }
        //List<Faculty> allFaculty { get; }

        //получить из БД список имен университетов можно через метод и заполнить данными nameUniversity
        List<string> nameUniversity { get; }
        

        //или хранить временно данные запросов, показывать их презентору и удалять
        void ClearData();

        void RequestGetStudentUniversity(string university);

        void RequestGetStudentRatingAverage(string university, string ratingAverage);



    }
}
