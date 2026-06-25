using System.Data.SqlClient;

namespace SistemManajemenObat
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
