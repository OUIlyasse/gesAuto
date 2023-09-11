﻿namespace PL.Interfaces.Sub.Normal
{
    partial class frmStock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colvl_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colart_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEtatExplicatif = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.entreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iText1 = new PL.Controls.iText();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colvl_Marque,
            this.colart_Designation,
            this.colReference,
            this.colQuantite});
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(12, 52);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(958, 589);
            this.dgvStock.TabIndex = 3;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            this.dgvStock.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvStock_CellContextMenuStripNeeded);
            this.dgvStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStock_CellFormatting);
            this.dgvStock.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStock_CellMouseDown);
            // 
            // colvl_Marque
            // 
            this.colvl_Marque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colvl_Marque.DataPropertyName = "vl_Marque";
            this.colvl_Marque.FillWeight = 270.7086F;
            this.colvl_Marque.HeaderText = "Véhicule";
            this.colvl_Marque.MinimumWidth = 6;
            this.colvl_Marque.Name = "colvl_Marque";
            this.colvl_Marque.ReadOnly = true;
            this.colvl_Marque.Width = 160;
            // 
            // colart_Designation
            // 
            this.colart_Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colart_Designation.DataPropertyName = "art_Designation";
            this.colart_Designation.FillWeight = 8.380396F;
            this.colart_Designation.HeaderText = "Article";
            this.colart_Designation.MinimumWidth = 6;
            this.colart_Designation.Name = "colart_Designation";
            this.colart_Designation.ReadOnly = true;
            // 
            // colReference
            // 
            this.colReference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReference.DataPropertyName = "ref_reference";
            this.colReference.FillWeight = 38.32801F;
            this.colReference.HeaderText = "Reference";
            this.colReference.MinimumWidth = 6;
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            this.colReference.Width = 200;
            // 
            // colQuantite
            // 
            this.colQuantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuantite.DataPropertyName = "mvt_Qte";
            this.colQuantite.FillWeight = 175.1565F;
            this.colQuantite.HeaderText = "Quantite";
            this.colQuantite.MinimumWidth = 6;
            this.colQuantite.Name = "colQuantite";
            this.colQuantite.ReadOnly = true;
            this.colQuantite.Width = 150;
            // 
            // menuDGV
            // 
            this.menuDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEtatExplicatif,
            this.toolStripSeparator2,
            this.entreesToolStripMenuItem,
            this.sortiesToolStripMenuItem,
            this.retoursToolStripMenuItem,
            this.toolStripSeparator1,
            this.journalToolStripMenuItem});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(211, 164);
            this.menuDGV.Opening += new System.ComponentModel.CancelEventHandler(this.menuDGV_Opening);
            // 
            // btnEtatExplicatif
            // 
            this.btnEtatExplicatif.Name = "btnEtatExplicatif";
            this.btnEtatExplicatif.Size = new System.Drawing.Size(210, 24);
            this.btnEtatExplicatif.Text = "Etat Explicatif";
            this.btnEtatExplicatif.Click += new System.EventHandler(this.btnEtatExplicatif_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // entreesToolStripMenuItem
            // 
            this.entreesToolStripMenuItem.Name = "entreesToolStripMenuItem";
            this.entreesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.entreesToolStripMenuItem.Text = "Entrees";
            this.entreesToolStripMenuItem.Click += new System.EventHandler(this.entreesToolStripMenuItem_Click);
            // 
            // sortiesToolStripMenuItem
            // 
            this.sortiesToolStripMenuItem.Name = "sortiesToolStripMenuItem";
            this.sortiesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.sortiesToolStripMenuItem.Text = "Sorties";
            this.sortiesToolStripMenuItem.Click += new System.EventHandler(this.sortiesToolStripMenuItem_Click);
            // 
            // retoursToolStripMenuItem
            // 
            this.retoursToolStripMenuItem.Name = "retoursToolStripMenuItem";
            this.retoursToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.retoursToolStripMenuItem.Text = "Retours";
            this.retoursToolStripMenuItem.Click += new System.EventHandler(this.retoursToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.journalToolStripMenuItem.Text = "Journal";
            this.journalToolStripMenuItem.Click += new System.EventHandler(this.journalToolStripMenuItem_Click);
            // 
            // iText1
            // 
            this.iText1.Location = new System.Drawing.Point(12, 12);
            this.iText1.Name = "iText1";
            this.iText1.Size = new System.Drawing.Size(461, 27);
            this.iText1.TabIndex = 5;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.iText1);
            this.Controls.Add(this.dgvStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Actuel";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvStock;
        private Controls.iText iText1;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem entreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvl_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colart_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantite;
        private System.Windows.Forms.ToolStripMenuItem btnEtatExplicatif;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}