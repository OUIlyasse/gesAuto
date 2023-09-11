using DAL.DB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmHBonSortie : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_Sortie bon_Sortie;
        private int _originalSelectedIndex;

        #endregion Variables

        #region Codes

        private void LoadUnite()
        {
            cmbxUnite.DisplayMember = "unt_Unite";
            cmbxUnite.ValueMember = "unt_ID";
            cmbxUnite.DataSource = db.Load_Unite_Soutien().ToList();
            cmbxUnite.SelectedValue = -1;
        }

        private void setValue(Bon_Sortie vl)
        {
            txtDesignation.Text = vl.bs_Designation;
            dtDate.Value = (DateTime)vl.bs_Date;
            cmbxUnite.SelectedValue = (int)vl.unt_ID;
            txtReference.Text = vl.bs_Reference;
            txtDescription.Text = vl.bs_Description;
        }

        #endregion Codes

        #region Constracteur

        public frmHBonSortie(Bon_Sortie bon_Sortie)
        {
            InitializeComponent();
            this.bon_Sortie = bon_Sortie;
            LoadUnite();
        }

        #endregion Constracteur

        private void frmHBonSortie_Load(object sender, EventArgs e)
        {
            setValue(bon_Sortie);
        }
    }
}