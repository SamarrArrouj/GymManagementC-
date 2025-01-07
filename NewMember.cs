using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystemC_
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Créer un objet Member à partir des données du formulaire
                Member member = new Member
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text,
                    DateOfBirth = dateTimePickerDOB.Value,
                    Mobile = long.Parse(txtMobile.Text),
                    Email = txtEmail.Text,
                    JoinDate = dateTimePickerJoinDate.Value,
                    GymTime = comboBoxGymTime.Text,
                    Address = txtAddress.Text,
                    Membership = comboBoxMembership.Text
                };

                // Ajouter le membre en utilisant la couche Repository
                MemberRepository repository = new MemberRepository();
                repository.AddMember(member);

                MessageBox.Show("Données enregistrées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}
