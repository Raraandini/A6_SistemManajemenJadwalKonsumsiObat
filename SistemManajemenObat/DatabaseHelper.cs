using System.Data.SqlClient;

namespace SistemManajemenObat
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString =
            "Data Source=LAPTOP-Q1UQHI44\\MEILANULFIA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
