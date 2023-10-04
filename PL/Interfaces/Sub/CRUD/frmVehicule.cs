using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.List;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Tools;
using Tools.iUtile;

namespace PL.Interfaces.Sub.CRUD
{
    public partial class frmVehicule : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idVL;
        private frmLVehicule frm;
        private Vehicule vehicule;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Véhicule", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Véhicule", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Véhicule", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private int maxID()
        {
            return (int)db.MaxID_Vehicule().FirstOrDefault();
        }

        private void setValue(Vehicule vl)
        {
            idVL = vl.vl_ID;
            txtImmatriculation.Text = vl.vl_Immatriculation;
            txtModel.Text = vl.vl_Modele;
            txtMarque.Text = vl.vl_Marque;
            dtDateFabrication.Value = (DateTime)vl.vl_Annee_Fabrication;
            txtDescription.Text = vl.vl_Description;
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter un véhicule";
            txtImmatriculation.Focus();
            base.newRecord();
        }

        public override void getData()
        {
            frm.getData();
            base.getData();
        }

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtModel.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModel.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMarque.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarque.Focus();
                    return;
                }
                var rs = db.Insert_Vehicule(maxID(), txtImmatriculation.Text, txtModel.Text, txtMarque.Text, dtDateFabrication.Value, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce véhicule {txtMarque.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtImmatriculation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un véhicule");
                        iTools.sucMsg("Information", "Votre véhicule a bien ajouté");
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
                if (string.IsNullOrEmpty(txtModel.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModel.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMarque.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarque.Focus();
                    return;
                }
                var rs = db.Update_Vehicule(idVL, txtImmatriculation.Text, txtModel.Text, txtMarque.Text, dtDateFabrication.Value, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce véhicule {txtMarque.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtImmatriculation.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un véhicule");
                        iTools.sucMsg("Information", "Votre véhicule a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce véhicule {txtMarque.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Vehicule_Temp(idVL);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un véhicule");
                    iTools.sucMsg("Information", "Votre véhicule  a bien supprimé");
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
            setValue(vehicule);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un véhicule");
        }

        #endregion Overrides

        #region Constracteur

        public frmVehicule(frmLVehicule frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        public frmVehicule(frmLVehicule frm, Vehicule vehicule)
        {
            InitializeComponent();
            this.frm = frm;
            this.vehicule = vehicule;
        }

        #endregion Constracteur

        #region Validating

        private void txtImmatriculation_Validating(object sender, CancelEventArgs e)
        {
            txtImmatriculation.Text = iTools.ValidateText(txtImmatriculation.Text, TypeText.Majuscule);
        }

        private void txtModel_Validating(object sender, CancelEventArgs e)
        {
            txtModel.Text = iTools.ValidateText(txtModel.Text, TypeText.Majuscule);
        }

        private void txtMarque_Validating(object sender, CancelEventArgs e)
        {
            txtMarque.Text = iTools.ValidateText(txtMarque.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        private void frmVehicule_Load(object sender, EventArgs e)
        {
            if (Text == "Ajouter un véhicule")
            {
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
    }
}