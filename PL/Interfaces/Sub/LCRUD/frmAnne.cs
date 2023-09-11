using DAL.DB;
using PL.iForms;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.LCRUD
{
    public partial class frmAnne : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idAnnee;

        #endregion Variables

        #region Codes

        private DateTime getYear(string s)
        {
            DateTime dt, dt2 = DateTime.Now;

            if (DateTime.TryParseExact(s, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                dt2 = dt;
            }

            return dt2;
        }

        private int maxID()
        {
            return (int)db.MaxID_Annees().FirstOrDefault();
        }

        private void setValue(Annee f)
        {
            dtAnnee.Value = getYear(f.an_Annee);
            txtLNumero.Text = f.an_LastNumero;
        }

        private void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        #endregion Codes

        #region Overrides

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(dtAnnee.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtAnnee.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtLNumero.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLNumero.Focus();
                    return;
                }
                var rs = db.Insert_Annees(maxID(), dtAnnee.Value.ToString("yyyy"), txtLNumero.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'année {dtAnnee.Value.ToString("yyyy")} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtAnnee.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "L'année a bien ajouté");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Add_Data();
        }

        public override void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(dtAnnee.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtAnnee.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtLNumero.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLNumero.Focus();
                    return;
                }
                var rs = db.Update_Annees(idAnnee, dtAnnee.Value.ToString("yyyy"), txtLNumero.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'année {dtAnnee.Value.ToString("yyyy")} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtAnnee.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "L'année a bien modifié");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Update_Data();
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette année {dtAnnee.Value.ToString("yyyy")}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Annees(idAnnee);
                    iTools.sucMsg("Information", "Votre année  a bien supprimé");
                    newRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                base.Delete_Data();
            }
        }

        public override void getData()
        {
            dgvAnnee.DataSource = db.Select_Annees().ToList();
            CountRow(db.Count_Annees().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            dtAnnee.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("une année");
        }

        #endregion Overrides

        #region Constracteur

        public frmAnne()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void txtLNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAnnee.DataSource = db.Search_Annees(txtSearch.Text);
            CountRow(dgvAnnee.Rows.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvAnnee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvAnnee.Rows[e.RowIndex];
            idAnnee = int.Parse(row.Cells[colan_ID.Name].Value.ToString());
            Annee annees = db.Show_Annees_By_ID(idAnnee).FirstOrDefault();
            setValue(annees);
            Verify_Buttons(false);
        }

        private void dgvAnnee_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}