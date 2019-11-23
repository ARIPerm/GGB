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
        public static string сonnectionParam
        { get
            {
                const string param = "Data Source =.\SQLEXPRESS;Initial Catalog = usersdb; Integrated Security = True";
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

        public string textSqlCommandStudents (int univer)
        {
            {
                string text = "Select * from [Students] where universityId=" + univer;
                return text;
            }
        }

        public SqlDataReader ExQuery (string textSqlCommand)
            {
            SqlConnection connect = new SqlConnection(DBUtil.сonnectionParam); // нужно написать using ()??
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
            };
            return list;
        }
    }
}

/*    
For Memory
int class DB
public class DBUtils
    {
        MainView f1 = new MainView();
        static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        private void executeQuery()
        {
            SqlConnection connect = new SqlConnection();

            SqlCommand queryComand = new SqlCommand("Select * from[Univerity]", connect);
            SqlDataReader result =  queryComand.ExecuteReader();
            while(result.Read())
            {
                
                Console.Write(String.Format($"{result["Id"]}"));
                Console.Write(String.Format($"{result["Name"]}"));
                Console.Write(String.Format($"{result["YearCreate"]}"));
                Console.Write(String.Format($"{result["Rector"]}"));
                Console.WriteLine();
            }
            Console.ReadKey();
        //private SqlCommand queryComand = new SqlCommand();

        //queryComand.Connection.Open();
        ///DbCommand.ExecuteNonQuery();
        }
       
          
        }


    public class BDConnecting
    {

    }

  }
  */
