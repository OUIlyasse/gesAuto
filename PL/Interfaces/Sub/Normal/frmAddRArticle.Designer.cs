namespace PL.Interfaces.Sub.Normal
{
    partial class frmAddRArticle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxArticle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQteLivree = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btnAfficherTous = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxNSerie = new System.Windows.Forms.ComboBox();
            this.btnAddAnnee = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cmbxVL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuDgvReference = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnModifierNSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDgvNSerie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDeleteNSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pnlVerifier = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlErreur = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlOk = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbxUMesure = new System.Windows.Forms.ComboBox();
            this.gbRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).BeginInit();
            this.gbCodeBarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSerie)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.menuDgvReference.SuspendLayout();
            this.menuDgvNSerie.SuspendLayout();
            this.pnlVerifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlErreur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlOk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Article";
            // 
            // cmbxArticle
            // 
            this.cmbxArticle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxArticle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxArticle.DisplayMember = "art_Designation";
            this.cmbxArticle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxArticle.FormattingEnabled = true;
            this.cmbxArticle.Location = new System.Drawing.Point(181, 41);
            this.cmbxArticle.Name = "cmbxArticle";
            this.cmbxArticle.Size = new System.Drawing.Size(373, 28);
            this.cmbxArticle.TabIndex = 0;
            this.cmbxArticle.ValueMember = "art_ID";
            this.cmbxArticle.SelectedIndexChanged += new System.EventHandler(this.cmbxArticle_SelectedIndexChanged);
            this.cmbxArticle.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxArticle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Véhicule";
            // 
            // txtQteLivree
            // 
            this.txtQteLivree.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtQteLivree.Location = new System.Drawing.Point(181, 120);
            this.txtQteLivree.Name = "txtQteLivree";
            this.txtQteLivree.Size = new System.Drawing.Size(170, 28);
            this.txtQteLivree.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtDescription.Location = new System.Drawing.Point(181, 160);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(373, 89);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description";
            // 
            // gbRef
            // 
            this.gbRef.Controls.Add(this.btnArtSupprimer);
            this.gbRef.Controls.Add(this.btnArtAjouter);
            this.gbRef.Controls.Add(this.dgvReference);
            this.gbRef.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRef.Location = new System.Drawing.Point(12, 276);
            this.gbRef.Name = "gbRef";
            this.gbRef.Size = new System.Drawing.Size(577, 422);
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
            this.btnArtSupprimer.Location = new System.Drawing.Point(496, 27);
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
            this.btnArtAjouter.Location = new System.Drawing.Point(538, 27);
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
            this.colDebut_Gravage,
            this.colFin_Gravage,
            this.colAnnee,
            this.colBon,
            this.colStatusGravage});
            this.dgvReference.GridColor = System.Drawing.SystemColors.Control;
            this.dgvReference.Location = new System.Drawing.Point(0, 65);
            this.dgvReference.MultiSelect = false;
            this.dgvReference.Name = "dgvReference";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvReference.Size = new System.Drawing.Size(571, 351);
            this.dgvReference.TabIndex = 2;
            this.dgvReference.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReference_CellClick);
            this.dgvReference.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvReference_CellContextMenuStripNeeded);
            this.dgvReference.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReference_CellMouseDown);
            this.dgvReference.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvReference_CellValidating);
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
            this.colQte.Width = 110;
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
            this.colBon.DataPropertyName = "bt_A_ID";
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
            this.colStatusGravage.Width = 108;
            // 
            // gbCodeBarre
            // 
            this.gbCodeBarre.Controls.Add(this.dgvNSerie);
            this.gbCodeBarre.Controls.Add(this.btnAfficherTous);
            this.gbCodeBarre.Controls.Add(this.label4);
            this.gbCodeBarre.Controls.Add(this.cmbxNSerie);
            this.gbCodeBarre.Controls.Add(this.btnAddAnnee);
            this.gbCodeBarre.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodeBarre.Location = new System.Drawing.Point(606, 23);
            this.gbCodeBarre.Name = "gbCodeBarre";
            this.gbCodeBarre.Size = new System.Drawing.Size(504, 450);
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
            this.dgvNSerie.Location = new System.Drawing.Point(6, 108);
            this.dgvNSerie.MultiSelect = false;
            this.dgvNSerie.Name = "dgvNSerie";
            this.dgvNSerie.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvNSerie.Size = new System.Drawing.Size(492, 337);
            this.dgvNSerie.TabIndex = 2;
            this.dgvNSerie.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvNSerie_CellContextMenuStripNeeded);
            this.dgvNSerie.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNSerie_CellMouseDown);
            // 
            // bc_ID
            // 
            this.bc_ID.DataPropertyName = "bc_ID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtNSerie.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtNSerie.HeaderText = "N°Serie";
            this.txtNSerie.MinimumWidth = 6;
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.ReadOnly = true;
            // 
            // txtReference
            // 
            this.txtReference.DataPropertyName = "ref_ID";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtReference.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtReference.HeaderText = "Reference";
            this.txtReference.MinimumWidth = 6;
            this.txtReference.Name = "txtReference";
            this.txtReference.ReadOnly = true;
            this.txtReference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtReference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtReference.Visible = false;
            // 
            // btnAfficherTous
            // 
            this.btnAfficherTous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfficherTous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficherTous.FlatAppearance.BorderSize = 0;
            this.btnAfficherTous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherTous.Image = global::PL.Properties.Resources.Menu_32;
            this.btnAfficherTous.Location = new System.Drawing.Point(461, 61);
            this.btnAfficherTous.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAfficherTous.Name = "btnAfficherTous";
            this.btnAfficherTous.Size = new System.Drawing.Size(32, 32);
            this.btnAfficherTous.TabIndex = 1;
            this.btnAfficherTous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAfficherTous.UseVisualStyleBackColor = true;
            this.btnAfficherTous.Click += new System.EventHandler(this.btnAfficherTous_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "N° de série";
            // 
            // cmbxNSerie
            // 
            this.cmbxNSerie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxNSerie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxNSerie.DisplayMember = "art_Designation";
            this.cmbxNSerie.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxNSerie.FormattingEnabled = true;
            this.cmbxNSerie.Location = new System.Drawing.Point(211, 26);
            this.cmbxNSerie.Name = "cmbxNSerie";
            this.cmbxNSerie.Size = new System.Drawing.Size(198, 28);
            this.cmbxNSerie.TabIndex = 0;
            this.cmbxNSerie.ValueMember = "art_ID";
            // 
            // btnAddAnnee
            // 
            this.btnAddAnnee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnnee.FlatAppearance.BorderSize = 0;
            this.btnAddAnnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnnee.Image = global::PL.Properties.Resources.Plus_24;
            this.btnAddAnnee.Location = new System.Drawing.Point(415, 27);
            this.btnAddAnnee.Name = "btnAddAnnee";
            this.btnAddAnnee.Size = new System.Drawing.Size(24, 24);
            this.btnAddAnnee.TabIndex = 3;
            this.btnAddAnnee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAnnee.UseVisualStyleBackColor = true;
            this.btnAddAnnee.Click += new System.EventHandler(this.btnAddAnnee_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cmbxUMesure);
            this.gbInfo.Controls.Add(this.cmbxVL);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtQteLivree);
            this.gbInfo.Controls.Add(this.cmbxArticle);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtDescription);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(577, 255);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // cmbxVL
            // 
            this.cmbxVL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxVL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxVL.DisplayMember = "art_Designation";
            this.cmbxVL.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxVL.FormattingEnabled = true;
            this.cmbxVL.Location = new System.Drawing.Point(181, 81);
            this.cmbxVL.Name = "cmbxVL";
            this.cmbxVL.Size = new System.Drawing.Size(373, 28);
            this.cmbxVL.TabIndex = 3;
            this.cmbxVL.ValueMember = "art_ID";
            this.cmbxVL.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxVL_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Qte Livree";
            // 
            // menuDgvReference
            // 
            this.menuDgvReference.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDgvReference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModifierNSerie});
            this.menuDgvReference.Name = "menuDgvReference";
            this.menuDgvReference.Size = new System.Drawing.Size(275, 28);
            this.menuDgvReference.Opening += new System.ComponentModel.CancelEventHandler(this.menuDgvReference_Opening);
            // 
            // btnModifierNSerie
            // 
            this.btnModifierNSerie.Name = "btnModifierNSerie";
            this.btnModifierNSerie.Size = new System.Drawing.Size(274, 24);
            this.btnModifierNSerie.Text = "Modifier les numéros de série";
            this.btnModifierNSerie.Click += new System.EventHandler(this.btnModifierNSerie_Click);
            // 
            // menuDgvNSerie
            // 
            this.menuDgvNSerie.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDgvNSerie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteNSerie});
            this.menuDgvNSerie.Name = "menuDgvReference";
            this.menuDgvNSerie.Size = new System.Drawing.Size(279, 28);
            // 
            // btnDeleteNSerie
            // 
            this.btnDeleteNSerie.Name = "btnDeleteNSerie";
            this.btnDeleteNSerie.Size = new System.Drawing.Size(278, 24);
            this.btnDeleteNSerie.Text = "Supprimer un numéro de série";
            this.btnDeleteNSerie.Click += new System.EventHandler(this.btnDeleteNSerie_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifier.AutoSize = true;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Image = global::PL.Properties.Resources.Modifier_32;
            this.btnModifier.Location = new System.Drawing.Point(886, 650);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(142, 48);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Image = global::PL.Properties.Resources.Ajouter_32;
            this.btnAjouter.Location = new System.Drawing.Point(692, 650);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 48);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pnlVerifier
            // 
            this.pnlVerifier.Controls.Add(this.label9);
            this.pnlVerifier.Controls.Add(this.pictureBox2);
            this.pnlVerifier.Location = new System.Drawing.Point(1116, 57);
            this.pnlVerifier.Name = "pnlVerifier";
            this.pnlVerifier.Size = new System.Drawing.Size(492, 80);
            this.pnlVerifier.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(75, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Veuillez saisie les code barres";
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
            // pnlErreur
            // 
            this.pnlErreur.Controls.Add(this.label10);
            this.pnlErreur.Controls.Add(this.pictureBox3);
            this.pnlErreur.Location = new System.Drawing.Point(1116, 162);
            this.pnlErreur.Name = "pnlErreur";
            this.pnlErreur.Size = new System.Drawing.Size(492, 80);
            this.pnlErreur.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(75, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(376, 52);
            this.label10.TabIndex = 1;
            this.label10.Text = "Il s\'agit d\'incompatibilité entre les quantités saisies et celles gravées";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PL.Properties.Resources.Haute_Importance_52;
            this.pictureBox3.Location = new System.Drawing.Point(12, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlOk
            // 
            this.pnlOk.Controls.Add(this.label8);
            this.pnlOk.Controls.Add(this.pictureBox1);
            this.pnlOk.Location = new System.Drawing.Point(1116, 276);
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Size = new System.Drawing.Size(492, 80);
            this.pnlOk.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 52);
            this.label8.TabIndex = 1;
            this.label8.Text = "Correcte";
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
            // cmbxUMesure
            // 
            this.cmbxUMesure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxUMesure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxUMesure.DisplayMember = "art_Designation";
            this.cmbxUMesure.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxUMesure.FormattingEnabled = true;
            this.cmbxUMesure.Location = new System.Drawing.Point(357, 120);
            this.cmbxUMesure.Name = "cmbxUMesure";
            this.cmbxUMesure.Size = new System.Drawing.Size(197, 28);
            this.cmbxUMesure.TabIndex = 49;
            this.cmbxUMesure.ValueMember = "art_ID";
            // 
            // frmAddRArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 710);
            this.Controls.Add(this.pnlVerifier);
            this.Controls.Add(this.pnlErreur);
            this.Controls.Add(this.pnlOk);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbCodeBarre);
            this.Controls.Add(this.gbRef);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRArticle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmAddArticle_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddArticle_FormClosing);
            this.Load += new System.EventHandler(this.frmAddArticle_Load);
            this.gbRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReference)).EndInit();
            this.gbCodeBarre.ResumeLayout(false);
            this.gbCodeBarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSerie)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.menuDgvReference.ResumeLayout(false);
            this.menuDgvNSerie.ResumeLayout(false);
            this.pnlVerifier.ResumeLayout(false);
            this.pnlVerifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlErreur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlOk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAnnee;
        private System.Windows.Forms.GroupBox gbRef;
        private System.Windows.Forms.GroupBox gbCodeBarre;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnArtSupprimer;
        private System.Windows.Forms.Button btnArtAjouter;
        public System.Windows.Forms.DataGridView dgvReference;
        public System.Windows.Forms.TextBox txtQteLivree;
        private System.Windows.Forms.ContextMenuStrip menuDgvReference;
        private System.Windows.Forms.ToolStripMenuItem btnModifierNSerie;
        public System.Windows.Forms.ComboBox cmbxNSerie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAfficherTous;
        public System.Windows.Forms.DataGridView dgvNSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn bc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReference;
        private System.Windows.Forms.ContextMenuStrip menuDgvNSerie;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteNSerie;
        private System.Windows.Forms.Panel pnlVerifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlErreur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbxVL;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ComboBox cmbxUMesure;
    }
}