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
    public partial class frmMagasin : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idMagasin;

        #endregion Variables

        #region Codes

        private void LoadVille()
        {
            cmbxVille.DisplayMember = "vil_Nom";
            cmbxVille.ValueMember = "vil_ID";
            cmbxVille.DataSource = db.Select_Ville().ToList();
            cmbxVille.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Magasin().FirstOrDefault();
        }

        private void setValue(Magasin f)
        {
            txtMagasin.Text = f.mags_Magasin;
            cmbxVille.SelectedValue = f.vil_ID;
            txtDescription.Text = f.mags_Description;
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
                if (string.IsNullOrEmpty(txtMagasin.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMagasin.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Insert_Magasin(maxID(), txtMagasin.Text, (int)cmbxVille.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le magasin {txtMagasin.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMagasin.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le magasin a bien ajouté");
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
                if (string.IsNullOrEmpty(txtMagasin.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMagasin.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Update_Magasin(idMagasin, txtMagasin.Text, (int)cmbxVille.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le magasin {txtMagasin.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMagasin.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le magasin a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce magasin {txtMagasin.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Magasin_Temp(idMagasin);
                    iTools.sucMsg("Information", "Votre magasin a bien supprimé");
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
            dgvMagasin.DataSource = db.Select_Magasin().ToList();
            CountRow(db.Count_Magasin().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtMagasin.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un magasin");
        }

        #endregion Overrides

        #region Constracteur

        public frmMagasin()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        #region Validating

        private void txtMagasin_Validating(object sender, CancelEventArgs e)
        {
            txtMagasin.Text = iTools.ValidateText(txtMagasin.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            LoadVille();
        }

        private void dgvMagasin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvMagasin.Rows[e.RowIndex];
            idMagasin = int.Parse(row.Cells[colmags_ID.Name].Value.ToString());
            Magasin mags = db.Show_Magasin_By_ID(idMagasin).FirstOrDefault();
            setValue(mags);
            Verify_Buttons(false);
            //txtMagasin.Text = row.Cells[colmags_Magasin.Name].Value.ToString();
            //cmbxVille.SelectedValue = row.Cells[colvil_ID.Name].Value;
            //txtDescription.Text = row.Cells[colmags_Description.Name].Value.ToString();
            //Verify_Buttons(false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMagasin.DataSource = db.Search_Magasin(txtSearch.Text);
            CountRow(dgvMagasin.Rows.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvMagasin_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}