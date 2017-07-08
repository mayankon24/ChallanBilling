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

namespace Billing
{
    public partial class BillingQuantityReportByPeriod : Form
    {
        #region Variavle
        CompanyEL companyEL;
            
        List<BillingDelivertDetailEL> lstBillingDelivertDetail = null;
        List<PurchasesOrderDetailEL> lstPurchasesOrderDetail = null;

        #endregion     

        #region Constructor
        private BillingQuantityReportByPeriod()
        {
            InitializeComponent();
            //Common objCommon = new Common();
            //objCommon.SetStyle(this);

            datePickerFromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            datePickerToDate.Value = new DateTime(DateTime.Now.Year, 12, 31);

        }
        public BillingQuantityReportByPeriod(CompanyEL _objCompanyEL)
            : this()
        {
            this.companyEL = _objCompanyEL;
          
            lblCompanyName.Text = companyEL.company_name;
           
            GetGlobalVariableData();
            ItemGridBind();
        }

        #endregion
        
        #region Grid operation
        void ItemGridBind()
        {
            try
            {

                var qurPurchasesOrderGroup = from b in lstBillingDelivertDetail
                                             where b.PURCHASES_ORDER_Date.Date >= datePickerFromDate.Value.Date && b.PURCHASES_ORDER_Date.Date <= datePickerToDate.Value.Date
                                             group b by new { b.Purchases_Order_Id, b.Purchases_Order_No, b.PURCHASES_ORDER_Date } into PurchasesOrderGroup
                                             select new
                                             {
                                                 PurchasesOrderGroup.Key.Purchases_Order_Id,
                                                 PurchasesOrderGroup.Key.Purchases_Order_No,
                                                 PurchasesOrderGroup.Key.PURCHASES_ORDER_Date,
                                                 PurchasesItem_Group = from PurchasesOrder in PurchasesOrderGroup
                                                                         join PurchasesOrderDetail in lstPurchasesOrderDetail on PurchasesOrder.Purchase_Order_Detail_Id equals PurchasesOrderDetail.Purchase_Order_Detail_Id
                                                                         group PurchasesOrder by new { PurchasesOrderDetail.Purchase_Order_Detail_Id, PurchasesOrderDetail.Item_Name, PurchasesOrderDetail.Item_Quantity } into PurchasesItemGroup
                                                                         select new
                                                                         {
                                                                             Purchase_Order_Detail_Id = PurchasesItemGroup.Key.Purchase_Order_Detail_Id,
                                                                             ItemName = PurchasesItemGroup.Key.Item_Name,
                                                                             PurcgasesOrderQuantity = PurchasesItemGroup.Key.Item_Quantity,
                                                                             TotalDeliverQuantity = PurchasesItemGroup.Sum(r => r.Deliver_Quantity),
                                                                             Total_Billing_Quantity = PurchasesItemGroup.Sum(r => r.Challan_Billing_Quantity),
                                                                             DeliveryDetail = PurchasesItemGroup
                                                                         }
                                             };

                grdItem.Rows.Clear();
                foreach (var PurchasesOrder in qurPurchasesOrderGroup)
                {
                    int index2 = grdItem.Rows.Add();
                    grdItem.Rows[index2].Cells["Purchases_Order_No"].Value = PurchasesOrder.Purchases_Order_No;
                    grdItem.Rows[index2].Cells["Purchases_Order_Date"].Value = PurchasesOrder.PURCHASES_ORDER_Date.ToString("dd/MM/yyyy");
                    grdItem.Rows[index2].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(184)))));
                    grdItem.Rows[index2].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    

                    foreach (var Delivery in PurchasesOrder.PurchasesItem_Group)
                    {  
                        int index1 = grdItem.Rows.Add();
                        grdItem.Rows[index1].Cells["Item_Name"].Value = Delivery.ItemName;
                        grdItem.Rows[index1].Cells["Item_Quantity"].Value = Delivery.PurcgasesOrderQuantity;
                        grdItem.Rows[index1].Cells["Total_Deliver_Quantity"].Value = Delivery.TotalDeliverQuantity;
                        grdItem.Rows[index1].Cells["Balance_Quantity"].Value = (Delivery.PurcgasesOrderQuantity - Delivery.TotalDeliverQuantity)*-1;
                        grdItem.Rows[index1].Cells["Total_Billing_Quantity"].Value = Delivery.Total_Billing_Quantity;
                        grdItem.Rows[index1].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(230)))));
                        grdItem.Rows[index1].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                        foreach (var n in Delivery.DeliveryDetail)
                        {
                            int index = grdItem.Rows.Add();
                            grdItem.Rows[index].Cells["Delivery_Detail_Id"].Value = n.Delivery_Detail_Id;
                            grdItem.Rows[index].Cells["Delivery_no"].Value = n.Delivery_No;
                            grdItem.Rows[index].Cells["Delivery_Date"].Value = n.Delivery_Date.ToString("dd/MM/yyyy");
                            grdItem.Rows[index].Cells["Deliver_Quantity"].Value = n.Deliver_Quantity;
                            grdItem.Rows[index].Cells["Billing_Quantity"].Value = n.Challan_Billing_Quantity;
                            grdItem.Rows[index].Cells["Billing_Status"].Value = n.Challan_Billing_Quantity == 0 ? "No":"Yes";
                        }
                    }
                }
            }
            catch
            {
            }
        }      
        
        #endregion        

        #region Private Function
        private void GetGlobalVariableData()
        {           
            BillingDelivertDetailDL objBillingDelivertDetailDL = new BillingDelivertDetailDL();
            lstBillingDelivertDetail = objBillingDelivertDetailDL.GetBillingDelivertDetail(companyEL);

            PurchasesOrderDetailDL objPurchasesOrderDetailDL = new PurchasesOrderDetailDL();
            lstPurchasesOrderDetail = objPurchasesOrderDetailDL.GetPurchasesOrderDetail();
        }
      
        #endregion

        #region Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Common objCommon = new Common();
            objCommon.ExcelExport(grdItem, saveFileDialog1, companyEL.company_name, "Period :-  "+ datePickerFromDate.Value.ToString("dd/MM/yyyy") + "-" + datePickerToDate.Value.ToString("dd/MM/yyyy"));
        }
        private void datePickerFromDate_ValueChanged(object sender, EventArgs e)
        {
            ItemGridBind();
        }
        private void datePickerToDate_ValueChanged(object sender, EventArgs e)
        {
            ItemGridBind();
        }
        
        #endregion        
       
    }
}
