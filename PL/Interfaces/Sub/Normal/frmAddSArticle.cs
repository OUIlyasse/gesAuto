using DAL.DB;
using PL.Interfaces.Sub.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAddSArticle : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private frmLBonSortie sBon;
        private Bon_Sortie bs;
        private Bon_Sortie_Article bonArt;
        private int idArticle, idBonSortie, idBonArt;
        private int rowSelected;
        private int rsStatus;
        private int svc = Properties.Settings.Default.idService;

        #endregion Fields

        #region DataGridView

        private DataGridViewCellStyle NormalCellStyle()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            return dataGridViewCellStyle3;
        }

        private DataGridViewCellStyle SelectCellStyle()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle3.BackColor = Color.FromArgb(234, 221, 186);
            dataGridViewCellStyle3.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(63, 59, 188);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            return dataGridViewCellStyle3;
        }

        #endregion DataGridView

        #region Codes

        private void LoadUMesure(int idArt)
        {
            cmbxUMesure.DataSource = db.Select_Unite_Mesure_By_IdArt(idArt).ToList();
            cmbxUMesure.DisplayMember = "unit_M_Abreviation";
            cmbxUMesure.ValueMember = "unit_M_ID";
            cmbxUMesure.SelectedValue = -1;
        }

        private void EnableControls()
        {
            cmbxArticle.Enabled = false;
            cmbxVL.Enabled = false;
        }

        private bool isExistArticle(string article)
        {
            var isExist = (from t in db.Article_Info
                           where t.art_Designation == article
                           select t).Any();
            return isExist;
        }

        private bool isExistVL(string VL)
        {
            var isExist = (from t in db.Vehicules
                           where t.vl_Marque == VL
                           select t).Any();
            return isExist;
        }

        private bool VerifieEtatBon_Sortie_Article(out int status)
        {
            bool rs = false;
            status = 0;
            int qteGlobale = ToInt(txtQteLivree.Text);
            int qteTotalIntoGrid = getQteTotal(dgvReference, colQte.Name);
            int qteCell = 0;
            int totalCodebarre = 0;
            try
            {
                if (qteGlobale == qteTotalIntoGrid)
                {
                    foreach (DataGridViewRow row in dgvReference.Rows)
                    {
                        totalCodebarre = countCodbarreByReference(getIdReference(row.Cells[colRef.Name].Value.ToString()));
                        qteCell = ToInt(row.Cells[colQte.Name].Value.ToString());
                        if (row.Cells[colStatusGravage.Name].Value == null || row.Cells[colStatusGravage.Name].Value == DBNull.Value || (bool)row.Cells[colStatusGravage.Name].Value == false)
                        {
                            //Vide
                            status = 3;
                            rs = true;
                        }
                        else
                        {
                            if (totalCodebarre != qteCell)
                            {
                                status = 2;
                                rs = false;
                                break;
                            }
                            else
                            {
                                status = 3;
                                rs = true;
                            }
                        }
                    }
                }
                else
                {
                    status = 1;
                    rs = false;
                }
            }
            catch (Exception)
            {
            }
            return rs;
        }

        private int getIdReference(string Reference)
        {
            return (int)db.Select_Article_Reference_By_Article_Referenece((int)cmbxArticle.SelectedValue, Reference).FirstOrDefault();
        }

        public static DataTable DataGridView_To_Datatable(DataGridView dg)
        {
            DataTable ExportDataTable = new DataTable();
            foreach (DataGridViewColumn col in dg.Columns)
            {
                ExportDataTable.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dg.Rows)
            {
                DataRow dRow = ExportDataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                ExportDataTable.Rows.Add(dRow);
            }
            return ExportDataTable;
        }

        private void Update_Last_CodeBarre(string LastNum)
        {
            try
            {
                int an = int.Parse(cmbxAnnee.SelectedValue.ToString());
                var rs = (int)db.Update_Last_CodeBarre(an, LastNum).FirstOrDefault();
                switch (rs)
                {
                    case 1:
                        db.SaveChanges();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
            }
        }

        private void Add_Update_Reference(int idBon, int idBonArt)
        {
            decimal qte = 0;
            int id;
            //Bon_reference refArt;
            bool status = false;
            foreach (DataGridViewRow row in dgvReference.Rows)
            {
                decimal.TryParse(row.Cells[dgvReference.Columns["colQte"].Index].Value.ToString(), out qte);
                if (row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == null || row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[dgvReference.Columns["colbr_ID"].Index].Value.ToString()))
                    id = maxID_Bon_Reference();
                else
                    id = int.Parse(row.Cells[dgvReference.Columns["colbr_ID"].Index].Value.ToString());
                if (row.Cells["colStatusGravage"].Value == null || row.Cells["colStatusGravage"].Value == DBNull.Value || (bool)row.Cells["colStatusGravage"].Value == false)
                    status = false;
                else
                    status = true;

                string reff = row.Cells[dgvReference.Columns["colRef"].Index].Value.ToString();
                //Article_Reference reffArt = Reference.GetSingle(f => f.ref_reference == reff && f.art_ID == int.Parse(cmbxArticle.SelectedValue.ToString()));
                //Reference.Update(new Article_Reference() { ref_ID = reffArt.ref_ID, art_ID = reffArt.art_ID, ref_reference = reffArt.ref_reference, ref_est_Gravee = status, ref_Description = reffArt.ref_Description, ref_Status = true });
                if (row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == null || row.Cells[dgvReference.Columns["colbr_ID"].Index].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[dgvReference.Columns["colbr_ID"].Index].Value.ToString()))
                {
                    var rs = (int)db.Insert_Bon_reference(id, "S", (int)cmbxArticle.SelectedValue, getIdReference(row.Cells[dgvReference.Columns[colRef.Name].Index].Value.ToString()), idBon, qte, idBonArt, null, null, status).FirstOrDefault();
                }
                else
                {
                    var rs = (int)db.Update_Bon_reference(id, "S", (int)cmbxArticle.SelectedValue, getIdReference(row.Cells[dgvReference.Columns[colRef.Name].Index].Value.ToString()), idBon, qte, idBonArt, null, null, status).FirstOrDefault();
                }
            }
        }

        private void Add_Update_CodeBarre(int idBon)
        {
            int id;
            //Bon_CodeBarre refArt;
            //int strRef = 0;
            for (int i = 0; i < dgvNSerie.Rows.Count - 1; i++)
            {
                if (dgvNSerie.Rows[i].Cells["txtNSerie"].Value == null || dgvNSerie.Rows[i].Cells["txtNSerie"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvNSerie.Rows[i].Cells["txtNSerie"].Value.ToString()))
                {
                    MessageBox.Show("Votre cellule est vide", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNSerie.CurrentCell = dgvNSerie.Rows[i].Cells["txtNSerie"];
                    return;
                }
                if (dgvNSerie.Rows[i].Cells[0].Value == null || dgvNSerie.Rows[i].Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvNSerie.Rows[i].Cells[0].Value.ToString()))
                    id = maxID_Bon_CodeBarre();
                else
                    id = int.Parse(dgvNSerie.Rows[i].Cells[0].Value.ToString());

                int rs = (int)db.Upsert_Bon_CodeBarre(id, DateTime.Now, "S", $"{dgvNSerie.Rows[i].Cells[txtNSerie.Name].Value}", null, null, (int)dgvNSerie.Rows[i].Cells[txtReference.Name].Value, (int)cmbxArticle.SelectedValue, idBon, (int)cmbxVL.SelectedValue).FirstOrDefault();

                //if (dgvNSerie.Rows[i].Cells[0].Value == null || dgvNSerie.Rows[i].Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvNSerie.Rows[i].Cells[0].Value.ToString()))
                //{
                //    //Add
                //    //if (db.Article_Reference.Any(f => f.ref_reference == dgvReference.Rows[i].Cells[2].Value.ToString() && f.art_ID.Equals(idArt)))
                //    //{
                //    //    return;
                //    //}
                //    strRef = int.Parse(dgvNSerie.Rows[i].Cells["txtReference"].Value.ToString());
                //    //MessageBox.Show(strRef.ToString());
                //    //bool rs = db.Bon_reference.Any(f => (f.ref_ID == strRef && f.art_ID == cmbxArticle.SelectedValue));
                //    //MessageBox.Show(rs.ToString());
                //    //    if (!rs)
                //    //    {
                //    refArt = new Bon_CodeBarre()
                //    {
                //        bc_ID = id,
                //        bc_Type = "S",
                //        ref_ID = strRef,
                //        art_ID = int.Parse(cmbxArticle.SelectedValue.ToString()),
                //        bon_ID = idBon,
                //        bc_N_Serie = dgvNSerie.Rows[i].Cells["txtNSerie"].Value.ToString()
                //    };
                //    bon_CodeBarre.Add(refArt);
                //}
                //else
                //{
                //    //Update
                //    refArt = new Bon_CodeBarre()
                //    {
                //        bc_ID = id,
                //        bc_Type = "S",
                //        ref_ID = strRef,
                //        art_ID = int.Parse(cmbxArticle.SelectedValue.ToString()),
                //        bon_ID = idBon,
                //        bc_N_Serie = dgvNSerie.Rows[i].Cells["txtNSerie"].Value.ToString()
                //    };
                //    bon_CodeBarre.Update(refArt);
                //}
            }
        }

        private int getIdCodeBarre(string codeBarre, int idRef, int bonID)
        {
            return (int)db.Select_Bon_CodeBarre_By_Ref_Art_Bon_NSerie(codeBarre, idRef, (int)cmbxArticle.SelectedValue, bonID).FirstOrDefault();
        }

        private string getLastTypeCodeBarre(string codeBarre)
        {
            return $"{db.Select_Last_Type_CodeBarre(codeBarre)}";
        }

        private void Delete_CodeBare()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer ce numéro de série", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        int index = dgvNSerie.CurrentCell.RowIndex;
                        int idCb = int.Parse(dgvNSerie.Rows[index].Cells[bc_ID.Name].Value.ToString());
                        string cb = (string)dgvNSerie.Rows[index].Cells[txtNSerie.Name].Value;

                        int rs = (int)db.Delete_Bon_CodeBarre(idCb).FirstOrDefault();
                        switch (rs)
                        {
                            case 1:
                                //UpdateBon_Reference_Qte();
                                var d = getPositionActuelle(cb);
                                string type = getLastTypeCodeBarre(cb);
                                if (AddOrUpdatePosition(d.pa_N_Serie, type, (int)d.pa_Numero, (int)d.pa_Annee, (int)d.ref_ID, (int)d.art_ID))
                                {
                                    LoadReference_Article();
                                    transaction.Commit();
                                    //form.txtStatus.Caption = "Votre code a bien ajouté";
                                    iTools.sucMsg("Information", "Votre numéro de série a bien supprimé");
                                    LoadCodBarreByRefrence();
                                    ShowEtatMessage();
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

        private void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter des articles";
            cmbxArticle.Focus();
            LoadAnnee();
            //dgvReference
            ClearDataGridView(dgvReference);
            //dgvReference.Rows.Clear();
            //var dt1 = dgvReference.DataSource as DataTable;
            //dt1.Rows.Clear();
            //dgvReference.DataSource = dt1;
            //dgvNSerie
            ClearDataGridView(dgvNSerie);
            //Enable les Grides
            dgvNSerie.Enabled = false;
            dgvReference.Enabled = false;
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            if (dgv.DataSource != null)
            {
                DataTable dt = (DataTable)dgv.DataSource;
                dt.Rows.Clear();
                dgv.DataSource = dt;
            }
            else
            {
                dgv.Rows.Clear();
            }
        }

        private void getData()
        {
            try
            {
                sBon.dgvEBon_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int maxID_SBon_Article()
        {
            return db.Bon_Sortie_Article.DefaultIfEmpty().Max(r => r == null ? 1 : (r.bs_A_ID + 1));
        }

        private int maxID_Bon_Reference()
        {
            return db.Bon_reference.DefaultIfEmpty().Max(r => r == null ? 1 : (r.br_ID + 1));
        }

        private int maxID_Bon_CodeBarre()
        {
            return db.Bon_CodeBarre.DefaultIfEmpty().Max(r => r == null ? 1 : (r.bc_ID + 1));
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

        private void Add_Data()
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
                    if (cmbxVL.SelectedIndex == -1)
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxVL.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtQteDemandee.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteDemandee.Focus();
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
                    int idBon = bs.bs_ID;
                    bool etat = VerifieEtatBon_Sortie_Article(out rsStatus);
                    int id = maxID_SBon_Article();
                    int rs = (int)db.Insert_Bon_Sortie_Article(id, DateTime.Now, decimal.Parse(txtQteDemandee.Text), Decimal.Parse(txtQteLivree.Text), null, idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            Bon_Sortie_Article bsA = db.Get_Bon_Sortie_Article(id).FirstOrDefault();
                            Add_Update_Reference(bs.bs_ID, bsA.bs_A_ID);
                            //Add_Update_CodeBarre(bs.bs_ID);
                            //Update_Last_CodeBarre();
                            transaction.Commit();
                            iTools.sucMsg("Information", "Votre article a bien ajouté");
                            //newRecord();
                            getData();
                            bonArt = bsA;
                            lblQteReste.Text = string.Empty;
                            lblQteTotal.Text = string.Empty;
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

        private void LoadBon(Bon_Sortie_Article bsA)
        {
            btnArtSupprimer.Enabled = false;
            LoadControls(bsA);
            LoadReference_Article();
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
                    if (string.IsNullOrEmpty(txtQteDemandee.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteDemandee.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txtQteLivree.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteLivree.Focus();
                        return;
                    }
                    //Ajouter Articles
                    int idBon = sBon.idBonSortie;

                    bool etat = VerifieEtatBon_Sortie_Article(out rsStatus);
                    int rs = (int)db.Update_Bon_Sortie_Article(bonArt.bs_A_ID, decimal.Parse(txtQteDemandee.Text), decimal.Parse(txtQteLivree.Text), null, idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            Bon_Sortie_Article bsA = db.Get_Bon_Sortie_Article(bonArt.bs_A_ID).FirstOrDefault();
                            //Add_Update_Reference(bs.bs_ID, bsA.bs_A_ID);
                            //Add_Update_CodeBarre(bs.bs_ID);
                            //Update_Last_CodeBarre();
                            transaction.Commit();
                            iTools.sucMsg("Information", "Votre article a bien modifié");
                            //newRecord();
                            getData();
                            bonArt = bsA;
                            LoadBon(bonArt);
                            lblQteReste.Text = string.Empty;
                            lblQteTotal.Text = string.Empty;
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

        private int getNSerie(string annee)
        {
            return int.Parse(db.Select_Annees_By_Annee(annee).FirstOrDefault()) + 1;
        }

        private DateTime getDateBonSortie()
        {
            DateTime AssNo = (DateTime)(from a in db.Bon_Sortie
                                        where a.bs_ID == idBonSortie
                                        select a).Single().bs_Date;
            return AssNo;
        }

        private void CodeBarreGenerateur(int qte, int refID, int vlID)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    int index = dgvReference.CurrentCell.RowIndex;
                    int idRef = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                    int iss = int.Parse(dgvReference.Rows[index].Cells["colart_ID"].Value.ToString());
                    Article_Info info = db.Get_Article_Info_By_ID(iss).FirstOrDefault();
                    string abreviation = info.art_Abreviation.Trim().ToUpper();
                    string annee = getYear(cmbxAnnee.Text.ToString()).ToString("yy");
                    string format;
                    int x = 0;
                    int debut = 0, fin = 0;
                    for (int i = 0; i < qte; i++)
                    {
                        int LastNum = int.Parse(lblSerie.Text);
                        debut = LastNum;
                        x = LastNum + i;
                        format = string.Format("{0}{1:00}{2}", abreviation.Trim().ToUpper(), x, annee);
                        //Add CodeBarre to Database
                        int id = maxID_Bon_CodeBarre();
                        //MessageBox.Show(bs.bs_Date.ToString());
                        var rs = (int)db.Upsert_Bon_CodeBarre(id, getDateBonSortie(), "S", format, x, int.Parse(cmbxAnnee.Text), idRef, iss, idBonSortie, vlID).FirstOrDefault();

                        switch (rs)
                        {
                            case 1:
                                Bon_CodeBarre refArt = db.Get_Bon_CodeBarre_By_ID(id).FirstOrDefault();
                                AddOrUpdatePosition(refArt.bc_N_Serie, "S", (int)refArt.bc_Numero, (int)refArt.bc_Annee, (int)refArt.ref_ID, (int)refArt.art_ID);
                                break;
                        }
                    }
                    Update_Last_CodeBarre(x.ToString());
                    lblSerie.Text = (x + 1).ToString();
                    LoadCodBarre_Reference();
                    fin = x;
                    UpdateBon_Reference();
                    transaction.Commit();
                    iTools.sucMsg("Information", "Votre numéro de série a généré correctement");
                    ShowEtatMessage();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    iTools.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
        }

        private bool AddOrUpdatePosition(string codeBarre, string positions, int numero, int annee, int ref_ID, int art_ID)
        {
            bool rs = false;
            if (db.Position_Actuelle.Any(f => f.pa_N_Serie == codeBarre))
            {
                //Update
                Position_Actuelle pa = getPositionActuelle(codeBarre);
                var r = (int)db.Update_Position_Actuelle(pa.pa_ID, pa.pa_Position, pa.pa_N_Serie, pa.pa_Numero, pa.pa_Annee, pa.ref_ID, pa.art_ID).FirstOrDefault();
                switch (r)
                {
                    case 0:
                        rs = false;
                        break;

                    case 1:
                        rs = true;
                        break;
                }
            }
            else
            {
                //Add
                var r = (int)db.Insert_Position_Actuelle(maxID_Position_Actuelle(), positions, codeBarre, numero, annee, ref_ID, art_ID).FirstOrDefault();
                switch (r)
                {
                    case 0:
                        rs = false;
                        break;

                    case 1:
                        rs = true;
                        break;
                }
            }
            return rs;
        }

        private Position_Actuelle getPositionActuelle(string codeBarre)
        {
            var No = (from a in db.Position_Actuelle
                      where a.pa_N_Serie == codeBarre
                      select a).FirstOrDefault();
            return No;
        }

        private int maxID_Position_Actuelle()
        {
            return db.Position_Actuelle.DefaultIfEmpty().Max(r => r == null ? 1 : (r.pa_ID + 1));
        }

        private int maxID_Annee()
        {
            return db.Annees.DefaultIfEmpty().Max(r => r == null ? 1 : (r.an_ID + 1));
        }

        private void UpdateBon_Reference()
        {
            try
            {
                int dex = dgvReference.CurrentRow.Index;
                int idBonRef = int.Parse(dgvReference.Rows[dex].Cells[colbr_ID.Name].Value.ToString());
                int idart = int.Parse(dgvReference.Rows[dex].Cells[colart_ID.Name].Value.ToString());
                int idReff = getIdReference(dgvReference.Rows[dex].Cells[colRef.Name].Value.ToString());
                int idbon = int.Parse(dgvReference.Rows[dex].Cells[colBon_ID.Name].Value.ToString());
                decimal qtee = decimal.Parse(dgvReference.Rows[dex].Cells[colQte.Name].Value.ToString());
                int aid = int.Parse(dgvReference.Rows[dex].Cells[colBon.Name].Value.ToString());
                bool status = Convert.ToBoolean(dgvReference.Rows[dex].Cells[colStatusGravage.Name].Value);
                int rs = (int)db.Update_Bon_reference(idBonRef, "S", idart, idReff, idbon, qtee, aid, null, null, status).FirstOrDefault();
                switch (rs)
                {
                    case 1:
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void UpdateBon_Reference_Qte()
        {
            //try
            //{
            int index = dgvReference.CurrentCell.RowIndex;
            int idBonReference = int.Parse(dgvReference.Rows[index].Cells[colbr_ID.Name].Value.ToString());
            Bon_reference br = db.Get_Bon_reference_By_ID(idBonReference).FirstOrDefault();
            decimal qtee = ToInt(br.br_Qte.ToString()) - 1;
            int rs = (int)db.Update_Bon_reference(br.br_ID, "S", br.art_ID, br.ref_ID, br.bon_ID, qtee, br.bs_A_ID, null, null, br.br_Status_Gravage).FirstOrDefault();
            switch (rs)
            {
                case 1:
                    //form.txtStatus.Caption = "Votre code a bien ajouté";
                    break;
            }

            //}
            //catch (Exception ex)
            //{
            //    iTools.errorMsg("Erreur", ex.Message);
            //    //form.txtStatus.Caption = ex.Message;
            //}
        }

        private DateTime getYear(string s)
        {
            DateTime dt, dt2 = DateTime.Now;

            if (DateTime.TryParseExact(s, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                dt2 = dt;
            }

            return dt2;
        }

        private int getIdAnnee(string annee)
        {
            int AssNo = (from a in db.Annees
                         where a.an_Annee == annee
                         select a).Single().an_ID;
            return AssNo;
        }

        private string getArticleByID(int art_ID)
        {
            string AssNo = (from a in db.Article_Info
                            where a.art_ID == art_ID
                            select a).Single().art_Designation;
            return AssNo;
        }

        private int maxNSerie()
        {
            int x = Convert.ToInt32(this.lblSerie.Text);
            return x;
        }

        private void LoadControls(Bon_Sortie_Article bon)
        {
            cmbxArticle.SelectedValue = bon.art_ID;
            cmbxVL.SelectedValue = bon.vl_ID;
            txtQteDemandee.Text = bon.bs_Qte_Demandee.ToString();
            txtQteLivree.Text = bon.bs_Qte_Livree.ToString();
            txtDescription.Text = bon.bs_A_Description;
        }

        private void Delete_Bon_Reference()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer ce référence", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                int index = dgvReference.CurrentCell.RowIndex;
                int id = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                int idVL = int.Parse(bonArt.vl_ID.ToString());
                if (dgvReference.Rows[index].Cells["colbr_ID"].Value == null || dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    dgvReference.Rows.Remove(dgvReference.Rows[index]);
                }
                else
                {
                    //Search into Database if exsest codebare
                    if (checkCodeBarreFromDatabase(id, idVL) > 0)
                    {
                        MessageBox.Show("Désolé que vous ne puissiez pas la suppression de cette référence, reportez-vous à la boîte de fusionnement de gravage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                int rs = (int)db.Delete_Bon_reference((int)dgvReference.Rows[index].Cells["colbr_ID"].Value).FirstOrDefault();
                                switch (rs)
                                {
                                    case 1:
                                        transaction.Commit();
                                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                                        iTools.sucMsg("Information", "Votre référence a bien supprimé");
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
                }
            }
        }

        private void loadQte(string vl, string article)
        {
            var rQte = db.ResteQteArticle(vl, article).FirstOrDefault() > 0 ? db.ResteQteArticle(vl, article).FirstOrDefault() : 0;
            Unite_Mesure um = db.Select_Unite_Mesure_By_Art_isDefault(db.get_Article_Info_By_Designation(article).FirstOrDefault().art_ID).FirstOrDefault();
            lblQteTotal.Text = $"En stock: {rQte} {um.unit_M_Nom}";
            Info.SetToolTip(lblQteTotal, $"En stock: {rQte} {um.unit_M_Nom}");
        }

        private decimal calcule_Reste_Qte(string vl, string article, decimal qte, int idUMesure)
        {
            decimal RQte;
            var TQte = db.ResteQteArticle(vl, article).FirstOrDefault() > 0 ? db.ResteQteArticle(vl, article).FirstOrDefault() : 0;
            decimal convert = qte * (decimal)db.get_Unite_Mesure_By_ID(idUMesure).FirstOrDefault().unit_M_Coefficient;
            RQte = (decimal)(TQte - convert);
            return decimal.Round(RQte, 2, MidpointRounding.AwayFromZero);
        }

        #endregion Codes

        #region Converts

        private int ToInt(decimal number)
        {
            return decimal.ToInt32(number);
        }

        private int ToInt(string number)
        {
            return decimal.ToInt32(decimal.Parse(number));
        }

        #endregion Converts

        #region Check

        private int checkDataFromDatabase()
        {
            return (int)db.COUNT_Bon_Sortie_Article(idBonSortie, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue).FirstOrDefault();
        }

        private int checkCodeBarreFromDatabase(int idRef, int idVL)
        {
            return (int)db.COUNT_Bon_CodeBarre_By_Type("S", idRef, (int)cmbxArticle.SelectedValue, idBonSortie, idVL).FirstOrDefault();
        }

        private List<int> getCodeBarreFromDatabase(int idRef, int idVL)
        {
            List<int> list = new List<int>();
            foreach (var item in db.Select_Bon_CodeBarre_ID("S", idRef, (int)cmbxArticle.SelectedValue, idBonSortie, idVL).ToList())
                list.Add((int)item);

            return list;
        }

        private void LoadCodBarreByRefrence()
        {
            try
            {
                int id = (int)cmbxVL.SelectedValue;
                int index = dgvReference.CurrentCell.RowIndex;

                int idRef = getIdReference(dgvReference.Rows[index].Cells[colRef.Name].Value.ToString());
                DateTime dtt = getDateBonSortie();
                var data = db.Select_Bon_CodeBarre_By_Date(dtt, "S", idRef, bonArt.art_ID, bonArt.bs_ID, id).ToList();
                //if (data.Count() > 0)
                dgvNSerie.DataSource = data;
                //else
                //{
                //    var dt = dgvNSerie.DataSource as DataTable;
                //    dt.Rows.Clear();
                //    dgvNSerie.DataSource = dt;
                //}
            }
            catch (Exception)
            {
            }
        }

        private void LoadCodBarreByRefrence(int idRef)
        {
            try
            {
                int id = int.Parse(cmbxVL.SelectedValue.ToString());
                var data = from t in db.Bon_CodeBarre where t.art_ID == bonArt.art_ID && t.bc_Type == "S" && t.bon_ID == bonArt.bs_ID && t.vl_ID == id && t.ref_ID == idRef select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
                if (data.Count() > 0)
                    dgvNSerie.DataSource = LINQResultToDataTable(data);
                else
                {
                    var dt = dgvNSerie.DataSource as DataTable;
                    dt.Rows.Clear();
                    dgvNSerie.DataSource = dt;
                }
            }
            catch (Exception)
            {
            }
        }

        private int countCodbarreByReference(int idRef)
        {
            int id = int.Parse(cmbxVL.SelectedValue.ToString());
            int count = 0;
            try
            {
                var data = from t in db.Bon_CodeBarre
                           where t.art_ID == bonArt.art_ID
                           where t.bc_Type == "S"
                           where t.bon_ID == bonArt.bs_ID
                           where t.vl_ID == id
                           where t.ref_ID == idRef
                           select t;
                count = data.Count();
            }
            catch (Exception)
            {
            }
            return count;
        }

        private int checkCodeBarreFromDatabase(int idVL)
        {
            int art = int.Parse(bonArt.art_ID.ToString());
            var _result = from x in db.Bon_CodeBarre
                          where x.bc_Type == "S"
                          where x.art_ID == art
                          where x.bon_ID == idBonSortie
                          where x.vl_ID == idVL
                          select x;

            return _result.Count();
        }

        private int getQteGravee()
        {
            int qte = 0;
            try
            {
                foreach (DataGridViewRow item in dgvReference.Rows)
                {
                    if (item.Cells["colStatusGravage"].Value == null || item.Cells["colStatusGravage"].Value == DBNull.Value || (bool)item.Cells["colStatusGravage"].Value == false)
                    {
                        qte += 0;
                    }
                    else
                    {
                        qte += ToInt(decimal.Parse(item.Cells["colQte"].Value.ToString()));
                    }
                }
            }
            catch (Exception)
            {
            }

            return qte;
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

        //private void VerifierQteTotalAvecQteReferenceAvecBaseDonnees()
        //{
        //    pnlErreur.Visible = false;
        //    pnlOk.Visible = false;
        //    pnlVerifier.Visible = false;
        //    string rs = "";
        //    int qteLivree = ToInt(decimal.Parse(txtQteLivree.Text));
        //    int qteTotal = getQteGravee();
        //    //
        //    int TotalNSerie = checkCodeBarreFromDatabase(int.Parse(cmbxVL.SelectedValue.ToString()));
        //    if (getQteGravee() != TotalNSerie)
        //    {
        //        rs = "Il s'agit d'incompatibilité entre les quantités saisies et celles gravées";
        //        pnlErreur.Visible = true;
        //        pnlErreur.Location = new Point(612, 511);
        //    }
        //    else if ((getQteGravee() == TotalNSerie) && (getQteGravee() != 0))
        //    {
        //        rs = "Correct";
        //        pnlOk.Visible = true;
        //        pnlOk.Location = new Point(612, 511);
        //    }
        //    else if (dgvReference.Rows == null || dgvReference.Rows.Count <= 0)
        //    {
        //        rs = "Veuillez saisie les code barres";
        //        pnlVerifier.Visible = true;
        //        pnlVerifier.Location = new Point(612, 511);
        //    }
        //}

        #endregion Check

        #region Loads

        private void LoadVL()
        {
            cmbxVL.DisplayMember = "vl_Marque";
            cmbxVL.ValueMember = "vl_ID";
            cmbxVL.DataSource = db.Select_Vehicule().ToList();
            cmbxVL.SelectedValue = -1;
        }

        private void LoadArticle()
        {
            cmbxArticle.DisplayMember = "art_Designation";
            cmbxArticle.ValueMember = "art_ID";
            cmbxArticle.DataSource = db.Select_Article_Info(svc).ToList();
            cmbxArticle.SelectedValue = -1;
        }

        private void LoadAnnee()
        {
            cmbxAnnee.DisplayMember = "an_Annee";
            cmbxAnnee.ValueMember = "an_ID";
            cmbxAnnee.DataSource = db.Select_Annees().ToList();
            cmbxAnnee.SelectedValue = -1;
        }

        private void LoadReference_Article()
        {
            try
            {
                var data = from t in db.Bon_reference where t.art_ID == bonArt.art_ID && t.br_Type == "S" && t.bon_ID == bonArt.bs_ID && t.bs_A_ID == bonArt.bs_A_ID select new { t.br_ID, t.br_Type, t.art_ID, t.Article_Reference.ref_reference, t.bon_ID, t.br_Qte, t.bs_A_ID, t.br_Status_Gravage };

                if (data.Count() > 0)
                    dgvReference.DataSource = LINQResultToDataTable(data);
                else
                {
                    var dt = dgvReference.DataSource as DataTable;
                    dt.Rows.Clear();
                    dgvReference.DataSource = dt;
                }
            }
            catch (Exception)
            {
            }
        }

        private void LoadCodBarre_Reference()
        {
            try
            {
                int id = int.Parse(cmbxVL.SelectedValue.ToString());
                var data = from t in db.Bon_CodeBarre where t.art_ID == bonArt.art_ID && t.bc_Type == "S" && t.bon_ID == bonArt.bs_ID && t.vl_ID == id select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
                dgvNSerie.DataSource = LINQResultToDataTable(data);
            }
            catch (Exception)
            {
            }
        }

        #endregion Loads

        #region New

        public frmAddSArticle(frmLBonSortie frm, Bon_Sortie bon)
        {
            InitializeComponent();
            sBon = frm;
            bs = bon;
            LoadArticle();
            LoadVL();
            idBonSortie = bon.bs_ID;
        }

        public frmAddSArticle(frmLBonSortie frm, Bon_Sortie_Article bon)
        {
            InitializeComponent();
            sBon = frm;
            bonArt = bon;
            LoadArticle();
            LoadVL();
            idBonSortie = int.Parse(bon.bs_ID.ToString());
        }

        #endregion New

        private void frmAddArticle_Activated(object sender, EventArgs e)
        {
            //if (Text != "Ajouter des articles")
            //{
            //    //VerifierQteTotalAvecQteReferenceAvecBaseDonnees();
            //    ShowEtatMessage();
            //}
            //else
            //{
            //    LoadReference_Article();
            //    LoadCodBarreByRefrence();
            //}
        }

        private void ShowEtatMessage()
        {
            int rs; //1 gride est vide,2 quntite diferent,3 confort
            VerifieEtatBon_Sortie_Article(out rs);
            switch (rs)
            {
                case 1:
                    pnlErreur.Visible = true;
                    pnlErreur.Location = new Point(612, 511);
                    pnlVerifier.Visible = false;
                    pnlOk.Visible = false;
                    break;

                case 2:
                    pnlErreur.Visible = false;
                    pnlVerifier.Visible = true;
                    pnlVerifier.Location = new Point(612, 511);
                    pnlOk.Visible = false;
                    break;

                case 3:
                    pnlErreur.Visible = false;
                    pnlVerifier.Visible = false;
                    pnlOk.Visible = true;
                    pnlOk.Location = new Point(612, 511);
                    break;

                default:
                    pnlErreur.Visible = false;
                    pnlVerifier.Visible = false;
                    pnlOk.Visible = false;
                    break;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Update_Data();
            //lblSerie.Text = "";
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
        }

        private void frmAddArticle_Load(object sender, EventArgs e)
        {
            //PopulateDataGridView(dgvReference, dgvNSerie);
            pnlVerifier.Visible = false;
            pnlOk.Visible = false;
            pnlErreur.Visible = false;

            NormalCellStyle();
            LoadAnnee();
            lblSerie.Text = "";
            lblQteReste.Text = string.Empty;
            lblQteTotal.Text = string.Empty;
            if (Text == "Ajouter des articles")
            {
                Verify_Buttons(true);
                btnArtSupprimer.Enabled = false;
            }
            else
            {
                //int idVL = int.Parse(bonArt.vl_ID.ToString());
                //if (checkCodeBarreFromDatabase(idVL) > 0)
                //{
                Verify_Buttons(false);
                //btnModifier.Enabled = false;
                //gbInfo.Enabled = false;
                //}
                //else
                //{
                //}
                btnArtSupprimer.Enabled = false;
                LoadControls(bonArt);
                LoadReference_Article();
                EnableControls();
            }
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

        private void btnAddAnnee_Click(object sender, EventArgs e)
        {
            //frmAddAnnee frm = new frmAddAnnee(this);
            //frm.ShowDialog();
            using (frmAdd frm = new frmAdd("Ajouter une année", "une année"))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            if (string.IsNullOrWhiteSpace(frm.Output))
                            {
                                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (db.Annees.Any(f => f.an_Annee == frm.Output.ToUpper()))
                            {
                                iTools.warningMsg("Attention", "Cette année est excite déjà");
                                return;
                            }
                            int max = maxID_Annee();
                            int rs = (int)db.Insert_Annees(max, frm.Output, "0").FirstOrDefault();
                            switch (rs)
                            {
                                case 1:
                                    transaction.Commit();
                                    iTools.sucMsg("Information", "Votre année a bien ajouté");
                                    LoadAnnee();
                                    lblSerie.Text = string.Empty;
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
                r = bonArt.bs_A_ID;
            else
                r = 0;

            frmAddSRefArticle frm = new frmAddSRefArticle(int.Parse(cmbxArticle.SelectedValue.ToString()), idBonSortie, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r);
            frm.ShowDialog();
        }

        private void dgvReference_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvReference.Rows != null)
            {
                btnArtSupprimer.Enabled = true;
            }
            else
            {
                btnArtSupprimer.Enabled = false;
            }
        }

        private void cmbxVL_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!isExistVL(cmbxVL.Text))
                {
                    MessageBox.Show("Ce véhicule n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbxVL.Focus();
                    return;
                }
                if (cmbxVL.SelectedIndex != -1)
                {
                    if (checkDataFromDatabase() > 0)
                    {
                        MessageBox.Show("Cette article est excite déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if (cmbxArticle.SelectedIndex != -1 && cmbxVL.SelectedIndex != -1)
                {
                    var qte = db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault();
                    if (qte == null)
                        lblQteTotal.Text = $"En stock: {0}";
                    else
                        lblQteTotal.Text = $"En stock: {qte.ToString()}";
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvReference_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menuDgvReference;
            rowSelected = e.RowIndex;
        }

        private void menuDgvReference_Opening(object sender, CancelEventArgs e)
        {
            int index = dgvReference.CurrentCell.RowIndex;

            if (dgvReference.Rows[index].Cells["colbr_ID"].Value == null || dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
            {
                //btnCreateNSerie.Text = "Evaluer N° Serie";
                //btnCreateNSerie.Enabled = false;
                btnEvaluerNSerie.Visible = false;
                btnModifierNSerie.Visible = false;
            }
            else
            {
                int id = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                int idVL = int.Parse(bonArt.vl_ID.ToString());
                if (checkCodeBarreFromDatabase(id, idVL) > 0)
                {
                    btnModifierNSerie.Visible = true;
                    btnEvaluerNSerie.Visible = false;
                }
                else
                {
                    btnEvaluerNSerie.Visible = true;
                    btnModifierNSerie.Visible = false;
                }
            }
        }

        private void dgvReference_DoubleClick(object sender, EventArgs e)
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
                    r = bonArt.bs_A_ID;
                else
                    r = 0;
                frmAddSRefArticle frm = new frmAddSRefArticle(int.Parse(cmbxArticle.SelectedValue.ToString()), idBonSortie, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r, id, dgvReference.Rows[index].Cells["colQte"].Value.ToString(), idd, Convert.ToBoolean(dgvReference.Rows[index].Cells["colStatusGravage"].Value));
                frm.Text = "Modifier Reference";
                frm.ShowDialog();
            }
            else
            {
                int.TryParse(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString(), out idd);
                int idVL = int.Parse(bonArt.vl_ID.ToString());
                if (checkCodeBarreFromDatabase(id, idVL) > 0)
                    MessageBox.Show("Désolé que vous ne puissiez pas mettre la modification, reportez-vous à la boîte de fusionnement de gravage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (string.IsNullOrEmpty(txtQteLivree.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteLivree.Focus();
                        return;
                    }
                    int r;
                    if (bonArt != null)
                        r = bonArt.bs_A_ID;
                    else
                        r = 0;
                    frmAddSRefArticle frm = new frmAddSRefArticle(int.Parse(cmbxArticle.SelectedValue.ToString()), idBonSortie, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r, id, dgvReference.Rows[index].Cells["colQte"].Value.ToString(), idd, Convert.ToBoolean(dgvReference.Rows[index].Cells["colStatusGravage"].Value));
                    frm.Text = "Modifier Reference";
                    frm.ShowDialog();
                }
            }
        }

        private void btnArtSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Bon_Reference();
        }

        private void btnEvaluerNSerie_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvReference.Rows[dgvReference.CurrentRow.Index];
            if (row.Cells["colStatusGravage"].Value == null || row.Cells["colStatusGravage"].Value == DBNull.Value || (bool)row.Cells["colStatusGravage"].Value == false)
            {
                MessageBox.Show("La reference ne peut pas gravee", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbxAnnee.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez indiquer l'année de gravage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbxAnnee.Focus();
                return;
            }
            int index = dgvReference.CurrentCell.RowIndex;
            int idRef = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
            int qte = decimal.ToInt32(decimal.Parse(dgvReference.Rows[index].Cells["colQte"].Value.ToString()));
            int idVil = int.Parse(cmbxVL.SelectedValue.ToString());
            //MessageBox.Show(idRef + " " + qte.ToString());
            CodeBarreGenerateur(qte, idRef, idVil);
        }

        private void btnModifierNSerie_Click(object sender, EventArgs e)
        {
            int index = dgvReference.CurrentCell.RowIndex;
            string reference = dgvReference.Rows[index].Cells["colRef"].Value.ToString();
            string qteReference = dgvReference.Rows[index].Cells["colQte"].Value.ToString();
            //string du = dgvReference.Rows[index].Cells["colDebut_Gravage"].Value.ToString();
            //string au = dgvReference.Rows[index].Cells["colFin_Gravage"].Value.ToString();
            //string annee = dgvReference.Rows[index].Cells["colAnnee"].Value.ToString();
            string art = cmbxArticle.Text;
            int iss = int.Parse(dgvReference.Rows[index].Cells["colart_ID"].Value.ToString());
            Article_Info info = db.Get_Article_Info_By_ID(iss).FirstOrDefault();
            string abreviation = info.art_Abreviation.Trim().ToUpper();
            string qteArt = txtQteLivree.Text;

            int id = int.Parse(dgvReference.Rows[index].Cells["colBon"].Value.ToString());
            int idd = int.Parse(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString());
            Bon_Sortie_Article bonA = db.Get_Bon_Sortie_Article(id).FirstOrDefault();
            Bon_reference _Reference = db.Get_Bon_reference_By_ID(idd).FirstOrDefault();
            frmCodeBarreSAvancee frm = new frmCodeBarreSAvancee(art, abreviation, qteArt, reference, qteReference, bonA, _Reference, this);
            frm.ShowDialog();
            ShowEtatMessage();
        }

        private void cmbxAnnee_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvReference_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvReference.CurrentCell = dgvReference[e.ColumnIndex, e.RowIndex];
            }
        }

        private void dgvReference_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }

        private void btnSelectNSerie_Click(object sender, EventArgs e)
        {
            LoadCodBarreByRefrence();
        }

        private void btnAfficherTous_Click(object sender, EventArgs e)
        {
            LoadCodBarre_Reference();
        }

        private void dgvReference_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dgvReference.CurrentRow != null)
                //{
                //    //int idRef = getIdReference(dgvReference.CurrentRow.Cells["colRef"].Value.ToString());
                //    LoadCodBarreByRefrence();
                //}
                int index = dgvReference.CurrentCell.RowIndex;
                if (dgvReference.Rows[index].Cells["colbr_ID"].Value == null || dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    return;
                }
                LoadCodBarreByRefrence();
            }
            catch (Exception)
            {
            }
        }

        private void dgvNSerie_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menuDgvNSerie;
        }

        private void dgvNSerie_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvNSerie.CurrentCell = dgvNSerie[e.ColumnIndex, e.RowIndex];
            }
        }

        private void btnAddNSerie_Click(object sender, EventArgs e)
        {
            int index = dgvReference.CurrentCell.RowIndex;
            string reference = dgvReference.Rows[index].Cells["colRef"].Value.ToString();
            string art = cmbxArticle.Text;
            int iss = int.Parse(dgvReference.Rows[index].Cells["colart_ID"].Value.ToString());
            Article_Info info = db.Get_Article_Info_By_ID(iss).FirstOrDefault();
            string abreviation = info.art_Abreviation.Trim().ToUpper();
            int idBon = int.Parse(dgvReference.Rows[index].Cells["colBon_ID"].Value.ToString());
            int idBonReference = int.Parse(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString());
            Bon_reference bon = db.Get_Bon_reference_By_ID(idBonReference).FirstOrDefault();
            frmAddSCodeBarre frm = new frmAddSCodeBarre(art, abreviation, reference, int.Parse(cmbxVL.SelectedValue.ToString()), idBon, this, idBonReference, bonArt, bon);
            frm.ShowDialog();
        }

        private void btnDeleteNSerie_Click(object sender, EventArgs e)
        {
            Delete_CodeBare();
        }

        private void frmAddArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cmbxArticle_Validating(object sender, CancelEventArgs e)
        {
        }

        private void attribuerUnNuméroDeSérieExistanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvReference.CurrentCell.RowIndex;
            string reference = dgvReference.Rows[index].Cells["colRef"].Value.ToString();
            string qteReference = dgvReference.Rows[index].Cells["colQte"].Value.ToString();
            string article = getArticleByID((int)dgvReference.Rows[index].Cells["colart_ID"].Value);
            int idVL = (int)cmbxVL.SelectedValue;
            frmSAttribuerNSerie frm = new frmSAttribuerNSerie(article, reference, qteReference, idBonSortie, idVL, this);
            frm.ShowDialog();
        }

        private void txtQteDemandee_Validating(object sender, CancelEventArgs e)
        {
            //txtQteLivree.Text = txtQteDemandee.Text;
            if (cmbxUMesure.SelectedIndex == -1)
                return;
            if (!string.IsNullOrEmpty(txtQteDemandee.Text))
            {
                var TQte = db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault() > 0 ? db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault() : 0;
                decimal Dqte = Convert.ToDecimal(txtQteDemandee.Text);
                decimal convert = Dqte * (decimal)db.get_Unite_Mesure_By_ID((int)cmbxUMesure.SelectedValue).FirstOrDefault().unit_M_Coefficient;

                if (TQte < convert)
                {
                    txtQteLivree.Text = $"{TQte}";
                }
                else
                {
                    txtQteLivree.Text = $"{convert}";
                }
            }
        }

        private void txtQteLivree_KeyPress(object sender, KeyPressEventArgs e)
        {
            //decimal qte = (decimal)db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault();
            //decimal Lqte = Convert.ToDecimal(txtQteLivree.Text.ToString());
            //if (qte > Lqte)
            //{
            //    e.Handled = true;
            //}
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txtDescription_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void cmbxVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxVL.SelectedIndex != -1 && cmbxArticle.SelectedIndex != -1)
                loadQte(cmbxVL.Text, cmbxArticle.Text);
        }

        private void cmbxUMesure_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtQteDemandee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void dgvReference_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtQteLivree_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQteLivree.Text))
            {
                var TQte = db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault() > 0 ? db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault() : 0;
                decimal Dqte = Convert.ToDecimal(txtQteLivree.Text);
                decimal convert = Dqte * (decimal)db.get_Unite_Mesure_By_ID((int)cmbxUMesure.SelectedValue).FirstOrDefault().unit_M_Coefficient;
                Unite_Mesure um = db.Select_Unite_Mesure_By_Art_isDefault((int)cmbxArticle.SelectedValue).FirstOrDefault();

                if (TQte < convert)
                {
                    MessageBox.Show("La quantité demandée est plus élevée que celle présente dans le stock", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblQteReste.Text = string.Empty;
                    txtQteLivree.Text = string.Empty;
                }
                else
                {
                    lblQteReste.Text = $"Reste: {calcule_Reste_Qte(cmbxVL.Text, cmbxArticle.Text, Dqte, (int)cmbxUMesure.SelectedValue)} {um.unit_M_Nom}";
                    Info.SetToolTip(lblQteReste, $"Reste: {calcule_Reste_Qte(cmbxVL.Text, cmbxArticle.Text, Dqte, (int)cmbxUMesure.SelectedValue)} {um.unit_M_Nom}");
                }
            }
        }

        private void cmbxAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var str = cmbxAnnee.Text;
                if (str != null || cmbxAnnee.SelectedIndex == -1)
                {
                    db = new ges_AutoEntities();
                    //cmbxAnnee.DataSource = uAnnee.GetAll();
                    lblSerie.Text = getNSerie(str.ToString()).ToString();
                    //MessageBox.Show(getMaxNSerie(int.Parse(str.ToString())).ToString());
                }
                else
                    lblSerie.Text = string.Empty;
            }
            catch (Exception)
            {
            }
        }
    }
}