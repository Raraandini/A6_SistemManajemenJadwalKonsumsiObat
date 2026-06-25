using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;

namespace SistemManajemenObat
{
    public static class DatabaseHelper
    {
        public static string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            try 
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIP = endPoint.Address.ToString();
                }
            }
            catch 
            {
                localIP = "127.0.0.1";
            }
            return localIP;
        }
<<<<<<< HEAD

        private static readonly string _connectionString =
            "Data Source=LAPTOP-Q1UQHI44\\MEILANULFIA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True;";
=======
>>>>>>> 892ff2afe9b94f39079c34c9ca696f307d102661

        private static readonly string _connectionString =
           "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
