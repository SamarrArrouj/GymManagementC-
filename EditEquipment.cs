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
    public partial class EditEquipment : Form
    {
        private Equipment _equipment;

        public EditEquipment(Equipment equipment)
        {
            InitializeComponent();
            _equipment = equipment ?? throw new ArgumentNullException(nameof(equipment));

            // Remplir les champs avec les données de l'équipement
            txtEquipName.Text = _equipment.EquipName;
            txtDescription.Text = _equipment.EquipDescrip;
            txtMusclesUsed.Text = _equipment.MusclesUsed;
            dateTimePickerDeliveryDate.Value = _equipment.DDate;
            txtCost.Text = _equipment.Cost.ToString();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtEquipName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please enter valid equipment name and description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtCost.Text, out decimal cost))
                {
                    MessageBox.Show("Please enter a valid cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the updated Equipment object
                _equipment.EquipName = txtEquipName.Text;
                _equipment.EquipDescrip = txtDescription.Text;
                _equipment.MusclesUsed = txtMusclesUsed.Text;
                _equipment.DDate = dateTimePickerDeliveryDate.Value; // Assuming you have a DateTimePicker for DDate
                _equipment.Cost = cost; // Ensure it's a valid decimal

                // Update the equipment in the database
                string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string updateQuery = "UPDATE Equipment SET EquipName = @EquipName, EDescription = @EDescription, MUsed = @MUsed, DDate = @DDate, Cost = @Cost WHERE EID = @EID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@EquipName", _equipment.EquipName);
                        cmd.Parameters.AddWithValue("@EDescription", _equipment.EquipDescrip);
                        cmd.Parameters.AddWithValue("@MUsed", _equipment.MusclesUsed);
                        cmd.Parameters.AddWithValue("@DDate", _equipment.DDate); // Ensure it's a valid DateTime
                        cmd.Parameters.AddWithValue("@Cost", _equipment.Cost); // Ensure it's a valid decimal
                        cmd.Parameters.AddWithValue("@EID", _equipment.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No equipment found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
