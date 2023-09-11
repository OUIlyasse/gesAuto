﻿using DAL.DB;
using PL.iForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Tools;
using Tools.iUtile;

namespace PL.Interfaces.Sub.LCRUD
{
    public partial class frmGrade : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idGrade;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MaxID_Grade().FirstOrDefault();
        }

        private void setValue(Grade f)
        {
            txtGrade.Text = f.grd_Grade;
            txtDescription.Text = f.grd_Description;
        }

        private void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        #endregion Codes

        #region Overrides

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtGrade.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGrade.Focus();
                    return;
                }
                var rs = db.Insert_Grade(maxID(), txtGrade.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le grade {txtGrade.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGrade.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le grade a bien ajouté");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Add_Data();
        }

        public override void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtGrade.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGrade.Focus();
                    return;
                }
                var rs = db.Update_Grade(idGrade, txtGrade.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le grade {txtGrade.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGrade.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le grade a bien modifié");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Update_Data();
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce grade {txtGrade.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Grade_Temp(idGrade);
                    iTools.sucMsg("Information", "Votre grade  a bien supprimé");
                    newRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                base.Delete_Data();
            }
        }

        public override void getData()
        {
            dgvGrade.DataSource = db.Select_Grade().ToList();
            CountRow(db.Count_Grade().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtGrade.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un grade");
        }

        #endregion Overrides

        #region Constracteur

        public frmGrade()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        #region Validating

        private void txtGrade_Validating(object sender, CancelEventArgs e)
        {
            txtGrade.Text = iTools.ValidateText(txtGrade.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvGrade.DataSource = db.Search_Grade(txtSearch.Text);
            CountRow(dgvGrade.Rows.Count);
        }

        #endregion Search

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvGrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvGrade.Rows[e.RowIndex];
            idGrade = int.Parse(row.Cells[colgrd_ID.Name].Value.ToString());
            Grade grade = db.Show_Grade_By_ID(idGrade).FirstOrDefault();
            setValue(grade);
            Verify_Buttons(false);
        }

        private void dgvGrade_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}