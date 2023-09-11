using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.Normal;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.CRUD
{
    public partial class frmRefEBon : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idArticle, idBon, idBonArt, idVL, idBonRef, idReff;
        private frmAddEArticle frm;
        private string qteRef;
        private decimal qte;

        #endregion Variables

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            LoadReference(idArticle);
            cmbxReference.Focus();
        }

        public override void Add_Data()
        {
            if (checkDataFromDatabase() > 0)
            {
                Add_Data_To_DB();
            }
            else
            {
                Add_Data_To_Grid(frm.dgvReference.Rows.Add());
            }
            //base.Add_Data();
        }

        public override void Update_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                int index = frm.dgvReference.CurrentCell.RowIndex;
                if (frm.dgvReference.Rows[index].Cells["colbr_ID"].Value == null || frm.dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(frm.dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    Add_Data_To_Grid(index);
                    base.Delete_Data();
                }
                else
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
                        //    iMessage.warningMsg("Attention", "Cette référence est excite déjà");
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
                        int rs = (int)db.Update_Bon_reference(idBonRef, "E", idArticle, int.Parse(cmbxReference.SelectedValue.ToString()), idBon, decimal.Parse(txtQteDemandee.Text), null, idBonArt, null, null).FirstOrDefault();

                        switch (rs)
                        {
                            case 0:
                                break;

                            case 1:
                                transaction.Commit();
                                iTools.sucMsg("Information", "Votre référence a bien modifié");
                                newRecord();
                                frm.LoadReference_Article();
                                Verify_Buttons(true);
                                base.Update_Data();
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

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer ce référence", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                int index = frm.dgvReference.CurrentCell.RowIndex;
                if (frm.dgvReference.Rows[index].Cells["colbr_ID"].Value == null || frm.dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(frm.dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    frm.dgvReference.Rows.Remove(frm.dgvReference.Rows[index]);
                    newRecord();
                    Verify_Buttons(true);
                }
                else
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            int rs = (int)db.Delete_Bon_reference(int.Parse($"{frm.dgvReference.Rows[index].Cells["colbr_ID"].Value}")).FirstOrDefault();
                            switch (rs)
                            {
                                case 0:
                                    break;

                                case 1:
                                    transaction.Commit();
                                    //form.txtStatus.Caption = "Votre code a bien ajouté";
                                    iTools.sucMsg("Information", "Votre référence a bien supprimé");
                                    frm.LoadReference_Article();
                                    newRecord();
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
            }
        }

        public override void Verify_Buttons(bool status)
        {
            base.Verify_Buttons(status);
        }

        #endregion Overrides

        #region Codes

        private void LoadReference(int idArt)
        {
            try
            {
                var rs = db.Load_Article_Reference(idArt);
                cmbxReference.DataSource = rs.ToList();
                cmbxReference.DisplayMember = "ref_reference";
                cmbxReference.ValueMember = "ref_ID";
                cmbxReference.SelectedIndex = -1;
            }
            catch (Exception)
            {
            }
        }

        private int maxReference_Article()
        {
            return (int)db.MAX_Bon_reference().FirstOrDefault() + 1;
        }

        private decimal TotalQuantite(int refID)
        {
            return (decimal)db.SUM_Bon_reference(idArticle, idBon, idBonArt).FirstOrDefault();
        }

        private int checkDataFromDatabase(int refID)
        {
            return (int)db.COUNT_Bon_reference(idArticle, refID, idBon, idBonArt).FirstOrDefault();
        }

        private int checkDataFromDatabase()
        {
            return (int)db.COUNT_Bon_Entree_Article(idBon, idArticle, idVL).FirstOrDefault();
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

        private void Add_Data_To_Grid(int index)
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
                    frm.dgvReference.Rows[index].Cells["colRef"].Value = cmbxReference.Text.ToString();
                    frm.dgvReference.Rows[index].Cells["colQte"].Value = Convert.ToDecimal(txtQteDemandee.Text).ToString();
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

        private void Add_Data_To_DB()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                //try
                //{
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
                decimal qte = decimal.Parse(frm.txtQteLivree.Text);
                decimal total = TotalQuantite(refID) + decimal.Parse(txtQteDemandee.Text);
                if (total > qte)
                {
                    MessageBox.Show("Votre quantité est maximale par rapport aux quantités demandées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQteDemandee.Focus();
                    return;
                }

                int max = maxReference_Article();
                int rs = (int)db.Insert_Bon_reference(max, "E", idArticle, int.Parse(cmbxReference.SelectedValue.ToString()), idBon, decimal.Parse(txtQteDemandee.Text), null, idBonArt, null, null).FirstOrDefault();

                switch (rs)
                {
                    case 0:
                        break;

                    case 1:
                        transaction.Commit();
                        iTools.sucMsg("Information", "Votre référence a bien ajouté");
                        newRecord();
                        frm.LoadReference_Article();
                        Verify_Buttons(true);
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

        #endregion Codes

        #region New

        public frmRefEBon(int idArticle, int idBon, int idVL, decimal qte, int idBonArt, frmAddEArticle frm)
        {
            InitializeComponent();
            this.idArticle = idArticle;
            this.idBon = idBon;
            this.idVL = idVL;
            this.qte = qte;
            this.idBonArt = idBonArt;
            this.frm = frm;
        }

        public frmRefEBon(int idArticle, int idBon, int idVL, decimal qte, int idBonArt, frmAddEArticle frm, int idReff, string qteRef, int idBonRef)
        {
            InitializeComponent();
            this.idArticle = idArticle;
            this.idBon = idBon;
            this.idVL = idVL;
            this.qte = qte;
            this.idBonArt = idBonArt;
            this.frm = frm;
            this.idReff = idReff;
            this.qteRef = qteRef;
            this.idBonRef = idBonRef;
        }

        #endregion New

        private void frmRefEBon_Load(object sender, EventArgs e)
        {
            decimal rs = 0;
            foreach (DataGridViewRow row in frm.dgvReference.Rows)
            {
                decimal val = Convert.ToDecimal(row.Cells[frm.dgvReference.Columns["colQte"].Index].Value);
                rs += val;
            }
            lblSum.Text = rs.ToString();
            if (Text == "Ajouter Référence")
            {
                newRecord();
                Verify_Buttons(true);
            }
            else
            {
                Verify_Buttons(false);
                LoadReference(idArticle);
                cmbxReference.SelectedValue = idReff;
                txtQteDemandee.Text = qteRef;
            }
        }
    }
}