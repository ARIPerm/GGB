using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class RequestUniversity : IRequest<string>
    {
        private List<string> listResult;

        public List<string> GetResult { get { if (listResult != null) return listResult; else return null; } }

        public RequestUniversity()
        {
            listResult = new List<string>();
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
                        listResult.Add(String.Format($"{result["Name"]}"));
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
