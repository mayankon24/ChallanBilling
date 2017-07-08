using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using GlobleLibrary;
using Billing.DataLayer;
using Billing.Entity;
using Billing.Utility;

namespace Billing
{
    public partial class ItemPrice : Form
    { 
         CompanyEL companyEL = null;

        #region Constructor
        private ItemPrice()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);

           
        }
        public ItemPrice(CompanyEL _CompanyEL)
            : this()
        {
            companyEL = _CompanyEL;
            GridBind();            
        }

        #endregion
               
        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Company_Item_Id", typeof(int));
                dt.Columns.Add("Item_Id", typeof(int));
                dt.Columns.Add("Item_Price", typeof(int));


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    try
                    {
                        int Company_Item_Id = Convert.ToInt32(dataGridView1.Rows[i].Cells["Company_Item_Id"].Value);
                        int Item_Id = Convert.ToInt32(dataGridView1.Rows[i].Cells["Item_Id"].Value);
                        decimal Item_Price = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Item_Price"].Value);
                        dt.Rows.Add(Company_Item_Id, Item_Id, Item_Price);
                    }
                    catch (Exception)
                    {
                        Common.MessageAlert("Please enter valid value for price.");
                    }
                }

                ItemNameDL objItemNameDL = new ItemNameDL();

                if (objItemNameDL.SaveItemPrice(dt, companyEL.Company_id))
                {
                    Common.MessageSave();
                    GridBind();                   
                }
            }
            catch
            {
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            GridBind();
        }      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region DataGrid operation
        void GridBind()
        {
            try
            {
                ItemNameDL objItemNameDL = new ItemNameDL();
                List<ItemNameEL> lstItemPrice = objItemNameDL.GetItemPriceList(companyEL.Company_id);
                
                dataGridView1.Rows.Clear();
                for (int i = 0; i < lstItemPrice.Count; i++)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["Item_Id"].Value = lstItemPrice[i].Item_id.ToString();
                    dataGridView1.Rows[n].Cells["Item_Name"].Value = lstItemPrice[i].Item_name.ToString();
                    dataGridView1.Rows[n].Cells["Company_Item_Id"].Value = lstItemPrice[i].Company_Item_Id;
                    dataGridView1.Rows[n].Cells["Item_Price"].Value = lstItemPrice[i].Item_Price; 
                }

            }
            catch
            {
            }
        }
       
        #endregion               
    }
}