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
    public partial class frmRepresentant : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idRepresentant, idFournisseur;
        private Representant representant;
        private frmLRepresentant frmLRepresentant;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MaxID_Representant().FirstOrDefault();
        }

        private void setValue(Representant vl)
        {
            idRepresentant = vl.rep_ID;
            idFournisseur = (int)vl.frns_ID;
            txtNom.Text = vl.rep_Nom;
            txtPrenom.Text = vl.rep_Prenom;
            txtCin.Text = vl.rep_Cin;
            txtGsm.Text = vl.rep_Tele;
            txtObservation.Text = vl.rep_Observation;
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter un representant";
            txtNom.Focus();
            base.newRecord();
        }

        public override void getData()
        {
            frmLRepresentant.getData();
            base.getData();
        }

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPrenom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrenom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtCin.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCin.Focus();
                    return;
                }
                var rs = db.Insert_Representant(maxID(), idFournisseur, txtNom.Text, txtPrenom.Text, txtCin.Text, txtGsm.Text, txtObservation.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce nom et prénom {txtNom.Text} {txtPrenom.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNom.Focus();
                        break;

                    case 1:
                        MessageBox.Show($"CIN {txtCin.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCin.Focus();
                        break;

                    case 2:
                        iTools.sucMsg("Information", "Votre representant a bien ajouté");
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
                if (string.IsNullOrEmpty(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPrenom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrenom.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtCin.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCin.Focus();
                    return;
                }
                var rs = db.Update_Representant(idRepresentant, idFournisseur, txtNom.Text, txtPrenom.Text, txtCin.Text, txtGsm.Text, txtObservation.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce nom et prénom {txtNom.Text} {txtPrenom.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNom.Focus();
                        break;

                    case 1:
                        MessageBox.Show($"CIN {txtCin.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCin.Focus();
                        break;

                    case 2:
                        iTools.sucMsg("Information", "Votre representant a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce representant {txtPrenom.Text} {txtNom.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Representant_Temp(idRepresentant);
                    iTools.sucMsg("Information", "Ce representant  a bien supprimé");
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
            setValue(representant);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un representant");
        }

        #endregion Overrides

        #region Constracteur

        public frmRepresentant(frmLRepresentant frmLRepresentant, int idFournisseur)
        {
            InitializeComponent();
            this.frmLRepresentant = frmLRepresentant;
            this.idFournisseur = idFournisseur;
        }

        public frmRepresentant(frmLRepresentant frmLRepresentant, int idFournisseur, Representant representant) : this(frmLRepresentant, idFournisseur)
        {
            InitializeComponent();
            this.representant = representant;
        }

        #endregion Constracteur

        #region Validating

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            if (sender is RichTextBox)
            {
                switch (((RichTextBox)sender).Name)
                {
                    case "txtObservation":
                        txtObservation.Text = iTools.ValidateText(txtObservation.Text, TypeText.Defaut); break;
                }
            }
            else if (sender is TextBox)
            {
                switch (((TextBox)sender).Name)
                {
                    case "txtPrenom":
                        txtPrenom.Text = iTools.ValidateText(txtPrenom.Text, TypeText.Defaut); break;

                    case "txtNom":
                        txtNom.Text = iTools.ValidateText(txtNom.Text, TypeText.Majuscule); break;

                    case "txtCin":
                        txtCin.Text = iTools.ValidateText(txtCin.Text, TypeText.Majuscule); break;

                    case "txtGsm":
                        txtGsm.Text = iTools.ValidateText(txtGsm.Text, TypeText.Defaut); break;
                }
            }
        }

        private void frmRepresentant_Load(object sender, EventArgs e)
        {
        }

        #endregion Validating

        #region KeyPress

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                switch (((TextBox)sender).Name)
                {
                    case "txtPrenom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back); break;

                    case "txtNom":
                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtCin":
                        e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;

                    case "txtGsm":
                        e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); break;
                }
            }
        }

        #endregion KeyPress
    }
}