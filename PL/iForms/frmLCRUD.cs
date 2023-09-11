using System;
using System.Windows.Forms;

namespace PL.iForms
{
    public partial class frmLCRUD : Form
    {
        #region Virtual

        public virtual void Add_Data()
        {
            getData();
        }

        public virtual void Update_Data()
        {
            getData();
        }

        public virtual void Delete_Data()
        {
            getData();
        }

        public virtual void Verify_Buttons(bool status)
        {
            if (status)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }

        public virtual void Verify_Buttons(Form f, string txt)
        {
            if (f.Text == txt)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
            getData();
        }

        public virtual void getData()
        {
        }

        public virtual void newRecord()
        {
            Verify_Buttons(true);
            getData();
        }

        public virtual void setToolTip(string enteties)
        {
            toolTip1.SetToolTip(btnAjouter, $"Ajouter {enteties}");
            toolTip1.SetToolTip(btnModifier, $"Modifier {enteties}");
            toolTip1.SetToolTip(btnSupprimer, $"Supprimer {enteties}");
        }

        #endregion Virtual

        #region Constracteur

        public frmLCRUD()
        {
            InitializeComponent();
            setToolTip("");
            toolTip1.ShowAlways = true;
        }

        #endregion Constracteur

        private void frmLCRUD_Load(object sender, EventArgs e)
        {
            newRecord();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void frmLCRUD_Activated(object sender, EventArgs e)
        {
            getData();
        }
    }
}