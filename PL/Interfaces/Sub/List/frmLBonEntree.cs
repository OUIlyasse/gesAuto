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
    public partial class frmLBonEntree : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonEntree, idBonArt;
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
            var rs = db.Select_Priv_Screen(idUtilisateur, "Reception d'un BL", getID_Lists("Entrees")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Reception d'un BL", getID_Lists("Entrees")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        #endregion Permission

        #region Bon d'entree

        public void getData_EBon()
        {
            //List<string> list = new List<string>();

            var rs = db.Select_Bon_Entree().ToList();
            //foreach (var item in result)
            //    list.Add(item.be_Designation);
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
            colEtat.DisplayIndex = 6;
            colbe_Qte_Demandee.DisplayIndex = 7;
            colbe_Qte_Livree.DisplayIndex = 8;
            colbe_Qte_Manque.DisplayIndex = 9;
            colbe_A_Description.DisplayIndex = 10;
        }

        private decimal getCoefficient(int idUMesure)
        {
            return (decimal)db.get_Unite_Mesure_By_ID(idUMesure).FirstOrDefault().unit_M_Coefficient;
        }

        #endregion Articles

        #region Mouvement

        private void mvt_Entree()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (!VerifiStatusBonArticle(idBonEntree))
                    {
                        MessageBox.Show("Veuillez régler ce bon avec ses articles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool rs = false;
                    foreach (int ba in getId_Bon_Article(idBonEntree))
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
                                    int rss = (int)db.Insert_Mouvement(max, getDateBon(idBonEntree), getDocRefBon(idBonEntree), reff.Key, vl, art, reff.Value, getCoefficient(idUMesure), idUMesure, "E", idBonEntree, null, ba, null).FirstOrDefault();
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
                        Bon_Entree ba = getBon(idBonEntree);
                        int output = (int)db.History_Bon_Entree(ba.be_ID).FirstOrDefault();

                        switch (output)
                        {
                            case 1:
                                transaction.Commit();
                                db.SaveChanges();
                                getData_EBon();
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
            return db.get_Bon_Entree(idBonEntree).FirstOrDefault().be_Reference;
        }

        private DateTime getDateBon(int idBonEntree)
        {
            return (DateTime)db.get_Bon_Entree(idBonEntree).FirstOrDefault().be_Date;
        }

        private int maxID_Mouvement()
        {
            return (int)db.MAX_Mouvement().FirstOrDefault() + 1;
        }

        private Dictionary<int, decimal> getReferences(int be_A_ID)
        {
            Dictionary<int, decimal> list = new Dictionary<int, decimal>();
            foreach (var id in db.Select_Bon_reference_idBonArtEntree(be_A_ID).ToList())
                list.Add((int)id.ref_ID, (decimal)id.br_Qte);

            return list;
        }

        private int getUMesureIDByidArticle(int be_A_ID)
        {
            return (int)db.Get_Bon_Entree_Article(be_A_ID).FirstOrDefault().unit_M_ID;
        }

        private List<int> getArticleByID(int be_A_ID)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Entree_Article_By_ID(be_A_ID).ToList())
                list.Add((int)id.art_ID);
            return list;
        }

        private List<int> getVLByID(int be_A_ID)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Entree_Article_By_ID(be_A_ID).ToList())
                list.Add((int)id.vl_ID);
            return list;
        }

        private List<int> getId_Bon_Article(int idBon)
        {
            List<int> list = new List<int>();
            foreach (var id in db.Select_Bon_Entree_Article_By_idBon(idBon).ToList())
                list.Add(id.be_A_ID);
            return list;
        }

        private bool VerifiStatusBonArticle(int idBon)
        {
            bool rs = false;
            foreach (int item in getId_Bon_Article(idBon))
            {
                var rss = (bool)db.Get_Bon_Entree_Article(item).FirstOrDefault().be_A_Etat;
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

            frmAddEArticle frm = new frmAddEArticle(this, getBon(idBonEntree));
            frm.Text = "Ajouter des articles";
            frm.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer cet article", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        int rs = (int)db.Delete_Bon_reference_By_idBonArtEntree(idBonArt).FirstOrDefault();
                        switch (rs)
                        {
                            case 1:
                                int rs1 = (int)db.Delete_Bon_Entree_Article_By_ID(idBonArt).FirstOrDefault();
                                switch (rs1)
                                {
                                    case 1:
                                        transaction.Commit();
                                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                                        iTools.sucMsg("Information", "Votre article a bien supprimé");
                                        dgvEBon_SelectionChanged(null, null);

                                        break;
                                }
                                break;
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
        }

        #endregion Overrides

        #region New

        public frmLBonEntree()
        {
            InitializeComponent();
            getData_EBon();
        }

        #endregion New

        private void btnBonNew_Click(object sender, EventArgs e)
        {
            frmBonEntree frmBon = new frmBonEntree(this);
            frmBon.Text = "Ajouter un bon d'entrée";
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
                bool rs = Convert.ToBoolean(dgvA_EBon.Rows[e.RowIndex].Cells[colbe_A_Etat.Name].Value);
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
                        mvt_Entree();
                    }
                }
            }
            else
            {
                mvt_Entree();
            }
        }

        private void txtSearchA_TextChanged(object sender, EventArgs e)
        {
            dgvA_EBon.DataSource = db.Search_Bon_Entree_Article(txtSearchA.Text, idBonEntree);
            CountRow(dgvA_EBon.Rows.Count);
            PositionColumns();
        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            dgvEBon.DataSource = db.Search_Bon_Entree(txtSearchB.Text);
            CountRow(dgvEBon.Rows.Count);
        }

        private void dgvA_EBon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                int id = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbe_A_ID.Name].Value.ToString());
                Bon_Entree_Article ei = db.Get_Bon_Entree_Article(id).FirstOrDefault();
                //MessageBox.Show(ei.bs_A_ID.ToString());
                frmAddEArticle frm = new frmAddEArticle(this, ei);
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
                int item = int.Parse(dgvEBon.Rows[dgvEBon.CurrentRow.Index].Cells[colb_be_ID.Name].Value.ToString());
                idBonEntree = item;
                Bon_Entree bs = db.Show_Bon_Entree_By_ID(item).FirstOrDefault();
                frmBonEntree form = new frmBonEntree(this, bs);
                form.Text = "Modifier un bon d'entrée";
                form.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void dgvA_EBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvA_EBon.CurrentRow != null)
                {
                    btnSupprimer.Enabled = true;
                    idBonArt = int.Parse(dgvA_EBon.Rows[dgvA_EBon.CurrentRow.Index].Cells[colbe_A_ID.Name].Value.ToString());
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