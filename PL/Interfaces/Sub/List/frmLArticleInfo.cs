using DAL.DB;
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
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Code

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Article", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Article", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        #endregion Code

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
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un article");
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

        private void frmLArticleInfo_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.idUtilisateur != 0)
                Refresh_Button_Ajouter();
            CountRow(dgvArticle.Rows.Count);
        }

        private void dgvArticle_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticle.CurrentRow != null)
            {
                idArticle = int.Parse(dgvArticle.CurrentRow.Cells[colart_ID.Name].Value.ToString());
                Verify_Buttons(false);
                if (Properties.Settings.Default.idUtilisateur != 0)
                    Refresh_Button_Supprimer();
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
                getData();
            else
            {
                dgvArticle.DataSource = db.Search_Article_Info(txtRecherche.Text, idService);
                CountRow(dgvArticle.Rows.Count);
            }
        }
    }
}