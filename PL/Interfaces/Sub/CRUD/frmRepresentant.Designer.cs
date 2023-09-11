namespace PL.Interfaces.Sub.CRUD
{
    partial class frmRepresentant
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservation = new System.Windows.Forms.RichTextBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservation);
            this.groupBox2.Controls.Add(this.txtGsm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCin);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(440, 100);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(429, 245);
            this.txtObservation.TabIndex = 10;
            this.txtObservation.Text = "";
            this.txtObservation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.txtObservation.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(19, 317);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(368, 28);
            this.txtGsm.TabIndex = 8;
            this.txtGsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.txtGsm.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "GSM";
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(19, 252);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(368, 28);
            this.txtCin.TabIndex = 2;
            this.txtCin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.txtCin.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(19, 176);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(368, 28);
            this.txtPrenom.TabIndex = 1;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.txtPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom\r\n";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(19, 100);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(368, 28);
            this.txtNom.TabIndex = 0;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // frmRepresentant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(912, 553);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Name = "frmRepresentant";
            this.Load += new System.EventHandler(this.frmRepresentant_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtObservation;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
    }
}