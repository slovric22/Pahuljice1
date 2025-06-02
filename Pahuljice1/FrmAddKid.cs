using Pahuljice1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahuljice1
{
    public partial class FrmAddKid : Form
    {
        public FrmAddKid()
        {
            InitializeComponent();
        }

        private void FrmAddKid_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("Molimo unesite barem ime i datum rođenja.");
                return;
            }

            Kid kid = new Kid
            {
                
                Name = txtName.Text,
                Date = txtDate.Text,
                Parent = txtParent.Text,
                Contact = txtContact.Text,
                Allergy = txtAllergy.Text,
                Setback = txtSetback.Text,
                Group = txtGroup.Text,
                Employee = txtEmployee.Text
            };

            KidRepository.AddKid(kid);

            MessageBox.Show("Dijete je uspješno dodano!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

