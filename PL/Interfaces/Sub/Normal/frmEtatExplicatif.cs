using DAL.DB;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmEtatExplicatif : Form
    {
        #region Variable

        private ges_AutoEntities db = new ges_AutoEntities();
        private string VL, Article, Reference;

        #endregion Variable

        #region Code

        private void getData()
        {
            dgvEtatExplicatif.DataSource = db.Etat_Explicatif_UMesure(VL, Article, Reference).ToList();
        }

        private void setData()
        {
            lblVL.Text = VL;
            lblArticle.Text = Article;
            lblReference.Text = Reference;
        }

        #endregion Code

        #region New

        public frmEtatExplicatif(string VL, string Article, string Reference)
        {
            InitializeComponent();
            this.VL = VL;
            this.Article = Article;
            this.Reference = Reference;
            setData();
            getData();
        }
    }

    #endregion New
}