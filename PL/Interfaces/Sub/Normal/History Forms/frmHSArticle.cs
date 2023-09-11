using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmHSArticle : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_Sortie_Article bonArt;
        private int idBonSortie;
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

        #endregion DataGridView

        #region Codes

        private void EnableControls()
        {
            cmbxArticle.Enabled = false;
            cmbxVL.Enabled = false;
        }

        private int getIdReference(string Reference)
        {
            return (int)db.Select_Article_Reference_By_Article_Referenece((int)cmbxArticle.SelectedValue, Reference).FirstOrDefault();
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

        private DateTime getDateBonSortie()
        {
            DateTime AssNo = (DateTime)(from a in db.Bon_Sortie
                                        where a.bs_ID == idBonSortie
                                        select a).Single().bs_Date;
            return AssNo;
        }

        private void LoadControls(Bon_Sortie_Article bon)
        {
            cmbxArticle.SelectedValue = bon.art_ID;
            cmbxVL.SelectedValue = bon.vl_ID;
            cmbxUMesure.SelectedValue = bon.unit_M_ID;
            txtQteDemandee.Text = bon.bs_Qte_Demandee.ToString();
            txtQteLivree.Text = bon.bs_Qte_Livree.ToString();
            txtDescription.Text = bon.bs_A_Description;
        }

        #endregion Codes

        #region Check

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

        #endregion Check

        #region Loads

        private void LoadUMesure(int idArt)
        {
            cmbxUMesure.DataSource = db.Select_Unite_Mesure_By_IdArt(idArt).ToList();
            cmbxUMesure.DisplayMember = "unit_M_Abreviation";
            cmbxUMesure.ValueMember = "unit_M_ID";
            cmbxUMesure.SelectedValue = -1;
        }

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

        public frmHSArticle(Bon_Sortie_Article bon)
        {
            InitializeComponent();
            bonArt = bon;
            LoadArticle();
            LoadVL();
            LoadUMesure((int)bon.art_ID);
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

        private void frmAddArticle_Load(object sender, EventArgs e)
        {
            //PopulateDataGridView(dgvReference, dgvNSerie);

            NormalCellStyle();

            LoadControls(bonArt);
            LoadReference_Article();
            EnableControls();
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
        }

        private void dgvNSerie_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvNSerie.CurrentCell = dgvNSerie[e.ColumnIndex, e.RowIndex];
            }
        }

        private void frmAddArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cmbxArticle_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtQteLivree_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal qte = (decimal)db.ResteQteArticle(cmbxVL.Text, cmbxArticle.Text).FirstOrDefault();
            decimal Lqte = Convert.ToDecimal(txtQteLivree.Text.ToString());
            if (qte > Lqte)
            {
                e.Handled = true;
            }
        }
    }
}