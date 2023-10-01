using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmSuivieUsers : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();

        #endregion Variables

        #region Codes

        private void getData()
        {
            dgvPersonnel.DataSource = db.Select_v_Enregistrement();
            lblCount.Text = $"Ligne: {dgvPersonnel.Rows.Count}";
        }

        #endregion Codes

        public frmSuivieUsers()
        {
            InitializeComponent();
        }

        private void frmSuivieUsers_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Recherche")
                getData();
            else
            {
                dgvPersonnel.DataSource = db.Search_v_Enregistrement(txtSearch.Text);
                lblCount.Text = $"Ligne: {dgvPersonnel.Rows.Count}";
            }
        }
    }
}