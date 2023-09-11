namespace PL.Interfaces.Sub.Normal
{
    partial class frmAnalyseCodeBarre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAnalyser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGravee = new System.Windows.Forms.DataGridView();
            this.colbc_Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbc_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbc_N_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvInutilise = new System.Windows.Forms.DataGridView();
            this.colAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbxAnnee = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGravee)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInutilise)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnalyser
            // 
            this.btnAnalyser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyser.AutoSize = true;
            this.btnAnalyser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalyser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalyser.Location = new System.Drawing.Point(584, 12);
            this.btnAnalyser.Name = "btnAnalyser";
            this.btnAnalyser.Size = new System.Drawing.Size(280, 48);
            this.btnAnalyser.TabIndex = 40;
            this.btnAnalyser.Text = "Analyser";
            this.btnAnalyser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalyser.UseVisualStyleBackColor = true;
            this.btnAnalyser.Click += new System.EventHandler(this.btnAnalyser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.dgvGravee);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 382);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numéros de série gravés";
            // 
            // dgvGravee
            // 
            this.dgvGravee.AllowUserToAddRows = false;
            this.dgvGravee.AllowUserToDeleteRows = false;
            this.dgvGravee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGravee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGravee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGravee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGravee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvGravee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGravee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbc_Annee,
            this.colbc_Numero,
            this.colbc_N_Serie});
            this.dgvGravee.GridColor = System.Drawing.SystemColors.Control;
            this.dgvGravee.Location = new System.Drawing.Point(6, 37);
            this.dgvGravee.MultiSelect = false;
            this.dgvGravee.Name = "dgvGravee";
            this.dgvGravee.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGravee.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGravee.RowHeadersVisible = false;
            this.dgvGravee.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGravee.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGravee.RowTemplate.Height = 24;
            this.dgvGravee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGravee.Size = new System.Drawing.Size(410, 339);
            this.dgvGravee.TabIndex = 13;
            // 
            // colbc_Annee
            // 
            this.colbc_Annee.DataPropertyName = "bc_Annee";
            this.colbc_Annee.HeaderText = "Année";
            this.colbc_Annee.MinimumWidth = 6;
            this.colbc_Annee.Name = "colbc_Annee";
            this.colbc_Annee.ReadOnly = true;
            this.colbc_Annee.Visible = false;
            // 
            // colbc_Numero
            // 
            this.colbc_Numero.DataPropertyName = "bc_Numero";
            this.colbc_Numero.HeaderText = "Numéro";
            this.colbc_Numero.MinimumWidth = 6;
            this.colbc_Numero.Name = "colbc_Numero";
            this.colbc_Numero.ReadOnly = true;
            // 
            // colbc_N_Serie
            // 
            this.colbc_N_Serie.DataPropertyName = "bc_N_Serie";
            this.colbc_N_Serie.HeaderText = "Numéro de série";
            this.colbc_N_Serie.MinimumWidth = 6;
            this.colbc_N_Serie.Name = "colbc_N_Serie";
            this.colbc_N_Serie.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.dgvInutilise);
            this.groupBox2.Location = new System.Drawing.Point(448, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 382);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numéros de série inutilisés";
            // 
            // dgvInutilise
            // 
            this.dgvInutilise.AllowUserToAddRows = false;
            this.dgvInutilise.AllowUserToDeleteRows = false;
            this.dgvInutilise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInutilise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInutilise.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInutilise.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInutilise.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvInutilise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInutilise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnnee,
            this.colNumero});
            this.dgvInutilise.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInutilise.Location = new System.Drawing.Point(6, 37);
            this.dgvInutilise.MultiSelect = false;
            this.dgvInutilise.Name = "dgvInutilise";
            this.dgvInutilise.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInutilise.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInutilise.RowHeadersVisible = false;
            this.dgvInutilise.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInutilise.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInutilise.RowTemplate.Height = 24;
            this.dgvInutilise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInutilise.Size = new System.Drawing.Size(410, 339);
            this.dgvInutilise.TabIndex = 14;
            // 
            // colAnnee
            // 
            this.colAnnee.DataPropertyName = "Value";
            this.colAnnee.HeaderText = "Année";
            this.colAnnee.MinimumWidth = 6;
            this.colAnnee.Name = "colAnnee";
            this.colAnnee.ReadOnly = true;
            this.colAnnee.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "Key";
            this.colNumero.HeaderText = "Numéro";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbxAnnee);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 74);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Année";
            // 
            // cmbxAnnee
            // 
            this.cmbxAnnee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxAnnee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxAnnee.FormattingEnabled = true;
            this.cmbxAnnee.Location = new System.Drawing.Point(19, 30);
            this.cmbxAnnee.Name = "cmbxAnnee";
            this.cmbxAnnee.Size = new System.Drawing.Size(242, 28);
            this.cmbxAnnee.TabIndex = 44;
            this.cmbxAnnee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxAnnee_KeyPress);
            // 
            // frmAnalyseCodeBarre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAnalyser);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnalyseCodeBarre";
            this.Text = "Analyse numéro de série";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGravee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInutilise)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvGravee;
        public System.Windows.Forms.DataGridView dgvInutilise;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbxAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbc_Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbc_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbc_N_Serie;
    }
}