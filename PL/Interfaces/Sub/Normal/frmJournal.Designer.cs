namespace PL.Interfaces.Sub.Normal
{
    partial class frmJournal
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
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReste = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVL = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colOpera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbon_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunit_M_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.AllowUserToOrderColumns = true;
            this.dgvOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOperation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIcon,
            this.colOpera,
            this.colopera_ID,
            this.colbon_ID,
            this.colopera_Date,
            this.colVL,
            this.colpne_Designation,
            this.colbe_Designation,
            this.colbe_Reference,
            this.colopera_Qte,
            this.colunit_M_Nom});
            this.dgvOperation.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOperation.Location = new System.Drawing.Point(12, 204);
            this.dgvOperation.MultiSelect = false;
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperation.RowHeadersVisible = false;
            this.dgvOperation.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOperation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperation.RowTemplate.Height = 24;
            this.dgvOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperation.Size = new System.Drawing.Size(958, 437);
            this.dgvOperation.TabIndex = 22;
            this.dgvOperation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOperation_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Véhicule";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReste);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblReference);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblArticle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblVL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 167);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // lblReste
            // 
            this.lblReste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReste.Location = new System.Drawing.Point(119, 98);
            this.lblReste.Name = "lblReste";
            this.lblReste.Size = new System.Drawing.Size(357, 20);
            this.lblReste.TabIndex = 30;
            this.lblReste.Text = "---";
            this.lblReste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Référence";
            // 
            // lblReference
            // 
            this.lblReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReference.Location = new System.Drawing.Point(119, 133);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(357, 20);
            this.lblReference.TabIndex = 28;
            this.lblReference.Text = "---";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Reste";
            // 
            // lblArticle
            // 
            this.lblArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticle.Location = new System.Drawing.Point(119, 63);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(357, 20);
            this.lblArticle.TabIndex = 26;
            this.lblArticle.Text = "---";
            this.lblArticle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Article";
            // 
            // lblVL
            // 
            this.lblVL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVL.Location = new System.Drawing.Point(119, 28);
            this.lblVL.Name = "lblVL";
            this.lblVL.Size = new System.Drawing.Size(357, 20);
            this.lblVL.TabIndex = 24;
            this.lblVL.Text = "---";
            this.lblVL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(530, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 72);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 27);
            this.textBox1.TabIndex = 0;
            // 
            // colIcon
            // 
            this.colIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIcon.HeaderText = "";
            this.colIcon.Name = "colIcon";
            this.colIcon.ReadOnly = true;
            this.colIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIcon.Width = 23;
            // 
            // colOpera
            // 
            this.colOpera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colOpera.DataPropertyName = "opera_Type";
            this.colOpera.HeaderText = "Operation";
            this.colOpera.MinimumWidth = 6;
            this.colOpera.Name = "colOpera";
            this.colOpera.ReadOnly = true;
            this.colOpera.Width = 111;
            // 
            // colopera_ID
            // 
            this.colopera_ID.DataPropertyName = "mvt_ID";
            this.colopera_ID.HeaderText = "code operation";
            this.colopera_ID.MinimumWidth = 6;
            this.colopera_ID.Name = "colopera_ID";
            this.colopera_ID.ReadOnly = true;
            this.colopera_ID.Visible = false;
            // 
            // colbon_ID
            // 
            this.colbon_ID.DataPropertyName = "bon_ID";
            this.colbon_ID.HeaderText = "code bon";
            this.colbon_ID.MinimumWidth = 6;
            this.colbon_ID.Name = "colbon_ID";
            this.colbon_ID.ReadOnly = true;
            this.colbon_ID.Visible = false;
            // 
            // colopera_Date
            // 
            this.colopera_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colopera_Date.DataPropertyName = "mvt_Date";
            this.colopera_Date.HeaderText = "Date";
            this.colopera_Date.MinimumWidth = 6;
            this.colopera_Date.Name = "colopera_Date";
            this.colopera_Date.ReadOnly = true;
            this.colopera_Date.Width = 150;
            // 
            // colVL
            // 
            this.colVL.DataPropertyName = "vl_ID";
            this.colVL.HeaderText = "VL";
            this.colVL.MinimumWidth = 6;
            this.colVL.Name = "colVL";
            this.colVL.ReadOnly = true;
            this.colVL.Visible = false;
            // 
            // colpne_Designation
            // 
            this.colpne_Designation.DataPropertyName = "art_ID";
            this.colpne_Designation.HeaderText = "Article";
            this.colpne_Designation.MinimumWidth = 6;
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            this.colpne_Designation.Visible = false;
            // 
            // colbe_Designation
            // 
            this.colbe_Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbe_Designation.DataPropertyName = "be_Designation";
            this.colbe_Designation.HeaderText = "BL";
            this.colbe_Designation.MinimumWidth = 6;
            this.colbe_Designation.Name = "colbe_Designation";
            this.colbe_Designation.ReadOnly = true;
            this.colbe_Designation.Width = 120;
            // 
            // colbe_Reference
            // 
            this.colbe_Reference.DataPropertyName = "be_Reference";
            this.colbe_Reference.HeaderText = "Référence";
            this.colbe_Reference.MinimumWidth = 6;
            this.colbe_Reference.Name = "colbe_Reference";
            this.colbe_Reference.ReadOnly = true;
            // 
            // colopera_Qte
            // 
            this.colopera_Qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colopera_Qte.DataPropertyName = "mvt_Qte";
            this.colopera_Qte.HeaderText = "Quantité";
            this.colopera_Qte.MinimumWidth = 6;
            this.colopera_Qte.Name = "colopera_Qte";
            this.colopera_Qte.ReadOnly = true;
            this.colopera_Qte.Width = 125;
            // 
            // colunit_M_Nom
            // 
            this.colunit_M_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunit_M_Nom.DataPropertyName = "unit_M_Nom";
            this.colunit_M_Nom.HeaderText = "Unite de mesure";
            this.colunit_M_Nom.MinimumWidth = 6;
            this.colunit_M_Nom.Name = "colunit_M_Nom";
            this.colunit_M_Nom.ReadOnly = true;
            this.colunit_M_Nom.Width = 150;
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOperation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJournal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblReste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn colIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbon_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunit_M_Nom;
    }
}