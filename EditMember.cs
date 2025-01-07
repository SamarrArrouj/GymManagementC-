using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace GymManagementSystemC_
{
    public partial class EditMember : Form
    {
        private Member _member;

        public EditMember(Member member)
        {
            InitializeComponent();
            _member = member;

            // Fill the fields with the member data
            txtFirstName.Text = _member.FirstName;
            txtLastName.Text = _member.LastName;
            radioButton1.Checked = _member.Gender == "Male"; // assuming "Male" or "Female"
            radioButton2.Checked = _member.Gender == "Female";
            dateTimePickerDOB.Value = _member.DateOfBirth;
            txtMobile.Text = _member.Mobile.ToString();
            txtEmail.Text = _member.Email;
            dateTimePickerJoinDate.Value = _member.JoinDate;
            comboBoxGymTime.SelectedItem = _member.GymTime;
            txtAddress.Text = _member.Address;
            comboBoxMembership.SelectedItem = _member.Membership;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please enter valid first and last names.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the updated Member object
                _member.FirstName = txtFirstName.Text;
                _member.LastName = txtLastName.Text;
                _member.Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                _member.DateOfBirth = dateTimePickerDOB.Value;
                _member.Mobile = long.Parse(txtMobile.Text);
                _member.Email = txtEmail.Text;
                _member.JoinDate = dateTimePickerJoinDate.Value;
                _member.GymTime = comboBoxGymTime.Text;
                _member.Address = txtAddress.Text;
                _member.Membership = comboBoxMembership.Text;

                // Update the member in the database
                string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string updateQuery = "UPDATE NewMember SET Fname = @Fname, Lname = @Lname, Gender = @Gender, Dob = @Dob, Mobile = @Mobile, Email = @Email, JoinDate = @JoinDate, GymTime = @GymTime, Maddress = @Maddress, MembershipTime = @MembershipTime WHERE MID = @MID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Fname", _member.FirstName);
                        cmd.Parameters.AddWithValue("@Lname", _member.LastName);
                        cmd.Parameters.AddWithValue("@Gender", _member.Gender);
                        cmd.Parameters.AddWithValue("@Dob", _member.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Mobile", _member.Mobile);
                        cmd.Parameters.AddWithValue("@Email", _member.Email);
                        cmd.Parameters.AddWithValue("@JoinDate", _member.JoinDate);
                        cmd.Parameters.AddWithValue("@GymTime", _member.GymTime);
                        cmd.Parameters.AddWithValue("@Maddress", _member.Address);
                        cmd.Parameters.AddWithValue("@MembershipTime", _member.Membership);
                        cmd.Parameters.AddWithValue("@MID", _member.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No member found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
