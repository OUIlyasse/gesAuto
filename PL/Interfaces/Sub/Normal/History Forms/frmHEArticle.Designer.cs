namespace PL.Interfaces.Sub.Normal.History_Forms
{
    partial class frmHEArticle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtQteLivree = new PL.Controls.iText();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmbxVL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxArticle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRef = new System.Windows.Forms.GroupBox();
            this.dgvReference = new System.Windows.Forms.DataGridView();
            this.colbr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBon_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbxUMesure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.gbRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.cmbxUMesure);
            this.gbInfo.Controls.Add(this.txtQteLivree);
            this.gbInfo.Controls.Add(this.txtDescription);
            this.gbInfo.Controls.Add(this.cmbxVL);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.cmbxArticle);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Enabled = false;
            this.gbInfo.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.gbInfo.Location = new System.Drawing.Point(8, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(956, 253);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // txtQteLivree
            // 
            this.txtQteLivree.BackColor = System.Drawing.SystemColors.Window;
            this.txtQteLivree.Location = new System.Drawing.Point(135, 69);
            this.txtQteLivree.Name = "txtQteLivree";
            this.txtQteLivree.ReadOnly = true;
            this.txtQteLivree.Size = new System.Drawing.Size(168, 28);
            this.txtQteLivree.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(135, 107);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(815, 139);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // cmbxVL
            // 
            this.cmbxVL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxVL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxVL.DisplayMember = "art_Designation";
            this.cmbxVL.Enabled = false;
            this.cmbxVL.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxVL.FormattingEnabled = true;
            this.cmbxVL.Location = new System.Drawing.Point(643, 31);
            this.cmbxVL.Name = "cmbxVL";
            this.cmbxVL.Size = new System.Drawing.Size(307, 28);
            this.cmbxVL.TabIndex = 1;
            this.cmbxVL.ValueMember = "art_ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Véhicule";
            // 
            // cmbxArticle
            // 
            this.cmbxArticle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxArticle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxArticle.DisplayMember = "art_Designation";
            this.cmbxArticle.Enabled = false;
            this.cmbxArticle.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxArticle.FormattingEnabled = true;
            this.cmbxArticle.Location = new System.Drawing.Point(135, 31);
            this.cmbxArticle.Name = "cmbxArticle";
            this.cmbxArticle.Size = new System.Drawing.Size(410, 28);
            this.cmbxArticle.TabIndex = 0;
            this.cmbxArticle.ValueMember = "art_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Qte Livree";
            // 
            // gbRef
            // 
            this.gbRef.Controls.Add(this.dgvReference);
            this.gbRef.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.gbRef.Location = new System.Drawing.Point(8, 272);
            this.gbRef.Name = "gbRef";
            this.gbRef.Size = new System.Drawing.Size(956, 387);
            this.gbRef.TabIndex = 3;
            this.gbRef.TabStop = false;
            this.gbRef.Text = "Reference Article";
            // 
            // dgvReference
            // 
            this.dgvReference.AllowUserToAddRows = false;
            this.dgvReference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReference.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReference.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReference.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReference.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReference.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbr_ID,
            this.colType,
            this.colart_ID,
            this.colRef,
            this.colBon_ID,
            this.colQte,
            this.colBon});
            this.dgvReference.GridColor = System.Drawing.SystemColors.Control;
            this.dgvReference.Location = new System.Drawing.Point(0, 27);
            this.dgvReference.MultiSelect = false;
            this.dgvReference.Name = "dgvReference";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReference.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReference.RowHeadersVisible = false;
            this.dgvReference.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReference.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReference.RowTemplate.Height = 24;
            this.dgvReference.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReference.Size = new System.Drawing.Size(950, 354);
            this.dgvReference.TabIndex = 2;
            // 
            // colbr_ID
            // 
            this.colbr_ID.DataPropertyName = "br_ID";
            this.colbr_ID.HeaderText = "Code";
            this.colbr_ID.MinimumWidth = 6;
            this.colbr_ID.Name = "colbr_ID";
            this.colbr_ID.ReadOnly = true;
            this.colbr_ID.Visible = false;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "br_Type";
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Visible = false;
            // 
            // colart_ID
            // 
            this.colart_ID.DataPropertyName = "art_ID";
            this.colart_ID.HeaderText = "Code";
            this.colart_ID.MinimumWidth = 6;
            this.colart_ID.Name = "colart_ID";
            this.colart_ID.ReadOnly = true;
            this.colart_ID.Visible = false;
            // 
            // colRef
            // 
            this.colRef.DataPropertyName = "ref_reference";
            this.colRef.FillWeight = 98.47716F;
            this.colRef.HeaderText = "Reference";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            this.colRef.ReadOnly = true;
            this.colRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colBon_ID
            // 
            this.colBon_ID.DataPropertyName = "bon_ID";
            this.colBon_ID.HeaderText = "Code";
            this.colBon_ID.MinimumWidth = 6;
            this.colBon_ID.Name = "colBon_ID";
            this.colBon_ID.ReadOnly = true;
            this.colBon_ID.Visible = false;
            // 
            // colQte
            // 
            this.colQte.DataPropertyName = "br_Qte";
            this.colQte.FillWeight = 20F;
            this.colQte.HeaderText = "Quantite";
            this.colQte.MinimumWidth = 6;
            this.colQte.Name = "colQte";
            this.colQte.ReadOnly = true;
            // 
            // colBon
            // 
            this.colBon.DataPropertyName = "be_A_ID";
            this.colBon.HeaderText = "codeBone";
            this.colBon.MinimumWidth = 6;
            this.colBon.Name = "colBon";
            this.colBon.Visible = false;
            // 
            // cmbxUMesure
            // 
            this.cmbxUMesure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxUMesure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxUMesure.DisplayMember = "art_Designation";
            this.cmbxUMesure.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxUMesure.FormattingEnabled = true;
            this.cmbxUMesure.Location = new System.Drawing.Point(643, 69);
            this.cmbxUMesure.Name = "cmbxUMesure";
            this.cmbxUMesure.Size = new System.Drawing.Size(307, 28);
            this.cmbxUMesure.TabIndex = 49;
            this.cmbxUMesure.ValueMember = "art_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Unité de mesure";
            // 
            // frmHEArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 673);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbRef);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHEArticle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des articles";
            this.Load += new System.EventHandler(this.frmHEArticle_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        public Controls.iText txtQteLivree;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbxVL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbRef;
        public System.Windows.Forms.DataGridView dgvReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBon_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBon;
        private System.Windows.Forms.ComboBox cmbxUMesure;
        private System.Windows.Forms.Label label1;
    }
}