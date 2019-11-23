using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace GGB
{
    public class DBUtil
    {
        public static string ConnectionParam
        {
            get
            {
                const string param = @"Data Source =.\SQLEXPRESS;Initial Catalog = usersdb; Integrated Security = True";
                return param;
            }
        }

        public static string textSqlCommandUniver
        {
            get
            {
                const string text = "Select * from[University]";
                return text;
            }
        }

        public string textSqlCommandStudents(int univer)
        {
            string text = "Select * from [Students] where universityId=" + univer;
            return text;
        }

        public SqlDataReader ExQuery(string textSqlCommand)
        {
            SqlConnection connect = new SqlConnection(DBUtil.ConnectionParam); // нужно написать using ()??
            SqlCommand queryCommand = new SqlCommand(textSqlCommandUniver, connect);
            SqlDataReader answerQ = queryCommand.ExecuteReader();
            return (answerQ);
        }

        public List<string> QueryResultToList(SqlDataReader result)
        {
            
            List<string> list = new List<string>();
                // TODO show column name?            list [0] = result.GetDataTypeName;
                int i = 0;

            while (result.Read())
            {
                list[i] = result.GetString(i);
                i++;
            }
            result.Close();
            return list;
            
             
        }
    }
}