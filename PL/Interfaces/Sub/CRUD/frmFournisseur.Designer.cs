namespace PL.Interfaces.Sub.CRUD
{
    partial class frmFournisseur
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
            this.components = new System.ComponentModel.Container();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbxVille = new System.Windows.Forms.ComboBox();
            this.txtFixe = new System.Windows.Forms.TextBox();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFixe2 = new System.Windows.Forms.TextBox();
            this.txtGSM2 = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtAdresse2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.errorValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(441, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(417, 139);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fournisseur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adresse secondaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "GSM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "GSM secondaire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fixe secondaire";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fixe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ville";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 423);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbxVille);
            this.tabPage1.Controls.Add(this.txtFixe);
            this.tabPage1.Controls.Add(this.txtGSM);
            this.tabPage1.Controls.Add(this.txtAdresse);
            this.tabPage1.Controls.Add(this.txtFournisseur);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbxVille
            // 
            this.cmbxVille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxVille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxVille.FormattingEnabled = true;
            this.cmbxVille.Location = new System.Drawing.Point(20, 162);
            this.cmbxVille.Name = "cmbxVille";
            this.cmbxVille.Size = new System.Drawing.Size(375, 28);
            this.cmbxVille.TabIndex = 17;
            // 
            // txtFixe
            // 
            this.txtFixe.Location = new System.Drawing.Point(20, 292);
            this.txtFixe.Name = "txtFixe";
            this.txtFixe.Size = new System.Drawing.Size(375, 28);
            this.txtFixe.TabIndex = 16;
            this.txtFixe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixe_KeyPress);
            this.txtFixe.Validating += new System.ComponentModel.CancelEventHandler(this.txtFixe_Validating);
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(20, 227);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(375, 28);
            this.txtGSM.TabIndex = 15;
            this.txtGSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGSM_KeyPress);
            this.txtGSM.Validating += new System.ComponentModel.CancelEventHandler(this.txtGSM_Validating);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(443, 97);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdresse.Size = new System.Drawing.Size(417, 223);
            this.txtAdresse.TabIndex = 14;
            this.txtAdresse.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresse_Validating);
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Location = new System.Drawing.Point(20, 97);
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(375, 28);
            this.txtFournisseur.TabIndex = 13;
            this.txtFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.txtFournisseur_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFixe2);
            this.tabPage2.Controls.Add(this.txtGSM2);
            this.tabPage2.Controls.Add(this.txtCodePostal);
            this.tabPage2.Controls.Add(this.txtAdresse2);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Divers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFixe2
            // 
            this.txtFixe2.Location = new System.Drawing.Point(22, 344);
            this.txtFixe2.Name = "txtFixe2";
            this.txtFixe2.Size = new System.Drawing.Size(375, 28);
            this.txtFixe2.TabIndex = 15;
            this.txtFixe2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixe2_KeyPress);
            this.txtFixe2.Validating += new System.ComponentModel.CancelEventHandler(this.txtFixe2_Validating);
            // 
            // txtGSM2
            // 
            this.txtGSM2.Location = new System.Drawing.Point(22, 244);
            this.txtGSM2.Name = "txtGSM2";
            this.txtGSM2.Size = new System.Drawing.Size(375, 28);
            this.txtGSM2.TabIndex = 14;
            this.txtGSM2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGSM2_KeyPress);
            this.txtGSM2.Validating += new System.ComponentModel.CancelEventHandler(this.txtGSM2_Validating);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(22, 144);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(375, 28);
            this.txtCodePostal.TabIndex = 13;
            this.txtCodePostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePostal_KeyPress);
            this.txtCodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodePostal_Validating);
            // 
            // txtAdresse2
            // 
            this.txtAdresse2.Location = new System.Drawing.Point(441, 44);
            this.txtAdresse2.Multiline = true;
            this.txtAdresse2.Name = "txtAdresse2";
            this.txtAdresse2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdresse2.Size = new System.Drawing.Size(417, 139);
            this.txtAdresse2.TabIndex = 12;
            this.txtAdresse2.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresse2_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 28);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // errorValidate
            // 
            this.errorValidate.ContainerControl = this;
            // 
            // frmFournisseur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(912, 553);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Name = "frmFournisseur";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAdresse2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtFixe2;
        private System.Windows.Forms.TextBox txtGSM2;
        private System.Windows.Forms.TextBox txtFixe;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtFournisseur;
        private System.Windows.Forms.ComboBox cmbxVille;
        private System.Windows.Forms.ErrorProvider errorValidate;
    }
}