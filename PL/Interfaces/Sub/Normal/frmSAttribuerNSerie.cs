using DAL.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmSAttribuerNSerie : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private string art_Name, ref_Name;
        private int qte, idBon, idVL;
        private frmAddSArticle frm;

        #endregion Variables

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

        private int maxID_Bon_CodeBarre()
        {
            return db.Bon_CodeBarre.DefaultIfEmpty().Max(r => r == null ? 1 : (r.bc_ID + 1));
        }

        private DateTime getDateBonSortie()
        {
            DateTime AssNo = (DateTime)(from a in db.Bon_Sortie
                                        where a.bs_ID == idBon
                                        select a).Single().bs_Date;
            return AssNo;
        }

        private int getAnneeCodeBarre(string codeBarre)
        {
            int AssNo = (int)(from a in db.Position_Actuelle
                              where a.pa_N_Serie == codeBarre
                              select a).Single().pa_Annee;
            return AssNo;
        }

        private int getNumeroCodeBarre(string codeBarre)
        {
            int AssNo = (int)(from a in db.Position_Actuelle
                              where a.pa_N_Serie == codeBarre
                              select a).Single().pa_Numero;
            return AssNo;
        }

        private bool Add_CodeBarre(int idRef, int idArt, int idBon, int idVL, string codeBarre)
        {
            bool rs = false;
            try
            {
                Bon_CodeBarre bc = new Bon_CodeBarre()
                {
                    bc_ID = maxID_Bon_CodeBarre(),
                    bc_Date = getDateBonSortie(),
                    bc_Type = "S",
                    bc_N_Serie = codeBarre,
                    ref_ID = idRef,
                    art_ID = idArt,
                    bon_ID = idBon,
                    vl_ID = idVL,
                    bc_Annee = getAnneeCodeBarre(codeBarre),
                    bc_Numero = getNumeroCodeBarre(codeBarre)
                };
                int r = (int)db.Insert_Bon_CodeBarre(maxID_Bon_CodeBarre(), getDateBonSortie(), "S", codeBarre, getNumeroCodeBarre(codeBarre), getAnneeCodeBarre(codeBarre), idRef, idArt, idBon, idVL).FirstOrDefault();
                switch (r)
                {
                    case 0:
                        rs = false;
                        break;

                    case 1:
                        if (AddOrUpdatePosition(codeBarre, "S", (int)bc.bc_Numero, (int)bc.bc_Annee, (int)bc.ref_ID, (int)bc.art_ID))
                            rs = true;
                        else
                            rs = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                rs = false;
                Cursor = Cursors.Default;
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            return rs;
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

        private void LoadCodBarreByRefrence(int idArt, int idRef, int idVL)
        {
            try
            {
                var data = from t in db.Bon_CodeBarre where t.art_ID == idArt && t.bc_Type == "S" && t.bon_ID == idBon && t.vl_ID == idVL && t.ref_ID == idRef select new { t.bc_ID, t.bc_N_Serie, t.ref_ID };
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

        private int ToInt(string number)
        {
            return decimal.ToInt32(decimal.Parse(number));
        }

        private void LoadCodeBarreStock(int ref_ID, int art_ID)
        {
            ckbListNSerieStock.Items.Clear();
            var result = (from t in db.Position_Actuelle
                          where t.pa_Position == "E"
                          where t.ref_ID == ref_ID
                          where t.art_ID == art_ID
                          select t).OrderBy(t => t.pa_Numero).ToList();
            foreach (var item in result)
                ckbListNSerieStock.Items.Add(item.pa_N_Serie, CheckState.Unchecked);
        }

        private void LoadCodeBarreRetour(int ref_ID, int art_ID)
        {
            ckbListNSerieRetour.Items.Clear();
            var result = (from t in db.Position_Actuelle
                          where t.pa_Position == "R"
                          where t.ref_ID == ref_ID
                          where t.art_ID == art_ID
                          select t).OrderBy(t => t.pa_Numero).ToList();
            foreach (var item in result)
                ckbListNSerieRetour.Items.Add(item.pa_N_Serie, CheckState.Unchecked);
        }

        private int getIdArticleByName(string name)
        {
            int AssNo = (from a in db.Article_Info
                         where a.art_Designation == name
                         select a).Single().art_ID;
            return AssNo;
        }

        private int getIdReferenceByName(string name)
        {
            int AssNo = (from a in db.Article_Reference
                         where a.ref_reference == name
                         select a).Single().ref_ID;
            return AssNo;
        }

        #endregion Codes

        private int coutRowIntoDB()
        {
            int count = 0;
            int id = getIdArticleByName(art_Name);
            int idd = getIdReferenceByName(ref_Name);
            var data = from t in db.Bon_CodeBarre
                       where t.art_ID == id
                       where t.bc_Type == "S"
                       where t.bon_ID == idBon
                       where t.vl_ID == idVL
                       where t.ref_ID == idd
                       select t;
            count = data.Count();

            return count;
        }

        private int contRow(CheckedListBox list)
        {
            int count = 0;
            foreach (string item in list.CheckedItems)
            {
                count += 1;
            }
            return count;
        }

        private List<string> getData()
        {
            List<string> data = new List<string>();
            foreach (string item in ckbListNSerieStock.CheckedItems)
                data.Add(item);
            foreach (string item in ckbListNSerieRetour.CheckedItems)
                data.Add(item);
            return data;
        }

        public frmSAttribuerNSerie(string article, string reference, string qteReference, int idBon, int idVL, frmAddSArticle form)
        {
            InitializeComponent();
            art_Name = article;
            ref_Name = reference;
            qte = ToInt(qteReference);
            this.idBon = idBon;
            this.idVL = idVL;
            frm = form;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    int total = contRow(ckbListNSerieRetour) + contRow(ckbListNSerieStock) + coutRowIntoDB();
                    if (total > qte)
                    {
                        MessageBox.Show("la selection est maximale par rapport aux quantités demandées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    bool rs = false;
                    foreach (string item in getData())
                    {
                        if (Add_CodeBarre(getIdReferenceByName(ref_Name), getIdArticleByName(art_Name), idBon, idVL, item))
                            rs = true;
                    }
                    if (rs)
                    {
                        iTools.Clear(this);
                        LoadCodBarreByRefrence(getIdArticleByName(art_Name), getIdReferenceByName(ref_Name), idVL);
                        LoadCodeBarreRetour(getIdReferenceByName(ref_Name), getIdArticleByName(art_Name));
                        LoadCodeBarreStock(getIdReferenceByName(ref_Name), getIdArticleByName(art_Name));
                        //UpdateBon_Reference();
                        iTools.sucMsg("Information", "Votre numéro de série a généré correctement");
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
            Cursor = Cursors.Default;
        }

        private void frmSAttribuerNSerie_Load(object sender, EventArgs e)
        {
            lblArticle.Text = art_Name;
            lblReference.Text = ref_Name;
            LoadCodeBarreRetour(getIdReferenceByName(ref_Name), getIdArticleByName(art_Name));
            LoadCodeBarreStock(getIdReferenceByName(ref_Name), getIdArticleByName(art_Name));
        }
    }
}