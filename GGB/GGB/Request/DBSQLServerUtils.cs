using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class DBSQLServerUtils
    {
        //TODO: путь чере диск
        private static string path = @"L:\GGB\GGB\GGB\Model_\Database.mdf";

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+";Integrated Security=True";

        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
