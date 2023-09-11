namespace PL.Interfaces.Sub.CRUD
{
    partial class frmRefEBon
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
            this.cmbxReference = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQteDemandee = new PL.Controls.iText();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxReference
            // 
            this.cmbxReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxReference.DisplayMember = "art_Designation";
            this.cmbxReference.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.cmbxReference.FormattingEnabled = true;
            this.cmbxReference.Location = new System.Drawing.Point(188, 31);
            this.cmbxReference.Name = "cmbxReference";
            this.cmbxReference.Size = new System.Drawing.Size(371, 28);
            this.cmbxReference.TabIndex = 0;
            this.cmbxReference.ValueMember = "art_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Référence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantite";
            // 
            // txtQteDemandee
            // 
            this.txtQteDemandee.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtQteDemandee.Location = new System.Drawing.Point(188, 75);
            this.txtQteDemandee.Name = "txtQteDemandee";
            this.txtQteDemandee.Size = new System.Drawing.Size(371, 28);
            this.txtQteDemandee.TabIndex = 1;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(535, 124);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(24, 20);
            this.lblSum.TabIndex = 30;
            this.lblSum.Text = "---";
            this.lblSum.Visible = false;
            // 
            // frmRefEBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 260);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtQteDemandee);
            this.Controls.Add(this.cmbxReference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRefEBon";
            this.Load += new System.EventHandler(this.frmRefEBon_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbxReference, 0);
            this.Controls.SetChildIndex(this.txtQteDemandee, 0);
            this.Controls.SetChildIndex(this.lblSum, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxReference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Controls.iText txtQteDemandee;
        private System.Windows.Forms.Label lblSum;
    }
}