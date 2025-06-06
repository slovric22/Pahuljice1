﻿using Pahuljice1.Repositories;
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
    public partial class FrmKids : Form
    {
        public FrmKids()
        {
            InitializeComponent();
        }
        private void FrmKids_Load(object sender, EventArgs e)
        {
            ShowKids();
        }

        private void ShowKids()
        {
            List<Kid> kids = KidRepository.GetKids();
            DGVKids.DataSource = kids;
            DGVKids.Columns["Id"].DisplayIndex = 0;
            DGVKids.Columns["Name"].DisplayIndex = 1;
            DGVKids.Columns["Date"].DisplayIndex = 2;
            DGVKids.Columns["Parent"].DisplayIndex = 3;
            DGVKids.Columns["Contact"].DisplayIndex = 4;
            DGVKids.Columns["Allergy"].DisplayIndex = 5;
            DGVKids.Columns["Setback"].DisplayIndex = 6;
            DGVKids.Columns["Group"].DisplayIndex = 7;
            DGVKids.Columns["Employee"].DisplayIndex = 8;
            DGVKids.Columns["FirstName"].Visible = false;
            DGVKids.Columns["LastName"].Visible = false;
            DGVKids.Columns["FirstName"].Visible = false;

            DGVKids.Columns["Id"].HeaderText = "OIB";
            DGVKids.Columns["Name"].HeaderText = "Ime i prezime";
            DGVKids.Columns["Date"].HeaderText = "Datum rođenja";
            DGVKids.Columns["Parent"].HeaderText = "Roditelj(i)";
            DGVKids.Columns["Contact"].HeaderText = "Kontakt";
            DGVKids.Columns["Allergy"].HeaderText = "Alergije";
            DGVKids.Columns["Setback"].HeaderText = "Poteškoće";
            DGVKids.Columns["Group"].HeaderText = "Skupina";
            DGVKids.Columns["Employee"].HeaderText = "Zaposlenik";

        }

        private void DGVKids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddKid form = new FrmAddKid();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ShowKids(); 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
       
        {
          
            if (DGVKids.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite dijete za brisanje.");
                return;
            }

            var selectedRow = DGVKids.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
            {
                MessageBox.Show("Ne može se dohvatiti Id odabranog djeteta.");
                return;
            }

            var confirmResult = MessageBox.Show("Jeste li sigurni da želite obrisati odabrano dijete?",
                                                "Potvrda brisanja",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    KidRepository.DeleteKidById(id);

                    MessageBox.Show("Dijete je uspješno obrisano.");

                  
                    ShowKids();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja: " + ex.Message);
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVKids.Rows)
            {
                if (row.IsNewRow) continue;

                Kid kid = new Kid
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Name = row.Cells["Name"].Value?.ToString(),
                    Date = row.Cells["Date"].Value?.ToString(),
                    Parent = row.Cells["Parent"].Value?.ToString(),
                    Contact = row.Cells["Contact"].Value?.ToString(),
                    Allergy = row.Cells["Allergy"].Value?.ToString(),
                    Setback = row.Cells["Setback"].Value?.ToString(),
                    Group = row.Cells["Group"].Value?.ToString(),
                    Employee = row.Cells["Employee"].Value?.ToString()
                };

                KidRepository.UpdateKid(kid);
            }

            MessageBox.Show("Sve promjene su spremljene.");
            ShowKids(); 
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ShowEmployeesAndKids();
        }
        private void ShowEmployeesAndKids()
        {
            var grouped = KidRepository.GetKidsGroupedByEmployee();
            string output = "";

            foreach (var employee in grouped.Keys)
            {
                output += "Zaposlenik: " + employee + Environment.NewLine;

                foreach (var kid in grouped[employee])
                {
                    output += " - Dijete: " + kid.Name + ", datum rođenja: " + kid.Date + Environment.NewLine;
                }

                output += Environment.NewLine;
            }

            MessageBox.Show(output, "Popis zaposlenika i djece");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}




