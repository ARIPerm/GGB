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
        public string paramConnection
        { get
            {
                const string param = "Data Source =.\SQLEXPRESS;Initial Catalog = usersdb; Integrated Security = True";
                return param;
            }
        }
        public List<string> QueryResultToList(SqlDataReader result)
        {
            result.GetDataTypeName
            int i = 1;
            List<string> list = new List<string>();
            while (result.Read())
            {
                list[i] = result.GetString(i);
                i++;
            };
            return list;
        }
    }
}

/*    int class DB
public class DBUtils
    {
        MainView f1 = new MainView();
        static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        private void executeQuery()
        {
            SqlConnection connect = new SqlConnection();

            SqlCommand qUniver = new SqlCommand("Select * from[Univerity]", connect);
            SqlDataReader result =  qUniver.ExecuteReader();
            while(result.Read())
            {
                
                Console.Write(String.Format($"{result["Id"]}"));
                Console.Write(String.Format($"{result["Name"]}"));
                Console.Write(String.Format($"{result["YearCreate"]}"));
                Console.Write(String.Format($"{result["Rector"]}"));
                Console.WriteLine();
            }
            Console.ReadKey();
        //private SqlCommand qUniver = new SqlCommand();

        //qUniver.Connection.Open();
        ///DbCommand.ExecuteNonQuery();
        }
       
          
        }

  }
  */