using DAL.DB;
using PL.iForms;
using PL.Interfaces.Sub.List;
using PL.Interfaces.Sub.Normal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tools;
using Tools.iUtile;

namespace PL.Interfaces.Sub.CRUD
{
    public partial class frmArticleInfo : frmCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private DataTable dt;
        private int idArticle, idReference, idPhoto, idUnitMesure, indexOUMesure, C2, C3, C4;
        private int idService = Properties.Settings.Default.idService;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;
        private Article_Info vl;
        private frmLArticleInfo frmLArticleInfo;
        private string fullPath;
        private const string FormatImages = "Tous les images(images)|*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp;*.png;*.bmp;*.tif;*.tiff|Format d'échange graphique(GIF)|*.gif|Groupe conjoint d'experts en photographie(JPEG)|*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp|Portable Network Graphics(PNG)|*.png|Bitmap(BMP)|*.bmp|Format de fichier image balisé(TIFF)|*.tif;*.tiff|Portable Document Format (pdf)|*.pdf";
        private string pathPhoto = Properties.Settings.Default.pathPhoto;
        private bool isFromDatabase = Properties.Settings.Default.isFromDatabase;
        private string gt;
        private string unite;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Article", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Article", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Article", getID_Lists("Gestion")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private void LoadFamille()
        {
            cmbxFamille.DisplayMember = "fam_Nom";
            cmbxFamille.ValueMember = "fam_ID";
            cmbxFamille.DataSource = db.Select_Famille();
            cmbxFamille.SelectedValue = -1;
        }

        #region Photos

        private void Verify_Buttons_Photo(bool status)
        {
            if (status)
            {
                btnAddPhoto.Enabled = true;
                btnUpdatePhoto.Enabled = false;
                btnDeletePhoto.Enabled = false;
            }
            else
            {
                btnAddPhoto.Enabled = false;
                btnUpdatePhoto.Enabled = true;
                btnDeletePhoto.Enabled = true;
            }
        }

        private void LoadPhoto()
        {
            dgvPhoto.DataSource = db.Select_Article_Photo(idArticle).ToList();
            CountRow(dgvPhoto.Rows.Count, lblPhotoCount);
        }

        private int maxID_Photo()
        {
            return (int)db.MaxID_Article_Photo().FirstOrDefault();
        }

