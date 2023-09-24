using DAL.DB;
using PL.iForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Tools;
using Tools.iUtile;

namespace PL.Interfaces.Sub.LCRUD
{
    public partial class frmFamille : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idFamille;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Famille", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Famille", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Famille", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private int maxID()
        {
            return (int)db.MaxID_Famille().FirstOrDefault();
        }

        private void setValue(Famille f)
        {
            txtAnnee.Text = f.fam_Nom;
            txtDescription.Text = f.fam_Description;
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
                if (string.IsNullOrEmpty(txtAnnee.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnnee.Focus();
                    return;
                }
                var rs = db.Insert_Famille(maxID(), txtAnnee.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"La famille {txtAnnee.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAnnee.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "La famille a bien ajouté");
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
                if (string.IsNullOrEmpty(txtAnnee.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnnee.Focus();
                    return;
                }
                var rs = db.Update_Famille(idFamille, txtAnnee.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"La famille {txtAnnee.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAnnee.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "La famille a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette famille {txtAnnee.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Famille_Temp(idFamille);
                    iTools.sucMsg("Information", "Votre famille  a bien supprimé");
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
            dgvFamille.DataSource = db.Select_Famille().ToList();
            CountRow(db.Count_Famille().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtAnnee.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("une famille");
        }

        #endregion Overrides

        #region Constracteur

        public frmFamille()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        #region Validating

        private void txtFamille_Validating(object sender, CancelEventArgs e)
        {
            txtAnnee.Text = iTools.ValidateText(txtAnnee.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        private void frmFamille_Load(object sender, EventArgs e)
        {
            Refresh_Button_Ajouter();
        }

        private void dgvFamille_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvFamille.Rows[e.RowIndex];
            idFamille = int.Parse(row.Cells[colfam_ID.Name].Value.ToString());
            Famille famille = db.Show_Famille_By_ID(idFamille).FirstOrDefault();
            setValue(famille);
            Verify_Buttons(false);
            Refresh_Button_Modifier();
            Refresh_Button_Supprimer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvFamille.DataSource = db.Search_Famille(txtSearch.Text);
            CountRow(dgvFamille.Rows.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvFamille_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}