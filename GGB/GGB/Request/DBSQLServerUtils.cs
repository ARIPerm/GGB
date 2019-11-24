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
        //private static string path = @"S:\PortableGit\GGB\GGB\GGB\Model_\Database.mdf";
        private static string path = Directory.GetCurrentDirectory();

        static string temp = path.Remove(19, path.Length - 19);

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + temp + @"GGB\GGB\Model_\Database.mdf;Integrated Security=True";

        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
