using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class RequestStudent : IRequest<Student>
    {
        private List<Student> students;

        public List<Student> GetResult { get { return students; } }

        public RequestStudent()
        {
            students = new List<Student>();
        }

        public void SetRequest(string textRequest)
        {
            SqlConnection connect = DBSQLServerUtils.GetDBConnection();
            connect.Open();

            try
            {
                SqlCommand command = new SqlCommand(textRequest, connect);
                using (SqlDataReader result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Student student = new Student(String.Format($"{result["Name"]}"), String.Format($"{result["Surname"]}"), String.Format($"{result["Patronymic"]}"), Convert.ToInt32(result["Id"]));
                        students.Add(student);
                    }
                }

            }
            catch
            {
                //TODO: обработка ошибки
            }
            finally
            {
                connect.Close();
                connect.Dispose();
            }
        }
    }
}
