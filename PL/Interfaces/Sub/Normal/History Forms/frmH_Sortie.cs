using DAL.DB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmH_Sortie : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonEntree, idBonArt;
        private int idService = Properties.Settings.Default.idService;

        #endregion Variables

        #region Codes

        private void CountRow(int count, Label lbl)
        {
            lbl.Text = $"Ligne: {count}";
        }

        #region Bon d'entree

        public void getData_SBon()
        {
            var rs = db.Select_H_Bon_Sortie().ToList();
            dgvSBon.DataSource = rs;
        }

        private int getIdSBon(string item)
        {
            return (int)db.Select_Bon_Sortie_By_Designation(item).FirstOrDefault();
        }

        private Bon_Sortie getBon(int idBon)
        {
            return db.Get_Bon_Sortie_By_ID(idBon).FirstOrDefault();
        }

        #endregion Bon d'entree

        #region Articles

        private void PositionColumns()
        {
            colbs_A_ID.DisplayIndex = 0;
            colbs_ID.DisplayIndex = 1;
            colbs_A_Date.DisplayIndex = 2;
            colvl_Marque.DisplayIndex = 3;
            colart_Designation.DisplayIndex = 4;
            colbs_A_Etat.DisplayIndex = 5;
            colbs_Qte_Demandee.DisplayIndex = 6;
            colbs_Qte_Livree.DisplayIndex = 7;
            colbs_Qte_Manque.DisplayIndex = 8;
            colbs_A_Description.DisplayIndex = 9;
        }

        #endregion Articles

        #endregion Codes

        public frmH_Sortie()
        {
            InitializeComponent();
            getData_SBon();
        }

        private void dgvA_SBon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvA_SBon.RowCount > 0)
                {
                    int id = int.Parse(dgvA_SBon.Rows[dgvA_SBon.CurrentRow.Index].Cells[colbs_A_ID.Name].Value.ToString());
                    Bon_Sortie_Article ei = db.Get_Bon_Sortie_Article(id).FirstOrDefault();
                    //MessageBox.Show(ei.bs_A_ID.ToString());
                    frmHSArticle frm = new frmHSArticle(ei);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvSBon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                int item = int.Parse(dgvSBon.Rows[dgvSBon.CurrentRow.Index].Cells[colbs_ID.Name].Value.ToString());
                idBonEntree = item;
                Bon_Sortie bs = db.Get_Bon_Sortie_By_ID(item).FirstOrDefault();
                frmHBonSortie form = new frmHBonSortie(bs);
                form.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void frmH_Sortie_Load(object sender, EventArgs e)
        {
            PositionColumns();
        }

        private void txtSearchA_TextChanged(object sender, EventArgs e)
        {
            string item = $"{dgvSBon.Rows[dgvSBon.CurrentRow.Index].Cells[colbs_Designation.Name].Value}";

            if (string.IsNullOrEmpty(txtSearchA.Text))
                dgvA_SBon.DataSource = db.Select_Bon_Sortie_Article(getIdSBon(item)).ToList();
            else
            {
                dgvA_SBon.DataSource = db.Search_Bon_Sortie_Article(txtSearchA.Text, idBonEntree);
            }
            CountRow(dgvA_SBon.Rows.Count, lblCountA);
            PositionColumns();
        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchB.Text))
                getData_SBon();
            else
            {
                dgvSBon.DataSource = db.Search_Bon_Sortie_H(txtSearchB.Text);
                CountRow(dgvSBon.Rows.Count, lblCountB);
            }
        }

        private void dgvSBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                string item = $"{dgvSBon.Rows[dgvSBon.CurrentRow.Index].Cells[colbs_Designation.Name].Value}";
                idBonEntree = int.Parse(dgvSBon.Rows[dgvSBon.CurrentRow.Index].Cells[colbs_ID.Name].Value.ToString());
                if (item != null)
                {
                    dgvA_SBon.DataSource = db.Select_Bon_Sortie_Article(getIdSBon(item)).ToList();
                    PositionColumns();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}