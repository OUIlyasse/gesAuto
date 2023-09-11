using DAL.DB;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmOperation : Form
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

        private void getData(char v, string VL, string Art, string Reff)
        {
            lblVL.Text = $"{VL}";
            lblArticle.Text = $"{Art}";
            lblReference.Text = $"{Reff}";
            switch (v)
            {
                case 'E':
                    lblType.Text = $"Entrées";
                    dgvOperation.DataSource = db.Select_Mouvement_By_Operation("E", getVL(VL), getArticle(Art), getReference(Reff));
                    break;

                case 'R':
                    lblType.Text = $"Retours";
                    dgvOperation.DataSource = db.Select_Mouvement_By_Operation("R", getVL(VL), getArticle(Art), getReference(Reff));
                    break;

                case 'S':
                    lblType.Text = $"Sorties";
                    dgvOperation.DataSource = db.Select_Mouvement_By_Operation("S", getVL(VL), getArticle(Art), getReference(Reff));
                    break;
            }
        }

        #endregion Code

        public frmOperation(char TypeOperation, string VL, string Art, string Reff)
        {
            InitializeComponent();
            getData(TypeOperation, VL, Art, Reff);
        }

        private void dgvOperation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}