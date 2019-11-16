using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Model : IModel
    {
        private List<Student> students;

        public List<Student> allStudent { get { return students; } }
        

        public List<string> nameUniversity { get; }


        public void ClearData()
        {
            throw new NotImplementedException();
        }

        public void RequestGetStudentRatingAverage(string university, string ratingAverage)
        {
            throw new NotImplementedException();
        }

        public void RequestGetStudentUniversity(string university)
        {
            throw new NotImplementedException();
        }

        //List<University> universities;

        //List<Faculty> faculties;




    }

}
