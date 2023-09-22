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
    public partial class frmPermission : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idPersonnel;

        #endregion Variables

        #region Codes

        #region Personnel

        private void loadPersonnel()
        {
            dgvPersonnel.DataSource = db.Select_PPersonnel();
        }

        private void Search()
        {
        }

        #endregion Personnel

        #region Service

        private void loadService()
        {
            cmbxService.DataSource = db.Select_Service().ToList();
            cmbxService.DisplayMember = "svc_Nom";
            cmbxService.ValueMember = "svc_ID";
            cmbxService.SelectedValue = -1;
        }

        #endregion Service

        private void VerifyButton(bool status)
        {
            if (status)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void newRecord()
        {
            iTools.Clear(this);
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            loadService();
            dgvPersonnel.Focus();
        }

        private int maxID()
        {
            return (int)db.MAX_Utilisateur().FirstOrDefault();
        }

        private void Add_Data()
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
                if (string.IsNullOrEmpty(txtRPassword.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRPassword.Focus();
                    return;
                }
                if (!txtPassword.Text.Equals(txtRPassword.Text))
                {
                    MessageBox.Show("Mots de passe non identiques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRPassword.Focus();
                    return;
                }
                var rs = db.Insert_Utilisateur(maxID(), idPersonnel, DateTime.Now, txtUsername.Text, txtPassword.Text, (int)cmbxService.SelectedValue, null).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Cet utilisateur {txtUsername.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Utilisateur a bien ajouté");
                        VerifyButton(false);
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Update_Data()
        {
        }

        private void Delete_Data()
        {
        }

        #endregion Codes

        #region Constracteur

        public frmPermission()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void frmPermission_Load(object sender, EventArgs e)
        {
            newRecord();
            loadPersonnel();
        }

        private void dgvPersonnel_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                int item = int.Parse(dgvPersonnel.Rows[dgvPersonnel.CurrentRow.Index].Cells[colpers_ID.Name].Value.ToString());
                idPersonnel = item;
                pers_Affecte bs = db.Show_pers_Affecte_By_ID(item).FirstOrDefault();
                txtNom.Text = bs.pers_Nom;
                txtPrenom.Text = bs.pers_Prenom;
            }
            catch (Exception)
            {
            }
        }

        private void ckbAffiche_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAffiche.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.UseSystemPasswordChar = false;
                txtRPassword.Enabled = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRPassword.UseSystemPasswordChar = true;
                txtRPassword.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (ckbAffiche.Checked)
                txtRPassword.Text = txtPassword.Text;
        }

        private void dgvPersonnel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPersonnel.Rows[e.RowIndex];
            idPersonnel = int.Parse(row.Cells[colpers_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Utilisateur vl = db.get_Utilisateur_By_ID(idPersonnel).FirstOrDefault();
            if (vl != null)
            {
                txtUsername.Text = vl.util_Identifiant;
                cmbxService.SelectedValue = (int)vl.svc_ID;
                txtPassword.Text = vl.util_MotPasse;
                txtRPassword.Text = vl.util_MotPasse;
                VerifyButton(false);
            }
            else
            {
                txtUsername.Text = string.Empty;
                cmbxService.SelectedValue = -1;
                txtPassword.Text = string.Empty;
                txtRPassword.Text = string.Empty;
                VerifyButton(true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }
    }
}