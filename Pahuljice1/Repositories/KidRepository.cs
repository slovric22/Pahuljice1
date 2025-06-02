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
            int id = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]);

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

                Id = id,
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


        public static void DeleteKidById(int id)
        {
            string sql = "DELETE FROM Kids WHERE Id = @Id";
            DB.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DB.GetConnection());
            cmd.Parameters.AddWithValue("@Id", id);
            int rowsAffected = cmd.ExecuteNonQuery();
            DB.CloseConnection();

            if (rowsAffected == 0)
                throw new Exception("Nije pronađeno dijete s tim Id-em za brisanje.");
        }




        public static void AddKid(Kid kid)
        {
            string sql = @"INSERT INTO Kids (Id, [Ime i prezime], [Datum rođenja], [Roditelj(i)], [Kontakt], [Alergije], [Poteškoće], [Skupina], [Zaposlenik])
                   VALUES (@Id, @Name, @Date, @Parent, @Contact, @Allergy, @Setback, @Group, @Employee)";

            DB.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DB.GetConnection());
            cmd.Parameters.AddWithValue("@Id", kid.Id);
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
        public static void UpdateKid(Kid kid)
        {
            string sql = @"UPDATE Kids SET 
                    [Ime i prezime] = @Name, 
                    [Datum rođenja] = @Date,
                    [Roditelj(i)] = @Parent,
                    [Kontakt] = @Contact,
                    [Alergije] = @Allergy,
                    [Poteškoće] = @Setback,
                    [Skupina] = @Group,
                    [Zaposlenik] = @Employee
                   WHERE Id = @Id";

            DB.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DB.GetConnection());
            cmd.Parameters.AddWithValue("@Id", kid.Id);
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

