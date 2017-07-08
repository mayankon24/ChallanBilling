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
using Billing.Entity;
using Billing.DataLayer;
using Billing.Utility;
using GlobleLibrary;
using System.Data.SqlClient;
using PurchasesChallan;


namespace Billing
{
    public partial class Bill_SubItem : Form
    {
        #region Variavle
        BillItemEL _BillParentItem;
        CompanyEL CompanyEL;
        List<BillItemEL> DeletedlstBillItem = new List<BillItemEL>();
        List<ItemNameEL> LstItemNameEL = null;
        #endregion     

        #region Constructor
        private Bill_SubItem()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);
        }
        public Bill_SubItem(BillItemEL _BillItemEL, CompanyEL _CompanyEL)
            : this()
        {
            this._BillParentItem = _BillItemEL;
            this.CompanyEL = _CompanyEL;

            GridBind();
            bindGridComboBox();
        }

        #endregion
        
        #region Grid operation
        void GridBind()
        {
            BillItemDL _billItemDL = new BillItemDL();
            List<BillItemEL> lstBillItem = _billItemDL.GetBillItemBy_ParentId(_BillParentItem.Bill_Item_Id);
            
            dataGridView1.Rows.Clear();
            try
            {
                foreach (var item in lstBillItem)
                {               
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["Bill_Item_Id"].Value = item.Bill_Item_Id;
                    dataGridView1.Rows[index].Cells["Color"].Value = item.Color;
                    dataGridView1.Rows[index].Cells["Form"].Value = item.Form;
                    dataGridView1.Rows[index].Cells["Rate"].Value = item.Rate;
                    dataGridView1.Rows[index].Cells["Quantity"].Value = item.Quantity;
                    dataGridView1.Rows[index].Cells["Bill_Item_Name"].Value = item.Item_Name;
                    dataGridView1.Rows[index].Cells["ItemName"].Value = item.Item_Id;
                }
            }
            catch
            {
            }
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewButtonCell ButNarration = (DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells["Narration"];
            ButNarration.Value = "Narration";
            //ButNarration.Style.ForeColor = Color.Purple;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    if (dataGridView1.SelectedCells[0].OwningRow.Cells["Bill_Item_Id"].Value == null)
                    {
                        Common.MessageAlert("First Save This Item ");
                        return;
                    }
                    BillItemEL _BillItemEL = new BillItemEL();
                    _BillItemEL.Bill_Item_Id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Bill_Item_Id"].Value);
                    _BillItemEL.Item_Name = dataGridView1.SelectedCells[0].OwningRow.Cells["ItemName"].FormattedValue.ToString();


                    BillItemNarration objBillItemNarration = new BillItemNarration(_BillItemEL);
                    objBillItemNarration.ShowDialog();
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["Bill_Item_Id"].Value != null)
            {
                int BillItemId;
                if (int.TryParse(e.Row.Cells["Bill_Item_Id"].Value.ToString(), out BillItemId))
                {
                    BillItemEL _BillItemEL = new BillItemEL();
                    _BillItemEL.Bill_Item_Id = BillItemId;
                    DeletedlstBillItem.Add(_BillItemEL);
                }
            }
            e.Row.Visible = false;
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = ((DataGridViewComboBoxEditingControl)sender).EditingControlRowIndex;
            ItemNameEL selectedItem = (ItemNameEL)((System.Windows.Forms.ComboBox)(((DataGridViewComboBoxEditingControl)sender))).SelectedItem;

            if (selectedItem != null)
            {
                dataGridView1.Rows[rowIndex].Cells["Rate"].Value = selectedItem.Item_Price.ToString();
            }
            else
            {
                dataGridView1.Rows[rowIndex].Cells["Rate"].Value = "";
            }
        }

        #endregion 
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                BillItemEL _BillItemEL;
                BillItemDL _BillItemDL = new BillItemDL();
                List<BillItemEL> lstBillItem = new List<BillItemEL>();
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        _BillItemEL = new BillItemEL();
                        _BillItemEL.Bill_Id = _BillParentItem.Bill_Id;
                        _BillItemEL.Purchase_Order_Detail_Id = null;
                        _BillItemEL.Form = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Form"].Value);
                        _BillItemEL.Color = Convert.ToInt32(dataGridView1.Rows[i].Cells["Color"].Value);
                        _BillItemEL.Rate = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Rate"].Value);
                        _BillItemEL.Quantity = Convert.ToDouble(dataGridView1.Rows[i].Cells["Quantity"].Value);
                        //_BillItemEL.Item_Name = dataGridView1.Rows[i].Cells["Bill_Item_Name"].Value.ToString();
                        _BillItemEL.Item_Id = Convert.ToInt32( dataGridView1.Rows[i].Cells["ItemName"].Value);
                        _BillItemEL.Parent_Id = _BillParentItem.Bill_Item_Id;

                        if ((dataGridView1.Rows[i].Cells["Bill_Item_Id"].Value != null))
                        {
                            _BillItemEL.Bill_Item_Id = Convert.ToInt32(dataGridView1.Rows[i].Cells["Bill_Item_Id"].Value); ;
                        }
                        else
                        {
                            _BillItemEL.Bill_Item_Id = 0;
                        }
                        lstBillItem.Add(_BillItemEL);
                    }
                }
                catch (Exception)
                {

                }

                SQLHelper _SQLHelper = new SQLHelper();
                SqlTransaction transaction = _SQLHelper.BeginTrans();
                try
                {
                    for (int i = 0; i < lstBillItem.Count; i++)
                    {
                        if (lstBillItem[i].Bill_Item_Id == 0)
                        {
                            _BillItemDL.Insert(transaction, lstBillItem[i]);
                        }
                        else
                        {
                            _BillItemDL.Update(transaction, lstBillItem[i]);
                        }
                    }


                    BillItemNarrationDL _BillItemNarrationDL = new BillItemNarrationDL();
                    List<BillItemNarrationEL> lstBillItemNarrationEL = new List<BillItemNarrationEL>();
                    
                    DeletedlstBillItem.ForEach(r => lstBillItemNarrationEL.AddRange(_BillItemNarrationDL.GetBillItemNarrationBy_BillItemId(r.Bill_Item_Id)));
                    lstBillItemNarrationEL.ForEach(n => _BillItemNarrationDL.Delete(transaction, n));                       
                    DeletedlstBillItem.ForEach(r => _BillItemDL.Delete(transaction, r));

                    transaction.Commit();
                    Common.MessageSave();
                    GridBind();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
        void bindGridComboBox()
        {
            DataGridViewComboBoxColumn ItemName = (DataGridViewComboBoxColumn)dataGridView1.Columns["ItemName"];

            ItemNameDL objItemNameDL = new ItemNameDL();
            LstItemNameEL = objItemNameDL.GetItemPriceList(CompanyEL.Company_id);

            ItemName.DataSource = LstItemNameEL;
            ItemName.DisplayMember = "Item_Name";
            ItemName.ValueMember = "Item_Id";
            //ItemName.HeaderText = "Item Name";

            //Adding combo box column in dataGridView
            //dataGridView1.Columns.Insert(4, ItemName);   
        }
        private void lnkItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ItemName newForm = new ItemName();
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                newForm.Close();
                newForm.Dispose();
                bindGridComboBox();
            }
        
        }

        
    }
}
