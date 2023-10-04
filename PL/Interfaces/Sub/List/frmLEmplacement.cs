using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLEmplacement : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idEmplacement;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
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
            dgvEmplacement.DataSource = db.Select_v_Emplacement().ToList();
            CountRow(dgvEmplacement.Rows.Count);
        }

        public override void openForm()
        {
            frmAddEmplacement form = new frmAddEmplacement(this);
            form.Text = "Ajouter un emplacement";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cet emplacement", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Emplacement(idEmplacement);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un emplacement");
                    iTools.sucMsg("Information", "Votre emplacement a bien supprimé");
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
            base.setToolTip("un emplacement");
        }

        #endregion Overrides

        #region Constracteur

        public frmLEmplacement()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void dgvEmplacement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvEmplacement.Rows[e.RowIndex];
            idEmplacement = int.Parse(row.Cells[coleplc_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Emplacement vl = db.Show_Emplacement_By_ID(idEmplacement).FirstOrDefault();
            frmAddEmplacement form = new frmAddEmplacement(this, vl);
            form.Text = "Modifier un emplacement";
            form.ShowDialog();
        }

        private void dgvEmplacement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmplacement.CurrentRow != null)
            {
                idEmplacement = int.Parse(dgvEmplacement.CurrentRow.Cells[coleplc_ID.Name].Value.ToString());
                Verify_Buttons(false);
                if (Properties.Settings.Default.idUtilisateur != 0)
                    Refresh_Button_Supprimer();
            }
            //bool status = dgvEmplacement.SelectedRows.Count > 0;
            //Verify_Buttons(status);
            //Refresh_Button_Supprimer();
        }

        private void frmLEmplacement_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.idUtilisateur != 0)
                Refresh_Button_Ajouter();
            CountRow(dgvEmplacement.Rows.Count);
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
                getData();
            else
            {
                dgvEmplacement.DataSource = db.Search_Emplacement(txtRecherche.Text);
                CountRow(dgvEmplacement.Rows.Count);
            }
        }
    }
}