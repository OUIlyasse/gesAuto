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
            VerifyButton(true);
            txtNom.Focus();
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
                txtRPassword.Enabled = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRPassword.Enabled = true;
            }
        }
    }
}