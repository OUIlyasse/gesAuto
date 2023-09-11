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
    public partial class frmArmoire : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idArmoire, idRayonnage;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MAX_Armoire().FirstOrDefault();
        }

        private void setValue(Armoire f)
        {
            txtRayonnage.Text = f.arm_Nom;
            txtDescription.Text = f.arm_Description;
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
                var rs = db.Insert_Armoire(maxID(), txtRayonnage.Text, txtDescription.Text, idRayonnage).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'armoire {txtRayonnage.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRayonnage.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "L'armoire a bien ajouté");
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
                var rs = db.Update_Armoire(idArmoire, txtRayonnage.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'armoire {txtRayonnage.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRayonnage.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "L'armoire a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cet armoire {txtRayonnage.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Armoire(idArmoire);
                    iTools.sucMsg("Information", "Votre armoire  a bien supprimé");
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
            dgvRayonnage.DataSource = db.Select_Armoire(idRayonnage).ToList();
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
            base.setToolTip("un armoire");
        }

        #endregion Overrides

        #region Constracteur

        public frmArmoire(int idRayonnage)
        {
            InitializeComponent();
            this.idRayonnage = idRayonnage;
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
            idArmoire = int.Parse(row.Cells[colarm_ID.Name].Value.ToString());
            Armoire famille = db.Show_Armoire_By_ID(idArmoire).FirstOrDefault();
            setValue(famille);
            Verify_Buttons(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void frmArmoire_Load(object sender, EventArgs e)
        {
            lblRayonnage.Text = $"Rayonnage: {db.Show_Rayonnage_By_ID(idRayonnage).FirstOrDefault().rayo_Nom}";
        }
    }
}