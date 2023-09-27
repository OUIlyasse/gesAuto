namespace PL.Interfaces.Sub.Normal.History_Forms
{
    partial class frmH_Retour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchA = new PL.Controls.iText();
            this.dgvEBon = new System.Windows.Forms.DataGridView();
            this.colb_bt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colbt_Suppression = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvA_EBon = new System.Windows.Forms.DataGridView();
            this.colbt_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_A_Etat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colbt_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchB = new PL.Controls.iText();
            this.lblCountA = new System.Windows.Forms.Label();
            this.lblCountB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_EBon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchA
            // 
            this.txtSearchA.Location = new System.Drawing.Point(212, 21);
            this.txtSearchA.Name = "txtSearchA";
            this.txtSearchA.Size = new System.Drawing.Size(354, 27);
            this.txtSearchA.TabIndex = 5;
            this.txtSearchA.TextChanged += new System.EventHandler(this.txtSearchA_TextChanged);
            // 
            // dgvEBon
            // 
            this.dgvEBon.AllowUserToAddRows = false;
            this.dgvEBon.AllowUserToDeleteRows = false;
            this.dgvEBon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEBon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEBon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEBon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEBon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colb_bt_ID,
            this.colbt_Date,
            this.colbt_Designation,
            this.colbt_Reference,
            this.colunt_ID,
            this.colbt_Description,
            this.colbt_Status,
            this.colbt_Suppression});
            this.dgvEBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEBon.Location = new System.Drawing.Point(6, 80);
            this.dgvEBon.MultiSelect = false;
            this.dgvEBon.Name = "dgvEBon";
            this.dgvEBon.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEBon.RowHeadersVisible = false;
            this.dgvEBon.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBon.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEBon.RowTemplate.Height = 24;
            this.dgvEBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBon.Size = new System.Drawing.Size(169, 393);
            this.dgvEBon.TabIndex = 3;
            this.dgvEBon.SelectionChanged += new System.EventHandler(this.dgvEBon_SelectionChanged);
            this.dgvEBon.DoubleClick += new System.EventHandler(this.dgvEBon_DoubleClick);
            // 
            // colb_bt_ID
            // 
            this.colb_bt_ID.DataPropertyName = "bt_ID";
            this.colb_bt_ID.HeaderText = "code Bon";
            this.colb_bt_ID.MinimumWidth = 6;
            this.colb_bt_ID.Name = "colb_bt_ID";
            this.colb_bt_ID.ReadOnly = true;
            this.colb_bt_ID.Visible = false;
            // 
            // colbt_Date
            // 
            this.colbt_Date.DataPropertyName = "bt_Date";
            this.colbt_Date.HeaderText = "Date";
            this.colbt_Date.MinimumWidth = 6;
            this.colbt_Date.Name = "colbt_Date";
            this.colbt_Date.ReadOnly = true;
            this.colbt_Date.Visible = false;
            // 
            // colbt_Designation
            // 
            this.colbt_Designation.DataPropertyName = "bt_Designation";
            this.colbt_Designation.HeaderText = "Bon";
            this.colbt_Designation.MinimumWidth = 6;
            this.colbt_Designation.Name = "colbt_Designation";
            this.colbt_Designation.ReadOnly = true;
            // 
            // colbt_Reference
            // 
            this.colbt_Reference.DataPropertyName = "bt_Reference";
            this.colbt_Reference.HeaderText = "Reference";
            this.colbt_Reference.MinimumWidth = 6;
            this.colbt_Reference.Name = "colbt_Reference";
            this.colbt_Reference.ReadOnly = true;
            this.colbt_Reference.Visible = false;
            // 
            // colunt_ID
            // 
            this.colunt_ID.DataPropertyName = "unt_ID";
            this.colunt_ID.HeaderText = "unt_ID";
            this.colunt_ID.MinimumWidth = 6;
            this.colunt_ID.Name = "colunt_ID";
            this.colunt_ID.ReadOnly = true;
            this.colunt_ID.Visible = false;
            // 
            // colbt_Description
            // 
            this.colbt_Description.DataPropertyName = "bt_Description";
            this.colbt_Description.HeaderText = "bt_Description";
            this.colbt_Description.MinimumWidth = 6;
            this.colbt_Description.Name = "colbt_Description";
            this.colbt_Description.ReadOnly = true;
            this.colbt_Description.Visible = false;
            // 
            // colbt_Status
            // 
            this.colbt_Status.DataPropertyName = "bt_Status";
            this.colbt_Status.HeaderText = "be_Status";
            this.colbt_Status.MinimumWidth = 6;
            this.colbt_Status.Name = "colbt_Status";
            this.colbt_Status.ReadOnly = true;
            this.colbt_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbt_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colbt_Status.Visible = false;
            // 
            // colbt_Suppression
            // 
            this.colbt_Suppression.DataPropertyName = "bt_Suppression";
            this.colbt_Suppression.HeaderText = "bt_Suppression";
            this.colbt_Suppression.MinimumWidth = 6;
            this.colbt_Suppression.Name = "colbt_Suppression";
            this.colbt_Suppression.ReadOnly = true;
            this.colbt_Suppression.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbt_Suppression.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colbt_Suppression.Visible = false;
            // 
            // dgvA_EBon
            // 
            this.dgvA_EBon.AllowUserToAddRows = false;
            this.dgvA_EBon.AllowUserToDeleteRows = false;
            this.dgvA_EBon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvA_EBon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvA_EBon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvA_EBon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvA_EBon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvA_EBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA_EBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbt_A_ID,
            this.colbt_ID,
            this.colbt_A_Date,
            this.colvl_Marque,
            this.colart_Designation,
            this.colbt_A_Etat,
            this.colbt_Qte_Livree,
            this.colbt_A_Description,
            this.colCodeUMesure,
            this.colUMesure});
            this.dgvA_EBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvA_EBon.Location = new System.Drawing.Point(212, 65);
            this.dgvA_EBon.MultiSelect = false;
            this.dgvA_EBon.Name = "dgvA_EBon";
            this.dgvA_EBon.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvA_EBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvA_EBon.RowHeadersVisible = false;
            this.dgvA_EBon.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvA_EBon.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvA_EBon.RowTemplate.Height = 24;
            this.dgvA_EBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvA_EBon.Size = new System.Drawing.Size(664, 426);
            this.dgvA_EBon.TabIndex = 6;
            this.dgvA_EBon.DoubleClick += new System.EventHandler(this.dgvA_EBon_DoubleClick);
            // 
            // colbt_A_ID
            // 
            this.colbt_A_ID.DataPropertyName = "bt_A_ID";
            this.colbt_A_ID.HeaderText = "Code bon article";
            this.colbt_A_ID.MinimumWidth = 6;
            this.colbt_A_ID.Name = "colbt_A_ID";
            this.colbt_A_ID.ReadOnly = true;
            this.colbt_A_ID.Visible = false;
            // 
            // colbt_ID
            // 
            this.colbt_ID.DataPropertyName = "bt_ID";
            this.colbt_ID.HeaderText = "Code bon";
            this.colbt_ID.MinimumWidth = 6;
            this.colbt_ID.Name = "colbt_ID";
            this.colbt_ID.ReadOnly = true;
            this.colbt_ID.Visible = false;
            // 
            // colbt_A_Date
            // 
            this.colbt_A_Date.DataPropertyName = "bt_A_Date";
            this.colbt_A_Date.HeaderText = "Date";
            this.colbt_A_Date.MinimumWidth = 6;
            this.colbt_A_Date.Name = "colbt_A_Date";
            this.colbt_A_Date.ReadOnly = true;
            this.colbt_A_Date.Visible = false;
            // 
            // colvl_Marque
            // 
            this.colvl_Marque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colvl_Marque.DataPropertyName = "vl_Marque";
            this.colvl_Marque.FillWeight = 270.7086F;
            this.colvl_Marque.HeaderText = "Véhicule";
            this.colvl_Marque.MinimumWidth = 6;
            this.colvl_Marque.Name = "colvl_Marque";
            this.colvl_Marque.ReadOnly = true;
            this.colvl_Marque.Width = 130;
            // 
            // colart_Designation
            // 
            this.colart_Designation.DataPropertyName = "art_Designation";
            this.colart_Designation.FillWeight = 21.86494F;
            this.colart_Designation.HeaderText = "Article";
            this.colart_Designation.MinimumWidth = 6;
            this.colart_Designation.Name = "colart_Designation";
            this.colart_Designation.ReadOnly = true;
            // 
            // colbt_A_Etat
            // 
            this.colbt_A_Etat.DataPropertyName = "bt_A_Etat";
            this.colbt_A_Etat.HeaderText = "Etat";
            this.colbt_A_Etat.MinimumWidth = 6;
            this.colbt_A_Etat.Name = "colbt_A_Etat";
            this.colbt_A_Etat.ReadOnly = true;
            this.colbt_A_Etat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbt_A_Etat.Visible = false;
            // 
            // colbt_Qte_Livree
            // 
            this.colbt_Qte_Livree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbt_Qte_Livree.DataPropertyName = "bt_Qte_Livree";
            this.colbt_Qte_Livree.FillWeight = 21.86494F;
            this.colbt_Qte_Livree.HeaderText = "Qte Livree";
            this.colbt_Qte_Livree.MinimumWidth = 6;
            this.colbt_Qte_Livree.Name = "colbt_Qte_Livree";
            this.colbt_Qte_Livree.ReadOnly = true;
            this.colbt_Qte_Livree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbt_Qte_Livree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colbt_Qte_Livree.Width = 130;
            // 
            // colbt_A_Description
            // 
            this.colbt_A_Description.DataPropertyName = "bt_A_Description";
            this.colbt_A_Description.HeaderText = "Description";
            this.colbt_A_Description.MinimumWidth = 6;
            this.colbt_A_Description.Name = "colbt_A_Description";
            this.colbt_A_Description.ReadOnly = true;
            this.colbt_A_Description.Visible = false;
            // 
            // colCodeUMesure
            // 
            this.colCodeUMesure.DataPropertyName = "unit_M_ID";
            this.colCodeUMesure.HeaderText = "code UMesure";
            this.colCodeUMesure.MinimumWidth = 6;
            this.colCodeUMesure.Name = "colCodeUMesure";
            this.colCodeUMesure.ReadOnly = true;
            this.colCodeUMesure.Visible = false;
            // 
            // colUMesure
            // 
            this.colUMesure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUMesure.DataPropertyName = "unit_M_Nom";
            this.colUMesure.HeaderText = "Unite de mesure";
            this.colUMesure.MinimumWidth = 6;
            this.colUMesure.Name = "colUMesure";
            this.colUMesure.ReadOnly = true;
            this.colUMesure.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 503);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblCountB);
            this.groupBox1.Controls.Add(this.txtSearchB);
            this.groupBox1.Controls.Add(this.dgvEBon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bons";
            // 
            // txtSearchB
            // 
            this.txtSearchB.Location = new System.Drawing.Point(6, 27);
            this.txtSearchB.Name = "txtSearchB";
            this.txtSearchB.Size = new System.Drawing.Size(169, 27);
            this.txtSearchB.TabIndex = 1;
            this.txtSearchB.TextChanged += new System.EventHandler(this.txtSearchB_TextChanged);
            // 
            // lblCountA
            // 
            this.lblCountA.AutoSize = true;
            this.lblCountA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCountA.Location = new System.Drawing.Point(572, 24);
            this.lblCountA.Name = "lblCountA";
            this.lblCountA.Size = new System.Drawing.Size(27, 20);
            this.lblCountA.TabIndex = 20;
            this.lblCountA.Text = "---";
            // 
            // lblCountB
            // 
            this.lblCountB.AutoSize = true;
            this.lblCountB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCountB.Location = new System.Drawing.Point(6, 57);
            this.lblCountB.Name = "lblCountB";
            this.lblCountB.Size = new System.Drawing.Size(27, 20);
            this.lblCountB.TabIndex = 21;
            this.lblCountB.Text = "---";
            // 
            // frmH_Retour
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.lblCountA);
            this.Controls.Add(this.txtSearchA);
            this.Controls.Add(this.dgvA_EBon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmH_Retour";
            this.Text = "Historique des bons de retours";
            this.Load += new System.EventHandler(this.frmLBonEntree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_EBon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.iText txtSearchA;
        public System.Windows.Forms.DataGridView dgvEBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colb_bt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbt_Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbt_Suppression;
        public System.Windows.Forms.DataGridView dgvA_EBon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.iText txtSearchB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbt_A_Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbt_A_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeUMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUMesure;
        private System.Windows.Forms.Label lblCountA;
        private System.Windows.Forms.Label lblCountB;
    }
}