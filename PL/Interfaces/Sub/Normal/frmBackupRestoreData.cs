using DAL.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.Normal
{
    public partial class frmBackupRestoreData : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();

        #endregion Variables

        #region Code

        private bool Backup()
        {
            bool rs = false;
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conStringMaster))
                {
                    con.Open();
                    string file = txtSPath.Text + @"\" + "backup" + "" + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
                    DirectorySecurity sec = Directory.GetAccessControl(txtSPath.Text);

                    SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                    sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                    Directory.SetAccessControl(txtSPath.Text, sec);
                    string sql = $"BACKUP DATABASE ges_Auto TO  DISK = N'{file}' WITH NOFORMAT, NOINIT,  NAME = N'ges_Auto-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        rs = true;
                        //iMessage.sucMsg("Success", "Votre backup");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                rs = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rs;
        }

        private bool Restore()
        {
            bool rs = false;
            try
            {
                string sql = "Alter Database ges_Auto SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database ges_Auto FROM DISK ='" + txtRPath.Text + "' WITH REPLACE;";
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conStringMaster))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        rs = true;
                    }
                }
            }
            catch (Exception ex)
            {
                rs = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rs;
        }

        #endregion Code

        public frmBackupRestoreData()
        {
            InitializeComponent();
        }

        private void btnSBrowse_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
            {
                //folder.SelectedPath = BPath;
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    txtSPath.Text = folder.SelectedPath;
                    Properties.Settings.Default.SPath = folder.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnRBrowse_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.FileName = string.Empty;
                open.Filter = "Backup File |*.bak";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtRPath.Text = open.FileName;
                    Properties.Settings.Default.RPath = open.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSPath.Text.Trim()))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSPath.Focus();
                return;
            }
            btnBackup.Enabled = false;
            if (Backup())
            {
                iTools.sucMsg("Success", "Votre sauvegarde est créée correctement");
            }
            btnBackup.Enabled = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRPath.Text.Trim()))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRPath.Focus();
                return;
            }
            btnRestore.Enabled = false;
            if (Restore())
            {
                iTools.sucMsg("Success", "Votre restauration s'effectue correctement");
            }
            btnRestore.Enabled = true;
        }

        private void frmBackupRestoreData_Load(object sender, EventArgs e)
        {
            txtSPath.Text = Properties.Settings.Default.SPath;
            txtRPath.Text = Properties.Settings.Default.RPath;
            string rs = Properties.Settings.Default.TBackup;
            switch (rs)
            {
                case "Manuel":
                    rdoStop.Checked = true;
                    break;

                case "Auto":
                    rdoAuto.Checked = true;
                    break;
            }
        }

        private void rdoStop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStop.Checked)
                Properties.Settings.Default.TBackup = "Manuel";
            Properties.Settings.Default.Save();
        }

        private void rdoAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAuto.Checked)
                Properties.Settings.Default.TBackup = "Auto";
            Properties.Settings.Default.Save();
        }
    }
}