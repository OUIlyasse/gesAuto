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

        private void LoadOperateur()
        {
            List<string> rs = new List<string> { "=", ">", "<", ">=", "<=", "<>" };
            cmbxOperateur.DataSource = rs;
        }

        private void LoadCondition()
        {
            List<string> rs = new List<string> { "Debut", "Contient", "Fin", "egal", "non egal" };
            cmbxCondition.DataSource = rs;
        }

        private void LoadTable()
        {
            List<string> rs = new List<string> { "Tous", "Véhicule", "Article", "Reference" };
            cmbxTable.DataSource = rs;
        }

        #endregion Codes

        public frmR_Stock()
        {
            InitializeComponent();
            getData();
            LoadOperateur();
            LoadCondition();
            LoadTable();
        }
    }
}