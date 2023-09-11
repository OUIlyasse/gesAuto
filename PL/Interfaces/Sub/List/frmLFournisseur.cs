using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLFournisseur : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idFournisseur;

        #endregion Variables

        #region Overrides

        public override void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        public override void getData()
        {
            dgvFournisseur.DataSource = db.Select_Fournisseur().ToList();
            CountRow(db.Count_Fournisseur().FirstOrDefault());
        }

        public override void openForm()
        {
            frmFournisseur form = new frmFournisseur(this);
            form.Text = "Ajouter un fournisseur";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce fournisseur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Fournisseur_Temp(idFournisseur);
                    iTools.sucMsg("Information", "Votre fournisseur a bien supprimé");
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
            base.setToolTip("un fournisseur");
        }

        #endregion Overrides

        #region Constracteur

        public frmLFournisseur()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void dgvFournisseur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFournisseur.Rows[e.RowIndex];
            idFournisseur = int.Parse(row.Cells[colfrns_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Fournisseur vl = db.Show_Fournisseur_By_ID(idFournisseur).FirstOrDefault();
            frmFournisseur form = new frmFournisseur(this, vl);
            form.Text = "Modifier un fournisseur";
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvFournisseur.DataSource = db.Search_Fournisseur(txtSearch.Text);
            CountRow(dgvFournisseur.Rows.Count);
        }

        private void dgvFournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvFournisseur.Rows[e.RowIndex];
                idFournisseur = int.Parse(row.Cells[colfrns_ID.Name].Value.ToString());
                if (idFournisseur > 0)
                    Verify_Buttons(false);
            }
        }

        private void dgvFournisseur_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
            else
                e.ContextMenuStrip = menuRows;
            idFournisseur = (int)dgvFournisseur[colfrns_ID.Index, e.RowIndex].Value;
        }

        private void dgvFournisseur_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dgvFournisseur.CurrentCell = dgvFournisseur[e.ColumnIndex, e.RowIndex];
                idFournisseur = (int)dgvFournisseur[colfrns_ID.Index, e.RowIndex].Value;
            }
        }

        private void btnRepresentant_Click(object sender, EventArgs e)
        {
            frmLRepresentant form = new frmLRepresentant(idFournisseur);
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}