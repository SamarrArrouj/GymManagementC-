using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GymManagementSystemC_
{
    internal class StaffRepository
    {
        private readonly string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True; TrustServerCertificate=True;";

        public void AddStaff(Staff staff)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Statee, City) " +
                               "VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Statee, @City)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", staff.FirstName);
                    cmd.Parameters.AddWithValue("@Lname", staff.LastName);
                    cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@Dob", staff.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Mobile", staff.Mobile);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@JoinDate", staff.JoinDate);
                    cmd.Parameters.AddWithValue("@Statee", staff.Statee);
                    cmd.Parameters.AddWithValue("@City", staff.City);


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Staff GetStaffById(int staffId)
        {
            Staff staff = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NewStaff WHERE SID = @SID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SID", staffId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            staff = new Staff();
                            staff.Id = reader.GetInt32(reader.GetOrdinal("SID"));
                            staff.FirstName = reader.GetString(reader.GetOrdinal("Fname"));
                            staff.LastName = reader.GetString(reader.GetOrdinal("Lname"));
                            staff.Gender = reader.GetString(reader.GetOrdinal("Gender"));

                            // Convertir Dob et JoinDate depuis le type VARCHAR
                            staff.DateOfBirth = DateTime.Parse(reader.GetString(reader.GetOrdinal("Dob")));
                            staff.Mobile = reader.GetInt64(reader.GetOrdinal("Mobile"));
                            staff.Email = reader.GetString(reader.GetOrdinal("Email"));

                            // Convertir JoinDate depuis le type VARCHAR
                            staff.JoinDate = DateTime.Parse(reader.GetString(reader.GetOrdinal("JoinDate")));

                            staff.Statee = reader.GetString(reader.GetOrdinal("Statee"));
                            staff.City = reader.GetString(reader.GetOrdinal("City"));
                        }
                    }

                }
            }

            return staff;
        }

        // Mettre à jour les informations d'un membre du personnel
        public void UpdateStaff(Staff staff)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE NewStaff SET Fname = @Fname, Lname = @Lname, Gender = @Gender, Dob = @Dob, Mobile = @Mobile, " +
                               "Email = @Email, JoinDate = @JoinDate, Statee = @Statee, City = @City WHERE SID = @SID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", staff.FirstName);
                    cmd.Parameters.AddWithValue("@Lname", staff.LastName);
                    cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@Dob", staff.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Mobile", staff.Mobile);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@JoinDate", staff.JoinDate);
                    cmd.Parameters.AddWithValue("@Statee", staff.Statee);
                    cmd.Parameters.AddWithValue("@City", staff.City);
                    cmd.Parameters.AddWithValue("@SID", staff.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
