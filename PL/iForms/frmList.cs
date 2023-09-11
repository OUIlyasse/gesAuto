using System;
using System.Windows.Forms;

namespace PL.iForms
{
    public partial class frmList : Form
    {
        #region Virtual

        public virtual void openForm()
        {
        }

        public virtual void Delete_Data_By_Row()
        {
            getData();
        }

        public virtual void Verify_Buttons(bool status)
        {
            if (status)
                btnSupprimer.Enabled = false;
            else
                btnSupprimer.Enabled = true;
        }

        public virtual void CountRow(int? count)
        {
        }

        public virtual void getData()
        {
            CountRow(null);
        }

        public virtual void setToolTip(string enteties)
        {
            toolTip1.SetToolTip(btnAjouter, $"Ajouter {enteties}");
            toolTip1.SetToolTip(btnSupprimer, $"Supprimer {enteties}");
        }

        #endregion Virtual

        #region Constracteur

        public frmList()
        {
            InitializeComponent();
            setToolTip("");
            toolTip1.ShowAlways = true;
        }

        #endregion Constracteur

        private void frmList_Activated(object sender, EventArgs e)
        {
            getData();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            Verify_Buttons(true);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Data_By_Row();
        }
    }
}