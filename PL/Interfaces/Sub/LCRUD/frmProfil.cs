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
    public partial class frmProfil : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idProfil;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MaxID_Profil().FirstOrDefault();
        }

        private void setValue(Profil f)
        {
            txtProfil.Text = f.prof_Nom;
            txtDescription.Text = f.prof_Description;
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
                if (string.IsNullOrEmpty(txtProfil.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProfil.Focus();
                    return;
                }
                var rs = db.Insert_Profil(maxID(), txtProfil.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le profil {txtProfil.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProfil.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le profil a bien ajouté");
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
                if (string.IsNullOrEmpty(txtProfil.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProfil.Focus();
                    return;
                }
                var rs = db.Update_Profil(idProfil, txtProfil.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le profil {txtProfil.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProfil.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le profil a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce profil {txtProfil.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Profil_Temp(idProfil);
                    iTools.sucMsg("Information", "Votre profil  a bien supprimé");
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
            dgvProfil.DataSource = db.Select_Profil().ToList();
            CountRow(db.Count_Profil().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtProfil.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un profil");
        }

        #endregion Overrides

        #region Constracteur

        public frmProfil()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        #region Validating

        private void txtProfil_Validating(object sender, CancelEventArgs e)
        {
            txtProfil.Text = iTools.ValidateText(txtProfil.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProfil.DataSource = db.Search_Profil(txtSearch.Text);
            CountRow(dgvProfil.Rows.Count);
        }

        #endregion Search

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvProfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvProfil.Rows[e.RowIndex];
            idProfil = int.Parse(row.Cells[colprof_ID.Name].Value.ToString());
            Profil profil = db.Show_Profil_By_ID(idProfil).FirstOrDefault();
            setValue(profil);
            Verify_Buttons(false);
        }

        private void dgvProfil_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}