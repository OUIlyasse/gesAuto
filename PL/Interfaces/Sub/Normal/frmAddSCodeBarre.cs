using DAL.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAddSCodeBarre : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_reference br;
        private frmAddSArticle frm;
        private int idVL, idBon, idBonReference;
        private Bon_Sortie_Article bonArt;

        #endregion Fields

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

        #region Annees

        private DateTime getYear(string s)
        {
            DateTime dt, dt2 = DateTime.Now;

            if (DateTime.TryParseExact(s, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                dt2 = dt;
            }

            return dt2;
        }

        #endregion Annees

        #region Codes

        private string getLastNum()
        {
            int anid = int.Parse(cmbxAnnee.SelectedValue.ToString());
            string AssNo = (from a in db.Annees
                            where a.an_ID == anid
                            select a).Single().an_LastNumero;
            return AssNo;
        }

        private int getNSerie(string annee)
        {
            string AssNo = (from a in db.Annees
                            where a.an_Annee == annee
                            select a).Single().an_LastNumero;
            return (int.Parse(AssNo) + 1);
        }

        private void Add_Data()
        {
            if (cmbxAnnee.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez indiquer l'année", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbxAnnee.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Veuillez indiquer le numero de code barre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
                return;
            }
            int idRef = getIdReference(lblReference.Text);
            Add_CodeBarre(idRef, getIdArticle(lblArticle.Text), idBon, idVL);
        }

        private DateTime getDateBonSortie()
        {
            DateTime AssNo = (DateTime)(from a in db.Bon_Sortie
                                        where a.bs_ID == idBon
                                        select a).Single().bs_Date;
            return AssNo;
        }

        private void Add_CodeBarre(int idRef, int idArt, int idBon, int idVL)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    string format = $"{lblAbreviation.Text}{int.Parse(txtNumero.Text):D2}{lblAbrevAnnee.Text}";
                    if (checkIsExistCodeBarre(format) > 0)
                    {
                        MessageBox.Show("Ce numéro de série a déjà été attribué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNumero.Focus();
                        return;
                    }

                    if (int.Parse(txtNumero.Text) > (int.Parse(getLastNum()) + 1))
                    {
                        MessageBox.Show("Celui-ci dépasse le dernier numéro de série", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNumero.Focus();
                        return;
                    }

                    Bon_CodeBarre bc = new Bon_CodeBarre()
                    {
                        bc_ID = maxID_Bon_CodeBarre(),
                        bc_Date = getDateBonSortie(),
                        bc_Type = "S",
                        bc_N_Serie = format,
                        ref_ID = idRef,
                        art_ID = idArt,
                        bon_ID = idBon,
                        vl_ID = idVL,
                        bc_Annee = int.Parse(cmbxAnnee.Text.ToString()),
                        bc_Numero = int.Parse(txtNumero.Text)
                    };
                    int rs = (int)db.Insert_Bon_CodeBarre(maxID_Bon_CodeBarre(), getDateBonSortie(), "S", format, int.Parse(txtNumero.Text), int.Parse(cmbxAnnee.Text), idRef, idArt, idBon, idVL).FirstOrDefault();
                    switch (rs)
                    {
                        case 1:
                            if (int.Parse(txtNumero.Text) == (int.Parse(getLastNum()) + 1))
                            {
                                Annee annee = db.Get_Annees_By_ID((int)cmbxAnnee.SelectedValue).FirstOrDefault();
                                db.Update_Annees(annee.an_ID, annee.an_Annee, txtNumero.Text).FirstOrDefault();
                            }
                            if (AddOrUpdatePosition(bc.bc_N_Serie, "S", (int)bc.bc_Numero, (int)bc.bc_Annee, (int)bc.ref_ID, (int)bc.art_ID))
                            {
                                transaction.Commit();
                                iTools.Clear(this);
                                txtNumero.Text = string.Empty;
                                LoadCodBarreByRefrence();
                                UpdateBon_Reference();
                                LoadReference_Article();
                                iTools.sucMsg("Information", "Votre numéro de série a généré correctement");
                                txtNumero.Focus();
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

        private void LoadCodBarreByRefrence()
        {
            try
            {
                int id = idVL;
                int idRef = int.Parse(br.ref_ID.ToString());
                var data = from t in db.Bon_CodeBarre where t.art_ID == bonArt.art_ID && t.bc_Type == "S" && t.bon_ID == bonArt.bs_ID && t.vl_ID == id && t.ref_ID == idRef select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
                if (data.Count() > 0)
                    frm.dgvNSerie.DataSource = LINQResultToDataTable(data);
                else
                {
                    var dt = frm.dgvNSerie.DataSource as DataTable;
                    dt.Rows.Clear();
                    frm.dgvNSerie.DataSource = dt;
                }
            }
            catch (Exception)
            {
            }
        }

        private void UpdateBon_Reference()
        {
            //try
            //{
            decimal qtee = ToInt(br.br_Qte.ToString()) + 1;
            Bon_reference bn = new Bon_reference()
            {
                br_ID = br.br_ID,
                br_Type = "S",
                art_ID = br.art_ID,
                ref_ID = br.ref_ID,
                bon_ID = br.bon_ID,
                br_Qte = qtee,
                bs_A_ID = br.bs_A_ID,
                br_Status_Gravage = br.br_Status_Gravage
            };

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

        private void LoadReference_Article()
        {
            var data = from t in db.Bon_reference where t.art_ID == bonArt.art_ID && t.br_Type == "S" && t.bon_ID == bonArt.bs_ID && t.bs_A_ID == bonArt.bs_A_ID select new { t.br_ID, t.br_Type, t.art_ID, t.Article_Reference.ref_reference, t.bon_ID, t.br_Qte, t.bs_A_ID, t.br_Status_Gravage };
            frm.dgvReference.DataSource = LINQResultToDataTable(data);
        }

        private int checkIsExistCodeBarre(string format)
        {
            var data = from f in db.Bon_CodeBarre
                       where f.bc_N_Serie == format
                       select f;
            return data.Count();
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

        private int maxID_Bon_CodeBarre()
        {
            return db.Bon_CodeBarre.DefaultIfEmpty().Max(r => r == null ? 1 : (r.bc_ID + 1));
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

        private void LoadAnnee()
        {
            cmbxAnnee.DisplayMember = "an_Annee";
            cmbxAnnee.ValueMember = "an_ID";
            cmbxAnnee.DataSource = db.Select_Annees();
            cmbxAnnee.SelectedValue = -1;
        }

        #endregion Codes

        #region New

        public frmAddSCodeBarre(string article, string abrevArticle, string reference, int idVL, int idBon, frmAddSArticle f, int index, Bon_Sortie_Article bon_Sortie_Article, Bon_reference bon_Reference)
        {
            InitializeComponent();
            LoadAnnee();
            lblArticle.Text = article;
            lblReference.Text = reference;
            lblAbreviation.Text = abrevArticle;
            this.idVL = idVL;
            this.idBon = idBon;
            frm = f;
            idBonReference = index;
            bonArt = bon_Sortie_Article;
            br = bon_Reference;
        }

        #endregion New

        private void cmbxAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAnnee.SelectedIndex == -1)
            {
                lblAbrevAnnee.Text = string.Empty;
                txtNumero.Text = string.Empty;
            }
            else
            {
                db = new ges_AutoEntities();
                lblAbrevAnnee.Text = getYear(cmbxAnnee.Text).ToString("yy");
                txtNumero.Text = getNSerie(cmbxAnnee.Text).ToString();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }
    }
}