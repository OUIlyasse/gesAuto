namespace PL.Interfaces.Sub.Normal
{
    partial class frmEtatExplicatif
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
            this.dgvEtatExplicatif = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colUMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtatExplicatif)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEtatExplicatif
            // 
            this.dgvEtatExplicatif.AllowUserToAddRows = false;
            this.dgvEtatExplicatif.AllowUserToDeleteRows = false;
            this.dgvEtatExplicatif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEtatExplicatif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtatExplicatif.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEtatExplicatif.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEtatExplicatif.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEtatExplicatif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtatExplicatif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUMesure,
            this.colQte});
            this.dgvEtatExplicatif.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEtatExplicatif.Location = new System.Drawing.Point(12, 181);
            this.dgvEtatExplicatif.MultiSelect = false;
            this.dgvEtatExplicatif.Name = "dgvEtatExplicatif";
            this.dgvEtatExplicatif.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtatExplicatif.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEtatExplicatif.RowHeadersVisible = false;
            this.dgvEtatExplicatif.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEtatExplicatif.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEtatExplicatif.RowTemplate.Height = 24;
            this.dgvEtatExplicatif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtatExplicatif.Size = new System.Drawing.Size(559, 346);
            this.dgvEtatExplicatif.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReference);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblArticle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblVL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 135);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // lblReference
            // 
            this.lblReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReference.Location = new System.Drawing.Point(122, 96);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(416, 20);
            this.lblReference.TabIndex = 28;
            this.lblReference.Text = "---";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Référence";
            // 
            // lblArticle
            // 
            this.lblArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticle.Location = new System.Drawing.Point(122, 61);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(416, 20);
            this.lblArticle.TabIndex = 26;
            this.lblArticle.Text = "---";
            this.lblArticle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Article";
            // 
            // lblVL
            // 
            this.lblVL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVL.Location = new System.Drawing.Point(122, 26);
            this.lblVL.Name = "lblVL";
            this.lblVL.Size = new System.Drawing.Size(416, 20);
            this.lblVL.TabIndex = 24;
            this.lblVL.Text = "---";
            this.lblVL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Véhicule";
            // 
            // colUMesure
            // 
            this.colUMesure.DataPropertyName = "unit_M_Nom";
            this.colUMesure.FillWeight = 5.076141F;
            this.colUMesure.HeaderText = "Unite de mesure";
            this.colUMesure.Name = "colUMesure";
            this.colUMesure.ReadOnly = true;
            // 
            // colQte
            // 
            this.colQte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQte.DataPropertyName = "mvt_Qte";
            this.colQte.FillWeight = 194.9239F;
            this.colQte.HeaderText = "Quantite";
            this.colQte.Name = "colQte";
            this.colQte.ReadOnly = true;
            this.colQte.Width = 130;
            // 
            // frmEtatExplicatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEtatExplicatif);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEtatExplicatif";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat Explicatif";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtatExplicatif)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvEtatExplicatif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
    }
}