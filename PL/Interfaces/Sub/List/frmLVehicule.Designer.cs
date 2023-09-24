namespace PL.Interfaces.Sub.List
{
    partial class frmLVehicule
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvVL = new System.Windows.Forms.DataGridView();
            this.colvl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Annee_Fabrication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVL)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recherche";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 27);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(12, 70);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "---";
            // 
            // dgvVL
            // 
            this.dgvVL.AllowUserToAddRows = false;
            this.dgvVL.AllowUserToDeleteRows = false;
            this.dgvVL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVL.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colvl_ID,
            this.colvl_Immatriculation,
            this.colvl_Modele,
            this.colvl_Marque,
            this.colvl_Annee_Fabrication,
            this.colvl_Description});
            this.dgvVL.ContextMenuStrip = this.menuDGV;
            this.dgvVL.GridColor = System.Drawing.SystemColors.Control;
            this.dgvVL.Location = new System.Drawing.Point(12, 93);
            this.dgvVL.MultiSelect = false;
            this.dgvVL.Name = "dgvVL";
            this.dgvVL.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVL.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVL.RowHeadersVisible = false;
            this.dgvVL.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVL.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVL.RowTemplate.Height = 24;
            this.dgvVL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVL.Size = new System.Drawing.Size(858, 398);
            this.dgvVL.TabIndex = 8;
            this.dgvVL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVL_CellClick);
            this.dgvVL.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvVL_CellContextMenuStripNeeded);
            this.dgvVL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVL_CellDoubleClick);
            // 
            // colvl_ID
            // 
            this.colvl_ID.DataPropertyName = "vl_ID";
            this.colvl_ID.HeaderText = "Code VL";
            this.colvl_ID.MinimumWidth = 6;
            this.colvl_ID.Name = "colvl_ID";
            this.colvl_ID.ReadOnly = true;
            this.colvl_ID.Visible = false;
            // 
            // colvl_Immatriculation
            // 
            this.colvl_Immatriculation.DataPropertyName = "vl_Immatriculation";
            this.colvl_Immatriculation.HeaderText = "Immatriculation";
            this.colvl_Immatriculation.MinimumWidth = 6;
            this.colvl_Immatriculation.Name = "colvl_Immatriculation";
            this.colvl_Immatriculation.ReadOnly = true;
            // 
            // colvl_Modele
            // 
            this.colvl_Modele.DataPropertyName = "vl_Modele";
            this.colvl_Modele.HeaderText = "Modèle";
            this.colvl_Modele.MinimumWidth = 6;
            this.colvl_Modele.Name = "colvl_Modele";
            this.colvl_Modele.ReadOnly = true;
            // 
            // colvl_Marque
            // 
            this.colvl_Marque.DataPropertyName = "vl_Marque";
            this.colvl_Marque.HeaderText = "Marque";
            this.colvl_Marque.MinimumWidth = 6;
            this.colvl_Marque.Name = "colvl_Marque";
            this.colvl_Marque.ReadOnly = true;
            // 
            // colvl_Annee_Fabrication
            // 
            this.colvl_Annee_Fabrication.DataPropertyName = "vl_Annee_Fabrication";
            this.colvl_Annee_Fabrication.HeaderText = "Annee de fabrication";
            this.colvl_Annee_Fabrication.MinimumWidth = 6;
            this.colvl_Annee_Fabrication.Name = "colvl_Annee_Fabrication";
            this.colvl_Annee_Fabrication.ReadOnly = true;
            this.colvl_Annee_Fabrication.Visible = false;
            // 
            // colvl_Description
            // 
            this.colvl_Description.DataPropertyName = "vl_Description";
            this.colvl_Description.HeaderText = "Description";
            this.colvl_Description.MinimumWidth = 6;
            this.colvl_Description.Name = "colvl_Description";
            this.colvl_Description.ReadOnly = true;
            this.colvl_Description.Visible = false;
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
            // frmLVehicule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvVL);
            this.Name = "frmLVehicule";
            this.Text = "Véhicules";
            this.Load += new System.EventHandler(this.frmLVehicule_Load);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnSupprimer, 0);
            this.Controls.SetChildIndex(this.dgvVL, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVL)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Modele;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Annee_Fabrication;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Description;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
    }
}