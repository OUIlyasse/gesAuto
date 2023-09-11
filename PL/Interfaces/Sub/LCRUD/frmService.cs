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
    public partial class frmService : frmLCRUD
    {
        #region Variables

        private ges_AutoEntities db = new ges_AutoEntities();
        private int idService;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MaxID_Service().FirstOrDefault();
        }

        private void setValue(Service f)
        {
            txtService.Text = f.svc_Nom;
            txtDescription.Text = f.svc_description;
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
                if (string.IsNullOrEmpty(txtService.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtService.Focus();
                    return;
                }
                var rs = db.Insert_Service(maxID(), txtService.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le service {txtService.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtService.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le service a bien ajouté");
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
                if (string.IsNullOrEmpty(txtService.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtService.Focus();
                    return;
                }
                var rs = db.Update_Service(idService, txtService.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Le service {txtService.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtService.Focus();
                        break;

                    case 1:
                        iTools.sucMsg("Information", "Le service a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce service {txtService.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Service_Temp(idService);
                    iTools.sucMsg("Information", "Votre service  a bien supprimé");
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
            dgvService.DataSource = db.Select_Service().ToList();
            CountRow(db.Count_Service().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iTools.Clear(this);
            txtService.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un service");
        }

        #endregion Overrides

        #region Constracteur

        public frmService()
        {
            InitializeComponent();
        }

        #endregion Constracteur

        #region Validating

        private void txtService_Validating(object sender, CancelEventArgs e)
        {
            txtService.Text = iTools.ValidateText(txtService.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iTools.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvService.DataSource = db.Search_Service(txtSearch.Text);
            CountRow(dgvService.Rows.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new ges_AutoEntities();
            DataGridViewRow row = dgvService.Rows[e.RowIndex];
            idService = int.Parse(row.Cells[colsvc_ID.Name].Value.ToString());
            Service service = db.Show_Service_By_ID(idService).FirstOrDefault();
            setValue(service);
            Verify_Buttons(false);
        }

        private void dgvService_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}