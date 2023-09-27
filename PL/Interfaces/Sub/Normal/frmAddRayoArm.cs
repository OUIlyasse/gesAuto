using DAL.DB;
using System.Linq;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAddRayoArm : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Permission

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
            {
                btnRayoAjouter.Enabled = (bool)rs.priv_Ajouter;
                btnArmAjouter.Enabled = (bool)rs.priv_Ajouter;
            }
            else
            {
                btnRayoAjouter.Enabled = false;
                btnArmAjouter.Enabled = false;
            }
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
            {
                btnRayoModifier.Enabled = (bool)rs.priv_Modifier;
                btnArmModifier.Enabled = (bool)rs.priv_Modifier;
            }
            else
            {
                btnRayoModifier.Enabled = false;
                btnArmModifier.Enabled = false;
            }
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
            {
                btnRayoSupprimer.Enabled = (bool)rs.priv_Supprimer;
                btnArmSupprimer.Enabled = (bool)rs.priv_Supprimer;
            }
            else
            {
                btnRayoSupprimer.Enabled = false;
                btnArmSupprimer.Enabled = false;
            }
        }

        #endregion Permission

        public frmAddRayoArm()
        {
            InitializeComponent();
        }

        private void btnRayoAjouter_Click(object sender, System.EventArgs e)
        {
        }
    }
}