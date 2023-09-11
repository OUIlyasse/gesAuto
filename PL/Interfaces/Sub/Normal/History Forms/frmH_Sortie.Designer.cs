namespace PL.Interfaces.Sub.Normal.History_Forms
{
    partial class frmH_Sortie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSBon = new System.Windows.Forms.DataGridView();
            this.colbs_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colbs_Suppression = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchB = new PL.Controls.iText();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvA_SBon = new System.Windows.Forms.DataGridView();
            this.txtSearchA = new PL.Controls.iText();
            this.colbs_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbs_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvl_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_A_Etat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colbs_Qte_Demandee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Qte_Manque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_SBon)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.dgvSBon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchB);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bons";
            // 
            // dgvSBon
            // 
            this.dgvSBon.AllowUserToAddRows = false;
            this.dgvSBon.AllowUserToDeleteRows = false;
            this.dgvSBon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSBon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSBon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSBon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSBon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbs_ID,
            this.colbs_Date,
            this.colbs_Designation,
            this.colbs_Reference,
            this.colunt_ID,
            this.colbs_Description,
            this.colbs_Status,
            this.colbs_Suppression});
            this.dgvSBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSBon.Location = new System.Drawing.Point(6, 79);
            this.dgvSBon.MultiSelect = false;
            this.dgvSBon.Name = "dgvSBon";
            this.dgvSBon.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSBon.RowHeadersVisible = false;
            this.dgvSBon.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSBon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSBon.RowTemplate.Height = 24;
            this.dgvSBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSBon.Size = new System.Drawing.Size(170, 394);
            this.dgvSBon.TabIndex = 7;
            this.dgvSBon.SelectionChanged += new System.EventHandler(this.dgvSBon_SelectionChanged);
            this.dgvSBon.DoubleClick += new System.EventHandler(this.dgvSBon_DoubleClick);
            // 
            // colbs_ID
            // 
            this.colbs_ID.DataPropertyName = "bs_ID";
            this.colbs_ID.HeaderText = "code Bon";
            this.colbs_ID.MinimumWidth = 6;
            this.colbs_ID.Name = "colbs_ID";
            this.colbs_ID.ReadOnly = true;
            this.colbs_ID.Visible = false;
            // 
            // colbs_Date
            // 
            this.colbs_Date.DataPropertyName = "bs_Date";
            this.colbs_Date.HeaderText = "Date";
            this.colbs_Date.MinimumWidth = 6;
            this.colbs_Date.Name = "colbs_Date";
            this.colbs_Date.ReadOnly = true;
            this.colbs_Date.Visible = false;
            // 
            // colbs_Designation
            // 
            this.colbs_Designation.DataPropertyName = "bs_Designation";
            this.colbs_Designation.HeaderText = "Bon";
            this.colbs_Designation.MinimumWidth = 6;
            this.colbs_Designation.Name = "colbs_Designation";
            this.colbs_Designation.ReadOnly = true;
            // 
            // colbs_Reference
            // 
            this.colbs_Reference.DataPropertyName = "bs_Reference";
            this.colbs_Reference.HeaderText = "Reference";
            this.colbs_Reference.MinimumWidth = 6;
            this.colbs_Reference.Name = "colbs_Reference";
            this.colbs_Reference.ReadOnly = true;
            this.colbs_Reference.Visible = false;
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
            // colbs_Description
            // 
            this.colbs_Description.DataPropertyName = "bs_Description";
            this.colbs_Description.HeaderText = "bs_Description";
            this.colbs_Description.MinimumWidth = 6;
            this.colbs_Description.Name = "colbs_Description";
            this.colbs_Description.ReadOnly = true;
            this.colbs_Description.Visible = false;
            // 
            // colbs_Status
            // 
            this.colbs_Status.DataPropertyName = "bs_Status";
            this.colbs_Status.HeaderText = "bs_Status";
            this.colbs_Status.MinimumWidth = 6;
            this.colbs_Status.Name = "colbs_Status";
            this.colbs_Status.ReadOnly = true;
            this.colbs_Status.Visible = false;
            // 
            // colbs_Suppression
            // 
            this.colbs_Suppression.DataPropertyName = "bs_Suppression";
            this.colbs_Suppression.HeaderText = "bs_Suppression";
            this.colbs_Suppression.MinimumWidth = 6;
            this.colbs_Suppression.Name = "colbs_Suppression";
            this.colbs_Suppression.ReadOnly = true;
            this.colbs_Suppression.Visible = false;
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
            // dgvA_SBon
            // 
            this.dgvA_SBon.AllowUserToAddRows = false;
            this.dgvA_SBon.AllowUserToDeleteRows = false;
            this.dgvA_SBon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvA_SBon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvA_SBon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvA_SBon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvA_SBon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvA_SBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA_SBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbs_A_ID,
            this.colAbs_ID,
            this.colbs_A_Date,
            this.colvl_Marque,
            this.colart_Designation,
            this.colbs_A_Etat,
            this.colbs_Qte_Demandee,
            this.colbs_Qte_Livree,
            this.colbs_Qte_Manque,
            this.colbs_A_Description,
            this.colCodeUMesure,
            this.colUMesure});
            this.dgvA_SBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvA_SBon.Location = new System.Drawing.Point(206, 65);
            this.dgvA_SBon.MultiSelect = false;
            this.dgvA_SBon.Name = "dgvA_SBon";
            this.dgvA_SBon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvA_SBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvA_SBon.RowHeadersVisible = false;
            this.dgvA_SBon.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvA_SBon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvA_SBon.RowTemplate.Height = 24;
            this.dgvA_SBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvA_SBon.Size = new System.Drawing.Size(664, 426);
            this.dgvA_SBon.TabIndex = 8;
            this.dgvA_SBon.DoubleClick += new System.EventHandler(this.dgvA_SBon_DoubleClick);
            // 
            // txtSearchA
            // 
            this.txtSearchA.Location = new System.Drawing.Point(212, 21);
            this.txtSearchA.Name = "txtSearchA";
            this.txtSearchA.Size = new System.Drawing.Size(354, 28);
            this.txtSearchA.TabIndex = 4;
            // 
            // colbs_A_ID
            // 
            this.colbs_A_ID.DataPropertyName = "bs_A_ID";
            this.colbs_A_ID.HeaderText = "Code bon article";
            this.colbs_A_ID.MinimumWidth = 6;
            this.colbs_A_ID.Name = "colbs_A_ID";
            this.colbs_A_ID.ReadOnly = true;
            this.colbs_A_ID.Visible = false;
            // 
            // colAbs_ID
            // 
            this.colAbs_ID.DataPropertyName = "bs_ID";
            this.colAbs_ID.HeaderText = "Code bon";
            this.colAbs_ID.MinimumWidth = 6;
            this.colAbs_ID.Name = "colAbs_ID";
            this.colAbs_ID.ReadOnly = true;
            this.colAbs_ID.Visible = false;
            // 
            // colbs_A_Date
            // 
            this.colbs_A_Date.DataPropertyName = "bs_A_Date";
            this.colbs_A_Date.HeaderText = "Date";
            this.colbs_A_Date.MinimumWidth = 6;
            this.colbs_A_Date.Name = "colbs_A_Date";
            this.colbs_A_Date.ReadOnly = true;
            this.colbs_A_Date.Visible = false;
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
            // colbs_A_Etat
            // 
            this.colbs_A_Etat.DataPropertyName = "bs_A_Etat";
            this.colbs_A_Etat.HeaderText = "Etat";
            this.colbs_A_Etat.MinimumWidth = 6;
            this.colbs_A_Etat.Name = "colbs_A_Etat";
            this.colbs_A_Etat.ReadOnly = true;
            this.colbs_A_Etat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbs_A_Etat.Visible = false;
            // 
            // colbs_Qte_Demandee
            // 
            this.colbs_Qte_Demandee.DataPropertyName = "bs_Qte_Demandee";
            this.colbs_Qte_Demandee.HeaderText = "Qte Demandee";
            this.colbs_Qte_Demandee.MinimumWidth = 6;
            this.colbs_Qte_Demandee.Name = "colbs_Qte_Demandee";
            this.colbs_Qte_Demandee.ReadOnly = true;
            this.colbs_Qte_Demandee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbs_Qte_Demandee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colbs_Qte_Demandee.Visible = false;
            // 
            // colbs_Qte_Livree
            // 
            this.colbs_Qte_Livree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbs_Qte_Livree.DataPropertyName = "bs_Qte_Livree";
            this.colbs_Qte_Livree.FillWeight = 21.86494F;
            this.colbs_Qte_Livree.HeaderText = "Qte Livree";
            this.colbs_Qte_Livree.MinimumWidth = 6;
            this.colbs_Qte_Livree.Name = "colbs_Qte_Livree";
            this.colbs_Qte_Livree.ReadOnly = true;
            this.colbs_Qte_Livree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbs_Qte_Livree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colbs_Qte_Livree.Width = 130;
            // 
            // colbs_Qte_Manque
            // 
            this.colbs_Qte_Manque.DataPropertyName = "bs_Qte_Manque";
            this.colbs_Qte_Manque.HeaderText = "Qte Manque";
            this.colbs_Qte_Manque.MinimumWidth = 6;
            this.colbs_Qte_Manque.Name = "colbs_Qte_Manque";
            this.colbs_Qte_Manque.ReadOnly = true;
            this.colbs_Qte_Manque.Visible = false;
            // 
            // colbs_A_Description
            // 
            this.colbs_A_Description.DataPropertyName = "bs_A_Description";
            this.colbs_A_Description.HeaderText = "Description";
            this.colbs_A_Description.MinimumWidth = 6;
            this.colbs_A_Description.Name = "colbs_A_Description";
            this.colbs_A_Description.ReadOnly = true;
            this.colbs_A_Description.Visible = false;
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
            // frmH_Sortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.dgvA_SBon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchA);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmH_Sortie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des bons de sorties";
            this.Load += new System.EventHandler(this.frmH_Sortie_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_SBon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.iText txtSearchA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.iText txtSearchB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvSBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbs_Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbs_Suppression;
        public System.Windows.Forms.DataGridView dgvA_SBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbs_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colbs_A_Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Qte_Demandee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Qte_Manque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_A_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeUMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUMesure;
    }
}