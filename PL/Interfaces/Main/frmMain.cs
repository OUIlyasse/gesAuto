using DAL.DB;
using PL.Interfaces.Sub.LCRUD;
using PL.Interfaces.Sub.List;
using PL.Interfaces.Sub.Normal;
using PL.Interfaces.Sub.Normal.History_Forms;
using PL.Repport;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Tools;
using System.Linq;

namespace PL.Interfaces.Main
{
    public partial class frmMain : Form
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        public int idUtilisateur;

        #endregion Variables

        #region Codes

        private void closallforms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }

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

        private void SetToolStripItems()
        {
            foreach (ToolStripMenuItem obj in menuStrip1.Items)
            {
                foreach (var item in obj.DropDownItems)
                {
                    if (item.GetType().Equals(typeof(ToolStripMenuItem)))
                    {
                        if (((ToolStripMenuItem)item).Text != "Quitter" && ((ToolStripMenuItem)item).Text != "About")
                            ((ToolStripMenuItem)item).Enabled = false;
                    }
                }
            }
        }

        public void Refresh_Menu()
        {
            foreach (ToolStripMenuItem obj in menuStrip1.Items)
            {
                foreach (var item in obj.DropDownItems)
                {
                    if (item.GetType().Equals(typeof(ToolStripMenuItem)))
                    {
                        if (((ToolStripMenuItem)item).Text != "Quitter" && ((ToolStripMenuItem)item).Text != "About" && ((ToolStripMenuItem)item).Text != "Presse-papiers" && ((ToolStripMenuItem)item).Text != "Journal")
                        {
                            var rs = db.Select_Priv_Screen(idUtilisateur, ((ToolStripMenuItem)item).Text, getID_Lists(((ToolStripMenuItem)obj).Text)).FirstOrDefault().priv_Afficher;
                            if (rs != null)
                                ((ToolStripMenuItem)item).Enabled = (bool)rs;
                            else
                                ((ToolStripMenuItem)item).Enabled = false;
                        }
                    }
                }
            }
        }

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
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
            frmLogin frm = new frmLogin(this);
            frm.ShowDialog();
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

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmR_Stock frm = new frmR_Stock();
            OpenForm(frm);
        }

        private void articleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmR_Article frm = new frmR_Article();
            OpenForm(frm);
        }

        private void personnelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmR_Personnel frm = new frmR_Personnel();
            OpenForm(frm);
        }

        private void véhiculeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmR_Vehicule frm = new frmR_Vehicule();
            OpenForm(frm);
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLArticleInfo frm = new frmLArticleInfo();
            OpenForm(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetToolStripItems();
            lblFullName.Text = string.Empty;
            lblFullName.Visible = false;
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closallforms();
            SetToolStripItems();
            lblFullName.Text = string.Empty;
            lblFullName.Visible = false;
            frmLogin frm = new frmLogin(this);
            frm.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}