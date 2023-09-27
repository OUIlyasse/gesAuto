using DAL.DB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Main
{
    public partial class frmLogin : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private frmMain main;

        #endregion Variables

        #region Codes

        private void SignIn()
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Votre champ est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Votre champ est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            var rs = db.Validate_Users(txtUsername.Text, txtPassword.Text).FirstOrDefault();
            switch (rs)
            {
                case 1:
                    v_Utilisateur users = db.get_Utilisateur(txtUsername.Text, txtPassword.Text).FirstOrDefault();

                    string fName = users.pers_Prenom.ToString();
                    string lName = users.pers_Nom.ToString();
                    string grade = users.grd_Grade;
                    string service = db.get_Service_By_ID(users.svc_ID).FirstOrDefault();

                    Properties.Settings.Default.Nom = fName;
                    Properties.Settings.Default.Prenom = lName;
                    Properties.Settings.Default.idUtilisateur = users.util_ID;
                    Properties.Settings.Default.idService = (int)users.svc_ID;

                    if (ckbRemember.Checked)
                    {
                        Properties.Settings.Default.isRemember = true;
                        Properties.Settings.Default.username = txtUsername.Text;
                        Properties.Settings.Default.password = txtPassword.Text;
                    }
                    else
                    {
                        Properties.Settings.Default.isRemember = false;
                        Properties.Settings.Default.username = "";
                        Properties.Settings.Default.password = "";
                    }

                    Properties.Settings.Default.Save();
                    Cursor = Cursors.Default;

                    main.lblFullName.Text = $"{grade} {fName} {lName}";
                    main.lblService.Text = $"Service: {service}";
                    //main.lblFullName.Visible = true;
                    Close();
                    main.idUtilisateur = users.util_ID;
                    main.Refresh_Menu();
                    break;

                case 0:
                    Cursor = Cursors.Default;
                    MessageBox.Show("Votre nom d’utilisateur et mot de passe sont incorrects", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case -1:
                    Cursor = Cursors.Default;
                    MessageBox.Show("Votre nom d’utilisateur et mot de passe sont incorrects", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        #endregion Codes

        public frmLogin(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void ckbRemember_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}