using System.ComponentModel;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmConfirmation : Form
    {
        public string Output
        { get { return txtOutput.Text; } }

        public frmConfirmation()
        {
            InitializeComponent();
            lblTitre.Text = "Veuillez insérer: Je confirme";
        }

        private void txtOutput_Validating(object sender, CancelEventArgs e)
        {
            if (txtOutput.Text != "Je confirme")
            {
                MessageBox.Show("Votre mot de confirmation est incorrect", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}