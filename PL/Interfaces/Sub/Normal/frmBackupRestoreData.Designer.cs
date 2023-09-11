namespace PL.Interfaces.Sub.Normal
{
    partial class frmBackupRestoreData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSEmplacement = new System.Windows.Forms.TextBox();
            this.btnSBrowse = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRBrowse = new System.Windows.Forms.Button();
            this.txtREmplacement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSBrowse);
            this.groupBox1.Controls.Add(this.txtSEmplacement);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sauvegarde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emplacement";
            // 
            // txtSEmplacement
            // 
            this.txtSEmplacement.Location = new System.Drawing.Point(21, 62);
            this.txtSEmplacement.Name = "txtSEmplacement";
            this.txtSEmplacement.Size = new System.Drawing.Size(634, 28);
            this.txtSEmplacement.TabIndex = 1;
            // 
            // btnSBrowse
            // 
            this.btnSBrowse.Location = new System.Drawing.Point(661, 65);
            this.btnSBrowse.Name = "btnSBrowse";
            this.btnSBrowse.Size = new System.Drawing.Size(34, 23);
            this.btnSBrowse.TabIndex = 2;
            this.btnSBrowse.Text = "...";
            this.btnSBrowse.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(570, 396);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(200, 45);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restaurer";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRBrowse);
            this.groupBox2.Controls.Add(this.txtREmplacement);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restauration";
            // 
            // btnRBrowse
            // 
            this.btnRBrowse.Location = new System.Drawing.Point(661, 65);
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.Size = new System.Drawing.Size(34, 23);
            this.btnRBrowse.TabIndex = 2;
            this.btnRBrowse.Text = "...";
            this.btnRBrowse.UseVisualStyleBackColor = true;
            // 
            // txtREmplacement
            // 
            this.txtREmplacement.Location = new System.Drawing.Point(21, 62);
            this.txtREmplacement.Name = "txtREmplacement";
            this.txtREmplacement.Size = new System.Drawing.Size(634, 28);
            this.txtREmplacement.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emplacement";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(341, 396);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 45);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Sauvegarder";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // frmBackupRestoreData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupRestoreData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarde/Restauration donnée";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSBrowse;
        private System.Windows.Forms.TextBox txtSEmplacement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRBrowse;
        private System.Windows.Forms.TextBox txtREmplacement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackup;
    }
}