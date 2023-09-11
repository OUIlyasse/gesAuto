using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAddRRefArticle : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idArticle, idBon, idVL, idBonArt, refID, bonRef;
        private string qteRef;
        private decimal qte;
        private frmAddRArticle frm;
        private bool status;

        #endregion Fields

        #region Codes

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

        private void LoadReference(int idArt)
        {
            try
            {
                cmbxReference.DataSource = db.Select_Article_Reference(idArt).ToList();
                cmbxReference.DisplayMember = "ref_reference";
                cmbxReference.ValueMember = "ref_ID";
                cmbxReference.SelectedIndex = -1;
            }
            catch (Exception)
            {
            }
        }

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

        private void LoadReference_Article()
        {
            try
            {
                var data = from t in db.Bon_reference where t.art_ID == idArticle && t.br_Type == "R" && t.bon_ID == idBon && t.bt_A_ID == idBonArt select new { t.br_ID, t.br_Type, t.art_ID, t.Article_Reference.ref_reference, t.bon_ID, t.br_Qte, t.bt_A_ID, t.br_Status_Gravage };
                frm.dgvReference.DataSource = LINQResultToDataTable(data);
            }
            catch (Exception)
            {
            }
        }

        private void newRecord()
        {
            iTools.Clear(this);
            LoadReference(idArticle);
            cmbxReference.Focus();
        }

        private int maxReference_Article()
        {
            return db.Bon_reference.DefaultIfEmpty().Max(r => r == null ? 1 : (r.br_ID + 1));
        }

        #endregion Codes

        #region CRUD

        private int checkDataFromDatabase(int refID)
        {
            var _result = from x in db.Bon_reference
                          where x.br_Type == "R"
                          where x.ref_ID == refID
                          where x.art_ID == idArticle
                          where x.bon_ID == idBon
                          where x.bt_A_ID == idBonArt
                          select x;

            return _result.Count();
        }

        private int checkDataFromDatabase()
        {
            var _result = from x in db.Bon_Retour_Article
                          where x.vl_ID == idVL
                          where x.art_ID == idArticle
                          where x.bt_ID == idBon
                          select x;

            return _result.Count();
        }

        private decimal TotalQuantite(int refID)
        {
            var _result = from x in db.Bon_reference
                          where x.br_Type == "R"
                          where x.art_ID == idArticle
                          where x.bon_ID == idBon
                          where x.bt_A_ID == idBonArt
                          select x.br_Qte;

            return Convert.ToDecimal(_result.Sum());
        }

        private void Add_data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (cmbxReference.SelectedIndex == -1)
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxReference.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtQteDemandee.Text.Trim()))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteDemandee.Focus();
                        return;
                    }
                    int refID = int.Parse(cmbxReference.SelectedValue.ToString());
                    if (checkDataFromDatabase(refID) > 0)
                    {
                        iTools.warningMsg("Attention", "Cette référence est excite déjà");
                        cmbxReference.Focus();
                        return;
                    }
                    decimal qte = Convert.ToDecimal(frm.txtQteLivree.Text);
                    decimal total = TotalQuantite(refID) + Convert.ToDecimal(txtQteDemandee.Text);
                    if (total > qte)
                    {
                        MessageBox.Show("Votre quantité est maximale par rapport aux quantités demandées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQteDemandee.Focus();
                        return;
                    }

                    int max = maxReference_Article();

                    int rs = (int)db.Insert_Bon_reference(max, "R", idArticle, (int)cmbxReference.SelectedValue, idBon, decimal.Parse(txtQteDemandee.Text), null, null, idBonArt, status).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            transaction.Commit();
                            iTools.sucMsg("Information", "Votre référence a bien ajouté");
                            newRecord();
                            LoadReference_Article();
                            Verify_Buttons(true);
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

        private void Update_data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (cmbxReference.SelectedIndex == -1)
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxReference.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtQteDemandee.Text.Trim()))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteDemandee.Focus();
                        return;
                    }
                    int refID = int.Parse(cmbxReference.SelectedValue.ToString());
                    //if (checkDataFromDatabase(refID) > 0)
                    //{
                    //    iTools.warningMsg("Attention", "Cette référence est excite déjà");
                    //    cmbxReference.Focus();
                    //    return;
                    //}
                    decimal qte = Convert.ToDecimal(frm.txtQteLivree.Text);
                    decimal total = TotalQuantite(refID) + Convert.ToDecimal(txtQteDemandee.Text) - Convert.ToDecimal(qteRef);
                    if (total > qte)
                    {
                        MessageBox.Show("Votre quantité est maximale par rapport aux quantités demandées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQteDemandee.Focus();
                        return;
                    }
                    int max = bonRef;

                    int rs = (int)db.Update_Bon_reference(max, "R", idArticle, (int)cmbxReference.SelectedValue, idBon, decimal.Parse(txtQteDemandee.Text), null, null, idBonArt, status).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            transaction.Commit();
                            iTools.sucMsg("Information", "Votre référence a bien modifié");
                            newRecord();
                            LoadReference_Article();
                            Verify_Buttons(true);
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

        private bool CheckRows(string valueTest, DataGridView dgv, string cell)
        {
            bool rs = false;
            if (dgv.Rows != null)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    var row = dgv.Rows[i];
                    if (row.Cells[cell].Value == null)
                    {
                        rs = false;
                    }
                    else
                    {
                        string Value0 = dgv.Rows[i].Cells[cell].Value.ToString();
                        if (Value0.Trim().ToUpper() == valueTest.Trim().ToUpper())
                        {
                            rs = true;
                            break;
                        }
                        else
                            rs = false;
                    }
                }
            }
            else
                rs = false;
            return rs;
        }

        private bool CheckTotalQte(decimal qteTotal, decimal qteAjoute, DataGridView dgv, string cell)
        {
            bool rs = false;
            decimal rss = 0;
            foreach (DataGridViewRow row in frm.dgvReference.Rows)
            {
                decimal val = Convert.ToDecimal(row.Cells[frm.dgvReference.Columns["colQte"].Index].Value);
                rss += val;
            }
            lblSum.Text = rss.ToString();
            if (dgv.Rows != null)
            {
                decimal qte0 = decimal.Parse(lblSum.Text);
                qte0 += qteAjoute;
                lblSum.Text = qte0.ToString();
                if (qte0 > qteTotal)
                    return true;
                else
                    return false;
            }
            else
                rs = false;
            return rs;
        }

        private bool CheckStatusGravageDeReference(string idRef)
        {
            bool AssNo = Convert.ToBoolean((from a in db.Article_Reference
                                            where a.art_ID == idArticle
                                            where a.ref_reference == idRef
                                            select a).Single().ref_est_Gravee);
            return AssNo;
        }

        private void UpdateToDataTable()
        {
            if (cmbxReference.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxReference.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQteDemandee.Text.Trim()))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQteDemandee.Focus();
                return;
            }
            bool rs = CheckRows(cmbxReference.Text.ToString(), frm.dgvReference, "colRef");
            bool rsQte = CheckTotalQte(qte, Convert.ToDecimal(txtQteDemandee.Text), frm.dgvReference, "colRef");
            if (rs != true)
            {
                if (rsQte != true)
                {
                    var index = frm.dgvReference.CurrentRow.Index;
                    frm.dgvReference.Rows[index].Cells["colRef"].Value = cmbxReference.Text.ToString();
                    frm.dgvReference.Rows[index].Cells["colQte"].Value = Convert.ToDecimal(txtQteDemandee.Text).ToString();
                    frm.dgvReference.Rows[index].Cells["colStatusGravage"].Value = status;
                    newRecord();
                    Verify_Buttons(true);
                }
                else
                {
                    MessageBox.Show("Votre quantité est maximale par rapport aux quantités demandées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtQteDemandee.Focus();
                }
            }
            else
            {
                MessageBox.Show("Cette référence est excite déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbxReference.Focus();
            }
        }

        private void AddToDataTable()
        {
            if (cmbxReference.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxReference.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQteDemandee.Text.Trim()))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQteDemandee.Focus();
                return;
            }
            bool rs = CheckRows(cmbxReference.Text.ToString(), frm.dgvReference, "colRef");
            bool rsQte = CheckTotalQte(qte, Convert.ToDecimal(txtQteDemandee.Text), frm.dgvReference, "colRef");
            if (rs != true)
            {
                if (rsQte != true)
                {
                    var index = frm.dgvReference.Rows.Add();
                    frm.dgvReference.Rows[index].Cells["colRef"].Value = cmbxReference.Text.ToString();
                    frm.dgvReference.Rows[index].Cells["colQte"].Value = Convert.ToDecimal(txtQteDemandee.Text).ToString();
                    frm.dgvReference.Rows[index].Cells["colStatusGravage"].Value = status;
                    newRecord();
                    Verify_Buttons(true);
                }
                else
                {
                    MessageBox.Show("Votre quantité est maximale par rapport aux quantités demandées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtQteDemandee.Focus();
                }
            }
            else
            {
                MessageBox.Show("Cette référence est excite déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbxReference.Focus();
            }
        }

        #endregion CRUD

        public frmAddRRefArticle(int idArt, int idBon, int idVL, frmAddRArticle grid, decimal qte, int idBonArt)
        {
            InitializeComponent();
            idArticle = idArt;
            this.idBon = idBon;
            this.idVL = idVL;
            this.qte = qte;
            this.idBonArt = idBonArt;
            frm = grid;
            Verify_Buttons(true);
        }

        private void ckbStatusGravage_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStatusGravage.Checked == true)
                status = true;
            else
                status = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int index = frm.dgvReference.CurrentCell.RowIndex;
            if (frm.dgvReference.Rows[index].Cells["colbr_ID"].Value == null || frm.dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(frm.dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
            {
                UpdateToDataTable();
            }
            else
            {
                Update_data();
            }
        }

        public frmAddRRefArticle(int idArt, int idBon, int idVL, frmAddRArticle grid, decimal qte, int idBonArt, int refID, string qteRef, int bonRef, bool StatusGravage)
        {
            InitializeComponent();
            idArticle = idArt;
            this.idBon = idBon;
            this.idVL = idVL;
            this.qte = qte;
            this.idBonArt = idBonArt;
            frm = grid;
            Verify_Buttons(false);
            this.refID = refID;
            this.qteRef = qteRef;
            this.bonRef = bonRef;
            this.status = StatusGravage;
        }

        private void frmAddBonArticles_Load(object sender, EventArgs e)
        {
            decimal rs = 0;
            foreach (DataGridViewRow row in frm.dgvReference.Rows)
            {
                decimal val = Convert.ToDecimal(row.Cells[frm.dgvReference.Columns["colQte"].Index].Value);
                rs += val;
            }
            lblSum.Text = rs.ToString();
            if (Text == "Ajouter Reference")
                newRecord();
            else
            {
                LoadReference(idArticle);
                cmbxReference.SelectedValue = refID;
                txtQteDemandee.Text = qteRef;
                if (status)
                    ckbStatusGravage.Checked = true;
                else
                    ckbStatusGravage.Checked = false;
            }
        }

        private void txtQteDemandee_Validating(object sender, CancelEventArgs e)
        {
            decimal val = 0;
            bool isDigit = decimal.TryParse(txtQteDemandee.Text, out val);
            if (isDigit)
            {
                if (val <= 0)
                    MessageBox.Show("Attention la quantité minimum est 1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //AddToDataTable();
            if (checkDataFromDatabase() > 0)
                Add_data();
            else
                AddToDataTable();
        }
    }
}