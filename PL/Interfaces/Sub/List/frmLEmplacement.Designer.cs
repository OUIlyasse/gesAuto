namespace PL.Interfaces.Sub.List
{
    partial class frmLEmplacement
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvEmplacement = new System.Windows.Forms.DataGridView();
            this.coleplc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleplc_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmags_Magasin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colref_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrayo_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarm_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleplc_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplacement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Recherche";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 27);
            this.txtSearch.TabIndex = 23;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(12, 66);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 22;
            this.lblCount.Text = "---";
            // 
            // dgvEmplacement
            // 
            this.dgvEmplacement.AllowUserToAddRows = false;
            this.dgvEmplacement.AllowUserToDeleteRows = false;
            this.dgvEmplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmplacement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmplacement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmplacement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmplacement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEmplacement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmplacement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coleplc_ID,
            this.coleplc_Date,
            this.colmags_Magasin,
            this.colart_Designation,
            this.colref_reference,
            this.colrayo_Nom,
            this.colarm_Nom,
            this.coleplc_Description});
            this.dgvEmplacement.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEmplacement.Location = new System.Drawing.Point(12, 89);
            this.dgvEmplacement.MultiSelect = false;
            this.dgvEmplacement.Name = "dgvEmplacement";
            this.dgvEmplacement.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmplacement.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmplacement.RowHeadersVisible = false;
            this.dgvEmplacement.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEmplacement.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmplacement.RowTemplate.Height = 24;
            this.dgvEmplacement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmplacement.Size = new System.Drawing.Size(858, 398);
            this.dgvEmplacement.TabIndex = 20;
            this.dgvEmplacement.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmplacement_CellDoubleClick);
            this.dgvEmplacement.SelectionChanged += new System.EventHandler(this.dgvEmplacement_SelectionChanged);
            // 
            // coleplc_ID
            // 
            this.coleplc_ID.DataPropertyName = "eplc_ID";
            this.coleplc_ID.HeaderText = "Code";
            this.coleplc_ID.Name = "coleplc_ID";
            this.coleplc_ID.ReadOnly = true;
            this.coleplc_ID.Visible = false;
            // 
            // coleplc_Date
            // 
            this.coleplc_Date.DataPropertyName = "eplc_Date";
            this.coleplc_Date.HeaderText = "Date";
            this.coleplc_Date.Name = "coleplc_Date";
            this.coleplc_Date.ReadOnly = true;
            this.coleplc_Date.Visible = false;
            // 
            // colmags_Magasin
            // 
            this.colmags_Magasin.DataPropertyName = "mags_Magasin";
            this.colmags_Magasin.HeaderText = "Magasin";
            this.colmags_Magasin.Name = "colmags_Magasin";
            this.colmags_Magasin.ReadOnly = true;
            // 
            // colart_Designation
            // 
            this.colart_Designation.DataPropertyName = "art_Designation";
            this.colart_Designation.HeaderText = "Article";
            this.colart_Designation.Name = "colart_Designation";
            this.colart_Designation.ReadOnly = true;
            // 
            // colref_reference
            // 
            this.colref_reference.DataPropertyName = "ref_reference";
            this.colref_reference.HeaderText = "Référence";
            this.colref_reference.Name = "colref_reference";
            this.colref_reference.ReadOnly = true;
            // 
            // colrayo_Nom
            // 
            this.colrayo_Nom.DataPropertyName = "rayo_Nom";
            this.colrayo_Nom.HeaderText = "Rayonnage";
            this.colrayo_Nom.Name = "colrayo_Nom";
            this.colrayo_Nom.ReadOnly = true;
            // 
            // colarm_Nom
            // 
            this.colarm_Nom.DataPropertyName = "arm_Nom";
            this.colarm_Nom.HeaderText = "Armoire";
            this.colarm_Nom.Name = "colarm_Nom";
            this.colarm_Nom.ReadOnly = true;
            // 
            // coleplc_Description
            // 
            this.coleplc_Description.DataPropertyName = "eplc_Description";
            this.coleplc_Description.HeaderText = "Description";
            this.coleplc_Description.Name = "coleplc_Description";
            this.coleplc_Description.ReadOnly = true;
            this.coleplc_Description.Visible = false;
            // 
            // frmLEmplacement
            // 
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvEmplacement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Name = "frmLEmplacement";
            this.Text = "Emplacement";
            this.Controls.SetChildIndex(this.btnSupprimer, 0);
            this.Controls.SetChildIndex(this.dgvEmplacement, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplacement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleplc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleplc_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmags_Magasin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colref_reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrayo_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleplc_Description;
    }
}