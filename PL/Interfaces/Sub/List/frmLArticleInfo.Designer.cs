namespace PL.Interfaces.Sub.List
{
    partial class frmLArticleInfo
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
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.colart_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Abreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsvc_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfam_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnReference = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRecherche = new PL.Controls.iText();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.menuRows.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(12, 51);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "---";
            // 
            // dgvArticle
            // 
            this.dgvArticle.AllowUserToAddRows = false;
            this.dgvArticle.AllowUserToDeleteRows = false;
            this.dgvArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colart_ID,
            this.colart_Designation,
            this.colart_Abreviation,
            this.colart_Description,
            this.colsvc_Nom,
            this.colfam_Nom});
            this.dgvArticle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticle.Location = new System.Drawing.Point(12, 74);
            this.dgvArticle.MultiSelect = false;
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticle.RowHeadersVisible = false;
            this.dgvArticle.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticle.RowTemplate.Height = 24;
            this.dgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticle.Size = new System.Drawing.Size(858, 413);
            this.dgvArticle.TabIndex = 16;
            this.dgvArticle.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvArticle_CellContextMenuStripNeeded);
            this.dgvArticle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticle_CellDoubleClick);
            this.dgvArticle.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticle_CellMouseDown);
            this.dgvArticle.SelectionChanged += new System.EventHandler(this.dgvArticle_SelectionChanged);
            // 
            // colart_ID
            // 
            this.colart_ID.DataPropertyName = "art_ID";
            this.colart_ID.HeaderText = "Code article";
            this.colart_ID.Name = "colart_ID";
            this.colart_ID.ReadOnly = true;
            this.colart_ID.Visible = false;
            // 
            // colart_Designation
            // 
            this.colart_Designation.DataPropertyName = "art_Designation";
            this.colart_Designation.HeaderText = "Article";
            this.colart_Designation.Name = "colart_Designation";
            this.colart_Designation.ReadOnly = true;
            // 
            // colart_Abreviation
            // 
            this.colart_Abreviation.DataPropertyName = "art_Abreviation";
            this.colart_Abreviation.HeaderText = "Abreviation";
            this.colart_Abreviation.Name = "colart_Abreviation";
            this.colart_Abreviation.ReadOnly = true;
            // 
            // colart_Description
            // 
            this.colart_Description.DataPropertyName = "art_Description";
            this.colart_Description.HeaderText = "Description";
            this.colart_Description.Name = "colart_Description";
            this.colart_Description.ReadOnly = true;
            this.colart_Description.Visible = false;
            // 
            // colsvc_Nom
            // 
            this.colsvc_Nom.DataPropertyName = "svc_Nom";
            this.colsvc_Nom.HeaderText = "Service";
            this.colsvc_Nom.Name = "colsvc_Nom";
            this.colsvc_Nom.ReadOnly = true;
            this.colsvc_Nom.Visible = false;
            // 
            // colfam_Nom
            // 
            this.colfam_Nom.DataPropertyName = "fam_Nom";
            this.colfam_Nom.HeaderText = "Famille";
            this.colfam_Nom.Name = "colfam_Nom";
            this.colfam_Nom.ReadOnly = true;
            // 
            // menuDGV
            // 
            this.menuDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnColonne});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(134, 28);
            // 
            // btnColonne
            // 
            this.btnColonne.Name = "btnColonne";
            this.btnColonne.Size = new System.Drawing.Size(133, 24);
            this.btnColonne.Text = "Colonne";
            // 
            // menuRows
            // 
            this.menuRows.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReference});
            this.menuRows.Name = "menuDGV";
            this.menuRows.Size = new System.Drawing.Size(151, 28);
            // 
            // btnReference
            // 
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(150, 24);
            this.btnReference.Text = "Références";
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Location = new System.Drawing.Point(12, 21);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(366, 27);
            this.txtRecherche.TabIndex = 19;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // frmLArticleInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvArticle);
            this.Name = "frmLArticleInfo";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.frmLArticleInfo_Load);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnSupprimer, 0);
            this.Controls.SetChildIndex(this.dgvArticle, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.Controls.SetChildIndex(this.txtRecherche, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.menuRows.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvArticle;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
        private System.Windows.Forms.ContextMenuStrip menuRows;
        private System.Windows.Forms.ToolStripMenuItem btnReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Abreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsvc_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfam_Nom;
        private Controls.iText txtRecherche;
    }
}