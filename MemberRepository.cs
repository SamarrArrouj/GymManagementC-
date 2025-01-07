using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GymManagementSystemC_
{
    public class MemberRepository
    {
        private readonly string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True; TrustServerCertificate=True;";

        public void AddMember(Member member)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, GymTime, Maddress, MembershipTime) " +
                               "VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @GymTime, @Maddress, @MembershipTime)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", member.FirstName);
                    cmd.Parameters.AddWithValue("@Lname", member.LastName);
                    cmd.Parameters.AddWithValue("@Gender", member.Gender);
                    cmd.Parameters.AddWithValue("@Dob", member.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Mobile", member.Mobile);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                    cmd.Parameters.AddWithValue("@GymTime", member.GymTime);
                    cmd.Parameters.AddWithValue("@Maddress", member.Address);
                    cmd.Parameters.AddWithValue("@MembershipTime", member.Membership);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Member GetMemberById(int memberId)
        {
            Member member = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NewMember WHERE MID = @MID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MID", memberId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = new Member();
                            var ordinal = reader.GetOrdinal("MID");

                            if (!reader.IsDBNull(ordinal))
                                member.Id = reader.GetInt32(ordinal);

                            ordinal = reader.GetOrdinal("Fname");
                            if (!reader.IsDBNull(ordinal))
                                member.FirstName = reader.GetString(ordinal);

                            ordinal = reader.GetOrdinal("Lname");
                            if (!reader.IsDBNull(ordinal))
                                member.LastName = reader.GetString(ordinal);

                            ordinal = reader.GetOrdinal("Gender");
                            if (!reader.IsDBNull(ordinal))
                                member.Gender = reader.GetString(ordinal);

                            // Handle DateOfBirth (Dob) safely
                            ordinal = reader.GetOrdinal("Dob");
                            if (!reader.IsDBNull(ordinal))
                            {
                                string dobStr = reader.GetString(ordinal);
                                DateTime dob;
                                if (DateTime.TryParse(dobStr, out dob))  // Safely parse the string into DateTime
                                {
                                    member.DateOfBirth = dob;
                                }
                                else
                                {
                                    member.DateOfBirth = DateTime.MinValue; // Fallback value if parsing fails
                                }
                            }

                            ordinal = reader.GetOrdinal("Mobile");
                            if (!reader.IsDBNull(ordinal))
                                member.Mobile = reader.GetInt64(ordinal);

                            ordinal = reader.GetOrdinal("Email");
                            if (!reader.IsDBNull(ordinal))
                                member.Email = reader.GetString(ordinal);

                            // Handle JoinDate safely as a string (since it's varchar)
                            ordinal = reader.GetOrdinal("JoinDate");
                            if (!reader.IsDBNull(ordinal))
                            {
                                string joinDateStr = reader.GetString(ordinal);
                                DateTime joinDate;
                                if (DateTime.TryParse(joinDateStr, out joinDate))  // Safely parse the string into DateTime
                                {
                                    member.JoinDate = joinDate;
                                }
                                else
                                {
                                    member.JoinDate = DateTime.MinValue; // Fallback value if parsing fails
                                }
                            }

                            // GymTime is a string (varchar), so we directly assign it
                            ordinal = reader.GetOrdinal("GymTime");
                            if (!reader.IsDBNull(ordinal))
                                member.GymTime = reader.GetString(ordinal);

                            ordinal = reader.GetOrdinal("Maddress");
                            if (!reader.IsDBNull(ordinal))
                                member.Address = reader.GetString(ordinal);

                            ordinal = reader.GetOrdinal("MembershipTime");
                            if (!reader.IsDBNull(ordinal))
                                member.Membership = reader.GetString(ordinal);
                        }
                    }
                }
            }

            return member;
        }

        public void UpdateMember(Member member)
        {
            string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE NewMember SET Fname = @Fname, Lname = @Lname, Gender = @Gender, Dob = @Dob, Mobile = @Mobile, Email = @Email, JoinDate = @JoinDate, GymTime = @GymTime, Maddress = @Maddress, MembershipTime = @MembershipTime WHERE MID = @MID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", member.FirstName);
                    cmd.Parameters.AddWithValue("@Lname", member.LastName);
                    cmd.Parameters.AddWithValue("@Gender", member.Gender);
                    cmd.Parameters.AddWithValue("@Dob", member.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Mobile", member.Mobile);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                    cmd.Parameters.AddWithValue("@GymTime", member.GymTime);
                    cmd.Parameters.AddWithValue("@Maddress", member.Address);
                    cmd.Parameters.AddWithValue("@MembershipTime", member.Membership);
                    cmd.Parameters.AddWithValue("@MID", member.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
