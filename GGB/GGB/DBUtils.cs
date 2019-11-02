using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace GGB
{
    class DBUtils
    {
        Form1 f1 = new Form1();
        static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        private void executeQuery()
        {
            SqlConnection connect = new SqlConnection();

            SqlCommand command = new SqlCommand("Select * from[Univerity]", connect);
            SqlDataReader result =  command.ExecuteReader();
            while(result.Read())
            {
                
                Console.Write(String.Format($"{result["Id"]}"));
                Console.Write(String.Format($"{result["Name"]}"));
                Console.Write(String.Format($"{result["YearCreate"]}"));
                Console.Write(String.Format($"{result["Rector"]}"));
                Console.WriteLine();
            }
            Console.ReadKey();
        //private SqlCommand command = new SqlCommand();

        //command.Connection.Open();
        ///DbCommand.ExecuteNonQuery();
        }
       
          
        }

  }
