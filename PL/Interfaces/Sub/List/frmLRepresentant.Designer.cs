namespace PL.Interfaces.Sub.List
{
    partial class frmLRepresentant
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
            this.dgvRepresentant = new System.Windows.Forms.DataGridView();
            this.colrep_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_Cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_Tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_Observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRecherche = new PL.Controls.iText();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepresentant)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            // 
            // dgvRepresentant
            // 
            this.dgvRepresentant.AllowUserToAddRows = false;
            this.dgvRepresentant.AllowUserToDeleteRows = false;
            this.dgvRepresentant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepresentant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepresentant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRepresentant.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRepresentant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRepresentant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepresentant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colrep_ID,
            this.colrep_Nom,
            this.colrep_Prenom,
            this.colrep_Cin,
            this.colrep_Tele,
            this.colrep_Observation,
            this.colfrns_Nom});
            this.dgvRepresentant.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRepresentant.Location = new System.Drawing.Point(12, 74);
            this.dgvRepresentant.MultiSelect = false;
            this.dgvRepresentant.Name = "dgvRepresentant";
            this.dgvRepresentant.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepresentant.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepresentant.RowHeadersVisible = false;
            this.dgvRepresentant.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRepresentant.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepresentant.RowTemplate.Height = 24;
            this.dgvRepresentant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepresentant.Size = new System.Drawing.Size(858, 417);
            this.dgvRepresentant.TabIndex = 16;
            this.dgvRepresentant.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvRepresentant_CellContextMenuStripNeeded);
            this.dgvRepresentant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepresentant_CellDoubleClick);
            this.dgvRepresentant.SelectionChanged += new System.EventHandler(this.dgvRepresentant_SelectionChanged);
            // 
            // colrep_ID
            // 
            this.colrep_ID.DataPropertyName = "rep_ID";
            this.colrep_ID.HeaderText = "Code representant";
            this.colrep_ID.MinimumWidth = 6;
            this.colrep_ID.Name = "colrep_ID";
            this.colrep_ID.ReadOnly = true;
            this.colrep_ID.Visible = false;
            // 
            // colrep_Nom
            // 
            this.colrep_Nom.DataPropertyName = "rep_Nom";
            this.colrep_Nom.HeaderText = "Nom";
            this.colrep_Nom.MinimumWidth = 6;
            this.colrep_Nom.Name = "colrep_Nom";
            this.colrep_Nom.ReadOnly = true;
            // 
            // colrep_Prenom
            // 
            this.colrep_Prenom.DataPropertyName = "rep_Prenom";
            this.colrep_Prenom.HeaderText = "Prénom";
            this.colrep_Prenom.MinimumWidth = 6;
            this.colrep_Prenom.Name = "colrep_Prenom";
            this.colrep_Prenom.ReadOnly = true;
            // 
            // colrep_Cin
            // 
            this.colrep_Cin.DataPropertyName = "rep_Cin";
            this.colrep_Cin.HeaderText = "CIN";
            this.colrep_Cin.MinimumWidth = 6;
            this.colrep_Cin.Name = "colrep_Cin";
            this.colrep_Cin.ReadOnly = true;
            // 
            // colrep_Tele
            // 
            this.colrep_Tele.DataPropertyName = "rep_Tele";
            this.colrep_Tele.HeaderText = "GSM";
            this.colrep_Tele.MinimumWidth = 6;
            this.colrep_Tele.Name = "colrep_Tele";
            this.colrep_Tele.ReadOnly = true;
            // 
            // colrep_Observation
            // 
            this.colrep_Observation.DataPropertyName = "rep_Observation";
            this.colrep_Observation.HeaderText = "Observation";
            this.colrep_Observation.MinimumWidth = 6;
            this.colrep_Observation.Name = "colrep_Observation";
            this.colrep_Observation.ReadOnly = true;
            this.colrep_Observation.Visible = false;
            // 
            // colfrns_Nom
            // 
            this.colfrns_Nom.DataPropertyName = "frns_Nom";
            this.colfrns_Nom.HeaderText = "Fournisseur";
            this.colfrns_Nom.MinimumWidth = 6;
            this.colfrns_Nom.Name = "colfrns_Nom";
            this.colfrns_Nom.ReadOnly = true;
            this.colfrns_Nom.Visible = false;
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
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Location = new System.Drawing.Point(12, 21);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(366, 27);
            this.txtRecherche.TabIndex = 28;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(12, 51);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 27;
            this.lblCount.Text = "---";
            // 
            // frmLRepresentant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvRepresentant);
            this.Name = "frmLRepresentant";
            this.Text = "Representants";
            this.Load += new System.EventHandler(this.frmLRepresentant_Load);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnSupprimer, 0);
            this.Controls.SetChildIndex(this.dgvRepresentant, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.Controls.SetChildIndex(this.txtRecherche, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepresentant)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvRepresentant;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_Cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_Tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_Observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_Nom;
        private Controls.iText txtRecherche;
        private System.Windows.Forms.Label lblCount;
    }
}