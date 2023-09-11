using System;
using System.Windows.Forms;

namespace PL.iForms
{
    public partial class frmCRUD : Form
    {
        #region Virtual

        public virtual void getData()
        {
        }

        public virtual void Add_Data()
        {
            newRecord();
        }

        public virtual void Update_Data()
        {
            newRecord();
        }

        public virtual void Delete_Data()
        {
            newRecord();
        }

        public virtual void Verify_Buttons(bool status)
        {
            if (status)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                newRecord();
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
                newRecord();
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                setData();
            }
        }

        public virtual void setData()
        { }

        public virtual void newRecord()
        {
            getData();
        }

        public virtual void setToolTip(string enteties)
        {
            toolTip1.SetToolTip(btnAjouter, $"Ajouter {enteties}");
            toolTip1.SetToolTip(btnModifier, $"Modifier {enteties}");
            toolTip1.SetToolTip(btnSupprimer, $"Supprimer {enteties}");
        }

        #endregion Virtual

        #region Costracteur

        public frmCRUD()
        {
            InitializeComponent();
            setToolTip("");
            toolTip1.ShowAlways = true;
        }

        #endregion Costracteur

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            Verify_Buttons(new Form(), "");
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
    }
}