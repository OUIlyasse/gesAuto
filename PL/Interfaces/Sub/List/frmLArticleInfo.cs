﻿using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLArticleInfo : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idArticle;
        private int idService = Properties.Settings.Default.idService;

        #endregion Variables

        #region Overrides

        public override void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        public override void getData()
        {
            dgvArticle.DataSource = db.Select_Article_Info(idService).ToList();
            CountRow(dgvArticle.Rows.Count);
        }

        public override void openForm()
        {
            frmArticleInfo form = new frmArticleInfo(this);
            form.Text = "Ajouter un article";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cet article", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Article_Info_Temp(idArticle);
                    iTools.sucMsg("Information", "Votre article a bien supprimé");
                    getData();
                    Verify_Buttons(true);
                }
                catch (Exception ex)
                {
                    iTools.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
            base.Delete_Data_By_Row();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un article");
        }

        #endregion Overrides

        #region Constracteur

        public frmLArticleInfo()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void dgvArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvArticle.Rows[e.RowIndex];
            idArticle = int.Parse(row.Cells[colart_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Article_Info vl = db.Show_Article_Info_By_ID(idArticle).FirstOrDefault();
            frmArticleInfo form = new frmArticleInfo(this, vl);
            form.Text = "Modifier un article";
            form.ShowDialog();
        }

        private void dgvArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvArticle.Rows[e.RowIndex];
                idArticle = int.Parse(row.Cells[colart_ID.Name].Value.ToString());
                if (idArticle > 0)
                    Verify_Buttons(false);
            }
        }

        private void dgvArticle_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
            else
                e.ContextMenuStrip = menuRows;
            idArticle = (int)dgvArticle[colart_ID.Index, e.RowIndex].Value;
        }

        private void dgvArticle_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dgvArticle.CurrentCell = dgvArticle[e.ColumnIndex, e.RowIndex];
                idArticle = (int)dgvArticle[colart_ID.Index, e.RowIndex].Value;
            }
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            frmLReference form = new frmLReference(idArticle);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvArticle.DataSource = db.Search_Article_Info(txtSearch.Text, idService);
            CountRow(dgvArticle.Rows.Count);
        }
    }
}