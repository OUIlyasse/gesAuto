using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmHRArticle : Form
    {
        #region Fields

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_Retour_Article bonArt;
        private int idBon;

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

        private DateTime getDateBonRetour()
        {
            return (DateTime)db.get_Bon_Retour(idBon).FirstOrDefault().bt_Date;
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

        private void LoadControls(Bon_Retour_Article bon)
        {
            cmbxArticle.SelectedValue = bon.art_ID;
            cmbxVL.SelectedValue = bon.vl_ID;
            cmbxUMesure.SelectedValue = bon.unit_M_ID;
            txtQteLivree.Text = bon.bt_Qte_Livree.ToString();
            txtDescription.Text = bon.bt_A_Description;
        }

        #endregion Codes

        #region Check

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

        private void LoadUMesure(int idArt)
        {
            cmbxUMesure.DataSource = db.Select_Unite_Mesure_By_IdArt(idArt).ToList();
            cmbxUMesure.DisplayMember = "unit_M_Abreviation";
            cmbxUMesure.ValueMember = "unit_M_ID";
            cmbxUMesure.SelectedValue = -1;
        }

        #endregion Loads

        #region New

        public frmHRArticle(Bon_Retour_Article bon)
        {
            InitializeComponent();
            LoadArticle();
            LoadVL();
            LoadUMesure((int)bon.art_ID);
            bonArt = bon;
            idBon = int.Parse(bon.bt_ID.ToString());
        }

        #endregion New

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.DefaultText(txtDescription.Text);
        }

        private void frmAddArticle_Load(object sender, EventArgs e)
        {
            NormalCellStyle();
            LoadControls(bonArt);
            LoadReference_Article();
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
                LoadCodBarreByRefrence();
            }
            catch (Exception)
            {
            }
        }
    }
}