namespace PL.Repport
{
    partial class frmR_Vehicule
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxCondition = new System.Windows.Forms.ComboBox();
            this.cmbxTable = new System.Windows.Forms.ComboBox();
            this.txtSearch = new PL.Controls.iText();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colart_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfam_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Abreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(777, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(193, 48);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxCondition);
            this.groupBox1.Controls.Add(this.cmbxTable);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditions";
            // 
            // cmbxCondition
            // 
            this.cmbxCondition.FormattingEnabled = true;
            this.cmbxCondition.Location = new System.Drawing.Point(617, 38);
            this.cmbxCondition.Name = "cmbxCondition";
            this.cmbxCondition.Size = new System.Drawing.Size(114, 28);
            this.cmbxCondition.TabIndex = 9;
            this.cmbxCondition.SelectedIndexChanged += new System.EventHandler(this.cmbxCondition_SelectedIndexChanged);
            // 
            // cmbxTable
            // 
            this.cmbxTable.FormattingEnabled = true;
            this.cmbxTable.Location = new System.Drawing.Point(360, 38);
            this.cmbxTable.Name = "cmbxTable";
            this.cmbxTable.Size = new System.Drawing.Size(251, 28);
            this.cmbxTable.TabIndex = 6;
            this.cmbxTable.SelectedIndexChanged += new System.EventHandler(this.cmbxTable_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colart_ID,
            this.colfam_Nom,
            this.colart_Designation,
            this.colart_Abreviation});
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(12, 120);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(958, 521);
            this.dgvStock.TabIndex = 8;
            // 
            // colart_ID
            // 
            this.colart_ID.DataPropertyName = "art_ID";
            this.colart_ID.HeaderText = "code Article";
            this.colart_ID.Name = "colart_ID";
            this.colart_ID.ReadOnly = true;
            this.colart_ID.Visible = false;
            // 
            // colfam_Nom
            // 
            this.colfam_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfam_Nom.DataPropertyName = "fam_Nom";
            this.colfam_Nom.HeaderText = "Famille";
            this.colfam_Nom.Name = "colfam_Nom";
            this.colfam_Nom.ReadOnly = true;
            this.colfam_Nom.Width = 92;
            // 
            // colart_Designation
            // 
            this.colart_Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colart_Designation.DataPropertyName = "art_Designation";
            this.colart_Designation.FillWeight = 8.380396F;
            this.colart_Designation.HeaderText = "Article";
            this.colart_Designation.MinimumWidth = 6;
            this.colart_Designation.Name = "colart_Designation";
            this.colart_Designation.ReadOnly = true;
            // 
            // colart_Abreviation
            // 
            this.colart_Abreviation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colart_Abreviation.DataPropertyName = "art_Abreviation";
            this.colart_Abreviation.HeaderText = "Abreviation";
            this.colart_Abreviation.Name = "colart_Abreviation";
            this.colart_Abreviation.ReadOnly = true;
            this.colart_Abreviation.Width = 121;
            // 
            // frmR_Vehicule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Name = "frmR_Vehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report etat des véhicules";
            this.Load += new System.EventHandler(this.frmR_Stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxCondition;
        private System.Windows.Forms.ComboBox cmbxTable;
        private Controls.iText txtSearch;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfam_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Abreviation;
    }
}