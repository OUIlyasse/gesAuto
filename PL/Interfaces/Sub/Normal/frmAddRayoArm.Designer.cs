namespace PL.Interfaces.Sub.Normal
{
    partial class frmAddRayoArm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRayoSupprimer = new System.Windows.Forms.Button();
            this.txtRayonnage = new System.Windows.Forms.TextBox();
            this.btnRayoModifier = new System.Windows.Forms.Button();
            this.btnRayoAjouter = new System.Windows.Forms.Button();
            this.gbArmoire = new System.Windows.Forms.GroupBox();
            this.btnSystematic = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnArmSupprimer = new System.Windows.Forms.Button();
            this.btnArmModifier = new System.Windows.Forms.Button();
            this.btnArmAjouter = new System.Windows.Forms.Button();
            this.txtArmoire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvArmoire = new System.Windows.Forms.DataGridView();
            this.colarm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarm_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarm_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrayo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbArmoire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmoire)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRayoSupprimer);
            this.groupBox1.Controls.Add(this.txtRayonnage);
            this.groupBox1.Controls.Add(this.btnRayoModifier);
            this.groupBox1.Controls.Add(this.btnRayoAjouter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rayonnage";
            // 
            // btnRayoSupprimer
            // 
            this.btnRayoSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRayoSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRayoSupprimer.FlatAppearance.BorderSize = 0;
            this.btnRayoSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRayoSupprimer.Image = global::PL.Properties.Resources.Supprimer_48;
            this.btnRayoSupprimer.Location = new System.Drawing.Point(627, 31);
            this.btnRayoSupprimer.Name = "btnRayoSupprimer";
            this.btnRayoSupprimer.Size = new System.Drawing.Size(49, 49);
            this.btnRayoSupprimer.TabIndex = 25;
            this.btnRayoSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRayoSupprimer.UseVisualStyleBackColor = true;
            // 
            // txtRayonnage
            // 
            this.txtRayonnage.Location = new System.Drawing.Point(32, 41);
            this.txtRayonnage.Name = "txtRayonnage";
            this.txtRayonnage.Size = new System.Drawing.Size(403, 28);
            this.txtRayonnage.TabIndex = 19;
            // 
            // btnRayoModifier
            // 
            this.btnRayoModifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRayoModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRayoModifier.FlatAppearance.BorderSize = 0;
            this.btnRayoModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRayoModifier.Image = global::PL.Properties.Resources.Modifier_48;
            this.btnRayoModifier.Location = new System.Drawing.Point(547, 31);
            this.btnRayoModifier.Name = "btnRayoModifier";
            this.btnRayoModifier.Size = new System.Drawing.Size(49, 49);
            this.btnRayoModifier.TabIndex = 24;
            this.btnRayoModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRayoModifier.UseVisualStyleBackColor = true;
            // 
            // btnRayoAjouter
            // 
            this.btnRayoAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRayoAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRayoAjouter.FlatAppearance.BorderSize = 0;
            this.btnRayoAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRayoAjouter.Image = global::PL.Properties.Resources.Ajouter_48;
            this.btnRayoAjouter.Location = new System.Drawing.Point(467, 31);
            this.btnRayoAjouter.Name = "btnRayoAjouter";
            this.btnRayoAjouter.Size = new System.Drawing.Size(49, 49);
            this.btnRayoAjouter.TabIndex = 23;
            this.btnRayoAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRayoAjouter.UseVisualStyleBackColor = true;
            this.btnRayoAjouter.Click += new System.EventHandler(this.btnRayoAjouter_Click);
            // 
            // gbArmoire
            // 
            this.gbArmoire.Controls.Add(this.btnSystematic);
            this.gbArmoire.Controls.Add(this.btnNew);
            this.gbArmoire.Controls.Add(this.btnArmSupprimer);
            this.gbArmoire.Controls.Add(this.btnArmModifier);
            this.gbArmoire.Controls.Add(this.btnArmAjouter);
            this.gbArmoire.Controls.Add(this.txtArmoire);
            this.gbArmoire.Controls.Add(this.label1);
            this.gbArmoire.Controls.Add(this.txtDescription);
            this.gbArmoire.Controls.Add(this.label5);
            this.gbArmoire.Controls.Add(this.dgvArmoire);
            this.gbArmoire.Location = new System.Drawing.Point(12, 118);
            this.gbArmoire.Name = "gbArmoire";
            this.gbArmoire.Size = new System.Drawing.Size(688, 335);
            this.gbArmoire.TabIndex = 1;
            this.gbArmoire.TabStop = false;
            this.gbArmoire.Text = "Armoire";
            // 
            // btnSystematic
            // 
            this.btnSystematic.Location = new System.Drawing.Point(549, 21);
            this.btnSystematic.Name = "btnSystematic";
            this.btnSystematic.Size = new System.Drawing.Size(133, 34);
            this.btnSystematic.TabIndex = 22;
            this.btnSystematic.Text = "Systématique";
            this.btnSystematic.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::PL.Properties.Resources.Fichier_48;
            this.btnNew.Location = new System.Drawing.Point(20, 270);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(49, 49);
            this.btnNew.TabIndex = 21;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnArmSupprimer
            // 
            this.btnArmSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArmSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArmSupprimer.FlatAppearance.BorderSize = 0;
            this.btnArmSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmSupprimer.Image = global::PL.Properties.Resources.Supprimer_48;
            this.btnArmSupprimer.Location = new System.Drawing.Point(260, 270);
            this.btnArmSupprimer.Name = "btnArmSupprimer";
            this.btnArmSupprimer.Size = new System.Drawing.Size(49, 49);
            this.btnArmSupprimer.TabIndex = 20;
            this.btnArmSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArmSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnArmModifier
            // 
            this.btnArmModifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArmModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArmModifier.FlatAppearance.BorderSize = 0;
            this.btnArmModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmModifier.Image = global::PL.Properties.Resources.Modifier_48;
            this.btnArmModifier.Location = new System.Drawing.Point(180, 270);
            this.btnArmModifier.Name = "btnArmModifier";
            this.btnArmModifier.Size = new System.Drawing.Size(49, 49);
            this.btnArmModifier.TabIndex = 19;
            this.btnArmModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArmModifier.UseVisualStyleBackColor = true;
            // 
            // btnArmAjouter
            // 
            this.btnArmAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArmAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArmAjouter.FlatAppearance.BorderSize = 0;
            this.btnArmAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmAjouter.Image = global::PL.Properties.Resources.Ajouter_48;
            this.btnArmAjouter.Location = new System.Drawing.Point(100, 270);
            this.btnArmAjouter.Name = "btnArmAjouter";
            this.btnArmAjouter.Size = new System.Drawing.Size(49, 49);
            this.btnArmAjouter.TabIndex = 5;
            this.btnArmAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArmAjouter.UseVisualStyleBackColor = true;
            // 
            // txtArmoire
            // 
            this.txtArmoire.Location = new System.Drawing.Point(6, 61);
            this.txtArmoire.Name = "txtArmoire";
            this.txtArmoire.Size = new System.Drawing.Size(326, 28);
            this.txtArmoire.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Armoire";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 119);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(330, 128);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // dgvArmoire
            // 
            this.dgvArmoire.AllowUserToAddRows = false;
            this.dgvArmoire.AllowUserToDeleteRows = false;
            this.dgvArmoire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArmoire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArmoire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArmoire.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArmoire.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvArmoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmoire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colarm_ID,
            this.colarm_Nom,
            this.colarm_Description,
            this.colrayo_ID});
            this.dgvArmoire.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArmoire.Location = new System.Drawing.Point(342, 61);
            this.dgvArmoire.MultiSelect = false;
            this.dgvArmoire.Name = "dgvArmoire";
            this.dgvArmoire.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArmoire.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArmoire.RowHeadersVisible = false;
            this.dgvArmoire.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArmoire.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArmoire.RowTemplate.Height = 24;
            this.dgvArmoire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArmoire.Size = new System.Drawing.Size(340, 268);
            this.dgvArmoire.TabIndex = 3;
            // 
            // colarm_ID
            // 
            this.colarm_ID.DataPropertyName = "arm_ID";
            this.colarm_ID.HeaderText = "Code";
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
            this.colrayo_ID.HeaderText = "Code rayo";
            this.colrayo_ID.Name = "colrayo_ID";
            this.colrayo_ID.ReadOnly = true;
            this.colrayo_ID.Visible = false;
            // 
            // frmAddRayoArm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 465);
            this.Controls.Add(this.gbArmoire);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRayoArm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rayonnage et armoire";
            this.Load += new System.EventHandler(this.frmAddRayoArm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbArmoire.ResumeLayout(false);
            this.gbArmoire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmoire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbArmoire;
        public System.Windows.Forms.DataGridView dgvArmoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarm_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrayo_ID;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArmoire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArmAjouter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnArmSupprimer;
        private System.Windows.Forms.Button btnArmModifier;
        private System.Windows.Forms.Button btnSystematic;
        private System.Windows.Forms.Button btnRayoSupprimer;
        private System.Windows.Forms.TextBox txtRayonnage;
        private System.Windows.Forms.Button btnRayoModifier;
        private System.Windows.Forms.Button btnRayoAjouter;
    }
}