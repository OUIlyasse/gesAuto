using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.List;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Tools;
using Tools.iUtile;

namespace PL.Interfaces.Sub.CRUD
{
    public partial class frmPersonnel : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idPersonnel;
        private frmLPersonnel frm;
        private pers_Affecte perso;
        private string sf;
        private string genre;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Personnel", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Personnel", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Personnel", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void InitializeControls()
        {
            rdoHomme.Checked = true;
            rdoC.Checked = true;
        }

        private void Lang_Ar()
        {
            CultureInfo ar = new CultureInfo("ar-MA");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
        }

        private void Lang_Current()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(currentCulture);
        }

        private void LoadGrade()
        {
            cmbxGrade.DisplayMember = "grd_Grade";
            cmbxGrade.ValueMember = "grd_ID";
            cmbxGrade.DataSource = db.Select_Grade();
            cmbxGrade.SelectedValue = -1;
        }

        private void LoadUnite()
        {
            cmbxUnite.DisplayMember = "unt_Unite";
            cmbxUnite.ValueMember = "unt_ID";
            cmbxUnite.DataSource = db.Select_Unite_Soutien();
            cmbxUnite.SelectedValue = -1;
        }

        private void LoadGS()
        {
            cmbxGS.DataSource = db.Select_GroupeSanguin().ToList();
            cmbxGS.ValueMember = "gs_ID";
            cmbxGS.DisplayMember = "gs_Nom";
            cmbxGS.SelectedIndex = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_pers_Affecte().FirstOrDefault();
        }

        private void setValue(pers_Affecte pers)
        {
            idPersonnel = pers.pers_ID;
            //Information
            txtPrenom.Text = pers.pers_Prenom;
            txtPrenomAr.Text = pers.pers_Prenom_Ar;
            txtNom.Text = pers.pers_Nom;
            txtNomAr.Text = pers.pers_Nom_Ar;
            txtMleFA.Text = pers.pers_Mle_FA;
            cmbxGrade.SelectedValue = pers.grd_ID;
            cmbxUnite.SelectedValue = pers.unt_ID;
            dtNaissance.Value = (DateTime)pers.pers_Date_Naissance;
            txtLieu.Text = pers.pers_Lieu_Naissance;
            txtLieuAr.Text = pers.pers_Lieu_Naissance_Ar;
            dtEngagement.Value = (DateTime)pers.pers_Date_Engagement;
            dtNomination.Value = (DateTime)pers.pers_Date_Nomination;
            txtRefNomination.Text = pers.pers_Reff_Nomination;
            txtOrigine.Text = pers.pers_Origine;
            txtOrigineAr.Text = pers.pers_Origine_Ar;
            txtCIN.Text = pers.pers_CIN;
            if (pers.pers_Sexe.Contains("Homme"))
            {
                rdoHomme.Checked = true;
            }
            else if (pers.pers_Sexe.Contains("Femme"))
            {
                rdoFemme.Checked = true;
            }
            txtAdresse.Text = pers.pers_Adresse_Personnelle;
            txtAdresseAr.Text = pers.pers_Adresse_Personnelle_Ar;
            txtCarteFA.Text = pers.pers_Carte_FA;
            //Situation Familiale
            if (pers.pers_Sit_Fam.Equals("Célibataire"))
                rdoC.Checked = true;
            else if (pers.pers_Sit_Fam.Equals("Marié"))
                rdoM.Checked = true;
            else if (pers.pers_Sit_Fam.Equals("Divorcé"))
                rdoD.Checked = true;
            txtEPrenom.Text = pers.pers_E_Prenom;
            txtENom.Text = pers.pers_E_Nom;
            txtECIN.Text = pers.pers_E_CIN;
            dtENaissance.Value = (DateTime)pers.pers_E_Date_Naissance;
            txtELieu.Text = pers.pers_E_Lieu_Naissance;
            txtENbrEnfant.Text = pers.pers_Nbr_Enf;
            //Mutuelle
            txtImmatriculation.Text = pers.pers_Immatriculation;
            txtMutuelle.Text = pers.pers_Mutuel;
            txtPPR.Text = pers.pers_PPR;
            cmbxGS.SelectedValue = pers.gs_ID;
            txtAffiliation.Text = pers.pers_Affiliation;
            dtAffiliation.Value = (DateTime)pers.pers_Date_Affiliation;
            //Parents
            txtPPrenom.Text = pers.pers_Pere_Prenom;
            txtPNom.Text = pers.pers_Pere_Nom;
            txtPCIN.Text = pers.pers_Pere_CIN;
            dtPNaissance.Value = (DateTime)pers.pers_Pere_Date_Naissance;
            txtPLieu.Text = pers.pers_Pere_Lieu_Naissance;
            txtMPrenom.Text = pers.pers_Mere_Prenom;
            txtMNom.Text = pers.pers_Mere_Nom;
            txtMCIN.Text = pers.pers_Mere_CIN;
            dtMNaissance.Value = (DateTime)pers.pers_Mere_Date_Naissance;
            txtMLieu.Text = pers.pers_Mere_Lieu_Naissance;
            //Divers
            txtSpecialite.Text = pers.pers_Specialite;
            txtFonction.Text = pers.pers_Fonction;
            txtTaille.Text = pers.pers_Taille.ToString();
            txtNiveauInstruction.Text = pers.pers_Niv_Instrution;
            txtDiplomeUniversitaire.Text = pers.pers_Diplome_Universitaire;
            txtNumPasseport.Text = pers.pers_Num_Passeport;
            txtNumArmeChasse.Text = pers.pers_Num_Arm_Chasse;
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter un personnel";
            tabControl1.SelectedTab = tpInformation;
            txtPrenom.Focus();
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
                if (string.IsNullOrEmpty(txtPrenom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrenom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMleFA.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMleFA.Focus();
                    return;
                }
                if (cmbxGrade.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxGrade.Focus();
                    return;
                }
                if (cmbxUnite.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxUnite.Focus();
                    return;
                }
                if (rdoD.Checked)
                    sf = "Divorcé";
                else if (rdoM.Checked)
                    sf = "Marié";
                else if (rdoC.Checked)
                    sf = "Célibataire";
                if (rdoHomme.Checked)
                    genre = "Homme";
                else if (rdoFemme.Checked)
                    genre = "Femme";

                decimal msgTaille;
                bool isDecimal = decimal.TryParse(txtTaille.Text, out msgTaille);
                if (!isDecimal)
                    msgTaille = 0.00M;

                var rs = db.Insert_pers_Affecte(maxID(), txtPrenom.Text, txtPrenomAr.Text, txtNom.Text, txtNomAr.Text, txtMleFA.Text, (int)cmbxGrade.SelectedValue, (int)cmbxUnite.SelectedValue,
                    dtNaissance.Value, txtLieu.Text, txtLieuAr.Text, dtEngagement.Value, dtNomination.Value, txtRefNomination.Text, txtOrigine.Text, txtOrigineAr.Text,
                    txtCIN.Text, genre, txtAdresse.Text, txtAdresseAr.Text, txtCarteFA.Text, txtSpecialite.Text, txtFonction.Text, null, msgTaille, sf, null, txtEPrenom.Text,
                    txtENom.Text, txtECIN.Text, dtENaissance.Value, txtELieu.Text, txtENbrEnfant.Text, txtPPR.Text, (int)cmbxGS.SelectedValue, txtMutuelle.Text, txtImmatriculation.Text,
                    txtAffiliation.Text, dtAffiliation.Value, txtPPrenom.Text, txtPNom.Text, txtPCIN.Text, dtPNaissance.Value, txtPLieu.Text, txtMPrenom.Text, txtMNom.Text, txtMCIN.Text,
                    dtMNaissance.Value, txtMLieu.Text, txtNiveauInstruction.Text, txtDiplomeUniversitaire.Text, txtNumPasseport.Text, txtNumArmeChasse.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le matricule FA de ce personnel {cmbxGrade.Text} {txtPrenom.Text} {txtNom.Text}, est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMleFA.Focus();
                        break;

                    case 1:
                        MessageBox.Show($"Le personnel {cmbxGrade.Text} {txtPrenom.Text} {txtNom.Text}, est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrenom.Focus();
                        break;

                    case 2:
                        iTools.sucMsg("Information", "Le personnel a bien ajouté");
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
                if (string.IsNullOrEmpty(txtPrenom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrenom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMleFA.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMleFA.Focus();
                    return;
                }
                if (cmbxGrade.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxGrade.Focus();
                    return;
                }
                if (cmbxUnite.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxUnite.Focus();
                    return;
                }
                if (rdoD.Checked)
                    sf = "Divorcé";
                else if (rdoM.Checked)
                    sf = "Marié";
                else if (rdoC.Checked)
                    sf = "Célibataire";
                if (rdoHomme.Checked)
                    genre = "Homme";
                else if (rdoFemme.Checked)
                    genre = "Femme";

                decimal msgTaille;
                bool isDecimal = decimal.TryParse(txtTaille.Text, out msgTaille);
                if (!isDecimal)
                    msgTaille = 0.00M;

                var rs = db.Update_pers_Affecte(idPersonnel, txtPrenom.Text, txtPrenomAr.Text, txtNom.Text, txtNomAr.Text, txtMleFA.Text, (int)cmbxGrade.SelectedValue, (int)cmbxUnite.SelectedValue,
                    dtNaissance.Value, txtLieu.Text, txtLieuAr.Text, dtEngagement.Value, dtNomination.Value, txtRefNomination.Text, txtOrigine.Text, txtOrigineAr.Text,
                    txtCIN.Text, genre, txtAdresse.Text, txtAdresseAr.Text, txtCarteFA.Text, txtSpecialite.Text, txtFonction.Text, null, msgTaille, sf, null, txtEPrenom.Text,
                    txtENom.Text, txtECIN.Text, dtENaissance.Value, txtELieu.Text, txtENbrEnfant.Text, txtPPR.Text, (int)cmbxGS.SelectedValue, txtMutuelle.Text, txtImmatriculation.Text,
                    txtAffiliation.Text, dtAffiliation.Value, txtPPrenom.Text, txtPNom.Text, txtPCIN.Text, dtPNaissance.Value, txtPLieu.Text, txtMPrenom.Text, txtMNom.Text, txtMCIN.Text,
                    dtMNaissance.Value, txtMLieu.Text, txtNiveauInstruction.Text, txtDiplomeUniversitaire.Text, txtNumPasseport.Text, txtNumArmeChasse.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le matricule FA de ce personnel {cmbxGrade.Text} {txtPrenom.Text} {txtNom.Text}, est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMleFA.Focus();
                        break;

                    case 1:
                        MessageBox.Show($"Le personnel {cmbxGrade.Text} {txtPrenom.Text} {txtNom.Text}, est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrenom.Focus();
                        break;

                    case 2:
                        iTools.sucMsg("Information", "Le personnel a bien modifié");
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

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce personnel {cmbxGrade.Text} {txtNom.Text} {txtPrenom.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_pers_Affecte_Temp(idPersonnel);
                    iTools.sucMsg("Information", "ce personnel a bien supprimé");
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
            setValue(perso);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un personnel");
        }

        #endregion Overrides

        #region Constracteur

        public frmPersonnel(frmLPersonnel frm)
        {
            InitializeComponent();
            LoadGrade();
            LoadUnite();
            LoadGS();
            this.frm = frm;
        }

        public frmPersonnel(frmLPersonnel frm, pers_Affecte pers)
        {
            InitializeComponent();
            LoadGrade();
            LoadUnite();
            LoadGS();
            this.frm = frm;
            perso = pers;
        }

        #endregion Constracteur

        #region Lang

        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender is RichTextBox)
            {
                switch (((RichTextBox)sender).Name)
                {
                    case nameof(txtRefNomination):
                        Lang_Current();
                        break;

                    case nameof(txtLieu):
                        Lang_Current();
                        break;

                    case nameof(txtLieuAr):
                        Lang_Ar();
                        break;

                    case nameof(txtAdresse):
                        Lang_Current();
                        break;

                    case nameof(txtAdresseAr):
                        Lang_Ar();
                        break;

                    case nameof(txtELieu):
                        Lang_Current();
                        break;

                    case nameof(txtPLieu):
                        Lang_Current();
                        break;

                    case nameof(txtMLieu):
                        Lang_Current();
                        break;

                    case nameof(txtNiveauInstruction):
                        Lang_Current();
                        break;

                    case nameof(txtNumPasseport):
                        Lang_Current();
                        break;

                    case nameof(txtDiplomeUniversitaire):
                        Lang_Current();
                        break;

                    case nameof(txtNumArmeChasse):
                        Lang_Current();
                        break;

                    case nameof(txtSpecialite):
                        Lang_Current();
                        break;

                    case nameof(txtFonction):
                        Lang_Current();
                        break;
                }
            }
            else if (sender is TextBox)
            {
                switch (((TextBox)sender).Name)
                {
                    case nameof(txtPrenom):
                        Lang_Current();
                        break;

                    case nameof(txtPrenomAr):
                        Lang_Ar();
                        break;

                    case nameof(txtNom):
                        Lang_Current();
                        break;

                    case nameof(txtNomAr):
                        Lang_Ar();
                        break;

                    case nameof(txtMleFA):
                        Lang_Current();
                        break;

                    case nameof(txtCIN):
                        Lang_Current();
                        break;

                    case nameof(txtCarteFA):
                        Lang_Current();
                        break;

                    case nameof(txtOrigineAr):
                        Lang_Ar();
                        break;

                    case nameof(txtOrigine):
                        Lang_Current();
                        break;

                    case nameof(txtEPrenom):
                        Lang_Current();
                        break;

                    case nameof(txtENom):
                        Lang_Current();
                        break;

                    case nameof(txtENbrEnfant):
                        Lang_Current();
                        break;

                    case nameof(txtECIN):
                        Lang_Current();
                        break;

                    case nameof(txtImmatriculation):
                        Lang_Current();
                        break;

                    case nameof(txtMutuelle):
                        Lang_Current();
                        break;

                    case nameof(txtPPR):
                        Lang_Current();
                        break;

                    case nameof(txtAffiliation):
                        Lang_Current();
                        break;

                    case nameof(txtPPrenom):
                        Lang_Current();
                        break;

                    case nameof(txtMPrenom):
                        Lang_Current();
                        break;

                    case nameof(txtPNom):
                        Lang_Current();
                        break;

                    case nameof(txtMNom):
                        Lang_Current();
                        break;

                    case nameof(txtPCIN):
                        Lang_Current();
                        break;

                    case nameof(txtMCIN):
                        Lang_Current();
                        break;

                    case nameof(txtTaille):
                        Lang_Current();
                        break;
                }
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            Lang_Current();
        }

        #endregion Lang

        #region Validating

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            if (sender is RichTextBox)
            {
                switch (((RichTextBox)sender).Name)
                {
                    case nameof(txtRefNomination):
                        txtRefNomination.Text = iTools.ValidateText(txtRefNomination.Text, TypeText.Defaut); break;

                    case nameof(txtLieu):
                        txtLieu.Text = iTools.ValidateText(txtLieu.Text, TypeText.Defaut); break;

                    case nameof(txtLieuAr):
                        txtLieuAr.Text = iTools.ValidateText(txtLieuAr.Text, TypeText.Defaut); break;

                    case nameof(txtAdresse):
                        txtAdresse.Text = iTools.ValidateText(txtAdresse.Text, TypeText.Defaut); break;

                    case nameof(txtAdresseAr):
                        txtAdresseAr.Text = iTools.ValidateText(txtAdresseAr.Text, TypeText.Defaut); break;

                    case nameof(txtELieu):
                        txtELieu.Text = iTools.ValidateText(txtELieu.Text, TypeText.Defaut); break;

                    case nameof(txtPLieu):
                        txtPLieu.Text = iTools.ValidateText(txtPLieu.Text, TypeText.Defaut); break;

                    case nameof(txtMLieu):
                        txtMLieu.Text = iTools.ValidateText(txtMLieu.Text, TypeText.Defaut); break;

                    case nameof(txtNiveauInstruction):
                        txtNiveauInstruction.Text = iTools.ValidateText(txtNiveauInstruction.Text, TypeText.Defaut); break;

                    case nameof(txtNumPasseport):
                        txtNumPasseport.Text = iTools.ValidateText(txtNumPasseport.Text, TypeText.Defaut); break;

                    case nameof(txtDiplomeUniversitaire):
                        txtDiplomeUniversitaire.Text = iTools.ValidateText(txtDiplomeUniversitaire.Text, TypeText.Defaut); break;

                    case nameof(txtNumArmeChasse):
                        txtNumArmeChasse.Text = iTools.ValidateText(txtNumArmeChasse.Text, TypeText.Defaut); break;

                    case nameof(txtSpecialite):
                        txtSpecialite.Text = iTools.ValidateText(txtSpecialite.Text, TypeText.Defaut); break;

                    case nameof(txtFonction):
                        txtFonction.Text = iTools.ValidateText(txtFonction.Text, TypeText.Defaut); break;
                }
            }
            else if (sender is TextBox)
            {
                switch (((TextBox)sender).Name)
                {
                    case nameof(txtPrenom):
                        txtPrenom.Text = iTools.ValidateText(txtPrenom.Text, TypeText.Defaut); break;

                    case nameof(txtPrenomAr):
                        txtPrenomAr.Text = iTools.ValidateText(txtPrenomAr.Text, TypeText.Defaut); break;

                    case nameof(txtNom):
                        txtNom.Text = iTools.ValidateText(txtNom.Text, TypeText.Majuscule); break;

                    case nameof(txtNomAr):
                        txtNomAr.Text = iTools.ValidateText(txtNomAr.Text, TypeText.Majuscule); break;

                    case nameof(txtMleFA):
                        txtMleFA.Text = iTools.ValidateText(txtMleFA.Text, TypeText.Majuscule); break;

                    case nameof(txtCIN):
                        txtCIN.Text = iTools.ValidateText(txtCIN.Text, TypeText.Majuscule); break;

                    case nameof(txtCarteFA):
                        txtCarteFA.Text = iTools.ValidateText(txtCarteFA.Text, TypeText.Majuscule); break;

                    case nameof(txtOrigineAr):
                        txtOrigineAr.Text = iTools.ValidateText(txtOrigineAr.Text, TypeText.Majuscule); break;

                    case nameof(txtOrigine):
                        txtOrigine.Text = iTools.ValidateText(txtOrigine.Text, TypeText.Majuscule); break;

                    case nameof(txtEPrenom):
                        txtEPrenom.Text = iTools.ValidateText(txtEPrenom.Text, TypeText.Defaut); break;

                    case nameof(txtENom):
                        txtENom.Text = iTools.ValidateText(txtENom.Text, TypeText.Majuscule); break;

                    case nameof(txtENbrEnfant):
                        txtENbrEnfant.Text = iTools.ValidateText(txtENbrEnfant.Text, TypeText.Defaut); break;

                    case nameof(txtECIN):
                        txtECIN.Text = iTools.ValidateText(txtECIN.Text, TypeText.Majuscule); break;

                    case nameof(txtImmatriculation):
                        txtImmatriculation.Text = iTools.ValidateText(txtImmatriculation.Text, TypeText.Majuscule); break;

                    case nameof(txtMutuelle):
                        txtMutuelle.Text = iTools.ValidateText(txtMutuelle.Text, TypeText.Majuscule); break;

                    case nameof(txtPPR):
                        txtPPR.Text = iTools.ValidateText(txtPPR.Text, TypeText.Majuscule); break;

                    case nameof(txtAffiliation):
                        txtAffiliation.Text = iTools.ValidateText(txtAffiliation.Text, TypeText.Majuscule); break;

                    case nameof(txtPPrenom):
                        txtPPrenom.Text = iTools.ValidateText(txtPPrenom.Text, TypeText.Defaut); break;

                    case nameof(txtMPrenom):
                        txtMPrenom.Text = iTools.ValidateText(txtMPrenom.Text, TypeText.Defaut); break;

                    case nameof(txtPNom):
                        txtPNom.Text = iTools.ValidateText(txtPNom.Text, TypeText.Majuscule); break;

                    case nameof(txtMNom):
                        txtMNom.Text = iTools.ValidateText(txtMNom.Text, TypeText.Majuscule); break;

                    case nameof(txtPCIN):
                        txtPCIN.Text = iTools.ValidateText(txtPCIN.Text, TypeText.Majuscule); break;

                    case nameof(txtMCIN):
                        txtMCIN.Text = iTools.ValidateText(txtMCIN.Text, TypeText.Majuscule); break;

                    case nameof(txtTaille):
                        txtTaille.Text = iTools.ValidateText(txtTaille.Text, TypeText.Defaut); break;
                }
            }
        }

        #endregion Validating

        private void frmPersonnel_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Ajouter un personnel"))
            {
                InitializeControls();
                Refresh_Button_Ajouter();
            }
            else
            {
                Refresh_Button_Modifier();
                Refresh_Button_Supprimer();
            }
        }

        #region RadioButton

        private void rdoM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoM.Checked)
            {
                gbEpouse.Enabled = true;
                iTools.Clear(gbEpouse);
                txtEPrenom.Focus();
            }
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoC.Checked)
            {
                gbEpouse.Enabled = false;
                iTools.Clear(gbEpouse);
            }
        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoD.Checked)
            {
                gbEpouse.Enabled = false;
                iTools.Clear(gbEpouse);
            }
        }

        #endregion RadioButton

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            txtPNom.Text = txtNom.Text;
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is RichTextBox)
            {
                switch (((RichTextBox)sender).Name)
                {
                    case "txtRefNomination":
                        //txtRefNomination.Text = iTools.ValidateText(txtRefNomination.Text, TypeText.Defaut);
                        break;

                    case "txtLieu":
                        //txtLieu.Text = iTools.ValidateText(txtLieu.Text, TypeText.Defaut);
                        break;

                    case "txtLieuAr":
                        //txtLieuAr.Text = iTools.ValidateText(txtLieuAr.Text, TypeText.Defaut);
                        break;

                    case "txtAdresse":
                        //txtAdresse.Text = iTools.ValidateText(txtAdresse.Text, TypeText.Defaut);
                        break;

                    case "txtAdresseAr":
                        //txtAdresseAr.Text = iTools.ValidateText(txtAdresseAr.Text, TypeText.Defaut);
                        break;

                    case "txtELieu":
                        //txtELieu.Text = iTools.ValidateText(txtELieu.Text, TypeText.Defaut);
                        break;

                    case "txtPLieu":
                        //txtPLieu.Text = iTools.ValidateText(txtPLieu.Text, TypeText.Defaut);
                        break;

                    case "txtMLieu":
                        //txtMLieu.Text = iTools.ValidateText(txtMLieu.Text, TypeText.Defaut);
                        break;

                    case "txtNiveauInstruction":
                        //txtNiveauInstruction.Text = iTools.ValidateText(txtNiveauInstruction.Text, TypeText.Defaut);
                        break;

                    case "txtNumPasseport":
                        //txtNumPasseport.Text = iTools.ValidateText(txtNumPasseport.Text, TypeText.Defaut);
                        break;

                    case "txtDiplomeUniversitaire":
                        //txtDiplomeUniversitaire.Text = iTools.ValidateText(txtDiplomeUniversitaire.Text, TypeText.Defaut);
                        break;

                    case "txtNumArmeChasse":
                        //txtNumArmeChasse.Text = iTools.ValidateText(txtNumArmeChasse.Text, TypeText.Defaut);
                        break;

                    case "txtSpecialite":
                        //txtSpecialite.Text = iTools.ValidateText(txtSpecialite.Text, TypeText.Defaut);
                        break;

                    case "txtFonction":
                        //txtFonction.Text = iTools.ValidateText(txtFonction.Text, TypeText.Defaut);
                        break;
                }
            }
            else if (sender is TextBox)
            {
                switch (((TextBox)sender).Name)
                {
                    case "txtPrenom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtPrenomAr":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtNom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtNomAr":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtMleFA":
                        e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtCIN":
                        e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtCarteFA":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtOrigineAr":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtOrigine":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtEPrenom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtENom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtENbrEnfant":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtECIN":
                        e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtImmatriculation":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtMutuelle":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtPPR":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtAffiliation":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtPPrenom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtMPrenom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtPNom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtMNom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtPCIN":
                        e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtMCIN":
                        e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtTaille":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back); break;
                }
            }
        }
    }
}