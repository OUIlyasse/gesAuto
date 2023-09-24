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
        private int idPersonnel, idUtilisateur;
        private DataTable dtPermission, dtLists;

        #endregion Variables

        #region Codes

        private void empty_Data()
        {
            if (dgvPermission.DataSource != null)
            {
                dtPermission = (DataTable)dgvPermission.DataSource;
                dtPermission.Rows.Clear();
                dgvPermission.DataSource = dtPermission;
            }

            if (dgvList.DataSource != null)
            {
                dtLists = (DataTable)dgvList.DataSource;
                dtLists.Rows.Clear();
                dgvList.DataSource = dtLists;
            }
        }

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

        #region Lists

        private void Init_DataTable_Lists()
        {
            dtLists = new DataTable();
            dtLists.Columns.Add("list_ID", typeof(int));
            dtLists.Columns.Add("list_Nom", typeof(string));
        }

        private void LoadLists()
        {
            dtLists.Rows.Clear();
            var rs = db.Select_Lists().ToList();
            foreach (var item in rs)
                dtLists.Rows.Add(item.list_ID, item.list_Nom);
            dgvList.DataSource = dtLists;
        }

        #endregion Lists

        #region Permission

        private void Init_DataTable_Permission()
        {
            dtPermission = new DataTable();
            dtPermission.Columns.Add("util_ID", typeof(int));
            dtPermission.Columns.Add("scrn_ID", typeof(int));
            dtPermission.Columns.Add("scrn_Nom", typeof(string));
            dtPermission.Columns.Add("priv_Afficher", typeof(bool));
            dtPermission.Columns.Add("priv_Ajouter", typeof(bool));
            dtPermission.Columns.Add("priv_Modifier", typeof(bool));
            dtPermission.Columns.Add("priv_Supprimer", typeof(bool));
        }

        private void LoadPermission(int idList)
        {
            dtPermission.Rows.Clear();
            var rs = db.Select_Priv(idUtilisateur, idList).ToList();
            //Init_DataTable();
            foreach (var item in rs)
                dtPermission.Rows.Add(item.util_ID, item.scrn_ID, item.scrn_Nom, item.priv_Afficher, item.priv_Ajouter, item.priv_Modifier, item.priv_Supprimer);
            dgvPermission.DataSource = dtPermission;
        }

        private bool Update_Permission()
        {
            try
            {
                for (int i = 0; i < dgvPermission.Rows.Count; i++)
                {
                    int idScreen = (int)dgvPermission.Rows[i].Cells[colscrn_ID.Name].Value;
                    bool affichage = dgvPermission.Rows[i].Cells[colpriv_Afficher.Name].Value.Equals(true || false);
                    bool ajouter = dgvPermission.Rows[i].Cells[colpriv_Ajouter.Name].Value.Equals(true || false);
                    bool modifier = dgvPermission.Rows[i].Cells[colpriv_Modifier.Name].Value.Equals(true || false);
                    bool supprimer = dgvPermission.Rows[i].Cells[colpriv_Supprimer.Name].Value.Equals(true || false);
                    db.Update_Priv(idUtilisateur, idScreen, affichage, ajouter, modifier, supprimer);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion Permission

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
            ckbAdmin.Checked = false;
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
                idUtilisateur = maxID();
                var rs = db.Insert_Utilisateur(idUtilisateur, idPersonnel, DateTime.Now, txtUsername.Text, txtPassword.Text, (int)cmbxService.SelectedValue, null).FirstOrDefault();
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
                db.Update_Utilisateur(idUtilisateur, idPersonnel, txtUsername.Text, txtPassword.Text, (int)cmbxService.SelectedValue);

                //Update permission
                if (Update_Permission())
                {
                    iTools.sucMsg("Information", "Utilisateur a bien modifié");
                    VerifyButton(false);
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Delete_Data()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer cet utilisateur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    int rs = (int)db.Delete_Utilisateur(idUtilisateur);

                    //form.txtStatus.Caption = "Votre code a bien ajouté";
                    iTools.sucMsg("Information", "L'utilisateur a bien supprimé");
                    newRecord();
                    empty_Data();
                }
                catch (Exception ex)
                {
                    iTools.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
        }

        #endregion Codes

        #region Constracteur

        public frmPermission()
        {
            InitializeComponent();
            Init_DataTable_Permission();
            Init_DataTable_Lists();
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
                LoadLists();
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
                idUtilisateur = vl.util_ID;
                txtUsername.Text = vl.util_Identifiant;
                cmbxService.SelectedValue = (int)vl.svc_ID;
                txtPassword.Text = vl.util_MotPasse;
                txtRPassword.Text = vl.util_MotPasse;
                VerifyButton(false);
                dgvList_SelectionChanged(null, null);
            }
            else
            {
                txtUsername.Text = string.Empty;
                cmbxService.SelectedValue = -1;
                txtPassword.Text = string.Empty;
                txtRPassword.Text = string.Empty;
                VerifyButton(true);
                empty_Data();
                dgvList_SelectionChanged(null, null);
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
            empty_Data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtSearchPersonnel_TextChanged(object sender, EventArgs e)
        {
        }

        private void ckbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdmin.Checked == true)
            {
                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    int idList = (int)dgvList.Rows[i].Cells[collist_ID.Name].Value;
                    var rs = db.Select_Screen_By_idList(idList).ToList();
                    foreach (var item in rs)
                    {
                        db.Update_Priv(idUtilisateur, item.scrn_ID, true, true, true, true);
                    }
                }
            }
            dgvList_SelectionChanged(null, null);
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvList.CurrentCell.RowIndex;
                int idList = (int)dgvList.Rows[index].Cells[collist_ID.Name].Value;
                LoadPermission(idList);
            }
            catch (Exception)
            {
            }
        }
    }
}