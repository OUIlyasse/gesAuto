namespace PL.Interfaces.Sub.Normal
{
    partial class frmSuivieUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new PL.Controls.iText();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.coleng_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleng_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleng_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleng_pc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colutil_Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mle_FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleng_Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(472, 28);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AllowUserToOrderColumns = true;
            this.dgvPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonnel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersonnel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coleng_ID,
            this.coleng_Date,
            this.coleng_Time,
            this.coleng_pc_Name,
            this.colutil_Identifiant,
            this.colpers_Prenom,
            this.colpers_Nom,
            this.colpers_Mle_FA,
            this.coleng_Operation});
            this.dgvPersonnel.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 74);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersonnel.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(938, 457);
            this.dgvPersonnel.TabIndex = 3;
            // 
            // coleng_ID
            // 
            this.coleng_ID.DataPropertyName = "eng_ID";
            this.coleng_ID.HeaderText = "Code enregistrement";
            this.coleng_ID.Name = "coleng_ID";
            this.coleng_ID.ReadOnly = true;
            this.coleng_ID.Visible = false;
            // 
            // coleng_Date
            // 
            this.coleng_Date.DataPropertyName = "eng_Date";
            this.coleng_Date.HeaderText = "Date";
            this.coleng_Date.Name = "coleng_Date";
            this.coleng_Date.ReadOnly = true;
            // 
            // coleng_Time
            // 
            this.coleng_Time.DataPropertyName = "eng_Time";
            this.coleng_Time.HeaderText = "Temps";
            this.coleng_Time.Name = "coleng_Time";
            this.coleng_Time.ReadOnly = true;
            // 
            // coleng_pc_Name
            // 
            this.coleng_pc_Name.DataPropertyName = "eng_pc_Name";
            this.coleng_pc_Name.HeaderText = "PC";
            this.coleng_pc_Name.Name = "coleng_pc_Name";
            this.coleng_pc_Name.ReadOnly = true;
            // 
            // colutil_Identifiant
            // 
            this.colutil_Identifiant.DataPropertyName = "util_Identifiant";
            this.colutil_Identifiant.HeaderText = "Identifiant";
            this.colutil_Identifiant.Name = "colutil_Identifiant";
            this.colutil_Identifiant.ReadOnly = true;
            // 
            // colpers_Prenom
            // 
            this.colpers_Prenom.DataPropertyName = "pers_Prenom";
            this.colpers_Prenom.HeaderText = "Prénom";
            this.colpers_Prenom.Name = "colpers_Prenom";
            this.colpers_Prenom.ReadOnly = true;
            // 
            // colpers_Nom
            // 
            this.colpers_Nom.DataPropertyName = "pers_Nom";
            this.colpers_Nom.HeaderText = "Nom";
            this.colpers_Nom.Name = "colpers_Nom";
            this.colpers_Nom.ReadOnly = true;
            // 
            // colpers_Mle_FA
            // 
            this.colpers_Mle_FA.DataPropertyName = "pers_Mle_FA";
            this.colpers_Mle_FA.HeaderText = "Mle FA";
            this.colpers_Mle_FA.Name = "colpers_Mle_FA";
            this.colpers_Mle_FA.ReadOnly = true;
            // 
            // coleng_Operation
            // 
            this.coleng_Operation.DataPropertyName = "eng_Operation";
            this.coleng_Operation.HeaderText = "Operation";
            this.coleng_Operation.Name = "coleng_Operation";
            this.coleng_Operation.ReadOnly = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(12, 51);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "---";
            // 
            // frmSuivieUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPersonnel);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmSuivieUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suivie d\'utilisateur";
            this.Load += new System.EventHandler(this.frmSuivieUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.iText txtSearch;
        public System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleng_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleng_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleng_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleng_pc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colutil_Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mle_FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleng_Operation;
        private System.Windows.Forms.Label lblCount;
    }
}