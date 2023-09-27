using DAL.DB;
using PL.Interfaces.Main;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmStock : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private frmMain frmMain;
        private int rowSelected;

        #endregion Variables

        #region Codes

        private int getIdArticle(string designation)
        {
            return db.get_Article_Info_By_Designation(designation).FirstOrDefault().art_ID;
        }

        private string getUMesure(int idArt)
        {
            return db.Select_Unite_Mesure_By_Art_isDefault(idArt).FirstOrDefault().unit_M_Nom;
        }

        private void getData()
        {
            var rs = db.SommeQte();
            dgvStock.DataSource = rs;
        }

        private void showOperation(char operation)
        {
            string VL = $"{dgvStock.Rows[rowSelected].Cells[colvl_Marque.Name].Value}";
            string Art = $"{dgvStock.Rows[rowSelected].Cells[colart_Designation.Name].Value}";
            string Reff = $"{dgvStock.Rows[rowSelected].Cells[colReference.Name].Value}";

            frmOperation frm;
            switch (operation)
            {
                case 'E':
                    frm = new frmOperation('E', VL, Art, Reff);
                    frm.ShowDialog();
                    break;

                case 'S':
                    frm = new frmOperation('S', VL, Art, Reff);
                    frm.ShowDialog();
                    break;

                case 'R':
                    frm = new frmOperation('R', VL, Art, Reff);
                    frm.ShowDialog();
                    break;
            }
        }

        #endregion Codes

        public frmStock()
        {
            InitializeComponent();
        }

        private void dgvStock_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menuDGV;
            rowSelected = e.RowIndex;
        }

        private void dgvStock_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgvStock.CurrentCell = dgvStock[e.ColumnIndex, e.RowIndex];
                }
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void entreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOperation('E');
        }

        private void sortiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOperation('S');
        }

        private void retoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOperation('R');
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string VL = $"{dgvStock.Rows[rowSelected].Cells[colvl_Marque.Name].Value}";
            string Art = $"{dgvStock.Rows[rowSelected].Cells[colart_Designation.Name].Value}";
            string Reff = $"{dgvStock.Rows[rowSelected].Cells[colReference.Name].Value}";
            frmJournal frm = new frmJournal(VL, Art, Reff);
            frm.ShowDialog();
        }

        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvStock.Columns[colQuantite.Name].Index && e.Value != null)
            {
                DataGridViewCell cell = dgvStock.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int idArt = getIdArticle(dgvStock.Rows[e.RowIndex].Cells[colart_Designation.Name].Value.ToString());
                string format = $"{e.Value} {getUMesure(idArt)}";
                e.Value = format;
            }
        }

        private void btnEtatExplicatif_Click(object sender, EventArgs e)
        {
            string VL = $"{dgvStock.Rows[rowSelected].Cells[colvl_Marque.Name].Value}";
            string Art = $"{dgvStock.Rows[rowSelected].Cells[colart_Designation.Name].Value}";
            string Reff = $"{dgvStock.Rows[rowSelected].Cells[colReference.Name].Value}";
            frmEtatExplicatif frm = new frmEtatExplicatif(VL, Art, Reff);
            frm.ShowDialog();
        }

        private void menuDGV_Opening(object sender, CancelEventArgs e)
        {
            int index = dgvStock.CurrentCell.RowIndex;
            string uMesure = db.Select_Unite_Mesure_By_Art_isDefault(getIdArticle($"{dgvStock.Rows[index].Cells[colart_Designation.Name].Value}")).FirstOrDefault().unit_M_Nom;
            if (uMesure == "Unité")
                btnEtatExplicatif.Enabled = false;
            else
                btnEtatExplicatif.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = db.Search_SommeQte(txtSearch.Text);
            lblCountA.Text = $"Ligne: {dgvStock.Rows.Count}";
        }
    }
}