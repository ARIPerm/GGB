using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Model : IModel
    {
        private List<University> universities;
        private List<Faculty> faculties;

        private DBUtil connect;

        private IRequest<string> request;
        private IRequest<Student> getRequestStudent;

        public IList<Student> GetStudent { get { return getRequestStudent.GetResult; } }
        public IList<string> GetNameUniversity { get { return request.GetResult; } }
        public IList<University> GetUniversity { get { return universities; } }
        public IList<Faculty> GetFaculty { get { return faculties; } }

        public Model()
        {
            getRequestStudent = new RequestStudent();
            NameUniversity();
        }

        private void NameUniversity()
        {
            request = new RequestUniversity();
            request.SetRequest(Constant.selectUniversity);
        }

        public void RequestGetStudentRatingAverage(int university, int ratingAverage)
        {
            string textRequest = Constant.universityStudentRequestText + university + Constant.averageRatingStudentRequestText + ratingAverage;
            getRequestStudent.SetRequest(textRequest);
        }

        public void RequestGetStudentUniversity(int university)
        {
            string textRequest = Constant.universityStudentRequestText + university.ToString();
            getRequestStudent.SetRequest(textRequest);
        }
    }

}
