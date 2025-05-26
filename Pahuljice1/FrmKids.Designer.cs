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
            ((System.ComponentModel.ISupportInitialize)(this.DGVKids)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVKids
            // 
            this.DGVKids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKids.Location = new System.Drawing.Point(20, 26);
            this.DGVKids.Name = "DGVKids";
            this.DGVKids.Size = new System.Drawing.Size(740, 401);
            this.DGVKids.TabIndex = 0;
            this.DGVKids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKids_CellContentClick);
            // 
            // FrmKids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVKids);
            this.Name = "FrmKids";
            this.Text = "FrmKids";
            this.Load += new System.EventHandler(this.FrmKids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKids)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVKids;
    }
}