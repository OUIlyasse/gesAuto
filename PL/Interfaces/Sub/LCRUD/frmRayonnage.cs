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
    public partial class frmRayonnage : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idRayonnage, index;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MAX_Rayonnage().FirstOrDefault();
        }

        private void setValue(Rayonnage f)
        {
            txtRayonnage.Text = f.rayo_Nom;
            txtDescription.Text = f.rayo_Description;
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
                if (string.IsNullOrEmpty(txtRayonnage.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRayonnage.Focus();
                    return;
                }
                var rs = db.Insert_Rayonnage(maxID(), txtRayonnage.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le rayonnage {txtRayonnage.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRayonnage.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le rayonnage a bien ajouté");
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
                if (string.IsNullOrEmpty(txtRayonnage.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRayonnage.Focus();
                    return;
                }
                var rs = db.Update_Rayonnage(idRayonnage, txtRayonnage.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le rayonnage {txtRayonnage.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRayonnage.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le rayonnage a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce rayonnage {txtRayonnage.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Armoire_By_idRayonnage(idRayonnage);
                    db.Delete_Rayonnage(idRayonnage);
                    iTools.sucMsg("Information", "Votre rayonnage  a bien supprimé");
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
            dgvRayonnage.DataSource = db.Select_Rayonnage().ToList();
            CountRow(dgvRayonnage.Rows.Count);
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtRayonnage.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un rayonnage");
        }

        #endregion Overrides

        #region Constracteur

        public frmRayonnage()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void txtRayonnage_Validating(object sender, CancelEventArgs e)
        {
            txtRayonnage.Text = iTools.ValidateText(txtRayonnage.Text, TypeText.Majuscule);
        }

        private void dgvRayonnage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvRayonnage.Rows[e.RowIndex];
            idRayonnage = int.Parse(row.Cells[colrayo_ID.Name].Value.ToString());
            Rayonnage famille = db.Show_Rayonnage_By_ID(idRayonnage).FirstOrDefault();
            setValue(famille);
            Verify_Buttons(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvRayonnage_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menu;
            index = e.RowIndex;
        }

        private void frmRayonnage_Load(object sender, EventArgs e)
        {
        }

        private void btnArmoire_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRayonnage.Rows[dgvRayonnage.CurrentRow.Index];
            frmArmoire frm = new frmArmoire((int)row.Cells[colrayo_ID.Name].Value);
            frm.ShowDialog();
        }
    }
}