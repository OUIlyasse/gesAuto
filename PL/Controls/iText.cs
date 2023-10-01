using System;
using System.Drawing;
using System.Windows.Forms;

namespace PL.Controls
{
    public class iText : TextBox
    {
        #region Variables

        private string placeholderText;
        private bool isPlaceholderActive;

        #endregion Variables

        #region Methodes

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                UpdatePlaceholder();
            }
        }

        #endregion Methodes

        #region New

        public iText()
        {
            isPlaceholderActive = true;
            PlaceholderText = "Recherche"; // Set a default placeholder text
            this.ForeColor = Color.Gray;
        }

        #endregion New

        #region Codes

        private void UpdatePlaceholder()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = PlaceholderText;
                this.ForeColor = Color.Gray;
                isPlaceholderActive = true;
            }
        }

        #endregion Codes

        #region Events

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (isPlaceholderActive)
            {
                this.Text = "";
                this.ForeColor = SystemColors.WindowText;
                isPlaceholderActive = false;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            UpdatePlaceholder();
        }

        #endregion Events
    }
}