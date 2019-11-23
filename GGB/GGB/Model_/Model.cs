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
        private List<University> universities;
        private List<Faculty> faculties;

        private DBUtil connect;

        public List<Student> GetStudent { get { return students; } }
        public List<string> GetNameUniversity { get; }
        public List<University> GetUniversity { get { return universities; } }
        public List<Faculty> GetFaculty { get { return faculties; } }


        public Model()
        {

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

    }

}
