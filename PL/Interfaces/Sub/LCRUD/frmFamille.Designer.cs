namespace PL.Interfaces.Sub.LCRUD
{
    partial class frmFamille
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new PL.Controls.iText();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvFamille = new System.Windows.Forms.DataGridView();
            this.colfam_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfam_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfam_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamille)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.FlatAppearance.BorderSize = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtRecherche);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.dgvFamille);
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 479);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Affichage";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Location = new System.Drawing.Point(194, 28);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(308, 27);
            this.txtRecherche.TabIndex = 8;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(6, 31);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "---";
            // 
            // dgvFamille
            // 
            this.dgvFamille.AllowUserToAddRows = false;
            this.dgvFamille.AllowUserToDeleteRows = false;
            this.dgvFamille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFamille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamille.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFamille.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFamille.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colfam_ID,
            this.colfam_Nom,
            this.colfam_Description});
            this.dgvFamille.ContextMenuStrip = this.menuDGV;
            this.dgvFamille.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFamille.Location = new System.Drawing.Point(6, 61);
            this.dgvFamille.MultiSelect = false;
            this.dgvFamille.Name = "dgvFamille";
            this.dgvFamille.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamille.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFamille.RowHeadersVisible = false;
            this.dgvFamille.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFamille.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFamille.RowTemplate.Height = 24;
            this.dgvFamille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamille.Size = new System.Drawing.Size(496, 412);
            this.dgvFamille.TabIndex = 1;
            this.dgvFamille.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvFamille_CellContextMenuStripNeeded);
            this.dgvFamille.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamille_CellDoubleClick);
            // 
            // colfam_ID
            // 
            this.colfam_ID.DataPropertyName = "fam_ID";
            this.colfam_ID.HeaderText = "Code famille";
            this.colfam_ID.MinimumWidth = 6;
            this.colfam_ID.Name = "colfam_ID";
            this.colfam_ID.ReadOnly = true;
            this.colfam_ID.Visible = false;
            // 
            // colfam_Nom
            // 
            this.colfam_Nom.DataPropertyName = "fam_Nom";
            this.colfam_Nom.HeaderText = "Famille";
            this.colfam_Nom.MinimumWidth = 6;
            this.colfam_Nom.Name = "colfam_Nom";
            this.colfam_Nom.ReadOnly = true;
            // 
            // colfam_Description
            // 
            this.colfam_Description.DataPropertyName = "fam_Description";
            this.colfam_Description.HeaderText = "Description";
            this.colfam_Description.MinimumWidth = 6;
            this.colfam_Description.Name = "colfam_Description";
            this.colfam_Description.ReadOnly = true;
            this.colfam_Description.Visible = false;
            // 
            // menuDGV
            // 
            this.menuDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnColonne});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(134, 28);
            // 
            // btnColonne
            // 
            this.btnColonne.Name = "btnColonne";
            this.btnColonne.Size = new System.Drawing.Size(133, 24);
            this.btnColonne.Text = "Colonne";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAnnee);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 373);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::PL.Properties.Resources.New_file_28px;
            this.btnNew.Location = new System.Drawing.Point(416, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 28);
            this.btnNew.TabIndex = 12;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.Location = new System.Drawing.Point(17, 156);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(420, 178);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Famille";
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(17, 76);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(420, 27);
            this.txtAnnee.TabIndex = 0;
            this.txtAnnee.Validating += new System.ComponentModel.CancelEventHandler(this.txtFamille_Validating);
            // 
            // frmFamille
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1018, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFamille";
            this.Text = "Famille";
            this.Load += new System.EventHandler(this.frmFamille_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamille)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvFamille;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfam_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfam_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfam_Description;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtAnnee;
        private Controls.iText txtRecherche;
    }
}