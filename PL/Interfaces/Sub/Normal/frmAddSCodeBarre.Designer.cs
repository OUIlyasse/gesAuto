namespace PL.Interfaces.Sub.Normal
{
    partial class frmAddSCodeBarre
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
            this.lblAbrevAnnee = new System.Windows.Forms.Label();
            this.lblAbreviation = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbxAnnee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAbrevAnnee);
            this.groupBox1.Controls.Add(this.lblAbreviation);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(48, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 114);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numéro de série";
            // 
            // lblAbrevAnnee
            // 
            this.lblAbrevAnnee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbrevAnnee.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrevAnnee.Location = new System.Drawing.Point(332, 59);
            this.lblAbrevAnnee.Name = "lblAbrevAnnee";
            this.lblAbrevAnnee.Size = new System.Drawing.Size(68, 27);
            this.lblAbrevAnnee.TabIndex = 39;
            this.lblAbrevAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbreviation
            // 
            this.lblAbreviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbreviation.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbreviation.Location = new System.Drawing.Point(157, 59);
            this.lblAbreviation.Name = "lblAbreviation";
            this.lblAbreviation.Size = new System.Drawing.Size(33, 27);
            this.lblAbreviation.TabIndex = 38;
            this.lblAbreviation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(196, 60);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.txtNumero.Size = new System.Drawing.Size(130, 26);
            this.txtNumero.TabIndex = 37;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Image = global::PL.Properties.Resources.Ajouter_32;
            this.btnAjouter.Location = new System.Drawing.Point(498, 313);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 48);
            this.btnAjouter.TabIndex = 38;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbxAnnee);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblReference);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblArticle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(48, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 143);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // cmbxAnnee
            // 
            this.cmbxAnnee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxAnnee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxAnnee.DisplayMember = "art_Designation";
            this.cmbxAnnee.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAnnee.FormattingEnabled = true;
            this.cmbxAnnee.Location = new System.Drawing.Point(437, 82);
            this.cmbxAnnee.Name = "cmbxAnnee";
            this.cmbxAnnee.Size = new System.Drawing.Size(102, 27);
            this.cmbxAnnee.TabIndex = 61;
            this.cmbxAnnee.ValueMember = "art_ID";
            this.cmbxAnnee.SelectedIndexChanged += new System.EventHandler(this.cmbxAnnee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Année";
            // 
            // lblReference
            // 
            this.lblReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReference.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(111, 82);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(248, 27);
            this.lblReference.TabIndex = 59;
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "Référence";
            // 
            // lblArticle
            // 
            this.lblArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.Location = new System.Drawing.Point(111, 38);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(248, 27);
            this.lblArticle.TabIndex = 57;
            this.lblArticle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Article";
            // 
            // frmAddCodeBarre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCodeBarre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un numéro de série";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblAbrevAnnee;
        public System.Windows.Forms.Label lblAbreviation;
        public System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbxAnnee;
    }
}