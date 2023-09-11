namespace PL.Interfaces.Sub.List
{
    partial class frmLFournisseur
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvFournisseur = new System.Windows.Forms.DataGridView();
            this.colfrns_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Adresse2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Code_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvil_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_GSM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_GSM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Fixe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Fixe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRepresentant = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.menuRows.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Recherche";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 28);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(12, 66);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 20);
            this.lblCount.TabIndex = 14;
            this.lblCount.Text = "---";
            // 
            // dgvFournisseur
            // 
            this.dgvFournisseur.AllowUserToAddRows = false;
            this.dgvFournisseur.AllowUserToDeleteRows = false;
            this.dgvFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFournisseur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFournisseur.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colfrns_ID,
            this.colfrns_Nom,
            this.colfrns_Adresse,
            this.colfrns_Adresse2,
            this.colfrns_Code_Postal,
            this.colvil_Nom,
            this.colfrns_Email,
            this.colfrns_GSM,
            this.colfrns_GSM2,
            this.colfrns_Fixe1,
            this.colfrns_Fixe2,
            this.colfrns_Description});
            this.dgvFournisseur.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFournisseur.Location = new System.Drawing.Point(12, 89);
            this.dgvFournisseur.MultiSelect = false;
            this.dgvFournisseur.Name = "dgvFournisseur";
            this.dgvFournisseur.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFournisseur.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFournisseur.RowHeadersVisible = false;
            this.dgvFournisseur.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFournisseur.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFournisseur.RowTemplate.Height = 24;
            this.dgvFournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFournisseur.Size = new System.Drawing.Size(858, 398);
            this.dgvFournisseur.TabIndex = 12;
            this.dgvFournisseur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFournisseur_CellClick);
            this.dgvFournisseur.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvFournisseur_CellContextMenuStripNeeded);
            this.dgvFournisseur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFournisseur_CellDoubleClick);
            this.dgvFournisseur.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFournisseur_CellMouseDown);
            // 
            // colfrns_ID
            // 
            this.colfrns_ID.DataPropertyName = "frns_ID";
            this.colfrns_ID.HeaderText = "Code fournisseur";
            this.colfrns_ID.MinimumWidth = 6;
            this.colfrns_ID.Name = "colfrns_ID";
            this.colfrns_ID.ReadOnly = true;
            this.colfrns_ID.Visible = false;
            // 
            // colfrns_Nom
            // 
            this.colfrns_Nom.DataPropertyName = "frns_Nom";
            this.colfrns_Nom.HeaderText = "Nom";
            this.colfrns_Nom.MinimumWidth = 6;
            this.colfrns_Nom.Name = "colfrns_Nom";
            this.colfrns_Nom.ReadOnly = true;
            // 
            // colfrns_Adresse
            // 
            this.colfrns_Adresse.DataPropertyName = "frns_Adresse";
            this.colfrns_Adresse.HeaderText = "Adresse";
            this.colfrns_Adresse.MinimumWidth = 6;
            this.colfrns_Adresse.Name = "colfrns_Adresse";
            this.colfrns_Adresse.ReadOnly = true;
            // 
            // colfrns_Adresse2
            // 
            this.colfrns_Adresse2.DataPropertyName = "frns_Adresse2";
            this.colfrns_Adresse2.HeaderText = "Adresse secondaire";
            this.colfrns_Adresse2.MinimumWidth = 6;
            this.colfrns_Adresse2.Name = "colfrns_Adresse2";
            this.colfrns_Adresse2.ReadOnly = true;
            this.colfrns_Adresse2.Visible = false;
            // 
            // colfrns_Code_Postal
            // 
            this.colfrns_Code_Postal.DataPropertyName = "frns_Code_Postal";
            this.colfrns_Code_Postal.HeaderText = "Code postal";
            this.colfrns_Code_Postal.MinimumWidth = 6;
            this.colfrns_Code_Postal.Name = "colfrns_Code_Postal";
            this.colfrns_Code_Postal.ReadOnly = true;
            this.colfrns_Code_Postal.Visible = false;
            // 
            // colvil_Nom
            // 
            this.colvil_Nom.DataPropertyName = "vil_Nom";
            this.colvil_Nom.HeaderText = "Ville";
            this.colvil_Nom.MinimumWidth = 6;
            this.colvil_Nom.Name = "colvil_Nom";
            this.colvil_Nom.ReadOnly = true;
            // 
            // colfrns_Email
            // 
            this.colfrns_Email.DataPropertyName = "frns_Email";
            this.colfrns_Email.HeaderText = "Email";
            this.colfrns_Email.MinimumWidth = 6;
            this.colfrns_Email.Name = "colfrns_Email";
            this.colfrns_Email.ReadOnly = true;
            this.colfrns_Email.Visible = false;
            // 
            // colfrns_GSM
            // 
            this.colfrns_GSM.DataPropertyName = "frns_GSM";
            this.colfrns_GSM.HeaderText = "GSM";
            this.colfrns_GSM.MinimumWidth = 6;
            this.colfrns_GSM.Name = "colfrns_GSM";
            this.colfrns_GSM.ReadOnly = true;
            // 
            // colfrns_GSM2
            // 
            this.colfrns_GSM2.DataPropertyName = "frns_GSM2";
            this.colfrns_GSM2.HeaderText = "GSM secondaire";
            this.colfrns_GSM2.MinimumWidth = 6;
            this.colfrns_GSM2.Name = "colfrns_GSM2";
            this.colfrns_GSM2.ReadOnly = true;
            this.colfrns_GSM2.Visible = false;
            // 
            // colfrns_Fixe1
            // 
            this.colfrns_Fixe1.DataPropertyName = "frns_Fixe1";
            this.colfrns_Fixe1.HeaderText = "Fixe";
            this.colfrns_Fixe1.MinimumWidth = 6;
            this.colfrns_Fixe1.Name = "colfrns_Fixe1";
            this.colfrns_Fixe1.ReadOnly = true;
            // 
            // colfrns_Fixe2
            // 
            this.colfrns_Fixe2.DataPropertyName = "frns_Fixe2";
            this.colfrns_Fixe2.HeaderText = "Fixe secondaire";
            this.colfrns_Fixe2.MinimumWidth = 6;
            this.colfrns_Fixe2.Name = "colfrns_Fixe2";
            this.colfrns_Fixe2.ReadOnly = true;
            this.colfrns_Fixe2.Visible = false;
            // 
            // colfrns_Description
            // 
            this.colfrns_Description.DataPropertyName = "frns_Description";
            this.colfrns_Description.HeaderText = "Description";
            this.colfrns_Description.MinimumWidth = 6;
            this.colfrns_Description.Name = "colfrns_Description";
            this.colfrns_Description.ReadOnly = true;
            this.colfrns_Description.Visible = false;
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
            // menuRows
            // 
            this.menuRows.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRepresentant});
            this.menuRows.Name = "menuDGV";
            this.menuRows.Size = new System.Drawing.Size(172, 28);
            // 
            // btnRepresentant
            // 
            this.btnRepresentant.Name = "btnRepresentant";
            this.btnRepresentant.Size = new System.Drawing.Size(210, 24);
            this.btnRepresentant.Text = "Representants";
            this.btnRepresentant.Click += new System.EventHandler(this.btnRepresentant_Click);
            // 
            // frmLFournisseur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvFournisseur);
            this.Name = "frmLFournisseur";
            this.Text = "Fournisseurs";
            this.Controls.SetChildIndex(this.dgvFournisseur, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.menuRows.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Adresse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Code_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvil_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_GSM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_GSM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Fixe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Fixe2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Description;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
        private System.Windows.Forms.ContextMenuStrip menuRows;
        private System.Windows.Forms.ToolStripMenuItem btnRepresentant;
    }
}