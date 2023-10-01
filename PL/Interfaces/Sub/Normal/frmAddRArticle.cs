using DAL.DB;
using PL.Interfaces.Sub.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAddRArticle : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private frmLBonRetour rBon;
        private Bon_Retour bs;
        private Bon_Retour_Article bonArt;
        private int idArticle, idBon;
        private int rowSelected;
        private int rsStatus;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

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

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Bons de retour courants", getID_Lists("Retours")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Supprimer;
            else
                btnModifier.Enabled = false;
        }

        #endregion Permission

        private void LoadUMesure(int idArt)
        {
            cmbxUMesure.DataSource = db.Select_Unite_Mesure_By_IdArt(idArt).ToList();
            cmbxUMesure.DisplayMember = "unit_M_Abreviation";
            cmbxUMesure.ValueMember = "unit_M_ID";
            cmbxUMesure.SelectedValue = -1;
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

        private void Add_CodeBarre(int idBon, int idVL)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    bool testValue = CheckRows(cmbxNSerie.Text, dgvNSerie, txtNSerie.Name);
                    if (!testValue)
                    {
                        Bon_CodeBarre bcc = getCodeBarre(cmbxNSerie.Text);
                        int num = getNumCodeBarre(cmbxNSerie.Text);
                        string annee = getAnneeCodeBarre(cmbxNSerie.Text).ToString();
                        if (bcc.ref_ID != getIdReference(dgvReference.Rows[dgvReference.CurrentRow.Index].Cells[colRef.Name].Value.ToString()))
                        {
                            MessageBox.Show("Les references ne sont pas compatibles", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cmbxNSerie.Focus();
                            return;
                        }
                        if (num > (int.Parse(getLastNum(annee))))
                        {
                            MessageBox.Show("Celui-ci dépasse le dernier numéro de série", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cmbxNSerie.Focus();
                            return;
                        }
                        int id = maxID_Bon_CodeBarre();
                        int rs = (int)db.Insert_Bon_CodeBarre(id, getDateBonRetour(), "R", cmbxNSerie.Text, bcc.bc_Numero, bcc.bc_Annee, bcc.ref_ID, bcc.art_ID, idBon, idVL).FirstOrDefault();
                        switch (rs)
                        {
                            case 1:
                                Bon_CodeBarre bc = db.Get_Bon_CodeBarre_By_ID(id).FirstOrDefault();
                                if (AddOrUpdatePosition(bc.bc_N_Serie, "R", (int)bc.bc_Numero, (int)bc.bc_Annee, (int)bc.ref_ID, (int)bc.art_ID))
                                {
                                    transaction.Commit();
                                    LoadCodBarreByRefrence();
                                    UpdateBon_Reference();
                                    LoadReference_Article();
                                    iTools.sucMsg("Information", "Votre numéro de série a généré correctement");
                                }
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce numéro de série est excite déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbxNSerie.Focus();
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

        private Bon_CodeBarre getCodeBarre(string codeBarre)
        {
            var No = (from a in db.Bon_CodeBarre
                      where a.bc_N_Serie == codeBarre
                      select a).FirstOrDefault();
            return No;
        }

        private DateTime getDateBonRetour()
        {
            return (DateTime)db.get_Bon_Retour(idBon).FirstOrDefault().bt_Date;
        }

        private bool AddOrUpdatePosition(string codeBarre, string positions, int numero, int annee, int ref_ID, int art_ID)
        {
            bool rs = false;
            if (db.Position_Actuelle.Any(f => f.pa_N_Serie == codeBarre))
            {
                //Update
                Position_Actuelle pa = getPositionActuelle(codeBarre);

                int rss = (int)db.Update_Position_Actuelle(pa.pa_ID, positions, pa.pa_N_Serie, pa.pa_Numero, pa.pa_Annee, pa.ref_ID, pa.art_ID).FirstOrDefault();
                switch (rss)
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
                int rss = (int)db.Insert_Position_Actuelle(maxID_Position_Actuelle(), positions, codeBarre, numero, annee, ref_ID, art_ID).FirstOrDefault();
                switch (rss)
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

        private string getLastNum(string annee)
        {
            return db.get_Annees_By_Annee(annee).FirstOrDefault().an_LastNumero;
        }

        private int getNumCodeBarre(string N_Serie)
        {
            int AssNo = (int)(from a in db.Bon_CodeBarre
                              where a.bc_N_Serie == N_Serie
                              select a).Single().bc_Numero;
            return AssNo;
        }

        private int getAnneeCodeBarre(string N_Serie)
        {
            int AssNo = (int)(from a in db.Bon_CodeBarre
                              where a.bc_N_Serie == N_Serie
                              select a).Single().bc_Annee;
            return AssNo;
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

        private bool VerifieEtatBon_Retour_Article(out int status)
        {
            bool rs = false;
            status = 0;
            int qteGlobale = ToInt(txtQteLivree.Text);
            int qteTotalIntoGrid = getQteTotal(dgvReference, "colQte");
            int qteCell = 0;
            int totalCodebarre = 0;
            try
            {
                if (qteGlobale == qteTotalIntoGrid)
                {
                    foreach (DataGridViewRow row in dgvReference.Rows)
                    {
                        totalCodebarre = countCodbarreByReference(getIdReference(row.Cells["colRef"].Value.ToString()));
                        qteCell = ToInt(row.Cells["colQte"].Value.ToString());
                        if (row.Cells["colStatusGravage"].Value == null || row.Cells["colStatusGravage"].Value == DBNull.Value || (bool)row.Cells["colStatusGravage"].Value == false)
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
            int artid = int.Parse(cmbxArticle.SelectedValue.ToString());
            int AssNo = (from a in db.Article_Reference
                         where a.ref_reference == Reference
                         where a.art_ID == artid
                         select a).Single().ref_ID;
            return AssNo;
        }

        private void Add_Update_Reference(int idBon, int idBonArt)
        {
            decimal qte = 0;
            int id;
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
                    db.Insert_Bon_reference(id, "R", (int)cmbxArticle.SelectedValue, getIdReference(row.Cells[dgvReference.Columns["colRef"].Index].Value.ToString()), idBon, qte, null, null, idBonArt, status).FirstOrDefault();
                }
                else
                {
                    db.Update_Bon_reference(id, "R", (int)cmbxArticle.SelectedValue, getIdReference(row.Cells[dgvReference.Columns["colRef"].Index].Value.ToString()), idBon, qte, null, null, idBonArt, status).FirstOrDefault();
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
                int rs = (int)db.Upsert_Bon_CodeBarre(id, DateTime.Now, "R", $"{dgvNSerie.Rows[i].Cells[txtNSerie.Name].Value}", null, null, (int)dgvNSerie.Rows[i].Cells[txtReference.Name].Value, (int)cmbxArticle.SelectedValue, idBon, (int)cmbxVL.SelectedValue).FirstOrDefault();
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
                //        bc_Type = "R",
                //        ref_ID = strRef,
                //        art_ID = int.Parse(cmbxArticle.SelectedValue.ToString()),
                //        bon_ID = idBon,
                //        bc_N_Serie = dgvNSerie.Rows[i].Cells["txtNSerie"].Value.ToString()
                //    };
                //    bon_CodeBarre.Add(refArt);
                //    db.Upsert_Bon_CodeBarre(id, )
                //}
                //else
                //{
                //    //Update
                //    refArt = new Bon_CodeBarre()
                //    {
                //        bc_ID = id,
                //        bc_Type = "R",
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
            int artid = int.Parse(cmbxArticle.SelectedValue.ToString());

            var No = (from a in db.Bon_CodeBarre
                      where a.bc_N_Serie == codeBarre
                      where a.art_ID == artid
                      where a.ref_ID == idRef
                      where a.bon_ID == bonID
                      select a).Single().bc_ID;
            return int.Parse(No.ToString());
        }

        private Position_Actuelle getPositionActuelle(string codeBarre)
        {
            var No = (from a in db.Position_Actuelle
                      where a.pa_N_Serie == codeBarre
                      select a).FirstOrDefault();
            return No;
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
                                var ps = getPositionActuelle(cb);
                                if (AddOrUpdatePosition(ps.pa_N_Serie, "S", (int)ps.pa_Numero, (int)ps.pa_Annee, (int)ps.ref_ID, (int)ps.art_ID))
                                {
                                    transaction.Commit();
                                    //form.txtStatus.Caption = "Votre code a bien ajouté";
                                    iTools.sucMsg("Information", "Votre numéro de série a bien supprimé");
                                    LoadReference_Article();
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
                rBon.dgvEBon_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int maxID_RBon_Article()
        {
            return (int)db.MAX_Bon_Retour_Article().FirstOrDefault();
        }

        private int maxID_Position_Actuelle()
        {
            return (int)db.MAX_Position_Actuelle().FirstOrDefault();
        }

        private int maxID_Bon_Reference()
        {
            return (int)db.MAX_Bon_reference().FirstOrDefault();
        }

        private int maxID_Bon_CodeBarre()
        {
            return (int)db.MAX_Bon_CodeBarre().FirstOrDefault();
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
                    int idBon = bs.bt_ID;
                    bool etat = VerifieEtatBon_Retour_Article(out rsStatus);
                    int id = maxID_RBon_Article();
                    var rs = (int)db.Insert_Bon_Retour_Article(id, DateTime.Now, Decimal.Parse(txtQteLivree.Text), idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            Bon_Retour_Article bsA = db.get_Bon_Retour_Article_By_ID(id).FirstOrDefault();
                            Add_Update_Reference(bs.bt_ID, bsA.bt_A_ID);
                            //Add_Update_CodeBarre(bs.bs_ID);
                            //Update_Last_CodeBarre();
                            db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un article de bon de retour");
                            transaction.Commit();

                            iTools.sucMsg("Information", "Votre article a bien ajouté");
                            //newRecord();
                            getData();
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

        private void LoadBon(Bon_Retour_Article bsA)
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
                    if (string.IsNullOrEmpty(txtQteLivree.Text))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQteLivree.Focus();
                        return;
                    }
                    //Ajouter Articles
                    int idBon = rBon.idBonRetour;

                    bool etat = VerifieEtatBon_Retour_Article(out rsStatus);
                    var rs = (int)db.Update_Bon_Retour_Article(bonArt.bt_A_ID, DateTime.Now, Decimal.Parse(txtQteLivree.Text), idBon, (int)cmbxArticle.SelectedValue, (int)cmbxVL.SelectedValue, (int)cmbxUMesure.SelectedValue, txtDescription.Text, etat).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            Bon_Retour_Article bsA = db.get_Bon_Retour_Article_By_ID(bonArt.bt_A_ID).FirstOrDefault();
                            db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un article de bon de retour");
                            transaction.Commit();
                            iTools.sucMsg("Information", "Votre article a bien modifié");
                            getData();
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

        //private void UpdateBon_Reference()
        //{
        //    try
        //    {
        //        int dex = dgvReference.CurrentRow.Index;
        //        int idBonRef = int.Parse(dgvReference.Rows[dex].Cells["colbr_ID"].Value.ToString());
        //        int idart = int.Parse(dgvReference.Rows[dex].Cells["colart_ID"].Value.ToString());
        //        int idReff = getIdReference(dgvReference.Rows[dex].Cells["colRef"].Value.ToString());
        //        int idbon = int.Parse(dgvReference.Rows[dex].Cells["colBon_ID"].Value.ToString());
        //        decimal qtee = decimal.Parse(dgvReference.Rows[dex].Cells["colQte"].Value.ToString());
        //        int aid = int.Parse(dgvReference.Rows[dex].Cells["colBon"].Value.ToString());
        //        bool status = Convert.ToBoolean(dgvReference.Rows[dex].Cells["colStatusGravage"].Value);
        //        Bon_reference bn = new Bon_reference()
        //        {
        //            br_ID = idBonRef,
        //            br_Type = "R",
        //            art_ID = idart,
        //            ref_ID = idReff,
        //            bon_ID = idbon,
        //            br_Qte = qtee,
        //            bt_A_ID = aid,
        //            br_Status_Gravage = status
        //        };
        //        if (bon_Reference.Update(bn))
        //        {
        //            //form.txtStatus.Caption = "Votre code a bien ajouté";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        iTools.errorMsg("Erreur", ex.Message);
        //        //form.txtStatus.Caption = ex.Message;
        //    }
        //}

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
                int rs = (int)db.Update_Bon_reference(idBonRef, "R", idart, idReff, idbon, qtee, null, null, aid, status).FirstOrDefault();
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

        //private void UpdateBon_Reference_Qte()
        //{
        //    //try
        //    //{
        //    int index = dgvReference.CurrentCell.RowIndex;
        //    int idBonReference = int.Parse(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString());
        //    Bon_reference br = bon_Reference.GetSingle(f => f.br_ID == idBonReference);
        //    decimal qtee = ToInt(br.br_Qte.ToString()) - 1;
        //    Bon_reference bn = new Bon_reference()
        //    {
        //        br_ID = br.br_ID,
        //        br_Type = "R",
        //        art_ID = br.art_ID,
        //        ref_ID = br.ref_ID,
        //        bon_ID = br.bon_ID,
        //        br_Qte = qtee,
        //        bt_A_ID = br.bt_A_ID,
        //        br_Status_Gravage = br.br_Status_Gravage
        //    };
        //    if (bon_Reference.Update(bn))
        //    {
        //        //form.txtStatus.Caption = "Votre code a bien ajouté";
        //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    iTools.errorMsg("Erreur", ex.Message);
        //    //    //form.txtStatus.Caption = ex.Message;
        //    //}
        //}

        private void LoadControls(Bon_Retour_Article bon)
        {
            cmbxArticle.SelectedValue = bon.art_ID;
            cmbxVL.SelectedValue = bon.vl_ID;
            txtQteLivree.Text = bon.bt_Qte_Livree.ToString();
            txtDescription.Text = bon.bt_A_Description;
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
                                int rs = (int)db.Delete_Bon_reference((int)dgvReference.Rows[index].Cells[colbr_ID.Name].Value).FirstOrDefault();
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
            int vl = int.Parse(cmbxVL.SelectedValue.ToString());
            int art = int.Parse(cmbxArticle.SelectedValue.ToString());
            var _result = from x in db.Bon_Retour_Article
                          where x.vl_ID == vl
                          where x.art_ID == art
                          where x.bt_ID == idBon
                          select x;

            return _result.Count();
        }

        private int checkCodeBarreFromDatabase(int idRef, int idVL)
        {
            int refId = idRef;
            int art = int.Parse(cmbxArticle.SelectedValue.ToString());
            var _result = from x in db.Bon_CodeBarre
                          where x.bc_Type == "R"
                          where x.art_ID == art
                          where x.bon_ID == idBon
                          where x.ref_ID == refId
                          where x.vl_ID == idVL
                          select x;

            return _result.Count();
        }

        private List<int> getCodeBarreFromDatabase(int idRef, int idVL)
        {
            List<int> list = new List<int>();
            int refId = idRef;
            int art = int.Parse(cmbxArticle.SelectedValue.ToString());
            var _result = from x in db.Bon_CodeBarre
                          where x.bc_Type == "R"
                          where x.art_ID == art
                          where x.bon_ID == idBon
                          where x.ref_ID == refId
                          where x.vl_ID == idVL
                          select x;
            foreach (var item in _result)
            {
                list.Add(item.bc_ID);
            }
            return list;
        }

        private void LoadCodBarreByRefrence()
        {
            try
            {
                int id = (int)cmbxVL.SelectedValue;
                int index = dgvReference.CurrentCell.RowIndex;
                int idRef = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                DateTime dtt = getDateBonRetour();
                dgvNSerie.DataSource = db.Select_Bon_CodeBarre_By_Date(dtt, "R", idRef, bonArt.art_ID, bonArt.bt_ID, id).ToList();
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
                //var data = from t in db.Bon_CodeBarre where t.art_ID == bonArt.art_ID && t.bc_Type == "S" && t.bon_ID == bonArt.bt_ID && t.vl_ID == id && t.ref_ID == idRef select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
                dgvNSerie.DataSource = db.Select_Bon_CodeBarre_By_Type("S", idRef, bonArt.art_ID, bonArt.bt_ID, id).ToList();
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
                           where t.bc_Type == "R"
                           where t.bon_ID == bonArt.bt_ID
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
                          where x.bc_Type == "R"
                          where x.art_ID == art
                          where x.bon_ID == idBon
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
            cmbxVL.DataSource = db.Select_Vehicule().ToList();
            cmbxVL.DisplayMember = "vl_Marque";
            cmbxVL.ValueMember = "vl_ID";
            cmbxVL.SelectedValue = -1;
        }

        private void LoadArticle()
        {
            cmbxArticle.DisplayMember = "art_Designation";
            cmbxArticle.ValueMember = "art_ID";
            cmbxArticle.DataSource = db.Select_Article_Info(Properties.Settings.Default.idService).ToList();
            cmbxArticle.SelectedValue = -1;
        }

        private void LoadReference_Article()
        {
            try
            {
                dgvReference.DataSource = db.Select_v_Bon_Reference_Retour("R", bonArt.art_ID, bonArt.bt_ID, bonArt.bt_A_ID).ToList();
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
                var data = from t in db.Bon_CodeBarre where t.art_ID == bonArt.art_ID && t.bc_Type == "R" && t.bon_ID == bonArt.bt_ID && t.vl_ID == id select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
                dgvNSerie.DataSource = LINQResultToDataTable(data);
            }
            catch (Exception)
            {
            }
        }

        private void LoadCodeBarreSortie(int idArticle, int idRef)
        {
            try
            {
                cmbxNSerie.DataSource = db.Select_Position_Actuelle_By_Position("S", idRef, idArticle).ToList();
                cmbxNSerie.DisplayMember = "pa_N_Serie";
                cmbxNSerie.ValueMember = "pa_ID";
                cmbxNSerie.SelectedIndex = -1;
            }
            catch (Exception)
            {
            }
        }

        #endregion Loads

        #region New

        public frmAddRArticle(frmLBonRetour frm, Bon_Retour bon)
        {
            InitializeComponent();
            LoadArticle();
            LoadVL();
            rBon = frm;
            bs = bon;
            idBon = bon.bt_ID;
        }

        public frmAddRArticle(frmLBonRetour frm, Bon_Retour_Article bon)
        {
            InitializeComponent();
            LoadArticle();
            LoadVL();
            rBon = frm;
            bonArt = bon;
            idBon = int.Parse(bon.bt_ID.ToString());
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
            VerifieEtatBon_Retour_Article(out rs);
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
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.DefaultText(txtDescription.Text);
        }

        private void frmAddArticle_Load(object sender, EventArgs e)
        {
            //PopulateDataGridView(dgvReference, dgvNSerie);

            NormalCellStyle();
            if (Text == "Ajouter des articles")
            {
                Verify_Buttons(true);
                btnArtSupprimer.Enabled = false;
                Refresh_Button_Ajouter();
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
                Refresh_Button_Modifier();
            }
        }

        private void cmbxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxArticle.SelectedIndex != -1)
            {
                LoadUMesure((int)cmbxArticle.SelectedValue);
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
                r = bonArt.bt_A_ID;
            else
                r = 0;

            frmAddRRefArticle frm = new frmAddRRefArticle(int.Parse(cmbxArticle.SelectedValue.ToString()), idBon, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r);
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
                btnModifierNSerie.Visible = false;
            }
            else
            {
                int id = getIdReference(dgvReference.Rows[index].Cells["colRef"].Value.ToString());
                int idVL = int.Parse(bonArt.vl_ID.ToString());
                if (checkCodeBarreFromDatabase(id, idVL) > 0)
                {
                    btnModifierNSerie.Visible = true;
                }
                else
                {
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
                    r = bonArt.bt_A_ID;
                else
                    r = 0;
                frmAddRRefArticle frm = new frmAddRRefArticle(int.Parse(cmbxArticle.SelectedValue.ToString()), idBon, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r, id, dgvReference.Rows[index].Cells["colQte"].Value.ToString(), idd, Convert.ToBoolean(dgvReference.Rows[index].Cells["colStatusGravage"].Value));
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
                        r = bonArt.bt_A_ID;
                    else
                        r = 0;
                    frmAddRRefArticle frm = new frmAddRRefArticle(int.Parse(cmbxArticle.SelectedValue.ToString()), idBon, int.Parse(cmbxVL.SelectedValue.ToString()), this, Convert.ToDecimal(txtQteLivree.Text), r, id, dgvReference.Rows[index].Cells["colQte"].Value.ToString(), idd, Convert.ToBoolean(dgvReference.Rows[index].Cells["colStatusGravage"].Value));
                    frm.Text = "Modifier Reference";
                    frm.ShowDialog();
                }
            }
        }

        private void btnArtSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Bon_Reference();
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
            Bon_Retour_Article bonA = db.get_Bon_Retour_Article_By_ID(id).FirstOrDefault();
            Bon_reference _Reference = db.Get_Bon_reference_By_ID(idd).FirstOrDefault();
            frmCodeBarreRAvancee frm = new frmCodeBarreRAvancee(art, abreviation, qteArt, reference, qteReference, bonA, _Reference, this);
            frm.ShowDialog();
            ShowEtatMessage();
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

        private void btnAfficherTous_Click(object sender, EventArgs e)
        {
            LoadCodBarre_Reference();
        }

        private void dgvReference_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvReference.CurrentCell.RowIndex;
                if (dgvReference.Rows[index].Cells["colbr_ID"].Value == null || dgvReference.Rows[index].Cells["colbr_ID"].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString()))
                {
                    return;
                }
                var idRef = getIdReference(dgvReference.CurrentRow.Cells["colRef"].Value.ToString());
                LoadCodeBarreSortie(int.Parse(cmbxArticle.SelectedValue.ToString()), idRef);
                LoadCodBarreByRefrence();
            }
            catch (Exception)
            {
            }
            //int idRef = 0;
            //try
            //{
            //    if (dgvReference.CurrentRow != null)
            //    {
            //        cmbxNSerie.DataSource = null;
            //        cmbxNSerie.DisplayMember = "pa_N_Serie";
            //        cmbxNSerie.ValueMember = "pa_ID";
            //idRef = getIdReference(dgvReference.CurrentRow.Cells["colRef"].Value.ToString());
            //LoadCodeBarreSortie(int.Parse(cmbxArticle.SelectedValue.ToString()), idRef);
            //LoadCodBarreByRefrence();
            //        cmbxNSerie.SelectedValue = -1;
            //    }
            //}
            //catch (Exception)
            //{
            //}
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

        //private void btnAddNSerie_Click(object sender, EventArgs e)
        //{
        //    int index = dgvReference.CurrentCell.RowIndex;
        //    string reference = dgvReference.Rows[index].Cells["colRef"].Value.ToString();
        //    string art = cmbxArticle.Text;
        //    int iss = int.Parse(dgvReference.Rows[index].Cells["colart_ID"].Value.ToString());
        //    Article_Info info = Article.GetSingle(f => f.art_ID == iss);
        //    string abreviation = info.art_Abreviation.Trim().ToUpper();
        //    int idBon = int.Parse(dgvReference.Rows[index].Cells["colBon_ID"].Value.ToString());
        //    int idBonReference = int.Parse(dgvReference.Rows[index].Cells["colbr_ID"].Value.ToString());
        //    Bon_reference bon = bon_Reference.GetSingle(f => f.br_ID == idBonReference);
        //    frmAddRCodeBarre frm = new frmAddRCodeBarre(art, abreviation, reference, int.Parse(cmbxVL.SelectedValue.ToString()), idBon, this, idBonReference, bonArt, bon);
        //    frm.ShowDialog();
        //}

        private void btnDeleteNSerie_Click(object sender, EventArgs e)
        {
            Delete_CodeBare();
        }

        private void frmAddArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnAddAnnee_Click(object sender, EventArgs e)
        {
            if (cmbxNSerie.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez indiquer un numéro de série", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbxNSerie.Focus();
                return;
            }
            Bon_CodeBarre bc = getCodeBarre(cmbxNSerie.Text);
            int idRef = int.Parse(bc.ref_ID.ToString());
            int idArt = int.Parse(cmbxArticle.SelectedValue.ToString());
            int idVL = int.Parse(cmbxVL.SelectedValue.ToString());

            Add_CodeBarre(idBon, idVL);
        }

        private void cmbxArticle_Validating(object sender, CancelEventArgs e)
        {
            if (!isExistArticle(cmbxArticle.Text))
            {
                MessageBox.Show("Cet article n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbxArticle.Focus();
                return;
            }
        }
    }
}