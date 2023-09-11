using DAL.DB;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmHBonRetour : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_Retour bon_Retour;

        #endregion Variables

        #region Codes

        private void LoadUnite()
        {
            cmbxUnite.DisplayMember = "unt_Unite";
            cmbxUnite.ValueMember = "unt_ID";
            cmbxUnite.DataSource = db.Select_Unite_Soutien().ToList();
            cmbxUnite.SelectedValue = -1;
        }

        private void setValue(Bon_Retour vl)
        {
            txtDesignation.Text = vl.bt_Designation;
            dtDate.Value = (DateTime)vl.bt_Date;
            cmbxUnite.SelectedValue = (int)vl.unt_ID;
            txtReference.Text = vl.bt_Reference;
            txtDescription.Text = vl.bt_Description;
        }

        #endregion Codes

        #region Constracteur

        public frmHBonRetour(Bon_Retour bon_Retour)
        {
            InitializeComponent();
            this.bon_Retour = bon_Retour;
            LoadUnite();
        }

        #endregion Constracteur

        private void frmBonEntree_Load(object sender, EventArgs e)
        {
            setValue(bon_Retour);
        }

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = txtReference.Text.Trim().ToUpper();
        }
    }
}