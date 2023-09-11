using System;
using System.Windows.Forms;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmPressePapiers : Form
    {
        public frmPressePapiers()
        {
            InitializeComponent();
        }

        private void frmPressePapiers_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            //listBox1.Items.Clear();
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();

                // Split the clipboard text into separate items using newline as the delimiter
                string[] items = clipboardText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Add each item to the ListBox
                listBox1.Items.AddRange(items);
            }
        }
    }
}