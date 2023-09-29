using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLVehicule : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idVL;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Véhicule", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Véhicule", getID_Lists("Gestion")).FirstOrDefault();
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
            dgvVL.DataSource = db.Select_Vehicule().ToList();
            CountRow(db.Count_Vehicule().FirstOrDefault());
        }

        public override void openForm()
        {
            frmVehicule form = new frmVehicule(this);
            form.Text = "Ajouter un véhicule";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce véhicule", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Vehicule_Temp(idVL);
                    iTools.sucMsg("Information", "Votre véhicule a bien supprimé");
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
            base.setToolTip("un véhicule");
        }

        #endregion Overrides

        #region Constracteur

        public frmLVehicule()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void dgvVL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvVL.Rows[e.RowIndex];
            idVL = int.Parse(row.Cells[colvl_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Vehicule vl = db.Show_Vehicule_By_ID(idVL).FirstOrDefault();
            frmVehicule form = new frmVehicule(this, vl);
            form.Text = "Modifier un véhicule";
            form.ShowDialog();
        }

        private void dgvVL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvVL_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }

        private void frmLVehicule_Load(object sender, EventArgs e)
        {
            Refresh_Button_Ajouter();
        }

        private void dgvVL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVL.CurrentRow != null)
            {
                idVL = int.Parse(dgvVL.CurrentRow.Cells[colvl_ID.Name].Value.ToString());
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
                dgvVL.DataSource = db.Search_Vehicule(txtRecherche.Text);
                CountRow(dgvVL.Rows.Count);
            }
        }
    }
}