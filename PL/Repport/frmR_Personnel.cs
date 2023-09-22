using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PL.Repport
{
    public partial class frmR_Personnel : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int rowSelected;
        private int idService = Properties.Settings.Default.idService;

        #endregion Variables

        #region Codes

        private void getData()
        {
            dgvPersonnel.DataSource = db.Select_pers_Affecte().ToList();
        }

        private void LoadCondition()
        {
            List<string> rs = new List<string> { "Est égale à", "Est différent de", "Commence par", "Se termine par", "Contient" };
            cmbxCondition.DataSource = rs;
            cmbxCondition.SelectedIndex = 4;
        }

        private void LoadTable()
        {
            List<string> rs = new List<string> { "Tous", "Famille", "Article", "Abreviation" };
            cmbxTable.DataSource = rs;
            cmbxTable.SelectedIndex = 0;
        }

        private void search()
        {
            try
            {
                dgvPersonnel.DataSource = db.Search_R_Personnel(txtSearch.Text).ToList();
            }
            catch (Exception)
            {
            }
        }

        #endregion Codes

        public frmR_Personnel()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                getData();
            else
                search();
        }

        private void cmbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxTable.SelectedIndex != -1)
            {
                search();
            }
        }

        private void cmbxCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxCondition.SelectedIndex != -1)
            {
                search();
            }
        }

        private void frmR_Stock_Load(object sender, EventArgs e)
        {
            getData();
            LoadCondition();
            LoadTable();
        }
    }
}