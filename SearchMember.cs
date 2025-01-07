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
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Veuillez entrer un MemberID.");
                    return;
                }

                // Vérifiez si l'entrée est bien un entier, ou une autre valeur appropriée
                int memberId;
                if (int.TryParse(txtSearch.Text.Trim(), out memberId))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM NewMember WHERE MID = @MID";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MID", memberId);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Vérifier si des résultats ont été trouvés
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Aucun membre trouvé avec l'ID spécifié.");
                            }
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un ID membre valide.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            string connectionString = "data source=DELL\\SQLEXPRESS;database=gym;integrated security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM NewMember";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
