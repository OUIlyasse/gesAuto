using DAL.DB;
using PL.Interfaces.Sub.CRUD;
using PL.Interfaces.Sub.List;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAddEArticle : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBon, idBonArticle;
        private frmLBonEntree eBon;
        private Bon_Entree_Article bonArt;
        private Bon_Entree bs;
        private int svc_ID = Properties.Settings.Default.idService;
        private int rsStatus;

        #endregion Variables

        #region Codes

        private void Verify_Buttons(bool status)
        {
            if (status)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
            }
        }

        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {
                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                               == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                           (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        public void LoadReference_Article()
        {
            try
            {
                //var data = from t in db.Bon_reference where t.art_ID == bonArt.art_ID && t.br_Type == "E" && t.bon_ID == bonArt.be_ID && t.be_A_ID == bonArt.be_A_ID select new { t.br_ID, t.br_Type, t.art_ID, t.Article_Reference.ref_reference, t.bon_ID, t.br_Qte, t.be_A_ID };
                var rs = db.Select_v_Get_E_Bon_Article(idBonArticle).ToList();
                //dgvReference.DataSource = rs;
                //return;
                dgvReference.DataSource = rs;
            }
            catch (Exception)
            {
            }
        }

        private void LoadArticle()
        {
            cmbxArticle.DataSource = db.Select_Article_Info(svc_ID);
            cmbxArticle.DisplayMember = "art_Designation";
            cmbxArticle.ValueMember = "art_ID";
            cmbxArticle.SelectedIndex = -1;
        }

        private void LoadVL()
        {
            cmbxVL.DataSource = db.Select_Vehicule();
            cmbxVL.DisplayMember = "vl_Marque";
            cmbxVL.ValueMember = "vl_ID";
            cmbxVL.SelectedValue = -1;
        }

        private void LoadUMesure(int idArt)
        {
            cmbxUMesure.DataSource = db.Select_Unite_Mesure_By_IdArt(idArt).ToList();
            cmbxUMesure.DisplayMember = "unit_M_Abreviation";
            cmbxUMesure.ValueMember = "unit_M_ID";
            cmbxUMesure.SelectedValue = -1;
        }

        private void LoadControls(Bon_Entree_Article bon)
        {
            cmbxArticle.SelectedValue = bon.art_ID;
            cmbxVL.SelectedValue = bon.vl_ID;
            cmbxUMesure.SelectedValue = bon.unit_M_ID;
            txtQteLivree.Text = bon.be_Qte_Livree.ToString();
            txtDescription.Text = bon.be_A_Description;
        }

        private void Delete_Bon_Reference()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer ce référence", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                int index = dgvReference.CurrentCell.RowIndex;
                //int id = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                //int idVL = int.Parse(bonArt.vl_ID.ToString());
                if (dgvReference.Rows[index].Cells["colbr_ID"].Value == null || dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    dgvReference.Rows.Remove(dgvReference.Rows[index]);
                }
                else
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            int rs = (int)db.Delete_Bon_reference(int.Parse($"{dgvReference.Rows[index].Cells["colbr_ID"].Value}")).FirstOrDefault();
                            switch (rs)
                            {
                                case 0:
                                    break;

                                case 1:
                                    transaction.Commit();
                                    //form.txtStatus.Caption = "Votre code a bien ajouté";
                                    iTools.sucMsg("Information", "Votre référence a bien supprimé");
                                    LoadReference_Article();
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
        }

        private int getIdReference(string Reference)
        {
            return (int)db.Get_ID_Article_Reference((int)cmbxArticle.SelectedValue, Reference).FirstOrDefault();
        }

        private void Add_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                //try
                //{
                if (cmbxArticle.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxArticle.Focus();
                    return;
                }
                if (cmbxVL.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVL.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtQteLivree.Text))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQteLivree.Focus();
                    return;
                }
                if (checkDataFromDatabase() > 0)
                {
                    MessageBox.Show("Cette article est excite déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Ajouter Articles
                bool etat = VerifieEtatBon_Entree_Article(out rsStatus);
                int idBon = bs.be_ID;
                int max = maxID_EBon_Article();
                int rs = (int)db.Insert_Bon_Entree_Article(max, DateTime.Now, Decimal.Parse(txtQteLivree.Text), idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                Bon_Entree_Article bsA = db.Get_Bon_Entree_Article(max).FirstOrDefault();
                switch (rs)
                {
                    case 1:
                        Add_Update_Reference(bs.be_ID, bsA.be_A_ID);
                        transaction.Commit();
                        iTools.sucMsg("Information", "Votre article a bien ajouté");
                        //newRecord();
                        bonArt = bsA;
                        LoadBon(bonArt);
                        Text = "Modifier des articles";
                        Verify_Buttons(false);
                        ShowEtatMessage();
                        break;
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

        private void Update_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (cmbxArticle.SelectedIndex == -1)
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxArticle.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtQteLivree.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteLivree.Focus();
                        return;
                    }
                    //Ajouter Articles
                    bool etat = VerifieEtatBon_Entree_Article(out rsStatus);
                    int rs = (int)db.Update_Bon_Entree_Article(idBonArticle, decimal.Parse(txtQteLivree.Text), idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                    Bon_Entree_Article bsA = db.Get_Bon_Entree_Article(idBonArticle).FirstOrDefault();

                    switch (rs)
                    {
                        case 1:
                            transaction.Commit();
                            iTools.sucMsg("Information", "Votre article a bien modifié");
                            //newRecord();
                            bonArt = bsA;
                            LoadBon(bonArt);
                            Verify_Buttons(false);
                            ShowEtatMessage();

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

        private void ShowEtatMessage()
        {
            int rs; //1 gride est vide,2 quntite diferent,3 confort
            VerifieEtatBon_Entree_Article(out rs);
            switch (rs)
            {
                case 1:
                    pnlVerifier.Visible = true;
                    pnlVerifier.Location = new Point(587, 143);
                    pnlOk.Visible = false;
                    break;

                case 2:
                    pnlVerifier.Visible = false;
                    pnlOk.Visible = true;
                    pnlOk.Location = new Point(587, 143);
                    break;

                default:
                    pnlVerifier.Visible = false;
                    pnlOk.Visible = false;
                    break;
            }
        }

        private void LoadBon(Bon_Entree_Article bsA)
        {
            btnArtSupprimer.Enabled = false;
            LoadControls(bsA);
            LoadReference_Article();
            eBon.dgvEBon_SelectionChanged(null, null);
        }

        private void Add_Update_Reference(int idBon, int idBonArt)
        {
            decimal qte = 0;
            int id;
            foreach (DataGridViewRow row in dgvReference.Rows)
            {
                decimal.TryParse(row.Cells[dgvReference.Columns["colQte"].Index].Value.ToString(), out qte);
                if (row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == null || row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[dgvReference.Columns["colbr_ID"].Index].Value.ToString()))
                    id = (int)db.MAX_Bon_reference().FirstOrDefault();
                else
                    id = int.Parse(row.Cells[dgvReference.Columns["colbr_ID"].Index].Value.ToString());
                //if (row.Cells["colStatusGravage"].Value == null || row.Cells["colStatusGravage"].Value == DBNull.Value || (bool)row.Cells["colStatusGravage"].Value == false)
                //    status = false;
                //else
                //    status = true;

                string reff = row.Cells[dgvReference.Columns["colRef"].Index].Value.ToString();
                //Article_Reference reffArt = Reference.GetSingle(f => f.ref_reference == reff && f.art_ID == int.Parse(cmbxArticle.SelectedValue.ToString()));
                //Reference.Update(new Article_Reference() { ref_ID = reffArt.ref_ID, art_ID = reffArt.art_ID, ref_reference = reffArt.ref_reference, ref_est_Gravee = status, ref_Description = reffArt.ref_Description, ref_Status = true });
                if (row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == null || row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[dgvReference.Columns["colbr_ID"].Index].Value.ToString()))
                {
                    db.Insert_Bon_reference(id, "E", (int)cmbxArticle.SelectedValue, getIdReference(row.Cells[dgvReference.Columns["colRef"].Index].Value.ToString())
                       , idBon, qte, null, idBonArt, null, null).FirstOrDefault();
                }
                else
                {
                    db.Update_Bon_reference(id, "E", (int)cmbxArticle.SelectedValue, getIdReference(row.Cells[dgvReference.Columns["colRef"].Index].Value.ToString())
                      , idBon, qte, null, idBonArt, null, null).FirstOrDefault();
                }
            }
        }

        private int maxID_EBon_Article()
        {
            return (int)db.MAX_Bon_Entree_Article().FirstOrDefault();
        }

        private bool VerifieEtatBon_Entree_Article(out int status)
        {
            bool rs = false;
            status = 0;
            int qteGlobale = ToInt(txtQteLivree.Text);
            int qteTotalIntoGrid = getQteTotal(dgvReference, colQte.Name);
            try
            {
                if (qteGlobale == qteTotalIntoGrid)
                {
                    status = 2;
                    rs = true;
                }
                else
                {
                    status = 1;
                    rs = false;
                }
            }
            catch (Exception)
            {
                status = 0;
            }
            return rs;
        }

        private bool VerifieEtatBon_Entree_Article()
        {
            bool rs = false;
            int qteGlobale = ToInt(txtQteLivree.Text);
            int qteTotalIntoGrid = getQteTotal(dgvReference, colQte.Name);
            try
            {
                if (qteGlobale == qteTotalIntoGrid)
                {
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (Exception)
            {
            }
            return rs;
        }

        private int getQteTotal(DataGridView grid, string cell)
        {
            int qte = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                qte += ToInt(item.Cells[cell].Value.ToString());
            }
            return qte;
        }

        private int ToInt(string number)
        {
            return decimal.ToInt32(decimal.Parse(number));
        }

        private int checkDataFromDatabase()
        {
            int rs = 0;
            int vl = int.Parse(cmbxVL.SelectedValue.ToString());
            int art = int.Parse(cmbxArticle.SelectedValue.ToString());
            var rss = (int)db.COUNT_Bon_Entree_Article(idBon, art, vl).FirstOrDefault();
            if (rss > 0)
                rs = rss;
            else
                rs = 0;
            return rs;
        }

        private void loadQte(string vl, string article)
        {
            var rQte = db.ResteQteArticle(vl, article).FirstOrDefault() > 0 ? db.ResteQteArticle(vl, article).FirstOrDefault() : 0;
            var um = db.Select_Unite_Mesure_By_Art_isDefault(db.get_Article_Info_By_Designation(article).FirstOrDefault().art_ID).FirstOrDefault();
            lblQte.Text = $"En stock: {rQte} {um}";
            Info.SetToolTip(lblQte, $"En stock: {rQte} {um}");
        }

        #endregion Codes

        #region New

        public frmAddEArticle(frmLBonEntree frm, Bon_Entree bon)
        {
            InitializeComponent();
            LoadArticle();
            LoadVL();
            eBon = frm;
            bs = bon;
            idBon = bon.be_ID;
        }

        public frmAddEArticle(frmLBonEntree frm, Bon_Entree_Article bon)
        {
            InitializeComponent();
            eBon = frm;
            bonArt = bon;
            LoadArticle();
            LoadVL();
            idBon = int.Parse(bon.be_ID.ToString());
            idBonArticle = bon.be_A_ID;
        }

        #endregion New

        private void btnArtAjouter_Click(object sender, EventArgs e)
        {
            if (cmbxArticle.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxArticle.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQteLivree.Text))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQteLivree.Focus();
                return;
            }
            int r;
            if (bonArt != null)
                r = bonArt.be_A_ID;
            else
                r = 0;
            frmRefEBon frm = new frmRefEBon((int)cmbxArticle.SelectedValue, idBon, (int)cmbxVL.SelectedValue, Convert.ToDecimal(txtQteLivree.Text), r, this);
            frm.Text = "Ajouter Référence";
            frm.ShowDialog();
        }

        private void btnArtSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Bon_Reference();
        }

        private void dgvReference_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReference.CurrentCell != null)
            {
                int index = dgvReference.CurrentCell.RowIndex;
                int id = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                int idd = 0;
                if (dgvReference.Rows[index].Cells["colbr_ID"].Value == null || dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    if (string.IsNullOrEmpty(txtQteLivree.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteLivree.Focus();
                        return;
                    }
                    int r;
                    if (bonArt != null)
                        r = bonArt.be_A_ID;
                    else
                        r = 0;
                    //int.Parse(cmbxArticle.SelectedValue.ToString()), idBon, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r, id, dgvReference.Rows[index].Cells["colQte"].Value.ToString(), idd
                    frmRefEBon frm = new frmRefEBon((int)cmbxArticle.SelectedValue, idBon, (int)cmbxVL.SelectedValue, Convert.ToDecimal(txtQteLivree.Text), r, this, id, $"{dgvReference.Rows[index].Cells["colQte"].Value}", idd);
                    frm.Text = "Modifier Reference";
                    frm.ShowDialog();
                }
                else
                {
                    int.TryParse(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString(), out idd);
                    int idVL = int.Parse(bonArt.vl_ID.ToString());

                    if (string.IsNullOrEmpty(txtQteLivree.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteLivree.Focus();
                        return;
                    }
                    int r;
                    if (bonArt != null)
                        r = bonArt.be_A_ID;
                    else
                        r = 0;
                    //frmRefEBon frm = new frmRefEBon(int.Parse(cmbxArticle.SelectedValue.ToString()), idBon, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r, id, dgvReference.Rows[index].Cells["colQte"].Value.ToString(), idd);
                    frmRefEBon frm = new frmRefEBon((int)cmbxArticle.SelectedValue, idBon, (int)cmbxVL.SelectedValue, Convert.ToDecimal(txtQteLivree.Text), r, this, id, $"{dgvReference.Rows[index].Cells["colQte"].Value}", idd);
                    frm.Text = "Modifier Référence";
                    frm.ShowDialog();
                }
            }
        }

        private void dgvReference_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvReference.CurrentRow != null)
                {
                    //int idRef = getIdReference(dgvReference.CurrentRow.Cells["colRef"].Value.ToString());
                    btnArtSupprimer.Enabled = true;
                }
                else
                {
                    btnArtSupprimer.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void frmAddEArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Text == "Modifier des articles")
            {
                bool etat = VerifieEtatBon_Entree_Article();
                int rs = (int)db.Update_Bon_Entree_Article(idBonArticle, decimal.Parse(txtQteLivree.Text), idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                switch (rs)
                {
                    case 1:
                        eBon.dgvEBon_SelectionChanged(null, null);
                        break;
                }
            }
        }

        private void cmbxVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxVL.SelectedIndex != -1 && cmbxArticle.SelectedIndex != -1)
                loadQte(cmbxVL.Text, cmbxArticle.Text);
        }

        private void cmbxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxVL.SelectedIndex != -1 && cmbxArticle.SelectedIndex != -1)
                loadQte(cmbxVL.Text, cmbxArticle.Text);

            if (cmbxArticle.SelectedIndex != -1)
            {
                LoadUMesure((int)cmbxArticle.SelectedValue);
            }
        }

        private void frmAddEArticle_Load(object sender, EventArgs e)
        {
            if (Text == "Ajouter des articles")
            {
                Verify_Buttons(true);
                btnArtSupprimer.Enabled = false;
                pnlOk.Visible = false;
                pnlVerifier.Visible = false;
                lblQte.Text = string.Empty;
            }
            else
            {
                Verify_Buttons(false);
                btnArtSupprimer.Enabled = false;
                LoadControls(bonArt);
                LoadReference_Article();
                ShowEtatMessage();
            }
        }
    }
}