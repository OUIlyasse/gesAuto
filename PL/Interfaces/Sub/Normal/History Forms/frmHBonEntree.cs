using DAL.DB;
using System;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal.History_Forms
{
    public partial class frmHBonEntree : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private Bon_Entree bon_Entree;
        private int _originalSelectedIndex;

        #endregion Variables

        #region Codes

        private void LoadFournisseur()
        {
            cmbxFournisseur.DisplayMember = "frns_Nom";
            cmbxFournisseur.ValueMember = "frns_ID";
            cmbxFournisseur.DataSource = db.Select_Fournisseur();
            cmbxFournisseur.SelectedValue = -1;
        }

        private void LoadRepresentant(int idFournisseur)
        {
            cmbxRepresentant.DisplayMember = "rep_Nom";
            cmbxRepresentant.ValueMember = "rep_ID";
            cmbxRepresentant.DataSource = db.Select_Representant(idFournisseur);
            cmbxRepresentant.SelectedValue = -1;
        }

        private void setValue(Bon_Entree vl)
        {
            txtDesignation.Text = vl.be_Designation;
            dtDate.Value = (DateTime)vl.be_Date;
            cmbxFournisseur.SelectedValue = (int)vl.frns_ID;
            cmbxRepresentant.SelectedValue = (int)vl.rep_ID;
            txtReference.Text = vl.be_Reference;
            txtDescription.Text = vl.be_Description;
        }

        #endregion Codes

        #region Constracteur

        public frmHBonEntree(Bon_Entree bon_Entree)
        {
            InitializeComponent();
            this.bon_Entree = bon_Entree;
            LoadFournisseur();
        }

        #endregion Constracteur

        private void frmHBonEntree_Load(object sender, EventArgs e)
        {
            setValue(bon_Entree);
        }

        private void cmbxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFournisseur.SelectedIndex != -1)
            {
                LoadRepresentant((int)cmbxFournisseur.SelectedValue);
            }
        }
    }
}