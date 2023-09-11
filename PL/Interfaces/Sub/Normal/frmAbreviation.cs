using System.Collections.Generic;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmAbreviation : Form
    {
        public frmAbreviation(string abreviation, List<string> data)
        {
            InitializeComponent();
            lblAbreviation.Text = $"Abreviation : {abreviation}";
            lbArticles.DataSource = data;
        }
    }
}