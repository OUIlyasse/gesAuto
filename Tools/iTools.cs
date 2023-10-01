using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
using System.Windows.Forms;
using Tools.iUtile;
using Tulpep.NotificationWindow;
using System.Drawing;
using System.IO;

namespace Tools
{
    public class iTools
    {
        #region Variables

        private static NotifyIcon ni = new NotifyIcon();
        private static ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
        private static OperatingSystem os = Environment.OSVersion;
        private static StringBuilder systemInfo = new StringBuilder(string.Empty);
        private static Version ver = os.Version;

        #endregion Variables

        #region PC

        public static string getBuild()
        {
            return ver.Build.ToString();
        }

        public static List<string> getLogicalDrivesInfo()
        {
            List<string> result = new List<string>();
            foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
            {
                try
                {
                    result.Add(DriveInfo1.Name.ToString()); //DriveName
                    result.Add(DriveInfo1.VolumeLabel.ToString()); // VolumeLabel
                    result.Add(DriveInfo1.DriveType.ToString()); //DriveType
                    result.Add(DriveInfo1.DriveFormat.ToString()); //DriveFormat
                    result.Add(DriveInfo1.TotalSize.ToString()); //TotalSize
                    result.Add(DriveInfo1.AvailableFreeSpace.ToString()); //AvailableFreeSpace
                }
                catch { }
            }
            return result;
        }

        public static string getName()
        {
            return Environment.MachineName;
        }

        public static List<string> getOperatingSystemArchitecture()
        {
            List<string> list = new List<string>();
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["OSArchitecture"] != null)
                {
                    list.Add(managementObject["OSArchitecture"].ToString());
                }
            }
            return list;
        }

        public static List<string> getOperatingSystemName()
        {
            List<string> list = new List<string>();
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                {
                    list.Add(managementObject["Caption"].ToString());
                }
            }
            return list;
        }

        public static List<string> getOperatingSystemServicePacke()
        {
            List<string> list = new List<string>();
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["CSDVersion"] != null)
                {
                    list.Add(managementObject["CSDVersion"].ToString());
                }
            }
            return list;
        }

        public static string getOStype()
        {
            string OStype = "";
            if (Environment.Is64BitOperatingSystem) { OStype = "64-Bit"; } else { OStype = "32-Bit"; }
            return OStype;
        }

        public static string getOSVersion()
        {
            return Environment.OSVersion.ToString();
        }

        public static string getProcessorArchitecture()
        {
            return Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString();
        }

        public static string getProcessorCount()
        {
            return Environment.ProcessorCount.ToString();
        }

        public static string getProcessorInfo()
        {
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);
            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                    return processor_name.GetValue("ProcessorNameString").ToString();
                else
                    return string.Empty;
            }
            else
                return string.Empty;
        }

        public static string getProcessorLevel()
        {
            return Environment.GetEnvironmentVariable("PROCESSOR_LEVEL").ToString();
        }

        public static string getProcessorModel()
        {
            return Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER").ToString();
        }

        public static string getRevesrionMajor()
        {
            return ver.MajorRevision.ToString();
        }

        public static string getRevesrionMinor()
        {
            return ver.MinorRevision.ToString();
        }

        public static string getSystemDirectory()
        {
            return Environment.SystemDirectory.ToString();
        }

        public static string getSystemPlatform()
        {
            return os.Platform.ToString();
        }

        public static string getSystemServicePack()
        {
            return os.ServicePack.ToString();
        }

        public static string getSystemVersionString()
        {
            return os.VersionString.ToString();
        }

        public static string getSystemVesrion()
        {
            return os.Version.ToString();
        }

        public static string getUserDomainName()
        {
            return Environment.UserDomainName.ToString();
        }

        public static string getUserName()
        {
            return Environment.UserName.ToString();
        }

        public static string getVersion()
        {
            return Environment.Version.ToString();
        }

        public static string getVesrionMajor()
        {
            return ver.Major.ToString();
        }

        public static string getVesrionMinor()
        {
            return ver.Minor.ToString();
        }

        #endregion PC

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