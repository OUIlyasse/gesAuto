namespace PL.Interfaces.Sub.Normal
{
    partial class frmAbreviation
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.lbArticles = new System.Windows.Forms.ListBox();
            this.lblAbreviation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRetour.Location = new System.Drawing.Point(305, 426);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(92, 38);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // lbArticles
            // 
            this.lbArticles.FormattingEnabled = true;
            this.lbArticles.ItemHeight = 20;
            this.lbArticles.Location = new System.Drawing.Point(12, 72);
            this.lbArticles.Name = "lbArticles";
            this.lbArticles.Size = new System.Drawing.Size(385, 324);
            this.lbArticles.TabIndex = 5;
            // 
            // lblAbreviation
            // 
            this.lblAbreviation.BackColor = System.Drawing.SystemColors.Info;
            this.lblAbreviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbreviation.Location = new System.Drawing.Point(12, 10);
            this.lblAbreviation.Name = "lblAbreviation";
            this.lblAbreviation.Size = new System.Drawing.Size(385, 45);
            this.lblAbreviation.TabIndex = 4;
            this.lblAbreviation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAbreviation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btnRetour;
            this.ClientSize = new System.Drawing.Size(409, 475);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lbArticles);
            this.Controls.Add(this.lblAbreviation);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbreviation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "frmAbreviation";
            this.Text = "Abreviation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox lbArticles;
        private System.Windows.Forms.Label lblAbreviation;
    }
}