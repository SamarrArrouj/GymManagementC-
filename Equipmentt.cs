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
    public partial class Equipmentt : Form
    {
        public Equipmentt()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                string EquipName = txtEquipName.Text;
                string Description = txtDescription.Text;
                string MUsed = txtMusclesUsed.Text;
                string DDate = dateTimePickerDeliveryDate.Value.ToString("yyyy-MM-dd");
                Int64 cost = Int64.Parse(txtCost.Text);

                // Database connection
                using (SqlConnection con = new SqlConnection("data source=DELL\\SQLEXPRESS;database=gym;integrated security=True; TrustServerCertificate=True;"))
                {
                    con.Open();

                    // SQL command with parameterized query
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Equipment (EquipName, EDescription, MUsed, DDate, Cost) VALUES (@EquipName, @EDescription, @MUsed, @DDate, @Cost)", con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@EquipName", EquipName);
                        cmd.Parameters.AddWithValue("@EDescription", Description);
                        cmd.Parameters.AddWithValue("@MUsed", MUsed);
                        cmd.Parameters.AddWithValue("@DDate", DDate);
                        cmd.Parameters.AddWithValue("@Cost", cost);

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            ViewEquipment vq = new ViewEquipment();
            vq.Show();
        }
    }
}
