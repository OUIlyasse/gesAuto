﻿using DAL.DB;
using PL.iForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Tools;
using Tools.iUtile;

namespace PL.Interfaces.Sub.LCRUD
{
    public partial class frmRayonnage : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idRayonnage, index;
        private int idUtilisateur = Properties.Settings.Default.idUtilisateur;

        #endregion Variables

        #region Codes

        private int getID_Lists(string list)
        {
            return (int)db.Select_Lists_By_Lists(list).FirstOrDefault();
        }

        public void Refresh_Button_Ajouter()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Rayonnage et Armoire", getID_Lists("Utilitaires")).FirstOrDefault();
            if (rs != null)
                btnAjouter.Enabled = (bool)rs.priv_Ajouter;
            else
                btnAjouter.Enabled = false;
        }

        public void Refresh_Button_Modifier()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Rayonnage et Armoire", getID_Lists("Utilitaires")).FirstOrDefault();
            if (rs != null)
                btnModifier.Enabled = (bool)rs.priv_Modifier;
            else
                btnModifier.Enabled = false;
        }

        public void Refresh_Button_Supprimer()
        {
            var rs = db.Select_Priv_Screen(idUtilisateur, "Rayonnage et Armoire", getID_Lists("Utilitaires")).FirstOrDefault();
            if (rs != null)
                btnSupprimer.Enabled = (bool)rs.priv_Supprimer;
            else
                btnSupprimer.Enabled = false;
        }

        private int maxID()
        {
            return (int)db.MAX_Rayonnage().FirstOrDefault();
        }

        private void setValue(Rayonnage f)
        {
            txtRayonnage.Text = f.rayo_Nom;
            txtDescription.Text = f.rayo_Description;
        }

        private void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        #endregion Codes

        #region Overrides

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtRayonnage.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRayonnage.Focus();
                    return;
                }
                var rs = db.Insert_Rayonnage(maxID(), txtRayonnage.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le rayonnage {txtRayonnage.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRayonnage.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Ajouter un rayonnage");
                        iTools.sucMsg("Information", "Le rayonnage a bien ajouté");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Add_Data();
        }

        public override void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtRayonnage.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRayonnage.Focus();
                    return;
                }
                var rs = db.Update_Rayonnage(idRayonnage, txtRayonnage.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le rayonnage {txtRayonnage.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRayonnage.Focus();
                        break;

                    case 1:
                        db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Modifier un rayonnage");
                        iTools.sucMsg("Information", "Le rayonnage a bien modifié");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iTools.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Update_Data();
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce rayonnage {txtRayonnage.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Armoire_By_idRayonnage(idRayonnage);
                    db.Delete_Rayonnage(idRayonnage);
                    db.Insert_Enregistrement(DateTime.Now.Date, DateTime.Now.TimeOfDay, idUtilisateur, iTools.getName(), "Supprimer un rayonnage");
                    iTools.sucMsg("Information", "Votre rayonnage  a bien supprimé");
                    newRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                base.Delete_Data();
            }
        }

        public override void getData()
        {
            dgvRayonnage.DataSource = db.Select_Rayonnage().ToList();
            CountRow(dgvRayonnage.Rows.Count);
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtRayonnage.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un rayonnage");
        }

        #endregion Overrides

        #region Constracteur

        public frmRayonnage()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        private void txtRayonnage_Validating(object sender, CancelEventArgs e)
        {
            txtRayonnage.Text = iTools.ValidateText(txtRayonnage.Text, TypeText.Majuscule);
        }

        private void dgvRayonnage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvRayonnage.Rows[e.RowIndex];
            idRayonnage = int.Parse(row.Cells[colrayo_ID.Name].Value.ToString());
            Rayonnage famille = db.Show_Rayonnage_By_ID(idRayonnage).FirstOrDefault();
            setValue(famille);
            Verify_Buttons(false);
            if (Properties.Settings.Default.idUtilisateur != 0)
            {
                Refresh_Button_Modifier();
                Refresh_Button_Supprimer();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvRayonnage_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menu;
            index = e.RowIndex;
        }

        private void frmRayonnage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.idUtilisateur != 0)
                Refresh_Button_Ajouter();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
                getData();
            else
            {
                dgvRayonnage.DataSource = db.Search_Rayonnage(txtRecherche.Text);
                CountRow(dgvRayonnage.Rows.Count);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
        }

        private void btnArmoire_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRayonnage.Rows[dgvRayonnage.CurrentRow.Index];
            frmArmoire frm = new frmArmoire((int)row.Cells[colrayo_ID.Name].Value);
            frm.ShowDialog();
        }
    }
}