using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GymManagementSystemC_
{
    public partial class EditStaff : Form
    {


        private Staff _staff;

        public EditStaff(Staff staff)
        {
            InitializeComponent();
            _staff = staff ?? throw new ArgumentNullException(nameof(staff));

            // Remplir les champs avec les données du staff
            txtFname.Text = _staff.FirstName;
            txtLname.Text = _staff.LastName;
            radioButton1.Checked = _staff.Gender == "Male"; // Supposant "Male" ou "Female"
            radioButton2.Checked = _staff.Gender == "Female";
            dateTimePickerDOB.Value = _staff.DateOfBirth;
            txtMobile.Text = _staff.Mobile.ToString();
            txtEmail.Text = _staff.Email;
            dateTimePickerJOINDate.Value = _staff.JoinDate;
            txtState.Text = _staff.Statee; // Assurez-vous que l'attribut "State" existe dans `Staff`
            txtCity.Text = _staff.City;  // Assurez-vous que l'attribut "City" existe dans `Staff`
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text))
                {
                    MessageBox.Show("Please enter valid first and last names.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the updated Staff object
                _staff.FirstName = txtFname.Text;
                _staff.LastName = txtLname.Text;
                _staff.Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                _staff.DateOfBirth = dateTimePickerDOB.Value;
                _staff.Mobile = long.Parse(txtMobile.Text);
                _staff.Email = txtEmail.Text;
                _staff.JoinDate = dateTimePickerJOINDate.Value;
                _staff.Statee = txtState.Text; // Assuming you have a field for State
                _staff.City = txtCity.Text;   // Assuming you have a field for City

                // Update the staff in the database
                string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string updateQuery = "UPDATE NewStaff SET Fname = @Fname, Lname = @Lname, Gender = @Gender, Dob = @Dob, Mobile = @Mobile, Email = @Email, JoinDate = @JoinDate, Statee = @Statee, City = @City WHERE SID = @SID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Fname", _staff.FirstName);
                        cmd.Parameters.AddWithValue("@Lname", _staff.LastName);
                        cmd.Parameters.AddWithValue("@Gender", _staff.Gender);
                        cmd.Parameters.AddWithValue("@Dob", _staff.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Mobile", _staff.Mobile);
                        cmd.Parameters.AddWithValue("@Email", _staff.Email);
                        cmd.Parameters.AddWithValue("@JoinDate", _staff.JoinDate);
                        cmd.Parameters.AddWithValue("@Statee", _staff.Statee);
                        cmd.Parameters.AddWithValue("@City", _staff.City);
                        cmd.Parameters.AddWithValue("@SID", _staff.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No staff found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
