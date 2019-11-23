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

        //private DBUtils connect;

        private IRequest<string> request;
        private IRequest<Student> getRequestStudent;

        public IList<Student> GetStudent { get { return students; } }
        public IList<string> GetNameUniversity { get { return request.GetResult; } }
        public IList<University> GetUniversity { get { return universities; } }
        public IList<Faculty> GetFaculty { get { return faculties; } }

        public Model()
        {
            //this.request = new RequestUniversity();
            getRequestStudent = new RequestStudent();
            NameUniversity();
        }

        private void NameUniversity()
        {
            request = new RequestUniversity();
            request.SetRequest(Constant.selectUniversity);
            
        }

        private void ClearData()
        {
            if (students.Count() != 0)
                students.Clear();
        }

        public void RequestGetStudentRatingAverage(string university, string ratingAverage)
        {
            ClearData();
            string textRequest = "SELECT..";
            getRequestStudent.SetRequest(textRequest);

            students = getRequestStudent.GetResult;
        }

        public void RequestGetStudentUniversity(string university)
        {
            throw new NotImplementedException();
        }
    }
}
