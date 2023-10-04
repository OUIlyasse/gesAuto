namespace PL.Interfaces.Sub.LCRUD
{
    partial class frmUniteSoutien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new PL.Controls.iText();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvUniteSoutien = new System.Windows.Forms.DataGridView();
            this.colunt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_Unite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvil_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxVille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnite = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.menuDGV.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniteSoutien)).BeginInit();
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtRecherche);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.dgvUniteSoutien);
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
            this.txtRecherche.ForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.Location = new System.Drawing.Point(194, 28);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderText = "Recherche";
            this.txtRecherche.Size = new System.Drawing.Size(308, 27);
            this.txtRecherche.TabIndex = 9;
            this.txtRecherche.Text = "Recherche";
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
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
            // dgvUniteSoutien
            // 
            this.dgvUniteSoutien.AllowUserToAddRows = false;
            this.dgvUniteSoutien.AllowUserToDeleteRows = false;
            this.dgvUniteSoutien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUniteSoutien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUniteSoutien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUniteSoutien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUniteSoutien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvUniteSoutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniteSoutien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunt_ID,
            this.colunt_Unite,
            this.colvil_Nom,
            this.colunt_Description});
            this.dgvUniteSoutien.ContextMenuStrip = this.menuDGV;
            this.dgvUniteSoutien.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUniteSoutien.Location = new System.Drawing.Point(6, 61);
            this.dgvUniteSoutien.MultiSelect = false;
            this.dgvUniteSoutien.Name = "dgvUniteSoutien";
            this.dgvUniteSoutien.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUniteSoutien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUniteSoutien.RowHeadersVisible = false;
            this.dgvUniteSoutien.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUniteSoutien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUniteSoutien.RowTemplate.Height = 24;
            this.dgvUniteSoutien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUniteSoutien.Size = new System.Drawing.Size(496, 412);
            this.dgvUniteSoutien.TabIndex = 1;
            this.dgvUniteSoutien.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvUniteSoutien_CellContextMenuStripNeeded);
            this.dgvUniteSoutien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUniteSoutien_CellDoubleClick);
            // 
            // colunt_ID
            // 
            this.colunt_ID.DataPropertyName = "unt_ID";
            this.colunt_ID.HeaderText = "Code Unité";
            this.colunt_ID.MinimumWidth = 6;
            this.colunt_ID.Name = "colunt_ID";
            this.colunt_ID.ReadOnly = true;
            this.colunt_ID.Visible = false;
            // 
            // colunt_Unite
            // 
            this.colunt_Unite.DataPropertyName = "unt_Unite";
            this.colunt_Unite.HeaderText = "Unité de soutien";
            this.colunt_Unite.MinimumWidth = 6;
            this.colunt_Unite.Name = "colunt_Unite";
            this.colunt_Unite.ReadOnly = true;
            // 
            // colvil_Nom
            // 
            this.colvil_Nom.DataPropertyName = "vil_Nom";
            this.colvil_Nom.HeaderText = "Ville";
            this.colvil_Nom.MinimumWidth = 6;
            this.colvil_Nom.Name = "colvil_Nom";
            this.colvil_Nom.ReadOnly = true;
            this.colvil_Nom.Visible = false;
            // 
            // colunt_Description
            // 
            this.colunt_Description.DataPropertyName = "unt_Description";
            this.colunt_Description.HeaderText = "Description";
            this.colunt_Description.MinimumWidth = 6;
            this.colunt_Description.Name = "colunt_Description";
            this.colunt_Description.ReadOnly = true;
            this.colunt_Description.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbxVille);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUnite);
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
            this.btnNew.Location = new System.Drawing.Point(416, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 28);
            this.btnNew.TabIndex = 14;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ville";
            // 
            // cmbxVille
            // 
            this.cmbxVille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxVille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxVille.FormattingEnabled = true;
            this.cmbxVille.Location = new System.Drawing.Point(17, 127);
            this.cmbxVille.Name = "cmbxVille";
            this.cmbxVille.Size = new System.Drawing.Size(420, 28);
            this.cmbxVille.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unité";
            // 
            // txtUnite
            // 
            this.txtUnite.Location = new System.Drawing.Point(17, 62);
            this.txtUnite.Name = "txtUnite";
            this.txtUnite.Size = new System.Drawing.Size(420, 27);
            this.txtUnite.TabIndex = 0;
            this.txtUnite.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnite_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(17, 192);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 141);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.Text = "";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // frmUniteSoutien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1018, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmUniteSoutien";
            this.Text = "Unites de soutien";
            this.Load += new System.EventHandler(this.frmUniteSoutien_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.menuDGV.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniteSoutien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvUniteSoutien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_Unite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvil_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_Description;
        private System.Windows.Forms.Button btnNew;
        private Controls.iText txtRecherche;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}