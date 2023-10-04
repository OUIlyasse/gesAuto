namespace PL.Interfaces.Sub.Normal
{
    partial class frmCodeBarreSAvancee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxAnnee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.lblQteArt = new System.Windows.Forms.Label();
            this.lblAbreviation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bc_ID
            // 
            this.bc_ID.DataPropertyName = "bc_ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.bc_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.bc_ID.HeaderText = "Code BonCodeBarre";
            this.bc_ID.Name = "bc_ID";
            this.bc_ID.ReadOnly = true;
            this.bc_ID.Visible = false;
            // 
            // txtReference
            // 
            this.txtReference.DataPropertyName = "ref_ID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtReference.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtReference.HeaderText = "Reference";
            this.txtReference.Name = "txtReference";
            this.txtReference.ReadOnly = true;
            this.txtReference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtReference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtReference.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSerie);
            this.groupBox2.Controls.Add(this.txtQte);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbxAnnee);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 138);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // lblSerie
            // 
            this.lblSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSerie.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(291, 32);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(132, 27);
            this.lblSerie.TabIndex = 58;
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQte
            // 
            this.txtQte.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtQte.Location = new System.Drawing.Point(476, 32);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(82, 28);
            this.txtQte.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Qte";
            // 
            // cmbxAnnee
            // 
            this.cmbxAnnee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxAnnee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxAnnee.DisplayMember = "fam_Nom";
            this.cmbxAnnee.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAnnee.FormattingEnabled = true;
            this.cmbxAnnee.Location = new System.Drawing.Point(108, 32);
            this.cmbxAnnee.Name = "cmbxAnnee";
            this.cmbxAnnee.Size = new System.Drawing.Size(177, 28);
            this.cmbxAnnee.TabIndex = 43;
            this.cmbxAnnee.ValueMember = "fam_ID";
            this.cmbxAnnee.SelectedIndexChanged += new System.EventHandler(this.cmbxAnnee_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Année";
            // 
            // txtDu
            // 
            this.txtDu.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtDu.Location = new System.Drawing.Point(103, 82);
            this.txtDu.Name = "txtDu";
            this.txtDu.Size = new System.Drawing.Size(93, 28);
            this.txtDu.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "DU";
            // 
            // txtAu
            // 
            this.txtAu.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtAu.Location = new System.Drawing.Point(310, 82);
            this.txtAu.Name = "txtAu";
            this.txtAu.Size = new System.Drawing.Size(93, 28);
            this.txtAu.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "AU";
            // 
            // lblReference
            // 
            this.lblReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReference.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(138, 75);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(332, 27);
            this.lblReference.TabIndex = 55;
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Référence";
            // 
            // lblArticle
            // 
            this.lblArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.Location = new System.Drawing.Point(138, 27);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(332, 27);
            this.lblArticle.TabIndex = 50;
            this.lblArticle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Article";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAppliquer.AutoSize = true;
            this.btnAppliquer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppliquer.Image = global::PL.Properties.Resources.Coche_32;
            this.btnAppliquer.Location = new System.Drawing.Point(528, 293);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(142, 48);
            this.btnAppliquer.TabIndex = 57;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // lblQteArt
            // 
            this.lblQteArt.AutoSize = true;
            this.lblQteArt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQteArt.Location = new System.Drawing.Point(564, 31);
            this.lblQteArt.Name = "lblQteArt";
            this.lblQteArt.Size = new System.Drawing.Size(29, 20);
            this.lblQteArt.TabIndex = 49;
            this.lblQteArt.Text = "00";
            this.lblQteArt.Visible = false;
            // 
            // lblAbreviation
            // 
            this.lblAbreviation.AutoSize = true;
            this.lblAbreviation.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbreviation.Location = new System.Drawing.Point(485, 31);
            this.lblAbreviation.Name = "lblAbreviation";
            this.lblAbreviation.Size = new System.Drawing.Size(30, 20);
            this.lblAbreviation.TabIndex = 53;
            this.lblAbreviation.Text = "---";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 58;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCodeBarreSAvancee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAbreviation);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.lblQteArt);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCodeBarreSAvancee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier le code barre";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn bc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReference;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxAnnee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblQteArt;
        private System.Windows.Forms.Label lblAbreviation;
        public System.Windows.Forms.TextBox txtDu;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtAu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}