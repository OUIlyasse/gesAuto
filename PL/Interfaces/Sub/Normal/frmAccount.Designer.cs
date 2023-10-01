namespace PL.Interfaces.Sub.Normal
{
    partial class frmAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVisible1 = new System.Windows.Forms.Button();
            this.btnVisible2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(94, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(227, 28);
            this.txtNom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(589, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(503, 30);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(227, 28);
            this.txtPrenom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(94, 95);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(227, 28);
            this.txtGrade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(503, 95);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(227, 28);
            this.txtService.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Service";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(157, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(573, 28);
            this.txtUsername.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Identifiant";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(527, 28);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mot de passe";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(157, 290);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(527, 28);
            this.txtConfirm.TabIndex = 14;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirm_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirmer";
            // 
            // btnVisible1
            // 
            this.btnVisible1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisible1.FlatAppearance.BorderSize = 0;
            this.btnVisible1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisible1.Image = global::PL.Properties.Resources.Visible_32;
            this.btnVisible1.Location = new System.Drawing.Point(690, 219);
            this.btnVisible1.Name = "btnVisible1";
            this.btnVisible1.Size = new System.Drawing.Size(40, 40);
            this.btnVisible1.TabIndex = 15;
            this.btnVisible1.UseVisualStyleBackColor = true;
            this.btnVisible1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVisible1_MouseDown);
            this.btnVisible1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVisible1_MouseUp);
            // 
            // btnVisible2
            // 
            this.btnVisible2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisible2.FlatAppearance.BorderSize = 0;
            this.btnVisible2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisible2.Image = global::PL.Properties.Resources.Visible_32;
            this.btnVisible2.Location = new System.Drawing.Point(690, 284);
            this.btnVisible2.Name = "btnVisible2";
            this.btnVisible2.Size = new System.Drawing.Size(40, 40);
            this.btnVisible2.TabIndex = 16;
            this.btnVisible2.UseVisualStyleBackColor = true;
            this.btnVisible2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVisible2_MouseDown);
            this.btnVisible2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVisible2_MouseUp);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnVisible2);
            this.Controls.Add(this.btnVisible1);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVisible1;
        private System.Windows.Forms.Button btnVisible2;
    }
}