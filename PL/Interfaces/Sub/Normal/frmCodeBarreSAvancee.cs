using DAL.DB;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmCodeBarreSAvancee : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_Sortie_Article bonArt;
        private Bon_reference br;
        private frmAddSArticle frm;

        #endregion Fields

        #region Converts

        private int ToInt(decimal number)
        {
            return decimal.ToInt32(number);
        }

        #endregion Converts

        #region Annees

        private void LoadAnnee()
        {
            cmbxAnnee.DisplayMember = "an_Annee";
            cmbxAnnee.ValueMember = "an_ID";
            cmbxAnnee.DataSource = db.Select_Annees();
            cmbxAnnee.SelectedValue = -1;
        }

        private int getNSerie(string annee)
        {
            string AssNo = (from a in db.Annees
                            where a.an_Annee == annee
                            select a).Single().an_LastNumero;
            return (int.Parse(AssNo) + 1);
        }

        #endregion Annees

        #region New

        public frmCodeBarreSAvancee(string Article, string Abreviation, string QteArticle, string Reference, string QteReference, Bon_Sortie_Article bsa, Bon_reference bre, frmAddSArticle f)
        {
            InitializeComponent();
            LoadAnnee();
            lblArticle.Text = Article;
            lblAbreviation.Text = Abreviation;
            lblQteArt.Text = QteArticle;
            lblReference.Text = Reference;
            txtQte.Text = QteReference;
            bonArt = bsa;
            br = bre;
            frm = f;
        }

        #endregion New

        #region Check

        private Dictionary<int, string> getIdCodeBarreFromDatabase(int idRef, int idVL, int artt, int idBon)
        {
            var list = new Dictionary<int, string>();
            int refId = idRef;
            int art = artt;
            var _result = from x in db.Bon_CodeBarre
                          where x.bc_Type == "S"
                          where x.art_ID == art
                          where x.bon_ID == idBon
                          where x.ref_ID == refId
                          where x.vl_ID == idVL
                          select x;
            foreach (var item in _result)
            {
                list.Add(item.bc_ID, item.bc_N_Serie);
            }
            return list;
        }

        private List<string> getCodeBarreFromDatabase(int idRef, int idVL, int artt, int idBon)
        {
            List<string> list = new List<string>();
            int refId = idRef;
            int art = artt;
            var _result = from x in db.Bon_CodeBarre
                          where x.bc_Type == "S"
                          where x.art_ID == art
                          where x.bon_ID == idBon
                          where x.ref_ID == refId
                          where x.vl_ID == idVL
                          select x;
            foreach (var item in _result)
            {
                list.Add(item.bc_N_Serie);
            }
            return list;
        }

        #endregion Check

        #region MaxID

        private int maxID_Bon_CodeBarre()
        {
            return db.Bon_CodeBarre.DefaultIfEmpty().Max(r => r == null ? 1 : (r.bc_ID + 1));
        }

        #endregion MaxID

        #region CRUD

        private void Update_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    int art = getIdArticle(lblArticle.Text);
                    int idBon = int.Parse(br.bon_ID.ToString());
                    int refId = int.Parse(br.ref_ID.ToString());
                    int idVL = int.Parse(bonArt.vl_ID.ToString());

                    //Supprimer les Codes barres
                    var list = getIdCodeBarreFromDatabase(refId, idVL, art, idBon);
                    foreach (var x in list)
                    {
                        string type = getLastTypeCodeBarre(x.Value);
                        db.Delete_Bon_CodeBarre(x.Key).FirstOrDefault();
                        var dd = getPositionActuelle(x.Value);
                        MessageBox.Show(dd.pa_Position);
                        //AddOrUpdatePosition(x.Value, type, (int)dd.pa_Numero, (int)dd.pa_Annee, (int)dd.ref_ID, (int)dd.art_ID);
                    }

                    //Regenerer le codeBarre

                    CodeBarreGenerateur(refId, idVL, art, idBon);
                    //var row = gvGrade.FocusedRowHandle;
                    //int id = int.Parse(gvGrade.GetRowCellValue(row, "grd_ID").ToString());
                    //if (data.Update(new Grade() { grd_ID = id, grd_Grade = txtGrade.Text.Trim() }))
                    //{
                    //    transaction.Commit();
                    //    //form.txtStatus.Caption = "Votre code a bien ajouté";
                    //    iTools.sucMsg("Information", "Votre grade a bien modifié");
                    //    newRecord();
                    //    Verify_Buttons(true);
                    //}
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    iTools.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
        }

        private void UpdateBon_Reference()
        {
            try
            {
                int idBonRef = int.Parse(br.br_ID.ToString());
                int idart = getIdArticle(lblArticle.Text);
                int idReff = getIdReference(lblReference.Text);
                int idbon = int.Parse(br.bon_ID.ToString());
                decimal qtee = decimal.Parse(txtQte.Text);
                int bsa = int.Parse(br.bs_A_ID.ToString());
                bool state = Convert.ToBoolean(br.br_Status_Gravage);

                int rs = (int)db.Update_Bon_reference(idBonRef, "S", idart, idReff, idbon, qtee, bsa, null, null, state).FirstOrDefault();
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

        private void LoadCodBarre_Reference()
        {
            try
            {
                int id = int.Parse(bonArt.vl_ID.ToString());
                var data = from t in db.Bon_CodeBarre where t.art_ID == bonArt.art_ID && t.bc_Type == "S" && t.bon_ID == bonArt.bs_ID && t.vl_ID == id select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
                frm.dgvNSerie.DataSource = LINQResultToDataTable(data);
            }
            catch (Exception)
            {
            }
        }

        private void LoadReference_Article()
        {
            try
            {
                var data = from t in db.Bon_reference where t.art_ID == bonArt.art_ID && t.br_Type == "S" && t.bon_ID == bonArt.bs_ID && t.bs_A_ID == bonArt.bs_A_ID select new { t.br_ID, t.br_Type, t.art_ID, t.Article_Reference.ref_reference, t.bon_ID, t.br_Qte, t.bs_A_ID, t.Article_Reference.ref_est_Gravee };
                frm.dgvReference.DataSource = LINQResultToDataTable(data);
            }
            catch (Exception)
            {
            }
        }

        #endregion CRUD

        #region Codes

        private string getLastTypeCodeBarre(string codeBarre)
        {
            var data = (from n in db.Bon_CodeBarre
                        where n.bc_N_Serie == codeBarre
                        select n).OrderByDescending(t => t.bc_Date).FirstOrDefault();
            return data.bc_Type;
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

        private int getIdReference(string Reference)
        {
            int artid = getIdArticle(lblArticle.Text);
            int AssNo = (from a in db.Article_Reference
                         where a.ref_reference == Reference
                         where a.art_ID == artid
                         select a).Single().ref_ID;
            return AssNo;
        }

        private int getIdArticle(string Article)
        {
            int AssNo = (from a in db.Article_Info
                         where a.art_Designation == Article
                         select a).Single().art_ID;
            return AssNo;
        }

        private void Appliquer()
        {
            if (cmbxAnnee.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxAnnee.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtQte.Text))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQte.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDu.Text))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDu.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtAu.Text))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAu.Focus();
                return;
            }

            int numDu = int.Parse(txtDu.Text);
            int numAu = int.Parse(txtAu.Text);
            if (numDu > numAu)
            {
                MessageBox.Show("Le nombre saisi est inférieur à celui de l'autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int qte = ToInt(decimal.Parse(txtQte.Text));
            int def = int.Parse(txtAu.Text) - int.Parse(txtDu.Text) + 1;
            if (qte != def)
            {
                MessageBox.Show("Votre borne de votre numéro de série et défier la quantité, Veuillez les changer", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Update_Data();
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

        private void CodeBarreGenerateur(int refID, int vlID, int idArticle, int idBon)
        {
            try
            {
                string abreviation = lblAbreviation.Text.Trim().ToUpper();
                string annee = getYear(cmbxAnnee.Text.ToString()).ToString("yy");
                string format;
                int x = 0;
                int debut = int.Parse(txtDu.Text), fin = int.Parse(txtAu.Text), qte = ToInt(decimal.Parse(txtQte.Text));
                for (int i = 0; i < qte; i++)
                {
                    x = debut + i;
                    format = string.Format("{0}{1:00}{2}", abreviation.Trim().ToUpper(), x, annee);
                    //Add CodeBarre to Database
                    int id = maxID_Bon_CodeBarre();
                    Bon_CodeBarre refArt = new Bon_CodeBarre()
                    {
                        bc_ID = id,
                        bc_Date = bonArt.Bon_Sortie.bs_Date,
                        bc_Type = "S",
                        ref_ID = refID,
                        art_ID = idArticle,
                        bon_ID = idBon,
                        bc_N_Serie = format,
                        vl_ID = vlID,
                        bc_Annee = int.Parse(cmbxAnnee.Text.ToString()),
                        bc_Numero = x
                    };
                    int rs = (int)db.Insert_Bon_CodeBarre(id, bonArt.Bon_Sortie.bs_Date, "S", format, x, int.Parse(cmbxAnnee.Text), refID, idArticle, idBon, vlID).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            AddOrUpdatePosition(refArt.bc_N_Serie, "S", (int)refArt.bc_Numero, (int)refArt.bc_Annee, (int)refArt.ref_ID, (int)refArt.art_ID);
                            break;
                    }
                }
                UpdateBon_Reference();
                LoadCodBarre_Reference();
                LoadReference_Article();
                iTools.sucMsg("Information", "Votre numéro de série a regénéré correctement");
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private bool AddOrUpdatePosition(string codeBarre, string positions, int numero, int annee, int ref_ID, int art_ID)
        {
            bool rs = false;
            if (db.Position_Actuelle.Any(f => f.pa_N_Serie == codeBarre))
            {
                //Update
                Position_Actuelle pa = getPositionActuelle(codeBarre);
                int r = (int)db.Update_Position_Actuelle(pa.pa_ID, positions, pa.pa_N_Serie, pa.pa_Numero, pa.pa_Annee, pa.ref_ID, pa.art_ID).FirstOrDefault();
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
                int r = (int)db.Insert_Position_Actuelle(maxID_Position_Actuelle(), positions, codeBarre, numero, annee, ref_ID, art_ID).FirstOrDefault();
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

        #endregion Codes

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

        private void txtAu_Validating(object sender, CancelEventArgs e)
        {
            int numDu = int.Parse(txtDu.Text);
            int numAu = int.Parse(txtAu.Text);

            if (numDu > numAu)
            {
                MessageBox.Show("Le nombre saisi est inférieur à celui de l'autre.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAu.Focus();
                return;
            }
        }

        private void txtDu_Validating(object sender, CancelEventArgs e)
        {
            int numDu = int.Parse(txtDu.Text);
            int numAu = int.Parse(txtAu.Text);

            if (numDu > numAu)
            {
                MessageBox.Show("Le nombre saisi est inférieur à celui de l'autre.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDu.Focus();
                return;
            }
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            Appliquer();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int qte = ToInt(decimal.Parse(txtQte.Text));
            MessageBox.Show(qte.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int art = getIdArticle(lblArticle.Text);
            int idBon = int.Parse(br.bon_ID.ToString());
            int refId = int.Parse(br.ref_ID.ToString());
            int idVL = int.Parse(bonArt.vl_ID.ToString());
            string rs = "";
            var listCB = getCodeBarreFromDatabase(refId, idVL, art, idBon);
            foreach (var item in listCB)
            {
                rs += item + Environment.NewLine;
            }
            MessageBox.Show(rs);
        }
    }
}