namespace PL.Repport
{
    partial class frmR_Personnel
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.colpers_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Prenom_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Nom_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mle_FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgrd_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_Unite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Date_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Lieu_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Lieu_Naissance_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Date_Engagement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Date_Nomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Reff_Nomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Origine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Origine_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Adresse_Personnelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Adresse_Personnelle_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Carte_FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Fonction_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Sit_Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Sit_Fam_Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_E_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_E_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_E_CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_E_Date_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_E_Lieu_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Nbr_Enf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_PPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_GS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mutuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Affiliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Date_Affiliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Pere_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Pere_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Pere_CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Pere_Date_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Pere_Lieu_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mere_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mere_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mere_CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mere_Date_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Mere_Lieu_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Niv_Instrution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Diplome_Universitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Num_Passeport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpers_Num_Arm_Chasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
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
            this.cmbxCondition.Enabled = false;
            this.cmbxCondition.FormattingEnabled = true;
            this.cmbxCondition.Location = new System.Drawing.Point(617, 38);
            this.cmbxCondition.Name = "cmbxCondition";
            this.cmbxCondition.Size = new System.Drawing.Size(114, 28);
            this.cmbxCondition.TabIndex = 9;
            this.cmbxCondition.SelectedIndexChanged += new System.EventHandler(this.cmbxCondition_SelectedIndexChanged);
            // 
            // cmbxTable
            // 
            this.cmbxTable.Enabled = false;
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
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
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
            this.colpers_Prenom,
            this.colpers_Prenom_Ar,
            this.colpers_Nom,
            this.colpers_Nom_Ar,
            this.colpers_Mle_FA,
            this.colgrd_Grade,
            this.colunt_Unite,
            this.colpers_Date_Naissance,
            this.colpers_Lieu_Naissance,
            this.colpers_Lieu_Naissance_Ar,
            this.colpers_Date_Engagement,
            this.colpers_Date_Nomination,
            this.colpers_Reff_Nomination,
            this.colpers_Origine,
            this.colpers_Origine_Ar,
            this.colpers_CIN,
            this.colpers_Sexe,
            this.colpers_Adresse_Personnelle,
            this.colpers_Adresse_Personnelle_Ar,
            this.colpers_Carte_FA,
            this.colpers_Specialite,
            this.colpers_Fonction,
            this.colpers_Fonction_Ar,
            this.colpers_Taille,
            this.colpers_Sit_Fam,
            this.colpers_Sit_Fam_Ar,
            this.colpers_E_Prenom,
            this.colpers_E_Nom,
            this.colpers_E_CIN,
            this.colpers_E_Date_Naissance,
            this.colpers_E_Lieu_Naissance,
            this.colpers_Nbr_Enf,
            this.colpers_PPR,
            this.colpers_GS,
            this.colpers_Mutuel,
            this.colpers_Immatriculation,
            this.colpers_Affiliation,
            this.colpers_Date_Affiliation,
            this.colpers_Pere_Prenom,
            this.colpers_Pere_Nom,
            this.colpers_Pere_CIN,
            this.colpers_Pere_Date_Naissance,
            this.colpers_Pere_Lieu_Naissance,
            this.colpers_Mere_Prenom,
            this.colpers_Mere_Nom,
            this.colpers_Mere_CIN,
            this.colpers_Mere_Date_Naissance,
            this.colpers_Mere_Lieu_Naissance,
            this.colpers_Niv_Instrution,
            this.colpers_Diplome_Universitaire,
            this.colpers_Num_Passeport,
            this.colpers_Num_Arm_Chasse});
            this.dgvPersonnel.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 128);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
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
            this.dgvPersonnel.Size = new System.Drawing.Size(958, 513);
            this.dgvPersonnel.TabIndex = 17;
            // 
            // colpers_ID
            // 
            this.colpers_ID.DataPropertyName = "pers_ID";
            this.colpers_ID.HeaderText = "Code Personnel";
            this.colpers_ID.Name = "colpers_ID";
            this.colpers_ID.ReadOnly = true;
            this.colpers_ID.Visible = false;
            // 
            // colpers_Prenom
            // 
            this.colpers_Prenom.DataPropertyName = "pers_Prenom";
            this.colpers_Prenom.HeaderText = "Prénom";
            this.colpers_Prenom.Name = "colpers_Prenom";
            this.colpers_Prenom.ReadOnly = true;
            // 
            // colpers_Prenom_Ar
            // 
            this.colpers_Prenom_Ar.DataPropertyName = "pers_Prenom_Ar";
            this.colpers_Prenom_Ar.HeaderText = "Prénom en arabe";
            this.colpers_Prenom_Ar.Name = "colpers_Prenom_Ar";
            this.colpers_Prenom_Ar.ReadOnly = true;
            this.colpers_Prenom_Ar.Visible = false;
            // 
            // colpers_Nom
            // 
            this.colpers_Nom.DataPropertyName = "pers_Nom";
            this.colpers_Nom.HeaderText = "Nom";
            this.colpers_Nom.Name = "colpers_Nom";
            this.colpers_Nom.ReadOnly = true;
            // 
            // colpers_Nom_Ar
            // 
            this.colpers_Nom_Ar.DataPropertyName = "pers_Nom_Ar";
            this.colpers_Nom_Ar.HeaderText = "Nom en arabe";
            this.colpers_Nom_Ar.Name = "colpers_Nom_Ar";
            this.colpers_Nom_Ar.ReadOnly = true;
            this.colpers_Nom_Ar.Visible = false;
            // 
            // colpers_Mle_FA
            // 
            this.colpers_Mle_FA.DataPropertyName = "pers_Mle_FA";
            this.colpers_Mle_FA.HeaderText = "Mle FA";
            this.colpers_Mle_FA.Name = "colpers_Mle_FA";
            this.colpers_Mle_FA.ReadOnly = true;
            // 
            // colgrd_Grade
            // 
            this.colgrd_Grade.DataPropertyName = "grd_Grade";
            this.colgrd_Grade.HeaderText = "Grade";
            this.colgrd_Grade.Name = "colgrd_Grade";
            this.colgrd_Grade.ReadOnly = true;
            // 
            // colunt_Unite
            // 
            this.colunt_Unite.DataPropertyName = "unt_Unite";
            this.colunt_Unite.HeaderText = "Unité";
            this.colunt_Unite.Name = "colunt_Unite";
            this.colunt_Unite.ReadOnly = true;
            // 
            // colpers_Date_Naissance
            // 
            this.colpers_Date_Naissance.DataPropertyName = "pers_Date_Naissance";
            this.colpers_Date_Naissance.HeaderText = "Date naissance";
            this.colpers_Date_Naissance.Name = "colpers_Date_Naissance";
            this.colpers_Date_Naissance.ReadOnly = true;
            // 
            // colpers_Lieu_Naissance
            // 
            this.colpers_Lieu_Naissance.DataPropertyName = "pers_Lieu_Naissance";
            this.colpers_Lieu_Naissance.HeaderText = "Lieu naissance";
            this.colpers_Lieu_Naissance.Name = "colpers_Lieu_Naissance";
            this.colpers_Lieu_Naissance.ReadOnly = true;
            this.colpers_Lieu_Naissance.Visible = false;
            // 
            // colpers_Lieu_Naissance_Ar
            // 
            this.colpers_Lieu_Naissance_Ar.DataPropertyName = "pers_Lieu_Naissance_Ar";
            this.colpers_Lieu_Naissance_Ar.HeaderText = "Lieu naissance en arabe";
            this.colpers_Lieu_Naissance_Ar.Name = "colpers_Lieu_Naissance_Ar";
            this.colpers_Lieu_Naissance_Ar.ReadOnly = true;
            this.colpers_Lieu_Naissance_Ar.Visible = false;
            // 
            // colpers_Date_Engagement
            // 
            this.colpers_Date_Engagement.DataPropertyName = "pers_Date_Engagement";
            this.colpers_Date_Engagement.HeaderText = "Date d\'engagement";
            this.colpers_Date_Engagement.Name = "colpers_Date_Engagement";
            this.colpers_Date_Engagement.ReadOnly = true;
            // 
            // colpers_Date_Nomination
            // 
            this.colpers_Date_Nomination.DataPropertyName = "pers_Date_Nomination";
            this.colpers_Date_Nomination.HeaderText = "Date nomination";
            this.colpers_Date_Nomination.Name = "colpers_Date_Nomination";
            this.colpers_Date_Nomination.ReadOnly = true;
            this.colpers_Date_Nomination.Visible = false;
            // 
            // colpers_Reff_Nomination
            // 
            this.colpers_Reff_Nomination.DataPropertyName = "pers_Reff_Nomination";
            this.colpers_Reff_Nomination.HeaderText = "Référence de nomination";
            this.colpers_Reff_Nomination.Name = "colpers_Reff_Nomination";
            this.colpers_Reff_Nomination.ReadOnly = true;
            this.colpers_Reff_Nomination.Visible = false;
            // 
            // colpers_Origine
            // 
            this.colpers_Origine.DataPropertyName = "pers_Origine";
            this.colpers_Origine.HeaderText = "Origine";
            this.colpers_Origine.Name = "colpers_Origine";
            this.colpers_Origine.ReadOnly = true;
            this.colpers_Origine.Visible = false;
            // 
            // colpers_Origine_Ar
            // 
            this.colpers_Origine_Ar.DataPropertyName = "pers_Origine_Ar";
            this.colpers_Origine_Ar.HeaderText = "Origine en arabe";
            this.colpers_Origine_Ar.Name = "colpers_Origine_Ar";
            this.colpers_Origine_Ar.ReadOnly = true;
            this.colpers_Origine_Ar.Visible = false;
            // 
            // colpers_CIN
            // 
            this.colpers_CIN.DataPropertyName = "pers_CIN";
            this.colpers_CIN.HeaderText = "CIN";
            this.colpers_CIN.Name = "colpers_CIN";
            this.colpers_CIN.ReadOnly = true;
            // 
            // colpers_Sexe
            // 
            this.colpers_Sexe.DataPropertyName = "pers_Sexe";
            this.colpers_Sexe.HeaderText = "Sexe";
            this.colpers_Sexe.Name = "colpers_Sexe";
            this.colpers_Sexe.ReadOnly = true;
            // 
            // colpers_Adresse_Personnelle
            // 
            this.colpers_Adresse_Personnelle.DataPropertyName = "pers_Adresse_Personnelle";
            this.colpers_Adresse_Personnelle.HeaderText = "Adresse personnelle";
            this.colpers_Adresse_Personnelle.Name = "colpers_Adresse_Personnelle";
            this.colpers_Adresse_Personnelle.ReadOnly = true;
            this.colpers_Adresse_Personnelle.Visible = false;
            // 
            // colpers_Adresse_Personnelle_Ar
            // 
            this.colpers_Adresse_Personnelle_Ar.DataPropertyName = "pers_Adresse_Personnelle_Ar";
            this.colpers_Adresse_Personnelle_Ar.HeaderText = "Adresse personnelle an arabe";
            this.colpers_Adresse_Personnelle_Ar.Name = "colpers_Adresse_Personnelle_Ar";
            this.colpers_Adresse_Personnelle_Ar.ReadOnly = true;
            this.colpers_Adresse_Personnelle_Ar.Visible = false;
            // 
            // colpers_Carte_FA
            // 
            this.colpers_Carte_FA.DataPropertyName = "pers_Carte_FA";
            this.colpers_Carte_FA.HeaderText = "Carte FA";
            this.colpers_Carte_FA.Name = "colpers_Carte_FA";
            this.colpers_Carte_FA.ReadOnly = true;
            this.colpers_Carte_FA.Visible = false;
            // 
            // colpers_Specialite
            // 
            this.colpers_Specialite.DataPropertyName = "pers_Specialite";
            this.colpers_Specialite.HeaderText = "Spécialité";
            this.colpers_Specialite.Name = "colpers_Specialite";
            this.colpers_Specialite.ReadOnly = true;
            this.colpers_Specialite.Visible = false;
            // 
            // colpers_Fonction
            // 
            this.colpers_Fonction.DataPropertyName = "pers_Fonction";
            this.colpers_Fonction.HeaderText = "Fonction";
            this.colpers_Fonction.Name = "colpers_Fonction";
            this.colpers_Fonction.ReadOnly = true;
            this.colpers_Fonction.Visible = false;
            // 
            // colpers_Fonction_Ar
            // 
            this.colpers_Fonction_Ar.DataPropertyName = "pers_Fonction_Ar";
            this.colpers_Fonction_Ar.HeaderText = "Fonction an arabe";
            this.colpers_Fonction_Ar.Name = "colpers_Fonction_Ar";
            this.colpers_Fonction_Ar.ReadOnly = true;
            this.colpers_Fonction_Ar.Visible = false;
            // 
            // colpers_Taille
            // 
            this.colpers_Taille.DataPropertyName = "pers_Taille";
            this.colpers_Taille.HeaderText = "Taille";
            this.colpers_Taille.Name = "colpers_Taille";
            this.colpers_Taille.ReadOnly = true;
            this.colpers_Taille.Visible = false;
            // 
            // colpers_Sit_Fam
            // 
            this.colpers_Sit_Fam.DataPropertyName = "pers_Sit_Fam";
            this.colpers_Sit_Fam.HeaderText = "Situation familiale";
            this.colpers_Sit_Fam.Name = "colpers_Sit_Fam";
            this.colpers_Sit_Fam.ReadOnly = true;
            this.colpers_Sit_Fam.Visible = false;
            // 
            // colpers_Sit_Fam_Ar
            // 
            this.colpers_Sit_Fam_Ar.DataPropertyName = "pers_Sit_Fam_Ar";
            this.colpers_Sit_Fam_Ar.HeaderText = "Situation familiale en arabe";
            this.colpers_Sit_Fam_Ar.Name = "colpers_Sit_Fam_Ar";
            this.colpers_Sit_Fam_Ar.ReadOnly = true;
            this.colpers_Sit_Fam_Ar.Visible = false;
            // 
            // colpers_E_Prenom
            // 
            this.colpers_E_Prenom.DataPropertyName = "pers_E_Prenom";
            this.colpers_E_Prenom.HeaderText = "Prénom d\'épouse";
            this.colpers_E_Prenom.Name = "colpers_E_Prenom";
            this.colpers_E_Prenom.ReadOnly = true;
            this.colpers_E_Prenom.Visible = false;
            // 
            // colpers_E_Nom
            // 
            this.colpers_E_Nom.DataPropertyName = "pers_E_Nom";
            this.colpers_E_Nom.HeaderText = "Nom d\'épouse";
            this.colpers_E_Nom.Name = "colpers_E_Nom";
            this.colpers_E_Nom.ReadOnly = true;
            this.colpers_E_Nom.Visible = false;
            // 
            // colpers_E_CIN
            // 
            this.colpers_E_CIN.DataPropertyName = "pers_E_CIN";
            this.colpers_E_CIN.HeaderText = "CIN d\'épouse";
            this.colpers_E_CIN.Name = "colpers_E_CIN";
            this.colpers_E_CIN.ReadOnly = true;
            this.colpers_E_CIN.Visible = false;
            // 
            // colpers_E_Date_Naissance
            // 
            this.colpers_E_Date_Naissance.DataPropertyName = "pers_E_Date_Naissance";
            this.colpers_E_Date_Naissance.HeaderText = "Date naissance d\'épouse";
            this.colpers_E_Date_Naissance.Name = "colpers_E_Date_Naissance";
            this.colpers_E_Date_Naissance.ReadOnly = true;
            this.colpers_E_Date_Naissance.Visible = false;
            // 
            // colpers_E_Lieu_Naissance
            // 
            this.colpers_E_Lieu_Naissance.DataPropertyName = "pers_E_Lieu_Naissance";
            this.colpers_E_Lieu_Naissance.HeaderText = "Lieu naissance d\'épouse";
            this.colpers_E_Lieu_Naissance.Name = "colpers_E_Lieu_Naissance";
            this.colpers_E_Lieu_Naissance.ReadOnly = true;
            this.colpers_E_Lieu_Naissance.Visible = false;
            // 
            // colpers_Nbr_Enf
            // 
            this.colpers_Nbr_Enf.DataPropertyName = "pers_Nbr_Enf";
            this.colpers_Nbr_Enf.HeaderText = "Nombre d\'enfant";
            this.colpers_Nbr_Enf.Name = "colpers_Nbr_Enf";
            this.colpers_Nbr_Enf.ReadOnly = true;
            this.colpers_Nbr_Enf.Visible = false;
            // 
            // colpers_PPR
            // 
            this.colpers_PPR.DataPropertyName = "pers_PPR";
            this.colpers_PPR.HeaderText = "PPR";
            this.colpers_PPR.Name = "colpers_PPR";
            this.colpers_PPR.ReadOnly = true;
            // 
            // colpers_GS
            // 
            this.colpers_GS.DataPropertyName = "gs_Nom";
            this.colpers_GS.HeaderText = "Groupe sanguin";
            this.colpers_GS.Name = "colpers_GS";
            this.colpers_GS.ReadOnly = true;
            // 
            // colpers_Mutuel
            // 
            this.colpers_Mutuel.DataPropertyName = "pers_Mutuel";
            this.colpers_Mutuel.HeaderText = "Mutuel";
            this.colpers_Mutuel.Name = "colpers_Mutuel";
            this.colpers_Mutuel.ReadOnly = true;
            // 
            // colpers_Immatriculation
            // 
            this.colpers_Immatriculation.DataPropertyName = "pers_Immatriculation";
            this.colpers_Immatriculation.HeaderText = "Immatriculation";
            this.colpers_Immatriculation.Name = "colpers_Immatriculation";
            this.colpers_Immatriculation.ReadOnly = true;
            this.colpers_Immatriculation.Visible = false;
            // 
            // colpers_Affiliation
            // 
            this.colpers_Affiliation.DataPropertyName = "pers_Affiliation";
            this.colpers_Affiliation.HeaderText = "Affiliation";
            this.colpers_Affiliation.Name = "colpers_Affiliation";
            this.colpers_Affiliation.ReadOnly = true;
            this.colpers_Affiliation.Visible = false;
            // 
            // colpers_Date_Affiliation
            // 
            this.colpers_Date_Affiliation.DataPropertyName = "pers_Date_Affiliation";
            this.colpers_Date_Affiliation.HeaderText = "Date Affiliation";
            this.colpers_Date_Affiliation.Name = "colpers_Date_Affiliation";
            this.colpers_Date_Affiliation.ReadOnly = true;
            this.colpers_Date_Affiliation.Visible = false;
            // 
            // colpers_Pere_Prenom
            // 
            this.colpers_Pere_Prenom.DataPropertyName = "pers_Pere_Prenom";
            this.colpers_Pere_Prenom.HeaderText = "Prénom de père";
            this.colpers_Pere_Prenom.Name = "colpers_Pere_Prenom";
            this.colpers_Pere_Prenom.ReadOnly = true;
            this.colpers_Pere_Prenom.Visible = false;
            // 
            // colpers_Pere_Nom
            // 
            this.colpers_Pere_Nom.DataPropertyName = "pers_Pere_Nom";
            this.colpers_Pere_Nom.HeaderText = "Nom de père";
            this.colpers_Pere_Nom.Name = "colpers_Pere_Nom";
            this.colpers_Pere_Nom.ReadOnly = true;
            this.colpers_Pere_Nom.Visible = false;
            // 
            // colpers_Pere_CIN
            // 
            this.colpers_Pere_CIN.DataPropertyName = "pers_Pere_CIN";
            this.colpers_Pere_CIN.HeaderText = "CIN de père";
            this.colpers_Pere_CIN.Name = "colpers_Pere_CIN";
            this.colpers_Pere_CIN.ReadOnly = true;
            this.colpers_Pere_CIN.Visible = false;
            // 
            // colpers_Pere_Date_Naissance
            // 
            this.colpers_Pere_Date_Naissance.DataPropertyName = "pers_Pere_Date_Naissance";
            this.colpers_Pere_Date_Naissance.HeaderText = "Date naissance de père";
            this.colpers_Pere_Date_Naissance.Name = "colpers_Pere_Date_Naissance";
            this.colpers_Pere_Date_Naissance.ReadOnly = true;
            this.colpers_Pere_Date_Naissance.Visible = false;
            // 
            // colpers_Pere_Lieu_Naissance
            // 
            this.colpers_Pere_Lieu_Naissance.DataPropertyName = "pers_Pere_Lieu_Naissance";
            this.colpers_Pere_Lieu_Naissance.HeaderText = "Lieu naissance de père";
            this.colpers_Pere_Lieu_Naissance.Name = "colpers_Pere_Lieu_Naissance";
            this.colpers_Pere_Lieu_Naissance.ReadOnly = true;
            this.colpers_Pere_Lieu_Naissance.Visible = false;
            // 
            // colpers_Mere_Prenom
            // 
            this.colpers_Mere_Prenom.DataPropertyName = "pers_Mere_Prenom";
            this.colpers_Mere_Prenom.HeaderText = "Prénom de mère";
            this.colpers_Mere_Prenom.Name = "colpers_Mere_Prenom";
            this.colpers_Mere_Prenom.ReadOnly = true;
            this.colpers_Mere_Prenom.Visible = false;
            // 
            // colpers_Mere_Nom
            // 
            this.colpers_Mere_Nom.DataPropertyName = "pers_Mere_Nom";
            this.colpers_Mere_Nom.HeaderText = "Nom de mère";
            this.colpers_Mere_Nom.Name = "colpers_Mere_Nom";
            this.colpers_Mere_Nom.ReadOnly = true;
            this.colpers_Mere_Nom.Visible = false;
            // 
            // colpers_Mere_CIN
            // 
            this.colpers_Mere_CIN.DataPropertyName = "pers_Mere_CIN";
            this.colpers_Mere_CIN.HeaderText = "CIN de mère";
            this.colpers_Mere_CIN.Name = "colpers_Mere_CIN";
            this.colpers_Mere_CIN.ReadOnly = true;
            this.colpers_Mere_CIN.Visible = false;
            // 
            // colpers_Mere_Date_Naissance
            // 
            this.colpers_Mere_Date_Naissance.DataPropertyName = "pers_Mere_Date_Naissance";
            this.colpers_Mere_Date_Naissance.HeaderText = "Date naissance de mère";
            this.colpers_Mere_Date_Naissance.Name = "colpers_Mere_Date_Naissance";
            this.colpers_Mere_Date_Naissance.ReadOnly = true;
            this.colpers_Mere_Date_Naissance.Visible = false;
            // 
            // colpers_Mere_Lieu_Naissance
            // 
            this.colpers_Mere_Lieu_Naissance.DataPropertyName = "pers_Mere_Lieu_Naissance";
            this.colpers_Mere_Lieu_Naissance.HeaderText = "Lieu naissance de mère";
            this.colpers_Mere_Lieu_Naissance.Name = "colpers_Mere_Lieu_Naissance";
            this.colpers_Mere_Lieu_Naissance.ReadOnly = true;
            this.colpers_Mere_Lieu_Naissance.Visible = false;
            // 
            // colpers_Niv_Instrution
            // 
            this.colpers_Niv_Instrution.DataPropertyName = "pers_Niv_Instrution";
            this.colpers_Niv_Instrution.HeaderText = "Niveau d\'instrution";
            this.colpers_Niv_Instrution.Name = "colpers_Niv_Instrution";
            this.colpers_Niv_Instrution.ReadOnly = true;
            this.colpers_Niv_Instrution.Visible = false;
            // 
            // colpers_Diplome_Universitaire
            // 
            this.colpers_Diplome_Universitaire.DataPropertyName = "pers_Diplome_Universitaire";
            this.colpers_Diplome_Universitaire.HeaderText = "Diplôme universitaire";
            this.colpers_Diplome_Universitaire.Name = "colpers_Diplome_Universitaire";
            this.colpers_Diplome_Universitaire.ReadOnly = true;
            this.colpers_Diplome_Universitaire.Visible = false;
            // 
            // colpers_Num_Passeport
            // 
            this.colpers_Num_Passeport.DataPropertyName = "pers_Num_Passeport";
            this.colpers_Num_Passeport.HeaderText = "Numero de passeport";
            this.colpers_Num_Passeport.Name = "colpers_Num_Passeport";
            this.colpers_Num_Passeport.ReadOnly = true;
            this.colpers_Num_Passeport.Visible = false;
            // 
            // colpers_Num_Arm_Chasse
            // 
            this.colpers_Num_Arm_Chasse.DataPropertyName = "pers_Num_Arm_Chasse";
            this.colpers_Num_Arm_Chasse.HeaderText = "Numero d\'arme de chasse";
            this.colpers_Num_Arm_Chasse.Name = "colpers_Num_Arm_Chasse";
            this.colpers_Num_Arm_Chasse.ReadOnly = true;
            this.colpers_Num_Arm_Chasse.Visible = false;
            // 
            // frmR_Personnel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Name = "frmR_Personnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report etat des personnels";
            this.Load += new System.EventHandler(this.frmR_Stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxCondition;
        private System.Windows.Forms.ComboBox cmbxTable;
        private Controls.iText txtSearch;
        public System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Prenom_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Nom_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mle_FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgrd_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_Unite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Date_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Lieu_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Lieu_Naissance_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Date_Engagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Date_Nomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Reff_Nomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Origine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Origine_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Adresse_Personnelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Adresse_Personnelle_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Carte_FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Fonction_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Taille;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Sit_Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Sit_Fam_Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_E_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_E_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_E_CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_E_Date_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_E_Lieu_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Nbr_Enf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_PPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_GS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mutuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Affiliation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Date_Affiliation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Pere_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Pere_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Pere_CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Pere_Date_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Pere_Lieu_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mere_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mere_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mere_CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mere_Date_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Mere_Lieu_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Niv_Instrution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Diplome_Universitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Num_Passeport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpers_Num_Arm_Chasse;
    }
}