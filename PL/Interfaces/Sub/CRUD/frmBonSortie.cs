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
    public partial class frmBonSortie : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonSortie;
        private Bon_Sortie bon_Sortie;
        private frmLBonSortie form;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de sortie courants", getID_Lists("Sorties")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de sortie courants", getID_Lists("Sorties")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de sortie courants", getID_Lists("Sorties")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void LoadUnite()
        {
            cmbxUnite.DisplayMember = "unt_Unite";
            cmbxUnite.ValueMember = "unt_ID";
            cmbxUnite.DataSource = db.Load_Unite_Soutien().ToList();
            cmbxUnite.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MAX_Bon_Sortie().FirstOrDefault();
        }

        private void setValue(Bon_Sortie bs)
        {
            idBonSortie = bs.bs_ID;
            txtDesignation.Text = bs.bs_Designation;
            dtDate.Value = (DateTime)bs.bs_Date;
            cmbxUnite.SelectedValue = (int)bs.unt_ID;
            txtReference.Text = bs.bs_Reference;
            txtDescription.Text = bs.bs_Description;
        }

        private string maxBL()
        {
            return $"BL {maxID().ToString()}/{dtDate.Value.Date.ToString("yy")}";
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter un bon de sortie";
            txtDesignation.Text = maxBL();
            txtDesignation.Focus();

            base.newRecord();
        }

        public override void getData()
        {
            form.getData_SBon();
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
                var rs = db.Insert_Bon_Sortie(maxID(), txtDesignation.Text, (DateTime)dtDate.Value, txtReference.Text, (int)cmbxUnite.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un bon de sortie");
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

                var rs = db.Update_Bon_Sortie(idBonSortie, txtDesignation.Text, (DateTime)dtDate.Value, txtReference.Text, (int)cmbxUnite.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un bon de sortie");
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
                    db.Delete_Bon_Sortie_Temp(idBonSortie);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un bon de sortie");
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
            setValue(bon_Sortie);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un bon de sortie");
        }

        #endregion Overrides

        #region Constracteur

        public frmBonSortie(frmLBonSortie form)
        {
            InitializeComponent();
            this.form = form;
            LoadUnite();
        }

        public frmBonSortie(frmLBonSortie form, Bon_Sortie bon_Sortie) : this(form)
        {
            InitializeComponent();
            this.bon_Sortie = bon_Sortie;
            LoadUnite();
        }

        #endregion Constracteur

        private void frmBonEntree_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Ajouter un bon de sortie"))
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

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = txtReference.Text.Trim().ToUpper();
        }
    }
}