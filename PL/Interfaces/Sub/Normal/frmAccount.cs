using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAccount : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        public int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private pers_Affecte getPers(int id)
        {
            return db.Show_pers_Affecte_By_ID(id).FirstOrDefault();
        }

        private Grade getGrade(int id)
        {
            return db.Show_Grade_By_ID(id).FirstOrDefault();
        }

        private Service getService(int id)
        {
            return db.Show_Service_By_ID(id).FirstOrDefault();
        }

        private void setValues()
        {
            Utilisateur user = db.get_Utilisateur_By_idUtilisateur(idUtilisateur).FirstOrDefault();
            txtNom.Text = getPers((int)user.pers_ID).pers_Nom;
            txtPrenom.Text = getPers((int)user.pers_ID).pers_Prenom;
            txtGrade.Text = getGrade(getPers((int)user.pers_ID).grd_ID).grd_Grade;
            txtService.Text = getService((int)user.svc_ID).svc_Nom;
            txtUsername.Text = user.util_Identifiant;
            txtPassword.Text = user.util_MotPasse;
            txtConfirm.Text = user.util_MotPasse;
        }

        #endregion Codes

        public frmAccount(int idUtilisateur)
        {
            InitializeComponent();
            //this.idUtilisateur = idUtilisateur;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            setValues();
        }

        private void btnVisible1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnVisible1.Image = Properties.Resources.Invisible_32;
        }

        private void btnVisible1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnVisible1.Image = Properties.Resources.Visible_32;
        }

        private void btnVisible2_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirm.UseSystemPasswordChar = false;
            btnVisible2.Image = Properties.Resources.Invisible_32;
        }

        private void btnVisible2_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirm.UseSystemPasswordChar = true;
            btnVisible2.Image = Properties.Resources.Visible_32;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtConfirm.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirm.Focus();
                    return;
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    MessageBox.Show("Mots de passe non identiques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirm.Focus();
                    return;
                }
                var rs = db.Update_Utilisateur_Only(idUtilisateur, txtUsername.Text, txtPassword.Text).FirstOrDefault();
                switch (rs)
                {
                    case 1:
                        iTools.sucMsg("Information", "L'utilisateur a bien modifié");
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show("Mots de passe non identiques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirm.Focus();
                return;
            }
        }
    }
}