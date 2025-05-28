using System.Data.SqlClient;
using System.Data;

namespace Pahuljice1
{
    public static class DB
    {
        private static SqlConnection connection;

        private static string connectionString =
            @"Data Source=31.147.206.65;Initial Catalog=PI2425_slovric22_DB;User ID=PI2425_slovric22_User;Password=bS^AjJkl;";

        public static void OpenConnection()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public static SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public static void ExecuteCommand(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public static SqlConnection GetConnection()
        {
            return connection;
        }
    }
}

