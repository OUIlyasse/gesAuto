namespace PL.Interfaces.Sub.LCRUD
{
    partial class frmArmoire
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new PL.Controls.iText();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvRayonnage = new System.Windows.Forms.DataGridView();
            this.colarm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarm_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarm_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrayo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRayonnage = new System.Windows.Forms.TextBox();
            this.lblRayonnage = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRayonnage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.FlatAppearance.BorderSize = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtRecherche);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.dgvRayonnage);
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 479);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Affichage";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Location = new System.Drawing.Point(194, 27);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(308, 27);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(6, 31);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 20);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "---";
            // 
            // dgvRayonnage
            // 
            this.dgvRayonnage.AllowUserToAddRows = false;
            this.dgvRayonnage.AllowUserToDeleteRows = false;
            this.dgvRayonnage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRayonnage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRayonnage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRayonnage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRayonnage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRayonnage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRayonnage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colarm_ID,
            this.colarm_Nom,
            this.colarm_Description,
            this.colrayo_ID});
            this.dgvRayonnage.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRayonnage.Location = new System.Drawing.Point(6, 61);
            this.dgvRayonnage.MultiSelect = false;
            this.dgvRayonnage.Name = "dgvRayonnage";
            this.dgvRayonnage.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRayonnage.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRayonnage.RowHeadersVisible = false;
            this.dgvRayonnage.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRayonnage.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRayonnage.RowTemplate.Height = 24;
            this.dgvRayonnage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRayonnage.Size = new System.Drawing.Size(496, 412);
            this.dgvRayonnage.TabIndex = 1;
            this.dgvRayonnage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRayonnage_CellDoubleClick);
            // 
            // colarm_ID
            // 
            this.colarm_ID.DataPropertyName = "arm_ID";
            this.colarm_ID.HeaderText = "Code armoire";
            this.colarm_ID.Name = "colarm_ID";
            this.colarm_ID.ReadOnly = true;
            this.colarm_ID.Visible = false;
            // 
            // colarm_Nom
            // 
            this.colarm_Nom.DataPropertyName = "arm_Nom";
            this.colarm_Nom.HeaderText = "Armoire";
            this.colarm_Nom.Name = "colarm_Nom";
            this.colarm_Nom.ReadOnly = true;
            // 
            // colarm_Description
            // 
            this.colarm_Description.DataPropertyName = "arm_Description";
            this.colarm_Description.HeaderText = "Description";
            this.colarm_Description.Name = "colarm_Description";
            this.colarm_Description.ReadOnly = true;
            this.colarm_Description.Visible = false;
            // 
            // colrayo_ID
            // 
            this.colrayo_ID.DataPropertyName = "rayo_ID";
            this.colrayo_ID.HeaderText = "Code rayonnage";
            this.colrayo_ID.Name = "colrayo_ID";
            this.colrayo_ID.ReadOnly = true;
            this.colrayo_ID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRayonnage);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 342);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(17, 156);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 147);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::PL.Properties.Resources.New_file_28px;
            this.btnNew.Location = new System.Drawing.Point(416, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 28);
            this.btnNew.TabIndex = 12;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Armoire";
            // 
            // txtRayonnage
            // 
            this.txtRayonnage.Location = new System.Drawing.Point(17, 76);
            this.txtRayonnage.Name = "txtRayonnage";
            this.txtRayonnage.Size = new System.Drawing.Size(420, 27);
            this.txtRayonnage.TabIndex = 0;
            this.txtRayonnage.Validating += new System.ComponentModel.CancelEventHandler(this.txtRayonnage_Validating);
            // 
            // lblRayonnage
            // 
            this.lblRayonnage.BackColor = System.Drawing.Color.PeachPuff;
            this.lblRayonnage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRayonnage.Location = new System.Drawing.Point(12, 9);
            this.lblRayonnage.Name = "lblRayonnage";
            this.lblRayonnage.Size = new System.Drawing.Size(454, 31);
            this.lblRayonnage.TabIndex = 7;
            this.lblRayonnage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmArmoire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1018, 503);
            this.Controls.Add(this.lblRayonnage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArmoire";
            this.ShowInTaskbar = false;
            this.Text = "Armoire";
            this.Load += new System.EventHandler(this.frmArmoire_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.lblRayonnage, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRayonnage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.iText txtRecherche;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvRayonnage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRayonnage;
        private System.Windows.Forms.Label lblRayonnage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrayo_ID;
    }
}