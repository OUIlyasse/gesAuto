﻿using DAL.DB;
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
    public partial class frmR_Stock : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int rowSelected;

        #endregion Variables

        #region Codes

        private int getIdArticle(string designation)
        {
            return db.get_Article_Info_By_Designation(designation).FirstOrDefault().art_ID;
        }

        private string getUMesure(int idArt)
        {
            return db.Select_Unite_Mesure_By_Art_isDefault(idArt).FirstOrDefault().unit_M_Nom;
        }

        private void getData()
        {
            var rs = db.SommeQte();
            dgvStock.DataSource = rs;
        }

        private void LoadCondition()
        {
            List<string> rs = new List<string> { "Est égale à", "Est différent de", "Commence par", "Se termine par", "Contient" };
            cmbxCondition.DataSource = rs;
            cmbxCondition.SelectedIndex = 4;
        }

        private void LoadTable()
        {
            List<string> rs = new List<string> { "Tous", "Véhicule", "Article", "Référence" };
            cmbxTable.DataSource = rs;
            cmbxTable.SelectedIndex = 0;
        }

        private void search()
        {
            try
            {
                dgvStock.DataSource = db.Search_R_Stock(txtSearch.Text, cmbxTable.Text, cmbxCondition.Text).ToList();
            }
            catch (Exception)
            {
            }
        }

        #endregion Codes

        public frmR_Stock()
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