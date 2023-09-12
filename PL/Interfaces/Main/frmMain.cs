using PL.Interfaces.Sub.LCRUD;
using PL.Interfaces.Sub.List;
using PL.Interfaces.Sub.Normal;
using PL.Interfaces.Sub.Normal.History_Forms;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Main
{
    public partial class frmMain : Form
    {
        #region Codes

        private void OpenForm(Form frm)
        {
            Cursor = Cursors.WaitCursor;
            bool isOpen = false;
            //Text = $"GESTION DE STOCK - [{frm.Text}]";
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == frm.Text)
                {
                    isOpen = true;
                    item.WindowState = FormWindowState.Maximized;
                    item.Activate();
                    break;
                }
            }
            if (isOpen == false)
            {
                frm.MdiParent = this;
                //frm.Dock = DockStyle.Fill;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            Cursor = Cursors.Default;
        }

        private bool Backup()
        {
            bool rs = false;
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conStringMaster))
                {
                    con.Open();
                    string file = Properties.Settings.Default.SPath + @"\" + "backup" + "" + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
                    DirectorySecurity sec = Directory.GetAccessControl(Properties.Settings.Default.SPath);

                    SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                    sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                    Directory.SetAccessControl(Properties.Settings.Default.SPath, sec);
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

        #endregion Codes

        #region Constracteur

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        #region Click

        private void btnMagasin_Click(object sender, EventArgs e)
        {
            frmMagasin frm = new frmMagasin();
            OpenForm(frm);
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFamille frm = new frmFamille();
            OpenForm(frm);
        }

        private void véhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLVehicule frm = new frmLVehicule();
            OpenForm(frm);
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLFournisseur frm = new frmLFournisseur();
            OpenForm(frm);
        }

        private void uniteDeSoutienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniteSoutien frm = new frmUniteSoutien();
            OpenForm(frm);
        }

        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLPersonnel frm = new frmLPersonnel();
            OpenForm(frm);
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade frm = new frmGrade();
            OpenForm(frm);
        }

        private void villeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVille frm = new frmVille();
            OpenForm(frm);
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfil frm = new frmProfil();
            OpenForm(frm);
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmService frm = new frmService();
            OpenForm(frm);
        }

        private void annéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnne frm = new frmAnne();
            OpenForm(frm);
        }

        private void suivieDenregistrementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnalyseCodeBarre frm = new frmAnalyseCodeBarre();
            OpenForm(frm);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLArticleInfo frm = new frmLArticleInfo();
            OpenForm(frm);
        }

        private void receptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLBonEntree frm = new frmLBonEntree();
            OpenForm(frm);
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmH_Entree frm = new frmH_Entree();
            OpenForm(frm);
        }

        private void bonsDeSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLBonSortie frm = new frmLBonSortie();
            OpenForm(frm);
        }

        private void historiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmH_Sortie frm = new frmH_Sortie();
            OpenForm(frm);
        }

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLBonRetour frm = new frmLBonRetour();
            OpenForm(frm);
        }

        private void bonsDeRetourCloturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmH_Retour frm = new frmH_Retour();
            OpenForm(frm);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            OpenForm(frm);
        }

        private void btnPressePapiers_Click(object sender, EventArgs e)
        {
            frmPressePapiers frm = new frmPressePapiers();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void emplacementDesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLEmplacement frm = new frmLEmplacement();
            OpenForm(frm);
        }

        private void rayonnageEtArmoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRayonnage frm = new frmRayonnage();
            OpenForm(frm);
        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermission frm = new frmPermission();
            OpenForm(frm);
        }

        #endregion Click

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();
        }

        private void sauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupRestoreData frm = new frmBackupRestoreData();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure about closing the form?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            //    e.Cancel = true;
            if (Properties.Settings.Default.TBackup == "Auto")
            {
                if (!Backup())
                {
                }
            }
        }
    }
}