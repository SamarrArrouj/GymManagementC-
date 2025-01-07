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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = new Staff
                {
                    FirstName = txtFname.Text,
                    LastName = txtLname.Text,
                    Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text,
                    DateOfBirth = dateTimePickerDOB.Value,
                    Mobile = long.Parse(txtMobile.Text),
                    Email = txtEmail.Text,
                    JoinDate = dateTimePickerJOINDate.Value,
                    Statee = txtState.Text,
                    City = txtCity.Text
                };

                StaffRepository repository = new StaffRepository();
                repository.AddStaff(staff);

                MessageBox.Show("Données enregistrées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            txtState.Clear();
            txtCity.Clear();


            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;
        }
    }
    }


