using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.List;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.CRUD
{
    public partial class frmBonRetour : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonEntree;
        private Bon_Retour bon_Retour;
        private frmLBonRetour form;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de retour courants", getID_Lists("Retours")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de retour courants", getID_Lists("Retours")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de retour courants", getID_Lists("Retours")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void LoadUnite()
        {
            cmbxUnite.DisplayMember = "unt_Unite";
            cmbxUnite.ValueMember = "unt_ID";
            cmbxUnite.DataSource = db.Select_Unite_Soutien().ToList();
            cmbxUnite.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MAX_Bon_Retour().FirstOrDefault();
        }

        private void setValue(Bon_Retour vl)
        {
            idBonEntree = vl.bt_ID;
            txtDesignation.Text = vl.bt_Designation;
            dtDate.Value = (DateTime)vl.bt_Date;
            cmbxUnite.SelectedValue = (int)vl.unt_ID;
            txtReference.Text = vl.bt_Reference;
            txtDescription.Text = vl.bt_Description;
        }

        private string maxBL()
        {
            string rs = $"BL {maxID().ToString()}/{dtDate.Value.Date.ToString("yy")}";
            return rs;
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter un bon de retour";
            txtDesignation.Text = maxBL();
            txtDesignation.Focus();

            base.newRecord();
        }

        public override void getData()
        {
            form.getData_RBon();
            base.getData();
        }

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDesignation.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesignation.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                if (cmbxUnite.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxUnite.Focus();
                    return;
                }
                var rs = db.Insert_Bon_Retour(maxID(), txtDesignation.Text, (DateTime)dtDate.Value, txtReference.Text, (int)cmbxUnite.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un bon de retour");
                        iTools.sucMsg("Information", "Votre bon a bien ajouté");
                        base.Add_Data();
                        Verify_Buttons(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public override void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDesignation.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesignation.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                if (cmbxUnite.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxUnite.Focus();
                    return;
                }
                var rs = db.Update_Bon_Retour(maxID(), txtDesignation.Text, (DateTime)dtDate.Value, txtReference.Text, (int)cmbxUnite.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un bon de retour");
                        iTools.sucMsg("Information", "Votre bon a bien modifié");
                        base.Update_Data();
                        Verify_Buttons(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce bon {txtDesignation.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Bon_Retour_Temp(idBonEntree);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un bon de retour");
                    iTools.sucMsg("Information", "Ce bon a bien supprimé");
                    base.Delete_Data();
                    Verify_Buttons(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void setData()
        {
            setValue(bon_Retour);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un bon de retour");
        }

        #endregion Overrides

        #region Constracteur

        public frmBonRetour(frmLBonRetour form)
        {
            InitializeComponent();
            this.form = form;
            LoadUnite();
        }

        public frmBonRetour(frmLBonRetour form, Bon_Retour bon_Retour) : this(form)
        {
            InitializeComponent();
            this.bon_Retour = bon_Retour;
            LoadUnite();
        }

        #endregion Constracteur

        private void frmBonEntree_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Ajouter un bon de retour"))
            {
                newRecord();
                Refresh_Button_Ajouter();
            }
            else
            {
                Refresh_Button_Modifier();
                Refresh_Button_Supprimer();
            }
        }

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = txtReference.Text.Trim().ToUpper();
        }
    }
}