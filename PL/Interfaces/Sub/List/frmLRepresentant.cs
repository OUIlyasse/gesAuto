using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.CRUD;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.List
{
    public partial class frmLRepresentant : frmList
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idFournisseur, idRepresentant;

        #endregion Variables

        #region Overrides

        public override void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        public override void getData()
        {
            dgvRepresentant.DataSource = db.Select_Representant(idFournisseur).ToList();
            CountRow(dgvRepresentant.Rows.Count);
        }

        public override void openForm()
        {
            frmRepresentant form = new frmRepresentant(this, idFournisseur);
            form.Text = "Ajouter un representant";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce representant", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Representant_Temp(idRepresentant);
                    iTools.sucMsg("Information", "Votre representant a bien supprimé");
                    getData();
                    Verify_Buttons(true);
                }
                catch (Exception ex)
                {
                    iTools.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
            base.Delete_Data_By_Row();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un representant");
        }

        #endregion Overrides

        #region Constracteur

        public frmLRepresentant(int idFournisseur)
        {
            InitializeComponent();
            this.idFournisseur = idFournisseur;
        }

        #endregion Constracteur

        private void dgvRepresentant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRepresentant.Rows[e.RowIndex];
            idRepresentant = int.Parse(row.Cells[colrep_ID.Name].Value.ToString());
            db = new ges_AutoEntities();
            Representant representant = db.Show_Representant_By_ID(idRepresentant).FirstOrDefault();
            frmRepresentant form = new frmRepresentant(this, idFournisseur, representant);
            form.Text = "Modifier un representant";
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvRepresentant.DataSource = db.Search_Representant(txtSearch.Text, idFournisseur);
            CountRow(dgvRepresentant.Rows.Count);
        }

        private void dgvRepresentant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvRepresentant.Rows[e.RowIndex];
                idRepresentant = int.Parse(row.Cells[colrep_ID.Name].Value.ToString());
                if (idRepresentant > 0)
                    Verify_Buttons(false);
            }
        }

        private void dgvRepresentant_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}