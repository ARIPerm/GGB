using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Model : IModel
    {
        List<Student> students;

        public List<Student> allStudent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<string> nameUniversity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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
