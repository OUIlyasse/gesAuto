using DAL.DB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmH_Entree : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonEntree, idBonArt;
        private int idService = Properties.Settings.Default.idService;

        #endregion Variables

        #region Codes

        #region Bon d'entree

        public void getData_EBon()
        {
            var rs = db.Select_H_Bon_Entree().ToList();
            dgvEBon.DataSource = rs;
        }

        private int getIdEBon(string item)
        {
            return (int)db.Select_Bon_Entree_By_Designation(item).FirstOrDefault();
        }

        private Bon_Entree getBon(int idBon)
        {
            return db.get_Bon_Entree(idBon).FirstOrDefault();
        }

        #endregion Bon d'entree

        #region Articles

        private void PositionColumns()
        {
            colbe_A_ID.DisplayIndex = 0;
            colbe_ID.DisplayIndex = 1;
            colbe_A_Date.DisplayIndex = 2;
            colvl_Marque.DisplayIndex = 3;
            colart_Designation.DisplayIndex = 4;
            colbe_A_Etat.DisplayIndex = 5;
            colbe_Qte_Demandee.DisplayIndex = 6;
            colbe_Qte_Livree.DisplayIndex = 7;
            colbe_Qte_Manque.DisplayIndex = 8;
            colbe_A_Description.DisplayIndex = 9;
        }

        #endregion Articles

        #endregion Codes

        public frmH_Entree()
        {
            InitializeComponent();
            getData_EBon();
        }

        private void frmH_Entree_Load(object sender, EventArgs e)
        {
            PositionColumns();
        }

        private void dgvEBon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                int item = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_be_ID.Name].Value.ToString());
                idBonEntree = item;
                Bon_Entree bs = db.Show_Bon_Entree_By_ID(item).FirstOrDefault();
                frmHBonEntree form = new frmHBonEntree(bs);
                form.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void dgvA_EBon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvA_EBon.RowCount > 0)
                {
                    int id = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbe_A_ID.Name].Value.ToString());
                    Bon_Entree_Article ei = db.Get_Bon_Entree_Article(id).FirstOrDefault();
                    //MessageBox.Show(ei.bs_A_ID.ToString());
                    frmHEArticle frm = new frmHEArticle(ei);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchA_TextChanged(object sender, EventArgs e)
        {
            dgvA_EBon.DataSource = db.Search_Bon_Entree_Article(txtSearchA.Text, idBonEntree);
            lblCountA.Text = $"Ligne: {dgvA_EBon.Rows.Count}";
        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            dgvEBon.DataSource = db.Search_Bon_Entree_H(txtSearchB.Text);
            lblCountB.Text = $"Ligne: {dgvEBon.Rows.Count}";
        }

        private void dgvEBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                string item = $"{dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbe_Designation.Name].Value}";
                idBonEntree = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_be_ID.Name].Value.ToString());
                if (item != null)
                {
                    dgvA_EBon.DataSource = db.Select_Bon_Entree_Article(getIdEBon(item)).ToList();
                    PositionColumns();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}