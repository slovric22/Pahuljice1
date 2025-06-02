using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pahuljice1.Repositories
{
    public class KidRepository
    {
        public static Kid GetKid(int id) {
            Kid kid = null;
            string sql = $"SELECT * FROM  dbo.Kids WHERE Id ={ id}";
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
        var kids = new List<Kid>();
            string sql = "SELECT * FROM dbo.Kids";
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
            
            string name = reader["Ime i prezime"].ToString();
            string date = reader["Datum rođenja"].ToString();
            string parent = reader["Roditelj(i)"].ToString();
            string contact = reader["Kontakt"].ToString();
            string allergy = reader["Alergije"].ToString();
            string setback = reader["Poteškoće"].ToString();
            string group = reader["Skupina"].ToString();
            string employee = reader["Zaposlenik"].ToString();

            var kid = new Kid
            {
                
                Name = name,
                Date = date,
                Parent = parent,
                Contact = contact,
                Allergy = allergy,
                Setback = setback,
                Group = group,
                Employee = employee
            };

            return kid;
        }
        

        public static void DeleteKid(Kid kid)
        {
            string sql = $"DELETE FROM Kids WHERE Id = {kid.OIB}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void AddKid(Kid kid)
        {
            string sql = @"INSERT INTO Kids ([Ime i prezime], [Datum rođenja], [Roditelj(i)], [Kontakt], [Alergije], [Poteškoće], [Skupina], [Zaposlenik])
                   VALUES (@Name, @Date, @Parent, @Contact, @Allergy, @Setback, @Group, @Employee)";

            DB.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DB.GetConnection());
            cmd.Parameters.AddWithValue("@Name", kid.Name);
            cmd.Parameters.AddWithValue("@Date", kid.Date);
            cmd.Parameters.AddWithValue("@Parent", kid.Parent);
            cmd.Parameters.AddWithValue("@Contact", kid.Contact);
            cmd.Parameters.AddWithValue("@Allergy", kid.Allergy);
            cmd.Parameters.AddWithValue("@Setback", kid.Setback);
            cmd.Parameters.AddWithValue("@Group", kid.Group);
            cmd.Parameters.AddWithValue("@Employee", kid.Employee);
            cmd.ExecuteNonQuery();
            DB.CloseConnection();
        }


    }

}

