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
    public partial class frmLBonRetour : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        public int idBonRetour;
        private int idBonArt;
        private int idService = Properties.Settings.Default.idService;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private void CountRows(int count, Label lbl)
        {
            lbl.Text = $"Ligne: {count}";
        }

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de retour courants", getID_Lists("Retours")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de retour courants", getID_Lists("Retours")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        #endregion Permission

        #region Bon d'entree

        public void getData_RBon()
        {
            dgvEBon.DataSource = db.Select_Bon_Retour().ToList();
            CountRows(dgvEBon.Rows.Count, lblCountB);
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
            colEtat.DisplayIndex = 6;
            colbt_Qte_Livree.DisplayIndex = 7;
            colbt_A_Description.DisplayIndex = 8;
        }

        #endregion Articles

        #region Mouvement

        private int getUMesureIDByidArticle(int bt_A_ID)
        {
            return (int)db.get_Bon_Retour_Article(bt_A_ID).FirstOrDefault().unit_M_ID;
        }

        private decimal getCoefficient(int idUMesure)
        {
            return (decimal)db.get_Unite_Mesure_By_ID(idUMesure).FirstOrDefault().unit_M_Coefficient;
        }

        private void mvt_Retour()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (!VerifiStatusBonArticle(idBonRetour))
                    {
                        MessageBox.Show("Veuillez régler ce bon avec ses articles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool rs = false;
                    foreach (int ba in getId_Bon_Article(idBonRetour))
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
                                    int rss = (int)db.Insert_Mouvement(max, getDateBon(idBonRetour), getDocRefBon(idBonRetour), reff.Key, vl, art, reff.Value, getCoefficient(idUMesure), idUMesure, "R", idBonRetour, null, null, ba).FirstOrDefault();
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
                        Bon_Retour ba = getBon(idBonRetour);
                        int output = (int)db.History_Bon_Retour(ba.bt_ID).FirstOrDefault();

                        switch (output)
                        {
                            case 1:
                                transaction.Commit();
                                db.SaveChanges();
                                getData_RBon();
                                iTools.sucMsg("Information", "Votre bon a bien exploité");
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    iTools.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
        }

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

        #region Overrides

        public override void openForm()
        {
            base.openForm();

            frmAddRArticle frm = new frmAddRArticle(this, getBon(idBonRetour));
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
            //            int rs = (int)db.Delete_Bon_reference_By_idBonArtEntree(idBonArt).FirstOrDefault();
            //            switch (rs)
            //            {
            //                case 1:
            //                    int rs1 = (int)db.Delete_Bon_Entree_Article_By_ID(idBonArt).FirstOrDefault();
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

        public frmLBonRetour()
        {
            InitializeComponent();
            getData_RBon();
        }

        #endregion New

        private void btnBonNew_Click(object sender, EventArgs e)
        {
            frmBonRetour frmBon = new frmBonRetour(this);
            frmBon.Text = "Ajouter un bon de retour";
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
                bool rs = Convert.ToBoolean(dgvA_EBon.Rows[e.RowIndex].Cells[colbt_A_Etat.Name].Value);
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
                if (dgvEBon.CurrentCell.RowIndex != -1 || dgvEBon.CurrentCell.ColumnIndex != -1)
                {
                    db = new ges_AutoEntities();
                    string item = $"{dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbt_Designation.Name].Value}";
                    idBonRetour = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_bt_ID.Name].Value.ToString());
                    if (item != null)
                    {
                        dgvA_EBon.DataSource = db.Select_v_Bon_Retour_Article(getIdRBon(item)).ToList();
                        CountRows(dgvA_EBon.Rows.Count, lblCountA);
                        PositionColumns();
                    }
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
                        mvt_Retour();
                    }
                }
            }
            else
            {
                mvt_Retour();
            }
        }

        private void dgvA_EBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvA_EBon.CurrentRow != null)
                {
                    btnSupprimer.Enabled = true;
                    idBonArt = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbt_A_ID.Name].Value.ToString());
                }
                else
                    btnSupprimer.Enabled = false;
                Refresh_Button_Supprimer();
            }
            catch (Exception)
            {
            }
        }

        private void txtSearchA_TextChanged(object sender, EventArgs e)
        {
            string item = $"{dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colbt_Designation.Name].Value}";

            if (txtSearchA.Text == "Recherche")
                dgvA_EBon.DataSource = db.Select_v_Bon_Retour_Article(getIdRBon(item)).ToList();
            else
                dgvA_EBon.DataSource = db.Search_Bon_Retour_Article(txtSearchA.Text, idBonRetour);

            CountRows(dgvA_EBon.Rows.Count, lblCountA);
            PositionColumns();
        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchB.Text == "Recherche")
                getData_RBon();
            else
            {
                dgvEBon.DataSource = db.Search_Bon_Retour(txtSearchB.Text);
                CountRows(dgvEBon.Rows.Count, lblCountB);
            }
        }

        private void dgvA_EBon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;
                int id = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbt_A_ID.Name].Value.ToString());
                Bon_Retour_Article ei = db.get_Bon_Retour_Article(id).FirstOrDefault();
                //MessageBox.Show(ei.bs_A_ID.ToString());
                frmAddRArticle frm = new frmAddRArticle(this, ei);
                frm.Text = "Modifier un article";
                frm.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;
                db = new ges_AutoEntities();
                int item = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_bt_ID.Name].Value.ToString());
                idBonRetour = item;
                Bon_Retour bs = db.get_Bon_Retour(item).FirstOrDefault();
                frmBonRetour form = new frmBonRetour(this, bs);
                form.Text = "Modifier un bon de retour";
                form.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
    }
}