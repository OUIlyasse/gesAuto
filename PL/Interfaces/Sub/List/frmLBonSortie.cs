using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using PL.Interfaces.Sub.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLBonSortie : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        public int idBonSortie;
        private int idBonArt;
        private int idService = Properties.Settings.Default.idService;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de sortie courants", getID_Lists("Sorties")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de sortie courants", getID_Lists("Sorties")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        #endregion Permission

        #region Bon sortie

        public void getData_SBon()
        {
            var rs = db.Select_Bon_Sortie().ToList();
            dgvEBon.DataSource = rs;
        }

        private int getIdSBon(string item)
        {
            return (int)db.Select_Bon_Sortie_By_Designation(item).FirstOrDefault();
        }

        private Bon_Sortie getBon(int idBon)
        {
            return db.Get_Bon_Sortie_By_ID(idBon).FirstOrDefault();
        }

        #endregion Bon sortie

        #region Articles

        private void PositionColumns()
        {
            colbs_A_ID.DisplayIndex = 0;
            colbs_ID.DisplayIndex = 1;
            colbs_A_Date.DisplayIndex = 2;
            colvl_Marque.DisplayIndex = 3;
            colart_Designation.DisplayIndex = 4;
            colbs_A_Etat.DisplayIndex = 5;
            colEtat.DisplayIndex = 6;
            colbs_Qte_Demandee.DisplayIndex = 7;
            colbs_Qte_Livree.DisplayIndex = 8;
            colbs_Qte_Manque.DisplayIndex = 9;
            colbs_A_Description.DisplayIndex = 10;
        }

        #endregion Articles

        #region Mouvement

        private int getUMesureIDByidArticle(int bs_A_ID)
        {
            return (int)db.Get_Bon_Sortie_Article(bs_A_ID).FirstOrDefault().unit_M_ID;
        }

        private decimal getCoefficient(int idUMesure)
        {
            return (decimal)db.get_Unite_Mesure_By_ID(idUMesure).FirstOrDefault().unit_M_Coefficient;
        }

        private void mvt_Sortie()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                //try
                //{
                if (!VerifiStatusBonArticle(idBonSortie))
                {
                    MessageBox.Show("Veuillez régler ce bon avec ses articles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool rs = false;
                foreach (int ba in getId_Bon_Article(idBonSortie))
                {
                    foreach (var vl in getVLByID(ba))
                    {
                        foreach (var art in getArticleByID(ba))
                        {
                            foreach (var reff in getReferences(ba))
                            {
                                //str += $"VL: {getVLByID(ba)} || Art: {getArticleByID(ba)} || ref: {getReferenceByID(reff.Key)} || Qte: {reff.Value.ToString()}" + Environment.NewLine;
                                int max = maxID_Mouvement();
                                int idUMesure = getUMesureIDByidArticle(ba);
                                //MessageBox.Show($"{max.ToString()} {ba} {reff}");
                                int rss = (int)db.Insert_Mouvement(max, getDateBon(idBonSortie), getDocRefBon(idBonSortie), reff.Key, vl, art, reff.Value, getCoefficient(idUMesure), idUMesure, "S", idBonSortie, ba, null, null).FirstOrDefault();
                                switch (rss)
                                {
                                    case 1:
                                        //transaction.Commit();
                                        rs = true;
                                        break;
                                }
                            }
                        }
                    }
                }
                if (rs)
                {
                    Bon_Sortie ba = getBon(idBonSortie);
                    int output = (int)db.History_Bon_Sortie(ba.bs_ID).FirstOrDefault();

                    switch (output)
                    {
                        case 1:
                            transaction.Commit();
                            db.SaveChanges();
                            getData_SBon();
                            iTools.sucMsg("Information", "Votre bon a bien exploité");
                            break;
                    }
                }
                //}
                //catch (Exception ex)
                //{
                //    transaction.Rollback();
                //    iTools.errorMsg("Erreur", ex.Message);
                //    //form.txtStatus.Caption = ex.Message;
                //}
            }
        }

        private string getDocRefBon(int idBon)
        {
            return db.Get_Bon_Sortie_By_ID(idBon).FirstOrDefault().bs_Reference;
        }

        private DateTime getDateBon(int idBon)
        {
            return (DateTime)db.Get_Bon_Sortie_By_ID(idBon).FirstOrDefault().bs_Date;
        }

        private int maxID_Mouvement()
        {
            return (int)db.MAX_Mouvement().FirstOrDefault() + 1;
        }

        private Dictionary<int, decimal> getReferences(int bs_A_ID)
        {
            Dictionary<int, decimal> list = new Dictionary<int, decimal>();
            foreach (var id in db.Select_Bon_reference_idBonArtSortie(bs_A_ID).ToList())
                list.Add((int)id.ref_ID, (decimal)id.br_Qte);

            return list;
        }

        private List<int> getArticleByID(int bs_A_ID)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Sortie_Article_By_ID(bs_A_ID).ToList())
                list.Add((int)id.art_ID);
            return list;
        }

        private List<int> getVLByID(int bs_A_ID)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Sortie_Article_By_ID(bs_A_ID).ToList())
                list.Add((int)id.vl_ID);
            return list;
        }

        private List<int> getId_Bon_Article(int idBon)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Sortie_Article_By_idBon(idBon).ToList())
                list.Add(id.bs_A_ID);
            return list;
        }

        private bool VerifiStatusBonArticle(int idBon)
        {
            bool rs = false;
            foreach (int item in getId_Bon_Article(idBon))
            {
                var rss = (bool)db.Get_Bon_Sortie_Article(item).FirstOrDefault().bs_A_Etat;
                if (!rss)
                    break;
                else
                    rs = true;
            }

            return rs;
        }

        #endregion Mouvement

        #endregion Codes

        #region Overrides

        public override void openForm()
        {
            base.openForm();

            frmAddSArticle frm = new frmAddSArticle(this, getBon(idBonSortie));
            frm.Text = "Ajouter des articles";
            frm.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            //DialogResult re = MessageBox.Show("Voulez-vous supprimer cet article", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (re == DialogResult.Yes)
            //{
            //    using (var transaction = db.Database.BeginTransaction())
            //    {
            //        try
            //        {
            //            int rs = (int)db.Delete_Bon_reference_By_idBonArtSortie(idBonArt).FirstOrDefault();
            //            switch (rs)
            //            {
            //                case 1:
            //                    int rs1 = (int)db.Delete_Bon_Sortie_Article_By_ID(idBonArt).FirstOrDefault();
            //                    switch (rs1)
            //                    {
            //                        case 1:
            //                            transaction.Commit();
            //                            //form.txtStatus.Caption = "Votre code a bien ajouté";
            //                            iTools.sucMsg("Information", "Votre article a bien supprimé");
            //                            dgvEBon_SelectionChanged(null, null);

            //                            break;
            //                    }
            //                    break;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            transaction.Rollback();
            //            iTools.errorMsg("Erreur", ex.Message);
            //            //form.txtStatus.Caption = ex.Message;
            //        }
            //    }
            //}
        }

        #endregion Overrides

        #region New

        public frmLBonSortie()
        {
            InitializeComponent();
            getData_SBon();
        }

        #endregion New

        private void btnBonNew_Click(object sender, EventArgs e)
        {
            frmBonSortie frmBon = new frmBonSortie(this);
            frmBon.Text = "Ajouter un bon de sortie";
            frmBon.ShowDialog();
        }

        private void frmLBonEntree_Load(object sender, EventArgs e)
        {
            PositionColumns();
            Refresh_Button_Ajouter();
        }

        private void dgvA_EBon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvA_EBon.Columns[e.ColumnIndex].Name == colEtat.Name)
            {
                bool rs = Convert.ToBoolean(dgvA_EBon.Rows[e.RowIndex].Cells[colbs_A_Etat.Name].Value);
                if (rs == true)
                    e.Value = Properties.Resources.Vérifié_32;
                else
                    e.Value = PL.Properties.Resources.Avertissement_Bouclier_32;
            }
        }

        public void dgvEBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db = new ges_AutoEntities();
                string item = $"{dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbs_Designation.Name].Value}";
                idBonSortie = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbs_ID.Name].Value.ToString());
                if (item != null)
                {
                    dgvA_EBon.DataSource = db.Select_Bon_Sortie_Article(getIdSBon(item)).ToList();
                    PositionColumns();
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
                int item = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbs_ID.Name].Value.ToString());
                idBonSortie = item;
                Bon_Sortie bs = db.Get_Bon_Sortie_By_ID(item).FirstOrDefault();
                frmBonSortie form = new frmBonSortie(this, bs);
                form.Text = "Modifier un bon de sortie";
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
                    int id = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbs_A_ID.Name].Value.ToString());
                    Bon_Sortie_Article ei = db.Get_Bon_Sortie_Article(id).FirstOrDefault();
                    //MessageBox.Show(ei.bs_A_ID.ToString());
                    frmAddSArticle frm = new frmAddSArticle(this, ei);
                    frm.Text = "Modifier un article";
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBon_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menuBon;
        }

        private void btnEntreeStock_Click(object sender, EventArgs e)
        {
            bool isConfirmation = Properties.Settings.Default.isConfirmation;
            if (isConfirmation)
            {
                using (frmConfirmation frm = new frmConfirmation())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrWhiteSpace(frm.Output))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        mvt_Sortie();
                    }
                }
            }
            else
            {
                mvt_Sortie();
            }
        }

        private void dgvA_EBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvA_EBon.CurrentRow != null)
                {
                    btnSupprimer.Enabled = true;
                    idBonArt = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbs_A_ID.Name].Value.ToString());
                }
                else
                    btnSupprimer.Enabled = false;
                Refresh_Button_Supprimer();
            }
            catch (Exception)
            {
            }
        }
    }
}