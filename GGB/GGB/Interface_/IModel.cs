using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IModel
    {
        IList<Student> GetStudent { get; }
        IList<University> GetUniversity { get; }
        IList<Faculty> GetFaculty { get; }
        IList<string> GetNameUniversity { get; }
       
        void RequestGetStudentUniversity(string university);

        void RequestGetStudentRatingAverage(string university, string ratingAverage);      
    }
}
