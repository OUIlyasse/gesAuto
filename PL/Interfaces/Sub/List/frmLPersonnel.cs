using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLPersonnel : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idPersonnel;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Personnel", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Personnel", getID_Lists("Gestion")).FirstOrDefault();
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
            dgvPersonnel.DataSource = db.Select_pers_Affecte().ToList();
            CountRow(db.Count_pers_Affecte().FirstOrDefault());
        }

        public override void openForm()
        {
            frmPersonnel form = new frmPersonnel(this);
            form.Text = "Ajouter un personnel";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce personnel", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_pers_Affecte_Temp(idPersonnel);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un personnel");
                    iTools.sucMsg("Information", "Votre personnel a bien supprimé");
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
            base.setToolTip("un personnel");
        }

        #endregion Overrides

        #region Constarteur

        public frmLPersonnel()
        {
            InitializeComponent();
        }

        #endregion Constarteur

        private void dgvPersonnel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvPersonnel.Rows[e.RowIndex];
            idPersonnel = int.Parse(row.Cells[colpers_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            pers_Affecte vl = db.Show_pers_Affecte_By_ID(idPersonnel).FirstOrDefault();
            frmPersonnel form = new frmPersonnel(this, vl);
            form.Text = "Modifier un personnel";
            form.ShowDialog();
        }

        private void dgvPersonnel_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }

        private void frmLPersonnel_Load(object sender, EventArgs e)
        {
            Refresh_Button_Ajouter();
        }

        private void dgvPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonnel.CurrentRow != null)
            {
                idPersonnel = int.Parse(dgvPersonnel.CurrentRow.Cells[colpers_ID.Name].Value.ToString());
                Verify_Buttons(false);
                Refresh_Button_Supprimer();
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
                getData();
            else
            {
                dgvPersonnel.DataSource = db.Search_Personnel(txtRecherche.Text);
                CountRow(dgvPersonnel.Rows.Count);
            }
        }
    }
}