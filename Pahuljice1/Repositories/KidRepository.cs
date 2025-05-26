using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Pahuljice1.Repositories
{
    public class KidRepository
    {
        public static Kid GetKids(int id) {
            Kid kid = null;
            string sql = $"SELECT * FROM  Kids WHERE Id ={ id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                kid = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return kid;
           }

        public static List<Kid> GetKids()
        { 
        List<Kid> kids = new List<Kid>();
            string sql = "SELECT * FROM Kids";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Kid kid = CreateObject(reader);
                kids.Add(kid);
            }
            reader.Close();
            DB.CloseConnection();
            return kids;
        }
        private static Kid CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName= reader["Ime i prezime"].ToString();
            string date = reader["Datum rođenja"].ToString();
            int.TryParse(reader["OIB"].ToString(), out int OIB);

            Kid kid = new Kid()
            {
                Id = id,
                FirstName  = firstName,
                Datum rođenja = date,
                OIB = OIB
            };
            return kid;
        }

    }
}
