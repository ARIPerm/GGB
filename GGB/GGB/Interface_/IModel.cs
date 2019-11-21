using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IModel
    {
        List<Student> GetStudent { get; }
        List<University> GetUniversity { get; }
        List<Faculty> GetFaculty { get; }
        List<string> GetNameUniversity { get; }
        


        void RequestGetStudentUniversity(string university);

        void RequestGetStudentRatingAverage(string university, string ratingAverage);



    }
}
