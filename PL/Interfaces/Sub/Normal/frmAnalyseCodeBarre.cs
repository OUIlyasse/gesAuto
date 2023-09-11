using DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAnalyseCodeBarre : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();

        #endregion Variables

        #region Codes

        private void ShowData()
        {
            LoadCodeBarreGravee();
            LoadCodeBarreReserver();
        }

        private void LoadAnnee()
        {
            cmbxAnnee.DisplayMember = "an_Annee";
            cmbxAnnee.ValueMember = "an_ID";
            cmbxAnnee.DataSource = db.Select_Annees().ToList();
            cmbxAnnee.SelectedValue = -1;
        }

        private void LoadCodeBarreReserver()
        {
            Annee annee = db.Show_Annees_By_Annee(cmbxAnnee.Text).FirstOrDefault();
            Dictionary<int, int> data = new Dictionary<int, int>();

            for (int i = 1; i < int.Parse(annee.an_LastNumero); i++)
            {
                if (!Trouve(i, int.Parse(annee.an_Annee)))
                {
                    data.Add(i, int.Parse(annee.an_Annee));
                }
            }

            dgvInutilise.DataSource = data;
        }

        private void LoadCodeBarreGravee()
        {
            try
            {
                dgvGravee.DataSource = db.LoadCodeBarreGravee(int.Parse(cmbxAnnee.Text)).ToList();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private bool Trouve(int numero, int annee)
        {
            bool rs = false;
            int result = (int)db.Count_Bon_CodeBarre(numero, annee).FirstOrDefault();

            if (result > 0)
            {
                rs = true;
            }
            else
            {
                rs = false;
            }
            return rs;
        }

        #endregion Codes

        #region Constrateur

        public frmAnalyseCodeBarre()
        {
            InitializeComponent();
            LoadAnnee();
        }

        #endregion Constrateur

        private void btnAnalyser_Click(object sender, EventArgs e)
        {
            if (cmbxAnnee.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxAnnee.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            ShowData();
            Cursor = Cursors.Default;
        }

        private void cmbxAnnee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}