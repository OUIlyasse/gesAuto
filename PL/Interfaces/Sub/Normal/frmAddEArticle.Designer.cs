namespace PL.Interfaces.Sub.Normal
{
    partial class frmAddEArticle
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cmbxUMesure = new System.Windows.Forms.ComboBox();
            this.lblQte = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmbxVL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxArticle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRef = new System.Windows.Forms.GroupBox();
            this.btnArtSupprimer = new System.Windows.Forms.Button();
            this.btnArtAjouter = new System.Windows.Forms.Button();
            this.dgvReference = new System.Windows.Forms.DataGridView();
            this.colbr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBon_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlVerifier = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlOk = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
            this.txtQteLivree = new PL.Controls.iText();
            this.gbInfo.SuspendLayout();
            this.gbRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).BeginInit();
            this.pnlVerifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlOk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cmbxUMesure);
            this.gbInfo.Controls.Add(this.txtQteLivree);
            this.gbInfo.Controls.Add(this.lblQte);
            this.gbInfo.Controls.Add(this.txtDescription);
            this.gbInfo.Controls.Add(this.cmbxVL);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.cmbxArticle);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.gbInfo.Location = new System.Drawing.Point(8, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(569, 253);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // cmbxUMesure
            // 
            this.cmbxUMesure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxUMesure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxUMesure.DisplayMember = "art_Designation";
            this.cmbxUMesure.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxUMesure.FormattingEnabled = true;
            this.cmbxUMesure.Location = new System.Drawing.Point(277, 115);
            this.cmbxUMesure.Name = "cmbxUMesure";
            this.cmbxUMesure.Size = new System.Drawing.Size(151, 28);
            this.cmbxUMesure.TabIndex = 48;
            this.cmbxUMesure.ValueMember = "art_ID";
            // 
            // lblQte
            // 
            this.lblQte.AutoEllipsis = true;
            this.lblQte.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQte.ForeColor = System.Drawing.Color.Green;
            this.lblQte.Location = new System.Drawing.Point(434, 115);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(111, 28);
            this.lblQte.TabIndex = 47;
            this.lblQte.Text = "00";
            this.lblQte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 157);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(410, 90);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // cmbxVL
            // 
            this.cmbxVL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxVL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxVL.DisplayMember = "art_Designation";
            this.cmbxVL.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxVL.FormattingEnabled = true;
            this.cmbxVL.Location = new System.Drawing.Point(135, 73);
            this.cmbxVL.Name = "cmbxVL";
            this.cmbxVL.Size = new System.Drawing.Size(410, 28);
            this.cmbxVL.TabIndex = 1;
            this.cmbxVL.ValueMember = "art_ID";
            this.cmbxVL.SelectedIndexChanged += new System.EventHandler(this.cmbxVL_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 77);
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
            this.cmbxArticle.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxArticle.FormattingEnabled = true;
            this.cmbxArticle.Location = new System.Drawing.Point(135, 31);
            this.cmbxArticle.Name = "cmbxArticle";
            this.cmbxArticle.Size = new System.Drawing.Size(410, 28);
            this.cmbxArticle.TabIndex = 0;
            this.cmbxArticle.ValueMember = "art_ID";
            this.cmbxArticle.SelectedIndexChanged += new System.EventHandler(this.cmbxArticle_SelectedIndexChanged);
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
            this.label3.Location = new System.Drawing.Point(16, 192);
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
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Qte Livree";
            // 
            // gbRef
            // 
            this.gbRef.Controls.Add(this.btnArtSupprimer);
            this.gbRef.Controls.Add(this.btnArtAjouter);
            this.gbRef.Controls.Add(this.dgvReference);
            this.gbRef.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.gbRef.Location = new System.Drawing.Point(8, 272);
            this.gbRef.Name = "gbRef";
            this.gbRef.Size = new System.Drawing.Size(956, 387);
            this.gbRef.TabIndex = 1;
            this.gbRef.TabStop = false;
            this.gbRef.Text = "Reference Article";
            // 
            // btnArtSupprimer
            // 
            this.btnArtSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArtSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtSupprimer.FlatAppearance.BorderSize = 0;
            this.btnArtSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtSupprimer.Image = global::PL.Properties.Resources.Bin_windows_32;
            this.btnArtSupprimer.Location = new System.Drawing.Point(875, 27);
            this.btnArtSupprimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnArtSupprimer.Name = "btnArtSupprimer";
            this.btnArtSupprimer.Size = new System.Drawing.Size(32, 32);
            this.btnArtSupprimer.TabIndex = 1;
            this.btnArtSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArtSupprimer.UseVisualStyleBackColor = true;
            this.btnArtSupprimer.Click += new System.EventHandler(this.btnArtSupprimer_Click);
            // 
            // btnArtAjouter
            // 
            this.btnArtAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArtAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtAjouter.FlatAppearance.BorderSize = 0;
            this.btnArtAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtAjouter.Image = global::PL.Properties.Resources.Plus_32;
            this.btnArtAjouter.Location = new System.Drawing.Point(917, 27);
            this.btnArtAjouter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnArtAjouter.Name = "btnArtAjouter";
            this.btnArtAjouter.Size = new System.Drawing.Size(32, 32);
            this.btnArtAjouter.TabIndex = 0;
            this.btnArtAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArtAjouter.UseVisualStyleBackColor = true;
            this.btnArtAjouter.Click += new System.EventHandler(this.btnArtAjouter_Click);
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
            this.dgvReference.Location = new System.Drawing.Point(0, 65);
            this.dgvReference.MultiSelect = false;
            this.dgvReference.Name = "dgvReference";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReference.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReference.RowHeadersVisible = false;
            this.dgvReference.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReference.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReference.RowTemplate.Height = 24;
            this.dgvReference.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReference.Size = new System.Drawing.Size(950, 316);
            this.dgvReference.TabIndex = 2;
            this.dgvReference.SelectionChanged += new System.EventHandler(this.dgvReference_SelectionChanged);
            this.dgvReference.DoubleClick += new System.EventHandler(this.dgvReference_DoubleClick);
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
            // pnlVerifier
            // 
            this.pnlVerifier.Controls.Add(this.label9);
            this.pnlVerifier.Controls.Add(this.pictureBox2);
            this.pnlVerifier.Location = new System.Drawing.Point(631, 90);
            this.pnlVerifier.Name = "pnlVerifier";
            this.pnlVerifier.Size = new System.Drawing.Size(381, 80);
            this.pnlVerifier.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(75, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Veuillez vérifier les quantités";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PL.Properties.Resources.Warning_52;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlOk
            // 
            this.pnlOk.Controls.Add(this.label8);
            this.pnlOk.Controls.Add(this.pictureBox1);
            this.pnlOk.Location = new System.Drawing.Point(631, 185);
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Size = new System.Drawing.Size(381, 80);
            this.pnlOk.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 52);
            this.label8.TabIndex = 1;
            this.label8.Text = "Correct";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PL.Properties.Resources.Ok_52;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnModifier
            // 
            this.btnModifier.AutoSize = true;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnModifier.Image = global::PL.Properties.Resources.Modifier_32;
            this.btnModifier.Location = new System.Drawing.Point(751, 25);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(142, 48);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnAjouter.Image = global::PL.Properties.Resources.Ajouter_32;
            this.btnAjouter.Location = new System.Drawing.Point(594, 25);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 48);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtQteLivree
            // 
            this.txtQteLivree.Location = new System.Drawing.Point(135, 115);
            this.txtQteLivree.Name = "txtQteLivree";
            this.txtQteLivree.Size = new System.Drawing.Size(140, 28);
            this.txtQteLivree.TabIndex = 2;
            // 
            // frmAddEArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 673);
            this.Controls.Add(this.pnlVerifier);
            this.Controls.Add(this.pnlOk);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbRef);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEArticle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEArticle_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEArticle_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).EndInit();
            this.pnlVerifier.ResumeLayout(false);
            this.pnlVerifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlOk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cmbxVL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbRef;
        private System.Windows.Forms.Button btnArtSupprimer;
        private System.Windows.Forms.Button btnArtAjouter;
        public System.Windows.Forms.DataGridView dgvReference;
        private System.Windows.Forms.Panel pnlVerifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBon_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBon;
        public Controls.iText txtQteLivree;
        private System.Windows.Forms.ComboBox cmbxUMesure;
        private System.Windows.Forms.ToolTip Info;
    }
}