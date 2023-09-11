using PL.Interfaces.Sub.LCRUD;
using PL.Interfaces.Sub.List;
using PL.Interfaces.Sub.Normal;
using PL.Interfaces.Sub.Normal.History_Forms;
using System;
using System.Windows.Forms;

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

        #endregion Codes

        public frmMain()
        {
            InitializeComponent();
        }

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
    }
}