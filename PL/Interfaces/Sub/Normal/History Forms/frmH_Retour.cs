using DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmH_Retour : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        public int idBonRetour;
        private int idBonArt;
        private int idService = Properties.Settings.Default.idService;

        #endregion Variables

        #region Codes

        private void CountRow(int count, Label lbl)
        {
            lbl.Text = $"Ligne: {count}";
        }

        #region Bon d'entree

        public void getData_RBon()
        {
            var rs = db.Select_H_Bon_Retour().ToList();
            dgvEBon.DataSource = rs;
            CountRow(dgvEBon.Rows.Count, lblCountB);
        }

        private int getIdRBon(string item)
        {
            return (int)db.Select_Bon_Retour_By_Designation(item).FirstOrDefault();
        }

        private Bon_Retour getBon(int idBon)
        {
            return db.get_Bon_Retour(idBon).FirstOrDefault();
        }

        #endregion Bon d'entree

        #region Articles

        private void PositionColumns()
        {
            colbt_A_ID.DisplayIndex = 0;
            colbt_ID.DisplayIndex = 1;
            colbt_A_Date.DisplayIndex = 2;
            colvl_Marque.DisplayIndex = 3;
            colart_Designation.DisplayIndex = 4;
            colbt_A_Etat.DisplayIndex = 5;
            colbt_Qte_Livree.DisplayIndex = 6;
            colbt_A_Description.DisplayIndex = 7;
        }

        #endregion Articles

        #region Mouvement

        private string getDocRefBon(int idBonEntree)
        {
            return db.get_Bon_Retour(idBonEntree).FirstOrDefault().bt_Reference;
        }

        private DateTime getDateBon(int idBonEntree)
        {
            return (DateTime)db.get_Bon_Retour(idBonEntree).FirstOrDefault().bt_Date;
        }

        private int maxID_Mouvement()
        {
            return (int)db.MAX_Mouvement().FirstOrDefault() + 1;
        }

        private Dictionary<int, decimal> getReferences(int bt_A_ID)
        {
            Dictionary<int, decimal> list = new Dictionary<int, decimal>();
            foreach (var id in db.Select_Bon_reference_idBonArtRetour(bt_A_ID).ToList())
                list.Add((int)id.ref_ID, (decimal)id.br_Qte);

            return list;
        }

        private List<int> getArticleByID(int bt_A_ID)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Retour_Article_By_ID(bt_A_ID).ToList())
                list.Add((int)id.art_ID);
            return list;
        }

        private List<int> getVLByID(int bt_A_ID)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Retour_Article_By_ID(bt_A_ID).ToList())
                list.Add((int)id.vl_ID);
            return list;
        }

        private List<int> getId_Bon_Article(int idBon)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Retour_Article_By_idBon(idBon).ToList())
                list.Add(id.bt_A_ID);
            return list;
        }

        private bool VerifiStatusBonArticle(int idBon)
        {
            bool rs = false;
            foreach (int item in getId_Bon_Article(idBon))
            {
                var rss = (bool)db.get_Bon_Retour_Article(item).FirstOrDefault().bt_A_Etat;
                if (!rss)
                    break;
                else
                    rs = true;
            }

            return rs;
        }

        #endregion Mouvement

        #endregion Codes

        #region New

        public frmH_Retour()
        {
            InitializeComponent();
            getData_RBon();
        }

        #endregion New

        private void frmLBonEntree_Load(object sender, EventArgs e)
        {
            PositionColumns();
            CountRow(dgvA_EBon.Rows.Count, lblCountA);
            CountRow(dgvEBon.Rows.Count, lblCountB);
        }

        public void dgvEBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEBon.CurrentCell.RowIndex != -1 || dgvEBon.CurrentCell.ColumnIndex != -1)
                {
                    db = new ges_AutoEntities();
                    string item = $"{dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbt_Designation.Name].Value}";
                    idBonRetour = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_bt_ID.Name].Value.ToString());
                    if (item != null)
                    {
                        dgvA_EBon.DataSource = db.Select_v_Bon_Retour_Article(getIdRBon(item)).ToList();
                        CountRow(dgvA_EBon.Rows.Count, lblCountA);
                        PositionColumns();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                int item = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_bt_ID.Name].Value.ToString());
                idBonRetour = item;
                Bon_Retour bs = db.get_Bon_Retour(item).FirstOrDefault();
                frmHBonRetour form = new frmHBonRetour(bs);
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
                    int id = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbt_A_ID.Name].Value.ToString());
                    Bon_Retour_Article ei = db.get_Bon_Retour_Article(id).FirstOrDefault();
                    //MessageBox.Show(ei.bs_A_ID.ToString());
                    frmHRArticle frm = new frmHRArticle(ei);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string item = $"{dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbt_Designation.Name].Value}";

                if (txtSearchA.Text == "Recherche")
                    dgvEBon_SelectionChanged(null, null);
                else
                    dgvA_EBon.DataSource = db.Search_Bon_Retour_Article(txtSearchA.Text, idBonRetour);
                CountRow(dgvA_EBon.Rows.Count, lblCountA);
                PositionColumns();
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchB.Text == "Recherche")
                getData_RBon();
            else
            {
                dgvEBon.DataSource = db.Search_Bon_Retour_H(txtSearchB.Text);
                CountRow(dgvEBon.Rows.Count, lblCountB);
            }
        }
    }
}