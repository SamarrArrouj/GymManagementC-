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
    public partial class DeleteEquipment : Form
    {
        public DeleteEquipment()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

            try
            {
                // Vérifier si l'ID de l'équipement est valide
                if (string.IsNullOrWhiteSpace(txtEditDelete.Text))
                {
                    MessageBox.Show("Veuillez entrer un Equipment ID.");
                    return;
                }

                if (!int.TryParse(txtEditDelete.Text.Trim(), out int equipmentId))
                {
                    MessageBox.Show("Veuillez entrer un ID d'équipement valide.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Vérification si l'équipement existe dans la base de données
                    string checkQuery = "SELECT * FROM Equipment WHERE EID = @EID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@EID", equipmentId);

                        SqlDataAdapter da = new SqlDataAdapter(checkCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Aucun équipement trouvé avec l'ID spécifié.");
                            return;
                        }
                    }

                    // Demande de confirmation avant suppression
                    DialogResult result = MessageBox.Show(
                        "Êtes-vous sûr de vouloir supprimer cet équipement ?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Suppression de l'équipement
                        string deleteQuery = "DELETE FROM Equipment WHERE EID = @EID";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                        {
                            deleteCmd.Parameters.AddWithValue("@EID", equipmentId);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Équipement supprimé avec succès.");
                                LoadEquipment(); // Rafraîchir la liste des équipements
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de la suppression de l'équipement.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void LoadEquipment()
        {
            string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Equipment";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Assurez-vous que les colonnes sont générées automatiquement dans le DataGridView
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void DeleteEquipment_Load(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEditDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditDelete.Text))
            {
                MessageBox.Show("Please enter a valid ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEditDelete.Text, out int equipmentId))
            {
                MessageBox.Show("The entered ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get member details from the database
           EquipmentRepository repository = new EquipmentRepository();
            Equipment equipment = repository.GetEquipmentById(equipmentId);

            if (equipment == null)
            {
                MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            EditEquipment editForm = new EditEquipment(equipment);
            editForm.ShowDialog();
        }

        private void txtEditDelete_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
