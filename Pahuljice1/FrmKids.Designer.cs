namespace Pahuljice1
{
    partial class FrmKids
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
            this.DGVKids = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKids)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVKids
            // 
            this.DGVKids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKids.Location = new System.Drawing.Point(12, 12);
            this.DGVKids.Name = "DGVKids";
            this.DGVKids.Size = new System.Drawing.Size(776, 346);
            this.DGVKids.TabIndex = 0;
            this.DGVKids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKids_CellContentClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAdd.Location = new System.Drawing.Point(584, 387);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 47);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(485, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Ukloni";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSaveChanges.Location = new System.Drawing.Point(683, 388);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 46);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Spremi promjene";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEmployees.Location = new System.Drawing.Point(12, 387);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(105, 46);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Ispis zaposlenih";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // FrmKids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Pahuljice1.Properties.Resources.Pislika2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DGVKids);
            this.Name = "FrmKids";
            this.Text = "FrmKids";
            this.Load += new System.EventHandler(this.FrmKids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKids)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVKids;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEmployees;
    }
}