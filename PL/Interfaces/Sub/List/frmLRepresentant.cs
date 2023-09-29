using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLRepresentant : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idFournisseur, idRepresentant;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Fournisseur", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Fournisseur", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        #endregion Permission

        #region Overrides

        public override void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        public override void getData()
        {
            dgvRepresentant.DataSource = db.Select_Representant(idFournisseur).ToList();
            CountRow(dgvRepresentant.Rows.Count);
        }

        public override void openForm()
        {
            frmRepresentant form = new frmRepresentant(this, idFournisseur);
            form.Text = "Ajouter un representant";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce representant", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Representant_Temp(idRepresentant);
                    iTools.sucMsg("Information", "Votre representant a bien supprimé");
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
            base.setToolTip("un representant");
        }

        #endregion Overrides

        #region Constracteur

        public frmLRepresentant(int idFournisseur)
        {
            InitializeComponent();
            this.idFournisseur = idFournisseur;
        }

        #endregion Constracteur

        private void dgvRepresentant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvRepresentant.Rows[e.RowIndex];
            idRepresentant = int.Parse(row.Cells[colrep_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Representant representant = db.Show_Representant_By_ID(idRepresentant).FirstOrDefault();
            frmRepresentant form = new frmRepresentant(this, idFournisseur, representant);
            form.Text = "Modifier un representant";
            form.ShowDialog();
        }

        private void frmLRepresentant_Load(object sender, EventArgs e)
        {
            Refresh_Button_Ajouter();
        }

        private void dgvRepresentant_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRepresentant.CurrentRow != null)
            {
                idRepresentant = int.Parse(dgvRepresentant.CurrentRow.Cells[colrep_ID.Name].Value.ToString());
                Verify_Buttons(false);
                Refresh_Button_Supprimer();
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecherche.Text))
                getData();
            else
            {
                dgvRepresentant.DataSource = db.Search_Representant(txtRecherche.Text, idFournisseur);
                CountRow(dgvRepresentant.Rows.Count);
            }
        }

        private void dgvRepresentant_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}