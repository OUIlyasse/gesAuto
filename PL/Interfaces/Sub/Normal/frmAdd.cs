using System.ComponentModel;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAdd : Form
    {
        public string Output
        { get { return txtOutput.Text; } }

        public frmAdd(string titre, string objets)
        {
            InitializeComponent();
            Text = titre;
            lblTitre.Text = $"Veuillez insérer {objets}";
        }

        private void txtOutput_Validating(object sender, CancelEventArgs e)
        {
            txtOutput.Text = txtOutput.Text.ToUpper().Trim();
            if (string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                return;
            }
        }
    }
}