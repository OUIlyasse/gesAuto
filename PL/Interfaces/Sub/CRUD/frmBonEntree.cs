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
    public partial class frmBonEntree : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonEntree;
        private Bon_Entree bon_Entree;
        private frmLBonEntree form;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Reception d'un BL", getID_Lists("Entrees")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Reception d'un BL", getID_Lists("Entrees")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Reception d'un BL", getID_Lists("Entrees")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void LoadFournisseur()
        {
            cmbxFournisseur.DisplayMember = "frns_Nom";
            cmbxFournisseur.ValueMember = "frns_ID";
            cmbxFournisseur.DataSource = db.Select_Fournisseur();
            cmbxFournisseur.SelectedValue = -1;
        }

        private void LoadRepresentant(int idFournisseur)
        {
            cmbxRepresentant.DisplayMember = "rep_Nom";
            cmbxRepresentant.ValueMember = "rep_ID";
            cmbxRepresentant.DataSource = db.Select_Representant(idFournisseur);
            cmbxRepresentant.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Bon_Entree().FirstOrDefault();
        }

        private void setValue(Bon_Entree vl)
        {
            idBonEntree = vl.be_ID;
            txtDesignation.Text = vl.be_Designation;
            dtDate.Value = (DateTime)vl.be_Date;
            cmbxFournisseur.SelectedValue = (int)vl.frns_ID;
            cmbxRepresentant.SelectedValue = (int)vl.rep_ID;
            txtReference.Text = vl.be_Reference;
            txtDescription.Text = vl.be_Description;
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
            Text = "Ajouter un bon d'entrée";
            txtDesignation.Text = maxBL();
            txtDesignation.Focus();

            base.newRecord();
        }

        public override void getData()
        {
            form.getData_EBon();
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
                if (cmbxFournisseur.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxFournisseur.Focus();
                    return;
                }
                if (cmbxRepresentant.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRepresentant.Focus();
                    return;
                }
                var rs = db.Insert_Bon_Entree(maxID(), (DateTime)dtDate.Value, txtDesignation.Text, txtReference.Text, null, (int)cmbxFournisseur.SelectedValue, (int)cmbxRepresentant.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un bon d'entrée");
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
                if (cmbxFournisseur.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxFournisseur.Focus();
                    return;
                }
                if (cmbxRepresentant.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRepresentant.Focus();
                    return;
                }
                var rs = db.Update_Bon_Entree(idBonEntree, (DateTime)dtDate.Value, txtDesignation.Text, txtReference.Text, null, (int)cmbxFournisseur.SelectedValue, (int)cmbxRepresentant.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un bon d'entrée");
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
                    db.Delete_Bon_Entree_Temp(idBonEntree);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un bon d'entrée");
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
            setValue(bon_Entree);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un bon d'entrée");
        }

        #endregion Overrides

        #region Constracteur

        public frmBonEntree(frmLBonEntree form)
        {
            InitializeComponent();
            this.form = form;
            LoadFournisseur();
        }

        public frmBonEntree(frmLBonEntree form, Bon_Entree bon_Entree) : this(form)
        {
            InitializeComponent();
            this.bon_Entree = bon_Entree;
            LoadFournisseur();
        }

        #endregion Constracteur

        private void frmBonEntree_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Ajouter un bon d'entrée"))
            {
                newRecord();
                if (Properties.Settings.Default.idUtilisateur != 0)
                    Refresh_Button_Ajouter();
            }
            else
            {
                if (Properties.Settings.Default.idUtilisateur != 0)
                {
                    Refresh_Button_Modifier();
                    Refresh_Button_Supprimer();
                }
            }
        }

        private void cmbxFournisseur_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //LoadRepresentant((int)cmbxFournisseur.SelectedValue);
        }

        private void cmbxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFournisseur.SelectedIndex != -1)
            {
                LoadRepresentant((int)cmbxFournisseur.SelectedValue);
            }
        }

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = txtReference.Text.Trim().ToUpper();
        }
    }
}