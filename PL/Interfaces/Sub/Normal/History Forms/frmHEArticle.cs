using DAL.DB;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmHEArticle : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idBonArticle;
        private Bon_Entree_Article bonArt;
        private int svc_ID = Properties.Settings.Default.idService;

        #endregion Variables

        #region Codes

        private void LoadUMesure(int idArt)
        {
            cmbxUMesure.DataSource = db.Select_Unite_Mesure_By_IdArt(idArt).ToList();
            cmbxUMesure.DisplayMember = "unit_M_Abreviation";
            cmbxUMesure.ValueMember = "unit_M_ID";
            cmbxUMesure.SelectedValue = -1;
        }

        public void LoadReference_Article()
        {
            try
            {
                var rs = db.Select_v_Get_E_Bon_Article(idBonArticle).ToList();
                if (rs.Count() > 0)
                    dgvReference.DataSource = rs;
                else
                {
                    if (dgvReference.Rows.Count > 0)
                    {
                        var dt = dgvReference.DataSource as DataTable;
                        dt.Rows.Clear();
                        dgvReference.DataSource = dt;
                    }
                }
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

        private void LoadControls(Bon_Entree_Article bon)
        {
            cmbxArticle.SelectedValue = bon.art_ID;
            cmbxVL.SelectedValue = bon.vl_ID;
            cmbxUMesure.SelectedValue = bon.unit_M_ID;
            txtQteLivree.Text = bon.be_Qte_Livree.ToString();
            txtDescription.Text = bon.be_A_Description;
        }

        #endregion Codes

        #region New

        public frmHEArticle(Bon_Entree_Article bon)
        {
            InitializeComponent();
            bonArt = bon;
            LoadArticle();
            LoadVL();
            LoadUMesure((int)bon.art_ID);
            idBonArticle = bon.be_A_ID;
        }

        #endregion New

        private void frmHEArticle_Load(object sender, EventArgs e)
        {
            LoadControls(bonArt);
            LoadReference_Article();
        }
    }
}