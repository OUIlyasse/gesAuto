namespace PL.Interfaces.Sub.Normal.History_Forms
{
    partial class frmHSArticle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxArticle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQteLivree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRef = new System.Windows.Forms.GroupBox();
            this.dgvReference = new System.Windows.Forms.DataGridView();
            this.colbr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBon_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebut_Gravage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFin_Gravage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusGravage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbCodeBarre = new System.Windows.Forms.GroupBox();
            this.dgvNSerie = new System.Windows.Forms.DataGridView();
            this.bc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQteDemandee = new System.Windows.Forms.TextBox();
            this.cmbxVL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxUMesure = new System.Windows.Forms.ComboBox();
            this.gbRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).BeginInit();
            this.gbCodeBarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSerie)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Article";
            // 
            // cmbxArticle
            // 
            this.cmbxArticle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxArticle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxArticle.BackColor = System.Drawing.SystemColors.Window;
            this.cmbxArticle.DisplayMember = "art_Designation";
            this.cmbxArticle.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxArticle.FormattingEnabled = true;
            this.cmbxArticle.Location = new System.Drawing.Point(170, 28);
            this.cmbxArticle.Name = "cmbxArticle";
            this.cmbxArticle.Size = new System.Drawing.Size(373, 27);
            this.cmbxArticle.TabIndex = 0;
            this.cmbxArticle.ValueMember = "art_ID";
            this.cmbxArticle.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxArticle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Qte Livree";
            // 
            // txtQteLivree
            // 
            this.txtQteLivree.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.txtQteLivree.Location = new System.Drawing.Point(509, 80);
            this.txtQteLivree.Name = "txtQteLivree";
            this.txtQteLivree.ReadOnly = true;
            this.txtQteLivree.Size = new System.Drawing.Size(194, 28);
            this.txtQteLivree.TabIndex = 3;
            this.txtQteLivree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQteLivree_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description";
            // 
            // gbRef
            // 
            this.gbRef.Controls.Add(this.dgvReference);
            this.gbRef.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRef.Location = new System.Drawing.Point(12, 290);
            this.gbRef.Name = "gbRef";
            this.gbRef.Size = new System.Drawing.Size(577, 408);
            this.gbRef.TabIndex = 1;
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
            this.colDebut_Gravage,
            this.colFin_Gravage,
            this.colAnnee,
            this.colBon,
            this.colStatusGravage});
            this.dgvReference.GridColor = System.Drawing.SystemColors.Control;
            this.dgvReference.Location = new System.Drawing.Point(0, 27);
            this.dgvReference.MultiSelect = false;
            this.dgvReference.Name = "dgvReference";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvReference.Size = new System.Drawing.Size(571, 375);
            this.dgvReference.TabIndex = 2;
            this.dgvReference.SelectionChanged += new System.EventHandler(this.dgvReference_SelectionChanged);
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
            this.colQte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQte.DataPropertyName = "br_Qte";
            this.colQte.HeaderText = "Quantite";
            this.colQte.MinimumWidth = 6;
            this.colQte.Name = "colQte";
            this.colQte.ReadOnly = true;
            this.colQte.Width = 114;
            // 
            // colDebut_Gravage
            // 
            this.colDebut_Gravage.DataPropertyName = "br_Debut_Gravage";
            this.colDebut_Gravage.HeaderText = "Debut Gravage";
            this.colDebut_Gravage.MinimumWidth = 6;
            this.colDebut_Gravage.Name = "colDebut_Gravage";
            this.colDebut_Gravage.ReadOnly = true;
            this.colDebut_Gravage.Visible = false;
            // 
            // colFin_Gravage
            // 
            this.colFin_Gravage.DataPropertyName = "br_Fin_Gravage";
            this.colFin_Gravage.HeaderText = "Fin Gravage";
            this.colFin_Gravage.MinimumWidth = 6;
            this.colFin_Gravage.Name = "colFin_Gravage";
            this.colFin_Gravage.ReadOnly = true;
            this.colFin_Gravage.Visible = false;
            // 
            // colAnnee
            // 
            this.colAnnee.DataPropertyName = "br_Annee";
            this.colAnnee.HeaderText = "Annee";
            this.colAnnee.MinimumWidth = 6;
            this.colAnnee.Name = "colAnnee";
            this.colAnnee.ReadOnly = true;
            this.colAnnee.Visible = false;
            // 
            // colBon
            // 
            this.colBon.DataPropertyName = "bs_A_ID";
            this.colBon.HeaderText = "codeBone";
            this.colBon.MinimumWidth = 6;
            this.colBon.Name = "colBon";
            this.colBon.Visible = false;
            // 
            // colStatusGravage
            // 
            this.colStatusGravage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatusGravage.DataPropertyName = "br_Status_Gravage";
            this.colStatusGravage.HeaderText = "Gravage";
            this.colStatusGravage.MinimumWidth = 6;
            this.colStatusGravage.Name = "colStatusGravage";
            this.colStatusGravage.ReadOnly = true;
            this.colStatusGravage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatusGravage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStatusGravage.Width = 112;
            // 
            // gbCodeBarre
            // 
            this.gbCodeBarre.Controls.Add(this.dgvNSerie);
            this.gbCodeBarre.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodeBarre.Location = new System.Drawing.Point(606, 290);
            this.gbCodeBarre.Name = "gbCodeBarre";
            this.gbCodeBarre.Size = new System.Drawing.Size(504, 408);
            this.gbCodeBarre.TabIndex = 2;
            this.gbCodeBarre.TabStop = false;
            this.gbCodeBarre.Text = "N° de Serie";
            // 
            // dgvNSerie
            // 
            this.dgvNSerie.AllowUserToAddRows = false;
            this.dgvNSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNSerie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNSerie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNSerie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvNSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bc_ID,
            this.txtNSerie,
            this.txtReference});
            this.dgvNSerie.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNSerie.Location = new System.Drawing.Point(6, 27);
            this.dgvNSerie.MultiSelect = false;
            this.dgvNSerie.Name = "dgvNSerie";
            this.dgvNSerie.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNSerie.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNSerie.RowHeadersVisible = false;
            this.dgvNSerie.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvNSerie.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNSerie.RowTemplate.Height = 24;
            this.dgvNSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNSerie.Size = new System.Drawing.Size(492, 376);
            this.dgvNSerie.TabIndex = 2;
            this.dgvNSerie.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvNSerie_CellContextMenuStripNeeded);
            this.dgvNSerie.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNSerie_CellMouseDown);
            // 
            // bc_ID
            // 
            this.bc_ID.DataPropertyName = "bc_ID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.bc_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.bc_ID.HeaderText = "Code BonCodeBarre";
            this.bc_ID.MinimumWidth = 6;
            this.bc_ID.Name = "bc_ID";
            this.bc_ID.ReadOnly = true;
            this.bc_ID.Visible = false;
            // 
            // txtNSerie
            // 
            this.txtNSerie.DataPropertyName = "bc_N_Serie";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.txtNSerie.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtNSerie.HeaderText = "N°Serie";
            this.txtNSerie.MinimumWidth = 6;
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.ReadOnly = true;
            // 
            // txtReference
            // 
            this.txtReference.DataPropertyName = "ref_ID";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.txtReference.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtReference.HeaderText = "Reference";
            this.txtReference.MinimumWidth = 6;
            this.txtReference.Name = "txtReference";
            this.txtReference.ReadOnly = true;
            this.txtReference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtReference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtReference.Visible = false;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.cmbxUMesure);
            this.gbInfo.Controls.Add(this.txtDescription);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtQteDemandee);
            this.gbInfo.Controls.Add(this.cmbxVL);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtQteLivree);
            this.gbInfo.Controls.Add(this.cmbxArticle);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Enabled = false;
            this.gbInfo.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(1098, 272);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(170, 133);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(922, 111);
            this.txtDescription.TabIndex = 32;
            this.txtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Qte Demandee";
            // 
            // txtQteDemandee
            // 
            this.txtQteDemandee.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.txtQteDemandee.Location = new System.Drawing.Point(170, 80);
            this.txtQteDemandee.Name = "txtQteDemandee";
            this.txtQteDemandee.ReadOnly = true;
            this.txtQteDemandee.Size = new System.Drawing.Size(194, 28);
            this.txtQteDemandee.TabIndex = 2;
            // 
            // cmbxVL
            // 
            this.cmbxVL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxVL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxVL.DisplayMember = "art_Designation";
            this.cmbxVL.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxVL.FormattingEnabled = true;
            this.cmbxVL.Location = new System.Drawing.Point(686, 28);
            this.cmbxVL.Name = "cmbxVL";
            this.cmbxVL.Size = new System.Drawing.Size(406, 27);
            this.cmbxVL.TabIndex = 1;
            this.cmbxVL.ValueMember = "art_ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Véhicule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Unité de mesure";
            // 
            // cmbxUMesure
            // 
            this.cmbxUMesure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxUMesure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxUMesure.DisplayMember = "art_Designation";
            this.cmbxUMesure.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxUMesure.FormattingEnabled = true;
            this.cmbxUMesure.Location = new System.Drawing.Point(872, 80);
            this.cmbxUMesure.Name = "cmbxUMesure";
            this.cmbxUMesure.Size = new System.Drawing.Size(220, 28);
            this.cmbxUMesure.TabIndex = 53;
            this.cmbxUMesure.ValueMember = "art_ID";
            // 
            // frmHSArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 710);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbCodeBarre);
            this.Controls.Add(this.gbRef);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHSArticle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des articles";
            this.Activated += new System.EventHandler(this.frmAddArticle_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddArticle_FormClosing);
            this.Load += new System.EventHandler(this.frmAddArticle_Load);
            this.gbRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).EndInit();
            this.gbCodeBarre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSerie)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbRef;
        private System.Windows.Forms.GroupBox gbCodeBarre;
        private System.Windows.Forms.GroupBox gbInfo;
        public System.Windows.Forms.DataGridView dgvReference;
        public System.Windows.Forms.TextBox txtQteLivree;
        public System.Windows.Forms.DataGridView dgvNSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn bc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBon_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebut_Gravage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFin_Gravage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatusGravage;
        private System.Windows.Forms.ComboBox cmbxVL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQteDemandee;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxUMesure;
    }
}