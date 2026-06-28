using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment
{
    internal class Database
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\15061\\Desktop\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True";

        public static bool AddUser(string Name, string Password, int PH, string Email, string Home, int Characters , int Status) //This method will add a user to the database
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                byte[] image = { 0 };
                con.Open();
                //Add the input as parameters to avoid SQL injections
                SqlCommand cmd = new SqlCommand("INSERT INTO Staff VALUES (@Name, @Password, @Email, @PH, @Home,@Characters,@Status)", con);
            cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Home", Home);
                cmd.Parameters.Add(new SqlParameter("@Characters", Characters));
                cmd.Parameters.Add(new SqlParameter("@Status", Status));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //violation of primary key
                    return false;
                }
            }
            return true;
        }

        internal static bool AddUser(string staffID, string fname, string lname, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
