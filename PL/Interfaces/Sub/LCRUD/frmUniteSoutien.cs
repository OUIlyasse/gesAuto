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
    public partial class frmUniteSoutien : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idUniteSoutien;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Unite de soutien", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Unite de soutien", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Unite de soutien", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void LoadVille()
        {
            cmbxVille.DisplayMember = "vil_Nom";
            cmbxVille.ValueMember = "vil_ID";
            cmbxVille.DataSource = db.Select_Ville().ToList();
            cmbxVille.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Unite_Soutien().FirstOrDefault();
        }

        private void setValue(Unite_Soutien f)
        {
            txtUnite.Text = f.unt_Unite;
            cmbxVille.SelectedValue = f.vil_ID;
            txtDescription.Text = f.unt_Description;
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
                if (string.IsNullOrEmpty(txtUnite.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnite.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Insert_Unite_Soutien(maxID(), txtUnite.Text, (int)cmbxVille.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'unité de soutien {txtUnite.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnite.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un unité de soutien");
                        iTools.sucMsg("Information", "L'unité de soutien a bien ajouté");
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
                if (string.IsNullOrEmpty(txtUnite.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnite.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Update_Unite_Soutien(idUniteSoutien, txtUnite.Text, (int)cmbxVille.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'unité de soutien {txtUnite.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnite.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un unité de soutien");
                        iTools.sucMsg("Information", "L'unité de soutien a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette unité de soutien {txtUnite.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Unite_Soutien_Temp(idUniteSoutien);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un unité de soutien");
                    iTools.sucMsg("Information", "Votre unité de soutien  a bien supprimé");
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
            dgvUniteSoutien.DataSource = db.Select_Unite_Soutien().ToList();
            CountRow(db.Count_Unite_Soutien().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtUnite.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("une unité de soutien");
        }

        #endregion Overrides

        #region Constracteurs

        public frmUniteSoutien()
        {
            InitializeComponent();
        }

        #endregion Constracteurs

        #region Validating

        private void txtUnite_Validating(object sender, CancelEventArgs e)
        {
            txtUnite.Text = iTools.ValidateText(txtUnite.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        private void dgvUniteSoutien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvUniteSoutien.Rows[e.RowIndex];
            idUniteSoutien = int.Parse(row.Cells[colunt_ID.Name].Value.ToString());
            Unite_Soutien us = db.Show_Unite_Soutien_By_ID(idUniteSoutien).FirstOrDefault();
            setValue(us);
            Verify_Buttons(false);
            Refresh_Button_Modifier();
            Refresh_Button_Supprimer();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void frmUniteSoutien_Load(object sender, EventArgs e)
        {
            LoadVille();
            Refresh_Button_Ajouter();
        }

        private void dgvUniteSoutien_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
                getData();
            else
            {
                dgvUniteSoutien.DataSource = db.Search_Unite_Soutien(txtRecherche.Text);
                CountRow(dgvUniteSoutien.Rows.Count);
            }
        }
    }
}