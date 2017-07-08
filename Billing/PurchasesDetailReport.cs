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
    public partial class PurchasesDetailReport : Form
    {
        #region Variavle
        CompanyEL companyEL;
        PurchaseOrderEL objPurchaseOrderEL;
        
        List<BillingDelivertDetailEL> lstBillingDelivertDetail = null;
        List<PurchasesOrderDetailEL> lstPurchasesOrderDetail = null;

        #endregion     

        #region Constructor
        private PurchasesDetailReport()
        {
            InitializeComponent();           
        }
        public PurchasesDetailReport(CompanyEL _objCompanyEL, PurchaseOrderEL _PurchaseOrderEL)
            : this()
        {
            this.companyEL = _objCompanyEL;
            objPurchaseOrderEL = _PurchaseOrderEL;

            lblCompanyName.Text = companyEL.company_name;
            lblPurchasesOrderNo.Text = "Purchases Order No  " + objPurchaseOrderEL.Purchases_Order_No;
            GetGlobalVariableData();
            ItemGridBind();
        }

        #endregion
        
        #region Grid operation
        void ItemGridBind()
        {
            try
            {
                var Query = from b in lstBillingDelivertDetail
                            join pd in lstPurchasesOrderDetail on b.Purchase_Order_Detail_Id equals pd.Purchase_Order_Detail_Id
                            where b.Purchases_Order_Id == objPurchaseOrderEL.Purchases_Order_Id
                            select new
                            {
                                  b.Purchase_Order_Detail_Id
                                 ,b.Delivery_No
                                 ,b.Delivery_Detail_Id
                                 ,b.Deliver_Quantity
                                 ,b.Delivery_Date
                                 ,pd.Item_Name
                                 ,pd.Item_Quantity
                                 ,pd.Item_Rate
                                 ,pd.Total_Amount
                                 ,b.Challan_Billing_Quantity
                            };

                var Query1 = from k in Query.Distinct()              
                             group k by new { k.Purchase_Order_Detail_Id, k.Item_Name,k.Item_Quantity }  into g
                             select new
                             {
                                 ItemName = g.Key.Item_Name
                                 ,Purchase_Order_Detail_Id = g.Key.Purchase_Order_Detail_Id
                                 ,PurcgasesOrderQuantity = g.Key.Item_Quantity
                                 ,TotalDeliverQuantity = g.Sum(r => r.Deliver_Quantity)                                 
                                 ,DeliveryDetail = g
                             };

                foreach (var g in Query1)
                {
                    int index1 = grdItem.Rows.Add();
                    grdItem.Rows[index1].Cells["Item_Name"].Value = g.ItemName;
                    grdItem.Rows[index1].Cells["Item_Quantity"].Value = g.PurcgasesOrderQuantity;
                    grdItem.Rows[index1].Cells["Total_Deliver_Quantity"].Value = g.TotalDeliverQuantity;
                    grdItem.Rows[index1].Cells["Balance_Quantity"].Value = (g.PurcgasesOrderQuantity - g.TotalDeliverQuantity)*-1;

                    foreach (var n in g.DeliveryDetail)
                    {
                        int index = grdItem.Rows.Add();
                        grdItem.Rows[index].Cells["Delivery_Detail_Id"].Value = n.Delivery_Detail_Id;
                        grdItem.Rows[index].Cells["Delivery_no"].Value = n.Delivery_No;
                        grdItem.Rows[index].Cells["Delivery_Date"].Value = n.Delivery_Date.ToString("dd/MM/yyyy");
                        grdItem.Rows[index].Cells["Deliver_Quantity"].Value = n.Deliver_Quantity;
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
            objCommon.ExcelExport(grdItem, saveFileDialog1, companyEL.company_name, "Purchases Order : " + objPurchaseOrderEL.Purchases_Order_No);
        }
        #endregion
       
    }
}
