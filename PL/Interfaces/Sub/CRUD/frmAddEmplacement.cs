using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.List;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Interfaces.Sub.CRUD
{
    public partial class frmAddEmplacement : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idEmplacement;
        private Emplacement emplacement;
        private frmLEmplacement form;
        private int idService = Properties.Settings.Default.idService;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Emplacement des articles", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void Loads()
        {
            LoadMagasin();
            LoadArticle();
            LoadRayonnage();
        }

        private void LoadMagasin()
        {
            cmbxMagasin.DisplayMember = "mags_Magasin";
            cmbxMagasin.ValueMember = "mags_ID";
            cmbxMagasin.DataSource = db.Select_Magasin();
            cmbxMagasin.SelectedValue = -1;
        }

        private void LoadArticle()
        {
            cmbxArticle.DisplayMember = "art_Designation";
            cmbxArticle.ValueMember = "art_ID";
            cmbxArticle.DataSource = db.Select_Article_Info(idService);
            cmbxArticle.SelectedValue = -1;
        }

        private void LoadReference(int idArticle)
        {
            cmbxReference.DisplayMember = "ref_reference";
            cmbxReference.ValueMember = "ref_ID";
            cmbxReference.DataSource = db.Select_Article_Reference(idArticle);
            cmbxReference.SelectedValue = -1;
        }

        private void LoadRayonnage()
        {
            cmbxRayonnage.DisplayMember = "rayo_Nom";
            cmbxRayonnage.ValueMember = "rayo_ID";
            cmbxRayonnage.DataSource = db.Select_Rayonnage();
            cmbxRayonnage.SelectedValue = -1;
        }

        private void LoadArmoire(int idRayonnage)
        {
            cmbxArmoire.DisplayMember = "arm_Nom";
            cmbxArmoire.ValueMember = "arm_ID";
            cmbxArmoire.DataSource = db.Select_Armoire_By_Rayonnage(idRayonnage);
            cmbxArmoire.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MAX_Emplacement().FirstOrDefault();
        }

        private void setValue(Emplacement vl)
        {
            idEmplacement = vl.eplc_ID;
            cmbxMagasin.SelectedValue = (int)vl.mags_ID;
            cmbxArticle.SelectedValue = (int)vl.art_ID;
            cmbxReference.SelectedValue = (int)vl.ref_ID;
            cmbxRayonnage.SelectedValue = (int)vl.rayo_ID;
            cmbxArmoire.SelectedValue = (int)vl.arm_ID;
            txtDescription.Text = vl.eplc_Description;
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iTools.Clear(this);
            Text = "Ajouter un emplacement";
            cmbxMagasin.Focus();

            base.newRecord();
        }

        public override void getData()
        {
            form.getData();
            base.getData();
        }

        public override void Add_Data()
        {
            try
            {
                if (cmbxMagasin.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxMagasin.Focus();
                    return;
                }
                if (cmbxArticle.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxArticle.Focus();
                    return;
                }
                if (cmbxReference.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxReference.Focus();
                    return;
                }
                if (cmbxRayonnage.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRayonnage.Focus();
                    return;
                }
                if (cmbxArmoire.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxArmoire.Focus();
                    return;
                }
                var rs = db.Insert_Emplacement(maxID(), DateTime.Now.Date, (int)cmbxArticle.SelectedValue, (int)cmbxReference.SelectedValue, (int)cmbxArmoire.SelectedValue, (int)cmbxRayonnage.SelectedValue, (int)cmbxMagasin.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Cet emplacement est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxMagasin.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un emplacement");
                        iTools.sucMsg("Information", "Votre emplacement a bien ajouté");
                        base.Add_Data();
                        Verify_Buttons(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public override void Update_Data()
        {
            try
            {
                if (cmbxMagasin.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxMagasin.Focus();
                    return;
                }
                if (cmbxArticle.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxArticle.Focus();
                    return;
                }
                if (cmbxReference.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxReference.Focus();
                    return;
                }
                if (cmbxRayonnage.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRayonnage.Focus();
                    return;
                }
                if (cmbxArmoire.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxArmoire.Focus();
                    return;
                }
                var rs = db.Update_Emplacement(idEmplacement, DateTime.Now.Date, (int)cmbxArticle.SelectedValue, (int)cmbxReference.SelectedValue, (int)cmbxArmoire.SelectedValue, (int)cmbxRayonnage.SelectedValue, (int)cmbxMagasin.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Cet emplacement est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxMagasin.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un emplacement");
                        iTools.sucMsg("Information", "Votre emplacement a bien modifié");
                        base.Update_Data();
                        Verify_Buttons(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cet emplacement", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Emplacement(idEmplacement);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un emplacement");
                    iTools.sucMsg("Information", "Cet emplacement a bien supprimé");
                    base.Delete_Data();
                    Verify_Buttons(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void setData()
        {
            setValue(emplacement);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un emplacement");
        }

        #endregion Overrides

        #region Constracteur

        public frmAddEmplacement(frmLEmplacement form)
        {
            InitializeComponent();
            this.form = form;
            Loads();
        }

        public frmAddEmplacement(frmLEmplacement form, Emplacement emplacement) : this(form)
        {
            InitializeComponent();
            this.emplacement = emplacement;
            Loads();
        }

        #endregion Constracteur

        private void cmbxMagasin_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxArticle.SelectedIndex != -1)
            {
                LoadReference((int)cmbxArticle.SelectedValue);
            }
        }

        private void cmbxRayonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxRayonnage.SelectedIndex != -1)
            {
                LoadArmoire((int)cmbxRayonnage.SelectedValue);
            }
        }

        private void frmAddEmplacement_Load(object sender, EventArgs e)
        {
            if (Text.Equals("Ajouter un emplacement"))
            {
                newRecord();
                if (Properties.Settings.Default.idUtilisateur != 0)
                    Refresh_Button_Ajouter();
            }
            else
            {
                if (Properties.Settings.Default.idUtilisateur != 0)
                {
                    Refresh_Button_Modifier();
                    Refresh_Button_Supprimer();
                }
            }
        }
    }
}