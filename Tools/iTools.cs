using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tools.iUtile;
using Tulpep.NotificationWindow;

namespace Tools
{
    public class iTools
    {
        #region Variables

        private static NotifyIcon ni = new NotifyIcon();

        #endregion Variables

        #region Text

        public static string UpperCase(string text)
        {
            return text.ToUpper().Trim();
        }

        public static string LowerCase(string text)
        {
            return text.ToLower().Trim();
        }

        public static string DefaultText(string text)
        {
            string rs = string.Empty;
            if (!string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == 0)
                        rs += text[i].ToString().ToUpper();
                    else
                        rs += text[i].ToString().ToLower();
                }
                return rs.Trim();
            }
            else
                rs = string.Empty;

            return rs;
        }

        public static string ValidateText(string text, TypeText type)
        {
            string rs = string.Empty;
            switch (type)
            {
                case TypeText.Defaut:
                    rs = DefaultText(text);
                    break;

                case TypeText.Majuscule:
                    rs = UpperCase(text);
                    break;

                case TypeText.Minuscule:
                    rs = LowerCase(text);
                    break;
            }

            return rs;
        }

        public static void ClearTextBox(Control cnrl)
        {
            foreach (Control item in cnrl.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
                if (item.HasChildren)
                    ClearTextBox(item);
            }
        }

        public static void Clear(Control cnrl)
        {
            foreach (Control item in cnrl.Controls)
            {
                try
                {
                    if (item is TextBox)
                        item.Text = string.Empty;
                    if (item is RichTextBox)
                        item.Text = string.Empty;
                    if (item is ComboBox)
                        item.Text = string.Empty;
                    if (item is RadioButton)
                    {
                        RadioButton _rb = (RadioButton)item;
                        if (_rb.Checked)
                            _rb.Checked = false;
                    }
                    if (item is CheckBox)
                    {
                        CheckBox _ck = (CheckBox)item;
                        if (_ck.Checked)
                            _ck.Checked = false;
                    }
                    if (item is DateTimePicker)
                    {
                        DateTimePicker dt = (DateTimePicker)item;
                        dt.ResetText();
                    }
                    if (item.HasChildren)
                        Clear(item);
                }
                catch (Exception)
                {
                }
            }
        }

        #endregion Text

        #region Message

        public static void sucMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Success;
            popup.BodyColor = Color.FromArgb(255, 255, 255);
            popup.TitleText = titre;
            popup.TitleColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        public static void infoMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Info;
            popup.BodyColor = Color.FromArgb(255, 255, 255);
            popup.TitleText = titre;
            popup.TitleColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        public static void warningMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Warning;
            popup.BodyColor = Color.FromArgb(255, 255, 255);
            popup.TitleText = titre;
            popup.TitleColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        public static void errorMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Erreur;
            popup.BodyColor = Color.FromArgb(255, 255, 255);
            popup.TitleText = titre;
            popup.TitleColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.Black;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        #endregion Message

        #region Image

        public static string GetNameOnly(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public static string GetExtension(string path)
        {
            return Path.GetExtension(path).Substring(1).ToUpper();
        }

        #endregion Image

        #region Properties

        //public static void ReadOnly(Control cnrl)
        //{
        //    foreach (Control childControl in cnrl.Controls)
        //    {
        //        SetProperty(childControl, "ReadOnly", true);

        //        // Recursively set controls in nested containers as read-only
        //        if (childControl.HasChildren)
        //        {
        //            ReadOnly(childControl);
        //        }
        //    }
        //}

        //private static void SetProperty(object obj, string propertyName, object value)
        //{
        //    var property = obj.GetType().GetProperty(propertyName);
        //    if (property != null && property.CanWrite)
        //    {
        //        property.SetValue(obj, value);
        //    }
        //}

        #endregion Properties
    }
}