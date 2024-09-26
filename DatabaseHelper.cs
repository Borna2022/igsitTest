using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igsit
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=borna;Initial Catalog=igsitDBTest;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
