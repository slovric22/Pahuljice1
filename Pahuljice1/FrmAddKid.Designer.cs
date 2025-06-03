namespace Pahuljice1
{
    partial class FrmAddKid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAllergy = new System.Windows.Forms.TextBox();
            this.lblAllergy = new System.Windows.Forms.Label();
            this.txtSetback = new System.Windows.Forms.TextBox();
            this.lblSetback = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(59, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ime i prezime:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(136, 119);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(271, 20);
            this.txtDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(59, 119);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Datum rođenja:";
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(135, 158);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(271, 20);
            this.txtParent.TabIndex = 4;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParent.Location = new System.Drawing.Point(59, 161);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(47, 13);
            this.lblParent.TabIndex = 5;
            this.lblParent.Text = "Roditelji:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(136, 202);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(270, 20);
            this.txtContact.TabIndex = 6;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContact.Location = new System.Drawing.Point(59, 205);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(47, 13);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Kontakt:";
            // 
            // txtAllergy
            // 
            this.txtAllergy.Location = new System.Drawing.Point(134, 252);
            this.txtAllergy.Name = "txtAllergy";
            this.txtAllergy.Size = new System.Drawing.Size(272, 20);
            this.txtAllergy.TabIndex = 8;
            // 
            // lblAllergy
            // 
            this.lblAllergy.AutoSize = true;
            this.lblAllergy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAllergy.Location = new System.Drawing.Point(59, 255);
            this.lblAllergy.Name = "lblAllergy";
            this.lblAllergy.Size = new System.Drawing.Size(44, 13);
            this.lblAllergy.TabIndex = 9;
            this.lblAllergy.Text = "Alergije:";
            // 
            // txtSetback
            // 
            this.txtSetback.Location = new System.Drawing.Point(134, 302);
            this.txtSetback.Name = "txtSetback";
            this.txtSetback.Size = new System.Drawing.Size(273, 20);
            this.txtSetback.TabIndex = 10;
            // 
            // lblSetback
            // 
            this.lblSetback.AutoSize = true;
            this.lblSetback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSetback.Location = new System.Drawing.Point(59, 305);
            this.lblSetback.Name = "lblSetback";
            this.lblSetback.Size = new System.Drawing.Size(61, 13);
            this.lblSetback.TabIndex = 11;
            this.lblSetback.Text = "Poteškoće:";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(134, 353);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(272, 20);
            this.txtGroup.TabIndex = 12;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGroup.Location = new System.Drawing.Point(59, 354);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(49, 13);
            this.lblGroup.TabIndex = 13;
            this.lblGroup.Text = "Skupina:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(134, 403);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(271, 20);
            this.txtEmployee.TabIndex = 14;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployee.Location = new System.Drawing.Point(58, 407);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(62, 13);
            this.lblEmployee.TabIndex = 15;
            this.lblEmployee.Text = "Zaposlenik:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Location = new System.Drawing.Point(162, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 50);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(270, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(60, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "OIB:";
            // 
            // FrmAddKid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pahuljice1.Properties.Resources.Pi4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 506);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.lblSetback);
            this.Controls.Add(this.txtSetback);
            this.Controls.Add(this.lblAllergy);
            this.Controls.Add(this.txtAllergy);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddKid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddKid";
            this.Load += new System.EventHandler(this.FrmAddKid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAllergy;
        private System.Windows.Forms.Label lblAllergy;
        private System.Windows.Forms.TextBox txtSetback;
        private System.Windows.Forms.Label lblSetback;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}