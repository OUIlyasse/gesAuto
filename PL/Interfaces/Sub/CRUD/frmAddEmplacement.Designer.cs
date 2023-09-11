namespace PL.Interfaces.Sub.CRUD
{
    partial class frmAddEmplacement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbxArmoire = new System.Windows.Forms.ComboBox();
            this.cmbxRayonnage = new System.Windows.Forms.ComboBox();
            this.cmbxMagasin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxReference = new System.Windows.Forms.ComboBox();
            this.cmbxArticle = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 389);
            this.groupBox1.Size = new System.Drawing.Size(808, 100);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbxArmoire);
            this.groupBox2.Controls.Add(this.cmbxRayonnage);
            this.groupBox2.Controls.Add(this.cmbxMagasin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbxReference);
            this.groupBox2.Controls.Add(this.cmbxArticle);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 371);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // cmbxArmoire
            // 
            this.cmbxArmoire.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxArmoire.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxArmoire.FormattingEnabled = true;
            this.cmbxArmoire.Location = new System.Drawing.Point(31, 323);
            this.cmbxArmoire.Name = "cmbxArmoire";
            this.cmbxArmoire.Size = new System.Drawing.Size(382, 28);
            this.cmbxArmoire.TabIndex = 18;
            // 
            // cmbxRayonnage
            // 
            this.cmbxRayonnage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxRayonnage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxRayonnage.FormattingEnabled = true;
            this.cmbxRayonnage.Location = new System.Drawing.Point(31, 258);
            this.cmbxRayonnage.Name = "cmbxRayonnage";
            this.cmbxRayonnage.Size = new System.Drawing.Size(382, 28);
            this.cmbxRayonnage.TabIndex = 17;
            this.cmbxRayonnage.SelectedIndexChanged += new System.EventHandler(this.cmbxRayonnage_SelectedIndexChanged);
            // 
            // cmbxMagasin
            // 
            this.cmbxMagasin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxMagasin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxMagasin.FormattingEnabled = true;
            this.cmbxMagasin.Location = new System.Drawing.Point(31, 63);
            this.cmbxMagasin.Name = "cmbxMagasin";
            this.cmbxMagasin.Size = new System.Drawing.Size(382, 28);
            this.cmbxMagasin.TabIndex = 16;
            this.cmbxMagasin.SelectedIndexChanged += new System.EventHandler(this.cmbxMagasin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Armoire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rayonnage";
            // 
            // cmbxReference
            // 
            this.cmbxReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxReference.FormattingEnabled = true;
            this.cmbxReference.Location = new System.Drawing.Point(31, 193);
            this.cmbxReference.Name = "cmbxReference";
            this.cmbxReference.Size = new System.Drawing.Size(382, 28);
            this.cmbxReference.TabIndex = 3;
            // 
            // cmbxArticle
            // 
            this.cmbxArticle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxArticle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxArticle.FormattingEnabled = true;
            this.cmbxArticle.Location = new System.Drawing.Point(31, 128);
            this.cmbxArticle.Name = "cmbxArticle";
            this.cmbxArticle.Size = new System.Drawing.Size(382, 28);
            this.cmbxArticle.TabIndex = 2;
            this.cmbxArticle.SelectedIndexChanged += new System.EventHandler(this.cmbxArticle_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(440, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(338, 288);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Référence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magasin";
            // 
            // frmAddEmplacement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(808, 489);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmAddEmplacement";
            this.Text = "Ajouter un emplacement";
            this.Load += new System.EventHandler(this.frmAddEmplacement_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxReference;
        private System.Windows.Forms.ComboBox cmbxArticle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxArmoire;
        private System.Windows.Forms.ComboBox cmbxRayonnage;
        private System.Windows.Forms.ComboBox cmbxMagasin;
        private System.Windows.Forms.Label label2;
    }
}