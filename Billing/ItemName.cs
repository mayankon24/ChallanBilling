using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Billing.DataLayer;
using Billing.Entity;
using GlobleLibrary;

namespace PurchasesChallan
{
    public partial class ItemName : Form
    {
        #region Constructor
        public ItemName()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);

            FillComboBoxes();
        }

        #endregion

        #region Event
        /// <summary>
        /// Event fire on change name field dropdown & file datatype according to name field 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbItemName_SelectedValueChanged(object sender, EventArgs e)
        {
            BindControl();
        }
        /// <summary>
        /// Update field name text in database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                Common.MessageAlert("Item Name Name can't be Blank");
            }
            else
            {
                try
                {
                    ItemNameEL objItemNameEL = new ItemNameEL();
                    ItemNameDL objItemNameDL = new ItemNameDL();

                    objItemNameEL.Item_id = (int)cmbItemName.SelectedValue;
                    objItemNameEL.Item_name = txtItemName.Text.Trim();
                    objItemNameEL.HSN_Code = txtHSN.Text.Trim();
                    objItemNameEL.Item_name_description = txtDescription.Text.Trim();
                    objItemNameDL.Update(objItemNameEL);


                    FillComboBoxes();
                    ClearControl();
                    Common.MessageUpdate();
                }
                catch (Exception ex)
                {
                    Common.MessageAlert(ex.Message);
                }
            }
        }
        /// <summary>
        /// add new name fiels 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                Common.MessageAlert("Item Name Name can't be Blank");
            }
            else
            {
                try
                {
                    ItemNameEL objItemNameEL = new ItemNameEL();
                    ItemNameDL objItemNameDL = new ItemNameDL();
                    objItemNameEL.Item_name = txtItemName.Text.Trim();
                    objItemNameEL.HSN_Code = txtHSN.Text.Trim();
                    objItemNameEL.Item_name_description = txtDescription.Text.Trim();
                    objItemNameDL.Insert(objItemNameEL);

                    FillComboBoxes();
                    ClearControl();
                    Common.MessageSave();
                }
                catch (Exception ex)
                {
                    Common.MessageAlert(ex.Message);
                }
            }
        }
        /// <summary>
        /// close this form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Method
        /// <summary>
        /// file field name & datatype dropdown 
        /// </summary>
        private void FillComboBoxes()
        {
            try
            {
                // Filll FieldName drop Down box 
                ItemNameDL objItemNameDL = new ItemNameDL();
                ItemNameEL objItemNameEL = new ItemNameEL();

                objItemNameEL.Item_name = "Add New";
                objItemNameEL.Item_id = 0;
                List<ItemNameEL> lstInputField = new List<ItemNameEL>();
                lstInputField.Add(objItemNameEL);
                lstInputField.AddRange(objItemNameDL.GetItemNameAll());


                cmbItemName.SelectedValueChanged -= cmbItemName_SelectedValueChanged;
                cmbItemName.DataSource = lstInputField;
                cmbItemName.DisplayMember = "Item_Name";
                cmbItemName.ValueMember = "Item_Id";
                cmbItemName.SelectedValueChanged += cmbItemName_SelectedValueChanged;

            }
            catch (Exception ex)
            {
                Common.MessageAlert(ex.Message);
            }
        }
        /// <summary>
        /// set text of field name on bases of selected value in dropdown box 
        /// </summary>
        private void BindControl()
        {
            ItemNameEL InputFieldEL = (ItemNameEL)cmbItemName.SelectedItem;

            if (InputFieldEL.Item_id != 0)
            {
                txtItemName.Text = cmbItemName.Text;
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtDescription.Text = InputFieldEL.Item_name_description;
                txtHSN.Text = InputFieldEL.HSN_Code;

            }
            else
            {
                txtItemName.Text = "";
                txtHSN.Text = "";
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                txtDescription.Text = "";
            }
        }
        private void ClearControl()
        {
            txtItemName.Text = "";
            txtHSN.Text = "";
            txtDescription.Text = "";
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
        }
        #endregion
    }
}