        private void setValue_Photo(Article_Photo f)
        {
            txtNom.Text = f.pho_Nom;
            txtExtension.Text = f.pho_Extension;
            txtPDescription.Text = f.pho_Description;
            gt = pathPhoto + $"{f.pho_ID}_{f.art_ID}_{f.pho_Nom}.{f.pho_Extension}";
            var rs = f.pho_Image;
            if (rs != null)
            {
                byte[] imageData = f.pho_Image;

                Image newImage;
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                picImage.Image = newImage;
            }
            //if (string.IsNullOrEmpty(f.pho_Path))
            //{
            //    string imgPath = $"{pathPhoto}{idPhoto}_{idArticle}_{f.pho_Nom.Trim()}.{f.pho_Extension.Trim()}";
            //    picImage.Image = GetCopyImage(gt);
            //}
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image GetCopyImage(string path)
        {
            try
            {
                using (Image im = Image.FromFile(path))
                {
                    Bitmap bm = new Bitmap(im);
                    return bm;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void newRecord_Photo()
        {
            iTools.Clear(tpPhoto);
            txtNom.Focus();
            LoadPhoto();
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Image = Properties.Resources.Image_100;
            picImage.SizeMode = PictureBoxSizeMode.CenterImage;
            Verify_Buttons_Photo(true);
        }

        private string getPath()
        {
            string rs = string.Empty;
            if (isFromDatabase == true)
                rs = string.Empty;
            else
                rs = Properties.Settings.Default.pathPhoto;
            return rs;
        }

        private void Add_Data_Photo()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
                int rs = 0;
                idPhoto = maxID_Photo();
                if (isFromDatabase == true)
                {
                    byte[] img;
                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    img = ms.ToArray();
                    rs = (int)db.Insert_Article_Photo(maxID_Photo(), getPath(), img, txtNom.Text, txtExtension.Text, idArticle, txtRDescription.Text, "with_image").FirstOrDefault();
                }
                //else
                //{
                //    rs = (int)db.Insert_Article_Photo(maxID_Photo(), getPath(), null, txtNom.Text, txtExtension.Text.ToLower(), idArticle, txtPDescription.Text, "without_image").FirstOrDefault();
                //    string imgNameNew = pathPhoto + $"{idPhoto}_{idArticle}_{txtNom.Text}.{txtExtension.Text.ToLower()}";
                //    File.Copy(fullPath, imgNameNew);
                //}
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'image {txtNom.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReference.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "L'image a bien ajouté");
                        newRecord_Photo();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Update_Data_Photo()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
                int rs = 0;
                if (isFromDatabase == true)
                {
                    byte[] img;
                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    img = ms.ToArray();
                    rs = (int)db.Update_Article_Photo(idPhoto, getPath(), img, txtNom.Text, txtExtension.Text, idArticle, txtRDescription.Text, "with_image").FirstOrDefault();
                }
                //else
                //{
                //    rs = (int)db.Insert_Article_Photo(maxID_Photo(), getPath(), null, txtNom.Text, txtExtension.Text.ToLower(), idArticle, txtPDescription.Text, "without_image").FirstOrDefault();
                //    string imgNameNew = pathPhoto + $"{idPhoto}_{idArticle}_{txtNom.Text}.{txtExtension.Text.ToLower()}";
                //    if (string.IsNullOrEmpty(fullPath))
                //    {
                //        if (!File.Exists(imgNameNew))
                //        {
                //            File.Copy(gt, imgNameNew);
                //            File.Delete(gt);
                //        }
                //    }
                //    else
                //    {
                //        File.Copy(fullPath, imgNameNew);
                //    }
                //}
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'image {txtNom.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReference.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "L'image a bien modifié");
                        newRecord_Photo();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Delete_Data_Photo()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette image {txtNom.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Article_Photo_Temp(idPhoto);
                    iTools.sucMsg("Information", "Votre image  a bien supprimé");
                    newRecord_Photo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Photos

        #region References

        private void Verify_Buttons_Reference(bool status)
        {
            if (status)
            {
                btnAddReference.Enabled = true;
                btnUpdateReference.Enabled = false;
                btnDeleteReference.Enabled = false;
            }
            else
            {
                btnAddReference.Enabled = false;
                btnUpdateReference.Enabled = true;
                btnDeleteReference.Enabled = true;
            }
        }

        private void LoadReference()
        {
            dgvReference.DataSource = db.Select_Article_Reference(idArticle).ToList();
            CountRow(dgvReference.Rows.Count, lblRefCount);
        }

        private int maxID_Reference()
        {
            return (int)db.MaxID_Article_Reference().FirstOrDefault();
        }

        private void setValue_Reference(Article_Reference f)
        {
            txtReference.Text = f.ref_reference;
            if (f.ref_est_Gravee == true)
                ckbStatutGravage.Checked = true;
            else
                ckbStatutGravage.Checked = false;
            txtRDescription.Text = f.ref_Description;
        }

        private void newRecord_Reference()
        {
            iTools.Clear(tpReference);
            txtReference.Focus();
            LoadReference();
            Verify_Buttons_Reference(true);
        }

        private bool statutGravage()
        {
            bool rs = false;
            if (ckbStatutGravage.Checked == true)
                rs = true;
            else
                rs = false;

            return rs;
        }

        private void Add_Data_Reference()
        {
            try
            {
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                var rs = db.Insert_Article_Reference(maxID_Reference(), idArticle, txtReference.Text, statutGravage(), txtRDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"La référence {txtReference.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReference.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "La référence a bien ajouté");
                        newRecord_Reference();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Update_Data_Reference()
        {
            try
            {
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                var rs = db.Update_Article_Reference(idReference, idArticle, txtReference.Text, statutGravage(), txtRDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"La référence {txtReference.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReference.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "La référence a bien modifié");
                        newRecord_Reference();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Delete_Data_Reference()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette référence {txtReference.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Article_Reference_Temp(idReference);
                    iTools.sucMsg("Information", "Votre référence  a bien supprimé");
                    newRecord_Reference();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion References

        #region Article Info

        private int maxID_Article()
        {
            return (int)db.MaxID_Article_Info().FirstOrDefault();
        }

        private void activeControls(bool status)
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                if (page.Name != tpInformation.Name)
                {
                    foreach (var item in page.Controls)
                        ((Control)item).Enabled = status;
                }
                txtExtension.Enabled = false;
            }
        }

        private void setValue_Article(Article_Info vl)
        {
            idArticle = vl.art_ID;
            txtArticle.Text = vl.art_Designation;
            txtAbreviation.Text = vl.art_Abreviation;
            cmbxFamille.SelectedValue = vl.fam_ID;
            txtDescription.Text = vl.art_Description;
        }

        private void InitializeControls()
        {
            btnShowAbrevation.Visible = false;
        }

        private List<string> ShowArticleByAbrevation(string abrev)
        {
            List<string> list = new List<string>();
            var rs = db.Select_Article_Info_Name_By_Abrevation(abrev).ToList();
            foreach (var item in rs)
                list.Add(item);
            return list;
        }

        private void CountRow(int? count, Label label)
        {
            label.Text = $"Ligne: {count}";
        }

        #endregion Article Info

        #region Unite de Mesure

        private void Init_DataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("unit_M_ID", typeof(int));
            dt.Columns.Add("art_ID", typeof(int));
            dt.Columns.Add("unit_M_Nom", typeof(string));
            dt.Columns.Add("unit_M_Abreviation", typeof(string));
            dt.Columns.Add("unit_M_Coefficient", typeof(decimal));
            dt.Columns.Add("unit_M_isDefault", typeof(bool));
            dt.Columns.Add("unit_M_Min", typeof(decimal));
            dt.Columns.Add("unit_M_Max", typeof(decimal));
            dt.Columns.Add("unit_M_Status", typeof(bool));
        }

        private int maxID_UMesure()
        {
            return (int)db.MaxID_Unite_Mesure().FirstOrDefault();
        }

        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {
                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                               == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                           (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void setValue_UMesure()
        {
            //try
            //{
            //dgvUMesure.DataSource = null;
            dt.Rows.Clear();
            var rs = db.Select_Unite_Mesure(idArticle).ToList();
            //Init_DataTable();
            foreach (var item in rs)
                dt.Rows.Add(item.unit_M_ID, item.art_ID, item.unit_M_Nom, item.unit_M_Abreviation, item.unit_M_Coefficient, item.unit_M_isDefault, item.unit_M_Min, item.unit_M_Max, item.unit_M_Status);
            dgvUMesure.DataSource = dt;
            //dgvUMesure.DataSource = rs;
            //}
            //catch (Exception)
            //{
            //}
        }

        private void Insert_Update_UMesure(int index, int unit_M_ID, int art_ID, string unit_M_Nom, string unit_M_Abreviation, decimal unit_M_Coefficient, bool unit_M_isDefault, decimal unit_M_Min, decimal unit_M_Max)
        {
            //try
            //{
            if (string.IsNullOrEmpty(unit_M_Nom))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvUMesure.CurrentCell = dgvUMesure.Rows[index].Cells[colunit_M_Nom.Name];
                return;
            }
            if (string.IsNullOrEmpty(unit_M_Abreviation))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvUMesure.CurrentCell = dgvUMesure.Rows[index].Cells[colunit_M_Abreviation.Name];
                return;
            }
            var rs = db.Upsert_Unite_Mesure(unit_M_ID, art_ID, unit_M_Nom, unit_M_Abreviation, unit_M_Coefficient, unit_M_isDefault, unit_M_Min, unit_M_Max).FirstOrDefault();
            switch (rs)
            {
                case 0:
                    setValue_UMesure();
                    break;

                case 1:
                    setValue_UMesure();
                    break;
            }
            //}

            //catch (Exception ex)
            //{
            //    iTools.errorMsg("Erreur", ex.Message);
            //    //form.txtStatus.Caption = ex.Message;
            //}
        }

        private void Update_UMesure(int unit_M_ID, int art_ID, string unit_M_Nom, string unit_M_Abreviation, decimal unit_M_Coefficient, bool unit_M_isDefault, decimal unit_M_Min, decimal unit_M_Max)
        {
            //try
            //{
            var rs = db.Update_Unite_Mesure(unit_M_ID, art_ID, unit_M_Nom, unit_M_Abreviation, unit_M_Coefficient, unit_M_isDefault, unit_M_Min, unit_M_Max).FirstOrDefault();
            switch (rs)
            {
                case 0:
                    //setValue_UMesure();
                    break;

                case 1:
                    iTools.sucMsg("Information", "Cet unité de mesure a bien modifié");
                    //setValue_UMesure();
                    break;
            }
            //}
            //catch (Exception ex)
            //{
            //    iTools.errorMsg("Erreur", ex.Message);
            //    //form.txtStatus.Caption = ex.Message;
            //}
        }

        private void Insert_UMesure(int unit_M_ID, int art_ID, string unit_M_Nom, string unit_M_Abreviation, decimal unit_M_Coefficient, bool unit_M_isDefault, decimal unit_M_Min, decimal unit_M_Max)
        {
            //try
            //{
            var rs = db.Insert_Unite_Mesure(unit_M_ID, art_ID, unit_M_Nom, unit_M_Abreviation, unit_M_Coefficient, unit_M_isDefault, unit_M_Min, unit_M_Max).FirstOrDefault();
            switch (rs)
            {
                case 0:
                    setValue_UMesure();
                    break;

                case 1:
                    iTools.sucMsg("Information", "Cet unité de mesure a bien ajouté");
                    setValue_UMesure();
                    break;
            }
            //}
            //catch (Exception ex)
            //{
            //    iTools.errorMsg("Erreur", ex.Message);
            //    //form.txtStatus.Caption = ex.Message;
            //}
        }

        private void Delete_Data_UMesure(string unite, int id)
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette unité de mesure {unite}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Unite_Mesure(id);
                    iTools.sucMsg("Information", "Votre unité de mesure  a bien supprimé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Unite de Mesure

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            //iTools.Clear(this);
            Text = "Ajouter un article";
            tabControl1.SelectedTab = tpInformation;
            txtArticle.Focus();
            base.newRecord();
        }

        public override void getData()
        {
            frmLArticleInfo.getData();
            base.getData();
        }

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtArticle.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtArticle.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAbreviation.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAbreviation.Focus();
                    return;
                }
                if (cmbxFamille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxFamille.Focus();
                    return;
                }
                idArticle = maxID_Article();
                var rs = db.Insert_Article_Info(idArticle, txtArticle.Text, txtAbreviation.Text, txtDescription.Text, idService, (int)cmbxFamille.SelectedValue).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Cet article {txtArticle.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtArticle.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Cet article a bien ajouté");
                        activeControls(true);
                        Verify_Buttons(true);
                        Verify_Buttons_Reference(true);
                        Verify_Buttons_Photo(true);
                        Text = "Modifier un article";
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
                if (string.IsNullOrEmpty(txtArticle.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtArticle.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAbreviation.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAbreviation.Focus();
                    return;
                }
                if (cmbxFamille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxFamille.Focus();
                    return;
                }
                var rs = db.Update_Article_Info(idArticle, txtArticle.Text, txtAbreviation.Text, txtDescription.Text, idService, (int)cmbxFamille.SelectedValue).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Cet article {txtArticle.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtArticle.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Cet article a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cet article {txtArticle.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    //delete reference

                    //delete image

                    //delete unite mesure

                    //delete article
                    db.Delete_Article_Info_Temp(idArticle);
                    iTools.sucMsg("Information", "Votre fournisseur  a bien supprimé");
                    base.Delete_Data();
                    Verify_Buttons(true);
                    activeControls(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void setData()
        {
            setValue_Article(vl);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un article");
        }

        #endregion Overrides

        #region New

        public frmArticleInfo(frmLArticleInfo frmLArticleInfo)
        {
            InitializeComponent();
            LoadFamille();
            this.frmLArticleInfo = frmLArticleInfo;
        }

        public frmArticleInfo(frmLArticleInfo frmLArticleInfo, Article_Info vl) : this(frmLArticleInfo)
        {
            this.vl = vl;
        }

        #endregion New

        #region Validating

        private void txtAbreviation_Validating(object sender, CancelEventArgs e)
        {
            txtAbreviation.Text = iTools.ValidateText(txtAbreviation.Text, TypeText.Majuscule);
            if (db.Article_Info.Any(f => f.art_Abreviation.Equals(txtAbreviation.Text.Trim().ToUpper())))
                btnShowAbrevation.Visible = true;
            else
                btnShowAbrevation.Visible = false;
        }

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = iTools.ValidateText(txtReference.Text, TypeText.Majuscule);
        }

        private void txtRDescription_Validating(object sender, CancelEventArgs e)
        {
            txtRDescription.Text = iTools.ValidateText(txtRDescription.Text, TypeText.Defaut);
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            txtNom.Text = iTools.ValidateText(txtNom.Text, TypeText.Defaut);
        }

        private void txtPDescription_Validating(object sender, CancelEventArgs e)
        {
            txtPDescription.Text = iTools.ValidateText(txtPDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        private void frmArticleInfo_Load(object sender, EventArgs e)
        {
            Init_DataTable();
            if (Text.Equals("Ajouter un article"))
            {
                InitializeControls();
                activeControls(false);
                Refresh_Button_Ajouter();
            }
            else
            {
                btnShowAbrevation.Visible = false;
                activeControls(true);
                newRecord_Reference();
                LoadReference();
                setValue_UMesure();
                newRecord_Photo();
                Refresh_Button_Modifier();
                Refresh_Button_Supprimer();
            }
        }

        private void btnShowAbrevation_Click(object sender, EventArgs e)
        {
            using (frmAbreviation frm = new frmAbreviation(txtAbreviation.Text.Trim(), ShowArticleByAbrevation(txtAbreviation.Text.Trim())))
            {
                frm.ShowDialog();
            }
        }

        private void btnNewReference_Click(object sender, EventArgs e)
        {
            newRecord_Reference();
            Verify_Buttons_Reference(true);
        }

        private void dgvReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvReference.Rows[e.RowIndex];
            idReference = int.Parse(row.Cells[colref_ID.Name].Value.ToString());
            Article_Reference reference = db.Show_Article_Reference(idReference).FirstOrDefault();
            setValue_Reference(reference);
            Verify_Buttons_Reference(false);
        }

        private void txtRefSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReference.DataSource = db.Search_Article_Reference(txtRefSearch.Text, idArticle);
            CountRow(dgvReference.Rows.Count, lblRefCount);
        }

        private void btnOpenPhoto_Click(object sender, EventArgs e)
        {
            using (ofdPhotos)
            {
                ofdPhotos.FileName = string.Empty;
                ofdPhotos.Filter = FormatImages;
                if (ofdPhotos.ShowDialog() == DialogResult.OK)
                {
                    fullPath = ofdPhotos.FileName;
                    txtNom.Text = iTools.GetNameOnly(ofdPhotos.FileName);
                    txtExtension.Text = iTools.GetExtension(ofdPhotos.FileName);
                    picImage.Image = (Bitmap)Bitmap.FromFile(ofdPhotos.FileName);
                    picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void dgvPhoto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvPhoto.Rows[e.RowIndex];
            idPhoto = int.Parse(row.Cells[colpho_ID.Name].Value.ToString());
            Article_Photo photo = db.Show_Article_Photo(idPhoto).FirstOrDefault();
            setValue_Photo(photo);
            Verify_Buttons_Photo(false);
        }

        private void btnNewPhoto_Click(object sender, EventArgs e)
        {
            newRecord_Photo();
        }

        private void dgvUMesure_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dgvUMesure.CurrentCell.ColumnIndex == dgvUMesure.Columns[colunit_M_Coefficient.Name].Index ||
                dgvUMesure.CurrentCell.ColumnIndex == dgvUMesure.Columns[colunit_M_Min.Name].Index ||
                dgvUMesure.CurrentCell.ColumnIndex == dgvUMesure.Columns[colunit_M_Max.Name].Index) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dgvUMesure_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgvUMesure.Rows[e.RowIndex];
            //if (dgvUMesure.CurrentCell != null && !dgvUMesure.CurrentCell.IsInEditMode)
            //{
            if (!row.IsNewRow)
            {
                int unit_M_ID, art_ID;
                string unit_M_Nom, unit_M_Abreviation;
                decimal unit_M_Coefficient, unit_M_Min, unit_M_Max;
                bool unit_M_isDefault;
                if (string.IsNullOrWhiteSpace(Convert.ToString(row.Cells[colunit_M_Nom.Name].Value)) || string.IsNullOrWhiteSpace(Convert.ToString(row.Cells[colunit_M_Abreviation.Name].Value)))
                {
                    e.Cancel = true;
                    MessageBox.Show("Veuillez remplir toutes les colonnes avant d'insérer.");
                    return;
                }
                //unit_M_ID
                if (row.Cells[colunit_M_ID.Name].Value == null || row.Cells[colunit_M_ID.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_ID.Name].Value.ToString()))
                    unit_M_ID = maxID_UMesure();
                else
                    unit_M_ID = Convert.ToInt32(row.Cells[colunit_M_ID.Name].Value);
                //art_ID
                if (row.Cells[colart_ID.Name].Value == null || row.Cells[colart_ID.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colart_ID.Name].Value.ToString()))
                    art_ID = idArticle;
                else
                    art_ID = (int)row.Cells[colart_ID.Name].Value;
                //unit_M_Nom
                if (row.Cells[colunit_M_Nom.Name].Value == null || row.Cells[colunit_M_Nom.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_Nom.Name].Value.ToString()))
                    unit_M_Nom = string.Empty;
                else
                    unit_M_Nom = (string)row.Cells[colunit_M_Nom.Name].Value;
                //unit_M_Abreviation
                if (row.Cells[colunit_M_Abreviation.Name].Value == null || row.Cells[colunit_M_Abreviation.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_Abreviation.Name].Value.ToString()))
                    unit_M_Abreviation = string.Empty;
                else
                    unit_M_Abreviation = (string)row.Cells[colunit_M_Abreviation.Name].Value;
                //unit_M_Coefficient
                if (row.Cells[colunit_M_Coefficient.Name].Value == null || row.Cells[colunit_M_Coefficient.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_Coefficient.Name].Value.ToString()))
                    unit_M_Coefficient = 0;
                else
                    unit_M_Coefficient = Convert.ToDecimal(row.Cells[colunit_M_Coefficient.Name].Value);
                //unit_M_isDefault
                if (row.Cells[colunit_M_isDefault.Name].Value == null || row.Cells[colunit_M_isDefault.Name].Value == DBNull.Value || (bool)row.Cells[colunit_M_isDefault.Name].Value == false)
                    unit_M_isDefault = false;
                else
                    unit_M_isDefault = true;
                //unit_M_Min
                if (row.Cells[colunit_M_Min.Name].Value == null || row.Cells[colunit_M_Min.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_Min.Name].Value.ToString()))
                    unit_M_Min = 0;
                else
                    unit_M_Min = Convert.ToDecimal(row.Cells[colunit_M_Min.Name].Value);
                //unit_M_Max
                if (row.Cells[colunit_M_Max.Name].Value == null || row.Cells[colunit_M_Max.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_Max.Name].Value.ToString()))
                    unit_M_Max = 0;
                else
                    unit_M_Max = Convert.ToDecimal(row.Cells[colunit_M_Max.Name].Value);

                if (row.Cells[colunit_M_ID.Name].Value == null || row.Cells[colunit_M_ID.Name].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[colunit_M_ID.Name].Value.ToString()))
                {
                    var rs = db.Insert_Unite_Mesure(unit_M_ID, art_ID, unit_M_Nom, unit_M_Abreviation, unit_M_Coefficient, unit_M_isDefault, unit_M_Min, unit_M_Max).FirstOrDefault();
                    switch (rs)
                    {
                        case 0:
                            setValue_UMesure();
                            break;

                        case 1:
                            //iTools.sucMsg("Information", "Cet unité de mesure a bien ajouté");
                            setValue_UMesure();
                            break;
                    }
                }
                else
                {
                    var rs = db.Update_Unite_Mesure(unit_M_ID, art_ID, unit_M_Nom, unit_M_Abreviation, unit_M_Coefficient, unit_M_isDefault, unit_M_Min, unit_M_Max).FirstOrDefault();
                    switch (rs)
                    {
                        case 0:
                            setValue_UMesure();
                            break;

                        case 1:
                            //iTools.sucMsg("Information", "Cet unité de mesure a bien modifié");
                            setValue_UMesure();
                            break;
                    }
                }
            }
            //}
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            Add_Data_Photo();
        }

        private void btnUpdatePhoto_Click(object sender, EventArgs e)
        {
            Update_Data_Photo();
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            Delete_Data_Photo();
        }

        private void txtPhotoSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPhoto.DataSource = db.Search_Article_Photo(txtPhotoSearch.Text, idArticle);
            CountRow(dgvPhoto.Rows.Count, lblPhotoCount);
        }

        private void btnAddReference_Click(object sender, EventArgs e)
        {
            Add_Data_Reference();
        }

        private void btnUpdateReference_Click(object sender, EventArgs e)
        {
            Update_Data_Reference();
        }

        private void btnDeleteReference_Click(object sender, EventArgs e)
        {
            Delete_Data_Reference();
        }
    }
}