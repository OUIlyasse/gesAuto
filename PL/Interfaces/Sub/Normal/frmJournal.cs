using DAL.DB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmJournal : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();

        #endregion Variables

        #region Code

        private int getVL(string designation)
        {
            return db.get_Vehicule_By_Marque(designation).FirstOrDefault().vl_ID;
        }

        private int getArticle(string designation)
        {
            return db.get_Article_Info_By_Designation(designation).FirstOrDefault().art_ID;
        }

        private int getReference(string designation)
        {
            return db.get_Article_Reference_By_Designation(designation).FirstOrDefault().ref_ID;
        }

        private void getJournal(string VL, string Art, string Ref)
        {
            dgvOperation.DataSource = db.Journal_All_Operation(getVL(VL), getArticle(Art), getReference(Ref));
        }

        private void restQte(string VL, string Art)
        {
            var rQte = db.ResteQteArticle(VL, Art).FirstOrDefault() > 0 ? db.ResteQteArticle(VL, Art).FirstOrDefault() : 0;
            var um = db.Select_Unite_Mesure_By_Art_isDefault(db.get_Article_Info_By_Designation(Art).FirstOrDefault().art_ID).FirstOrDefault();
            lblReste.Text = $"{rQte} {um.unit_M_Nom}";
            //Info.SetToolTip(lblQteTotal, $"En stock: {rQte} {um}");
        }

        #endregion Code

        public frmJournal(string VL, string Art, string Reff)
        {
            InitializeComponent();
            lblVL.Text = $"{VL}";
            lblArticle.Text = $"{Art}";
            lblReference.Text = $"{Reff}";
            getJournal(VL, Art, Reff);
            restQte(VL, Art);
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
        }

        private void dgvOperation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOperation.Columns[e.ColumnIndex].Name == colIcon.Name)
            {
                string rs = Convert.ToString(dgvOperation.Rows[e.RowIndex].Cells[colOpera.Name].Value);
                switch (rs)
                {
                    case "Entrée":
                        e.Value = Properties.Resources.Plus_32_O;
                        break;

                    case "Sortie":
                        e.Value = Properties.Resources.Moins_32_O;
                        break;

                    case "Retour":
                        e.Value = Properties.Resources.Retour_32_O;
                        break;
                }
            }
        }

        private void txtSearch_TextAlignChanged(object sender, EventArgs e)
        {

        }
    }
}