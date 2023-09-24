namespace PL.Interfaces.Sub.Normal
{
    partial class frmPermission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxService = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.ckbAffiche = new System.Windows.Forms.CheckBox();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchPersonnel = new PL.Controls.iText();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.colpers_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgrd_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mle_FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckbAdmin = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.collist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collist_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPermission = new System.Windows.Forms.DataGridView();
            this.colutil_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colscrn_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colscrn_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpriv_Afficher = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colpriv_Ajouter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colpriv_Modifier = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colpriv_Supprimer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxService);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.ckbAffiche);
            this.groupBox1.Controls.Add(this.txtRPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cmbxService
            // 
            this.cmbxService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxService.FormattingEnabled = true;
            this.cmbxService.Location = new System.Drawing.Point(274, 126);
            this.cmbxService.Name = "cmbxService";
            this.cmbxService.Size = new System.Drawing.Size(237, 27);
            this.cmbxService.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Service";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(274, 60);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(237, 28);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(10, 60);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(237, 28);
            this.txtNom.TabIndex = 0;
            // 
            // ckbAffiche
            // 
            this.ckbAffiche.AutoSize = true;
            this.ckbAffiche.Location = new System.Drawing.Point(10, 225);
            this.ckbAffiche.Name = "ckbAffiche";
            this.ckbAffiche.Size = new System.Drawing.Size(102, 23);
            this.ckbAffiche.TabIndex = 5;
            this.ckbAffiche.Text = "Affichier";
            this.ckbAffiche.UseVisualStyleBackColor = true;
            this.ckbAffiche.CheckedChanged += new System.EventHandler(this.ckbAffiche_CheckedChanged);
            // 
            // txtRPassword
            // 
            this.txtRPassword.Location = new System.Drawing.Point(270, 191);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(237, 28);
            this.txtRPassword.TabIndex = 4;
            this.txtRPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmer mot de passe";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de passe";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(10, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 28);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::PL.Properties.Resources.Ajouter_utilisateur_32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(176, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSearchPersonnel);
            this.groupBox2.Controls.Add(this.dgvPersonnel);
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 425);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnel";
            // 
            // txtSearchPersonnel
            // 
            this.txtSearchPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPersonnel.Location = new System.Drawing.Point(6, 53);
            this.txtSearchPersonnel.Name = "txtSearchPersonnel";
            this.txtSearchPersonnel.Size = new System.Drawing.Size(202, 28);
            this.txtSearchPersonnel.TabIndex = 0;
            this.txtSearchPersonnel.TextChanged += new System.EventHandler(this.txtSearchPersonnel_TextChanged);
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
            this.colpers_ID,
            this.colgrd_Grade,
            this.colpers_Prenom,
            this.colpers_Nom,
            this.colpers_Mle_FA});
            this.dgvPersonnel.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 87);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersonnel.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(350, 332);
            this.dgvPersonnel.TabIndex = 1;
            this.dgvPersonnel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnel_CellDoubleClick);
            this.dgvPersonnel.DoubleClick += new System.EventHandler(this.dgvPersonnel_DoubleClick);
            // 
            // colpers_ID
            // 
            this.colpers_ID.DataPropertyName = "pers_ID";
            this.colpers_ID.HeaderText = "Code personnel";
            this.colpers_ID.Name = "colpers_ID";
            this.colpers_ID.ReadOnly = true;
            this.colpers_ID.Visible = false;
            // 
            // colgrd_Grade
            // 
            this.colgrd_Grade.DataPropertyName = "grd_Grade";
            this.colgrd_Grade.HeaderText = "Grade";
            this.colgrd_Grade.Name = "colgrd_Grade";
            this.colgrd_Grade.ReadOnly = true;
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
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(141, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Image = global::PL.Properties.Resources.Mises_a_jour_32;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(6, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 45);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nouveau";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::PL.Properties.Resources.Supprimer_utilisateur_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(516, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = global::PL.Properties.Resources.Modifier_utilisateur_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(346, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 45);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.ckbAdmin);
            this.groupBox4.Controls.Add(this.dgvList);
            this.groupBox4.Controls.Add(this.dgvPermission);
            this.groupBox4.Location = new System.Drawing.Point(12, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 163);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Permission";
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.Location = new System.Drawing.Point(408, 23);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(156, 23);
            this.ckbAdmin.TabIndex = 12;
            this.ckbAdmin.Text = "Administrateur";
            this.ckbAdmin.UseVisualStyleBackColor = true;
            this.ckbAdmin.CheckedChanged += new System.EventHandler(this.ckbAdmin_CheckedChanged);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collist_ID,
            this.collist_Nom});
            this.dgvList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvList.Location = new System.Drawing.Point(6, 52);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(145, 105);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // collist_ID
            // 
            this.collist_ID.DataPropertyName = "list_ID";
            this.collist_ID.HeaderText = "Code list";
            this.collist_ID.Name = "collist_ID";
            this.collist_ID.ReadOnly = true;
            this.collist_ID.Visible = false;
            // 
            // collist_Nom
            // 
            this.collist_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collist_Nom.DataPropertyName = "list_Nom";
            this.collist_Nom.HeaderText = "List";
            this.collist_Nom.Name = "collist_Nom";
            this.collist_Nom.ReadOnly = true;
            // 
            // dgvPermission
            // 
            this.dgvPermission.AllowUserToAddRows = false;
            this.dgvPermission.AllowUserToDeleteRows = false;
            this.dgvPermission.AllowUserToOrderColumns = true;
            this.dgvPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermission.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPermission.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPermission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colutil_ID,
            this.colscrn_ID,
            this.colscrn_Nom,
            this.colpriv_Afficher,
            this.colpriv_Ajouter,
            this.colpriv_Modifier,
            this.colpriv_Supprimer});
            this.dgvPermission.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPermission.Location = new System.Drawing.Point(157, 52);
            this.dgvPermission.MultiSelect = false;
            this.dgvPermission.Name = "dgvPermission";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermission.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPermission.RowHeadersVisible = false;
            this.dgvPermission.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPermission.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPermission.RowTemplate.Height = 24;
            this.dgvPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermission.Size = new System.Drawing.Size(407, 105);
            this.dgvPermission.TabIndex = 0;
            // 
            // colutil_ID
            // 
            this.colutil_ID.DataPropertyName = "util_ID";
            this.colutil_ID.HeaderText = "util_ID";
            this.colutil_ID.Name = "colutil_ID";
            this.colutil_ID.ReadOnly = true;
            this.colutil_ID.Visible = false;
            // 
            // colscrn_ID
            // 
            this.colscrn_ID.DataPropertyName = "scrn_ID";
            this.colscrn_ID.HeaderText = "scrn_ID";
            this.colscrn_ID.Name = "colscrn_ID";
            this.colscrn_ID.ReadOnly = true;
            this.colscrn_ID.Visible = false;
            // 
            // colscrn_Nom
            // 
            this.colscrn_Nom.DataPropertyName = "scrn_Nom";
            this.colscrn_Nom.HeaderText = "Ecran";
            this.colscrn_Nom.Name = "colscrn_Nom";
            this.colscrn_Nom.ReadOnly = true;
            // 
            // colpriv_Afficher
            // 
            this.colpriv_Afficher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colpriv_Afficher.DataPropertyName = "priv_Afficher";
            this.colpriv_Afficher.HeaderText = "Afficher";
            this.colpriv_Afficher.Name = "colpriv_Afficher";
            this.colpriv_Afficher.Width = 80;
            // 
            // colpriv_Ajouter
            // 
            this.colpriv_Ajouter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colpriv_Ajouter.DataPropertyName = "priv_Ajouter";
            this.colpriv_Ajouter.HeaderText = "Ajouter";
            this.colpriv_Ajouter.Name = "colpriv_Ajouter";
            this.colpriv_Ajouter.Width = 76;
            // 
            // colpriv_Modifier
            // 
            this.colpriv_Modifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colpriv_Modifier.DataPropertyName = "priv_Modifier";
            this.colpriv_Modifier.HeaderText = "Modifier";
            this.colpriv_Modifier.Name = "colpriv_Modifier";
            this.colpriv_Modifier.Width = 88;
            // 
            // colpriv_Supprimer
            // 
            this.colpriv_Supprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colpriv_Supprimer.DataPropertyName = "priv_Supprimer";
            this.colpriv_Supprimer.HeaderText = "Supprimer";
            this.colpriv_Supprimer.Name = "colpriv_Supprimer";
            this.colpriv_Supprimer.Width = 102;
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission";
            this.Load += new System.EventHandler(this.frmPermission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Controls.iText txtSearchPersonnel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbAffiche;
        private System.Windows.Forms.TextBox txtRPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView dgvPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgrd_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mle_FA;
        private System.Windows.Forms.ComboBox cmbxService;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn collist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn collist_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colutil_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colscrn_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colscrn_Nom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colpriv_Afficher;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colpriv_Ajouter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colpriv_Modifier;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colpriv_Supprimer;
        private System.Windows.Forms.CheckBox ckbAdmin;
    }
}