namespace PL.Interfaces.Sub.Normal.History_Forms
{
    partial class frmH_Entree
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchA = new PL.Controls.iText();
            this.dgvA_EBon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEBon = new System.Windows.Forms.DataGridView();
            this.colb_be_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.be_Suppression = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtSearchB = new PL.Controls.iText();
            this.label2 = new System.Windows.Forms.Label();
            this.colbe_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Etat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colbe_Qte_Demandee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Qte_Manque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_EBon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchA
            // 
            this.txtSearchA.Location = new System.Drawing.Point(212, 21);
            this.txtSearchA.Name = "txtSearchA";
            this.txtSearchA.Size = new System.Drawing.Size(354, 28);
            this.txtSearchA.TabIndex = 4;
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
            this.colbe_A_ID,
            this.colbe_ID,
            this.colbe_A_Date,
            this.colvl_Marque,
            this.colart_Designation,
            this.colbe_A_Etat,
            this.colbe_Qte_Demandee,
            this.colbe_Qte_Livree,
            this.colbe_Qte_Manque,
            this.colbe_A_Description,
            this.colUMesure,
            this.colCodeUMesure});
            this.dgvA_EBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvA_EBon.Location = new System.Drawing.Point(212, 65);
            this.dgvA_EBon.MultiSelect = false;
            this.dgvA_EBon.Name = "dgvA_EBon";
            this.dgvA_EBon.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvA_EBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvA_EBon.RowHeadersVisible = false;
            this.dgvA_EBon.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvA_EBon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvA_EBon.RowTemplate.Height = 24;
            this.dgvA_EBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvA_EBon.Size = new System.Drawing.Size(664, 426);
            this.dgvA_EBon.TabIndex = 5;
            this.dgvA_EBon.DoubleClick += new System.EventHandler(this.dgvA_EBon_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 503);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvEBon);
            this.groupBox1.Controls.Add(this.txtSearchB);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
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
            this.colb_be_ID,
            this.colbe_Date,
            this.colbe_Designation,
            this.colbe_Reference,
            this.colbe_PV,
            this.colfrns_ID,
            this.colrep_ID,
            this.colbe_Description,
            this.colbe_Status,
            this.be_Suppression});
            this.dgvEBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEBon.Location = new System.Drawing.Point(6, 79);
            this.dgvEBon.MultiSelect = false;
            this.dgvEBon.Name = "dgvEBon";
            this.dgvEBon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEBon.RowHeadersVisible = false;
            this.dgvEBon.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEBon.RowTemplate.Height = 24;
            this.dgvEBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBon.Size = new System.Drawing.Size(170, 394);
            this.dgvEBon.TabIndex = 2;
            this.dgvEBon.SelectionChanged += new System.EventHandler(this.dgvEBon_SelectionChanged);
            this.dgvEBon.DoubleClick += new System.EventHandler(this.dgvEBon_DoubleClick);
            // 
            // colb_be_ID
            // 
            this.colb_be_ID.DataPropertyName = "be_ID";
            this.colb_be_ID.HeaderText = "code Bon";
            this.colb_be_ID.MinimumWidth = 6;
            this.colb_be_ID.Name = "colb_be_ID";
            this.colb_be_ID.ReadOnly = true;
            this.colb_be_ID.Visible = false;
            // 
            // colbe_Date
            // 
            this.colbe_Date.DataPropertyName = "be_Date";
            this.colbe_Date.HeaderText = "Date";
            this.colbe_Date.MinimumWidth = 6;
            this.colbe_Date.Name = "colbe_Date";
            this.colbe_Date.ReadOnly = true;
            this.colbe_Date.Visible = false;
            // 
            // colbe_Designation
            // 
            this.colbe_Designation.DataPropertyName = "be_Designation";
            this.colbe_Designation.HeaderText = "Bon";
            this.colbe_Designation.MinimumWidth = 6;
            this.colbe_Designation.Name = "colbe_Designation";
            this.colbe_Designation.ReadOnly = true;
            // 
            // colbe_Reference
            // 
            this.colbe_Reference.DataPropertyName = "be_Reference";
            this.colbe_Reference.HeaderText = "Reference";
            this.colbe_Reference.MinimumWidth = 6;
            this.colbe_Reference.Name = "colbe_Reference";
            this.colbe_Reference.ReadOnly = true;
            this.colbe_Reference.Visible = false;
            // 
            // colbe_PV
            // 
            this.colbe_PV.DataPropertyName = "be_PV";
            this.colbe_PV.HeaderText = "be_PV";
            this.colbe_PV.MinimumWidth = 6;
            this.colbe_PV.Name = "colbe_PV";
            this.colbe_PV.ReadOnly = true;
            this.colbe_PV.Visible = false;
            // 
            // colfrns_ID
            // 
            this.colfrns_ID.DataPropertyName = "frns_ID";
            this.colfrns_ID.HeaderText = "frns_ID";
            this.colfrns_ID.MinimumWidth = 6;
            this.colfrns_ID.Name = "colfrns_ID";
            this.colfrns_ID.ReadOnly = true;
            this.colfrns_ID.Visible = false;
            // 
            // colrep_ID
            // 
            this.colrep_ID.DataPropertyName = "rep_ID";
            this.colrep_ID.HeaderText = "rep_ID";
            this.colrep_ID.MinimumWidth = 6;
            this.colrep_ID.Name = "colrep_ID";
            this.colrep_ID.ReadOnly = true;
            this.colrep_ID.Visible = false;
            // 
            // colbe_Description
            // 
            this.colbe_Description.DataPropertyName = "be_Description";
            this.colbe_Description.HeaderText = "be_Description";
            this.colbe_Description.MinimumWidth = 6;
            this.colbe_Description.Name = "colbe_Description";
            this.colbe_Description.ReadOnly = true;
            this.colbe_Description.Visible = false;
            // 
            // colbe_Status
            // 
            this.colbe_Status.DataPropertyName = "be_Status";
            this.colbe_Status.HeaderText = "be_Status";
            this.colbe_Status.MinimumWidth = 6;
            this.colbe_Status.Name = "colbe_Status";
            this.colbe_Status.ReadOnly = true;
            this.colbe_Status.Visible = false;
            // 
            // be_Suppression
            // 
            this.be_Suppression.DataPropertyName = "be_Suppression";
            this.be_Suppression.HeaderText = "be_Suppression";
            this.be_Suppression.MinimumWidth = 6;
            this.be_Suppression.Name = "be_Suppression";
            this.be_Suppression.ReadOnly = true;
            this.be_Suppression.Visible = false;
            // 
            // txtSearchB
            // 
            this.txtSearchB.Location = new System.Drawing.Point(6, 27);
            this.txtSearchB.Name = "txtSearchB";
            this.txtSearchB.Size = new System.Drawing.Size(170, 28);
            this.txtSearchB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(572, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // colbe_A_ID
            // 
            this.colbe_A_ID.DataPropertyName = "be_A_ID";
            this.colbe_A_ID.HeaderText = "Code bon article";
            this.colbe_A_ID.MinimumWidth = 6;
            this.colbe_A_ID.Name = "colbe_A_ID";
            this.colbe_A_ID.ReadOnly = true;
            this.colbe_A_ID.Visible = false;
            // 
            // colbe_ID
            // 
            this.colbe_ID.DataPropertyName = "be_ID";
            this.colbe_ID.HeaderText = "Code bon";
            this.colbe_ID.MinimumWidth = 6;
            this.colbe_ID.Name = "colbe_ID";
            this.colbe_ID.ReadOnly = true;
            this.colbe_ID.Visible = false;
            // 
            // colbe_A_Date
            // 
            this.colbe_A_Date.DataPropertyName = "be_A_Date";
            this.colbe_A_Date.HeaderText = "Date";
            this.colbe_A_Date.MinimumWidth = 6;
            this.colbe_A_Date.Name = "colbe_A_Date";
            this.colbe_A_Date.ReadOnly = true;
            this.colbe_A_Date.Visible = false;
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
            // colbe_A_Etat
            // 
            this.colbe_A_Etat.DataPropertyName = "be_A_Etat";
            this.colbe_A_Etat.HeaderText = "Etat";
            this.colbe_A_Etat.MinimumWidth = 6;
            this.colbe_A_Etat.Name = "colbe_A_Etat";
            this.colbe_A_Etat.ReadOnly = true;
            this.colbe_A_Etat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbe_A_Etat.Visible = false;
            // 
            // colbe_Qte_Demandee
            // 
            this.colbe_Qte_Demandee.DataPropertyName = "be_Qte_Demandee";
            this.colbe_Qte_Demandee.HeaderText = "Qte Demandee";
            this.colbe_Qte_Demandee.MinimumWidth = 6;
            this.colbe_Qte_Demandee.Name = "colbe_Qte_Demandee";
            this.colbe_Qte_Demandee.ReadOnly = true;
            this.colbe_Qte_Demandee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbe_Qte_Demandee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colbe_Qte_Demandee.Visible = false;
            // 
            // colbe_Qte_Livree
            // 
            this.colbe_Qte_Livree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbe_Qte_Livree.DataPropertyName = "be_Qte_Livree";
            this.colbe_Qte_Livree.FillWeight = 21.86494F;
            this.colbe_Qte_Livree.HeaderText = "Qte Livree";
            this.colbe_Qte_Livree.MinimumWidth = 6;
            this.colbe_Qte_Livree.Name = "colbe_Qte_Livree";
            this.colbe_Qte_Livree.ReadOnly = true;
            this.colbe_Qte_Livree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbe_Qte_Livree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colbe_Qte_Livree.Width = 130;
            // 
            // colbe_Qte_Manque
            // 
            this.colbe_Qte_Manque.DataPropertyName = "be_Qte_Manque";
            this.colbe_Qte_Manque.HeaderText = "Qte Manque";
            this.colbe_Qte_Manque.MinimumWidth = 6;
            this.colbe_Qte_Manque.Name = "colbe_Qte_Manque";
            this.colbe_Qte_Manque.ReadOnly = true;
            this.colbe_Qte_Manque.Visible = false;
            // 
            // colbe_A_Description
            // 
            this.colbe_A_Description.DataPropertyName = "be_A_Description";
            this.colbe_A_Description.HeaderText = "Description";
            this.colbe_A_Description.MinimumWidth = 6;
            this.colbe_A_Description.Name = "colbe_A_Description";
            this.colbe_A_Description.ReadOnly = true;
            this.colbe_A_Description.Visible = false;
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
            // colCodeUMesure
            // 
            this.colCodeUMesure.DataPropertyName = "unit_M_ID";
            this.colCodeUMesure.HeaderText = "code UMesure";
            this.colCodeUMesure.MinimumWidth = 6;
            this.colCodeUMesure.Name = "colCodeUMesure";
            this.colCodeUMesure.ReadOnly = true;
            this.colCodeUMesure.Visible = false;
            // 
            // frmH_Entree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchA);
            this.Controls.Add(this.dgvA_EBon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmH_Entree";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des bons d\'entrées";
            this.Load += new System.EventHandler(this.frmH_Entree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_EBon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.iText txtSearchA;
        public System.Windows.Forms.DataGridView dgvA_EBon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.iText txtSearchB;
        public System.Windows.Forms.DataGridView dgvEBon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colb_be_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_PV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn be_Suppression;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbe_A_Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Qte_Demandee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Qte_Manque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeUMesure;
    }
}