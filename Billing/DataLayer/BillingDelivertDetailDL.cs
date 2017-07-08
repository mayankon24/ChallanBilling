using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Billing.Entity;
using System.Data;
using System.Data.SqlClient;
using GlobleLibrary;

namespace Billing.DataLayer
{
    class BillingDelivertDetailDL
    {
        public List<BillingDelivertDetailEL> GetBillingDelivertDetail(CompanyEL companyEL)
        {
            BillingDelivertDetailEL objBillingDelivertDetailEL;
            List<BillingDelivertDetailEL> lstBillingDelivertDetail = new List<BillingDelivertDetailEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("B_GetBilling_DeliverDeatil"
                                                                    , objSQLHelper.SqlParam("@Company_id", companyEL.Company_id, SqlDbType.Int)
                                                                     );

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillingDelivertDetailEL = new BillingDelivertDetailEL();

                    objBillingDelivertDetailEL.Challan_Billing_Quantity = Convert.ToInt32(dt.Rows[i]["Challan_Billing_Quantity"]);
                    objBillingDelivertDetailEL.Deliver_Quantity = Convert.ToInt32(dt.Rows[i]["Deliver_Quantity"]);
                    objBillingDelivertDetailEL.Delivery_Detail_Id = Convert.ToInt32(dt.Rows[i]["Delivery_Detail_Id"]);
                    objBillingDelivertDetailEL.Delivery_Id = Convert.ToInt32(dt.Rows[i]["Delivery_Id"]);
                    objBillingDelivertDetailEL.Delivery_No = dt.Rows[i]["Delivery_No"].ToString();
                    objBillingDelivertDetailEL.Delivery_Date = Convert.ToDateTime(dt.Rows[i]["Delivery_Date"]);
                    objBillingDelivertDetailEL.Item_Quantity = Convert.ToInt32(dt.Rows[i]["Item_Quantity"]);
                    objBillingDelivertDetailEL.Purchase_Order_Detail_Id = Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]);
                    objBillingDelivertDetailEL.Purchases_Order_Id = Convert.ToInt32(dt.Rows[i]["Purchases_Order_Id"]);
                    objBillingDelivertDetailEL.Total_Deliver_Quantity = Convert.ToInt32(dt.Rows[i]["Total_Deliver_Quantity"]);
                    objBillingDelivertDetailEL.Purchases_Order_No = dt.Rows[i]["Purchases_Order_No"].ToString();
                    objBillingDelivertDetailEL.PURCHASES_ORDER_Date = Convert.ToDateTime(dt.Rows[i]["PURCHASES_ORDER_Date"]);
                    lstBillingDelivertDetail.Add(objBillingDelivertDetailEL);
                }

            }
            return lstBillingDelivertDetail;
        }
        public List<BillingDelivertDetailEL> GetUnProcessBillingDeliver(CompanyEL companyEL)
        {
            BillingDelivertDetailEL objBillingDelivertDetailEL;
            List<BillingDelivertDetailEL> lstBillingDelivertDetail = new List<BillingDelivertDetailEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("B_GetUnProcess_Billing_DeliverDeatil"
                                                                    , objSQLHelper.SqlParam("@Company_id", companyEL.Company_id, SqlDbType.Int)
                                                                     );

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillingDelivertDetailEL = new BillingDelivertDetailEL();

                    objBillingDelivertDetailEL.Challan_Billing_Quantity = Convert.ToInt32(dt.Rows[i]["Challan_Billing_Quantity"]);
                    objBillingDelivertDetailEL.Deliver_Quantity = Convert.ToInt32(dt.Rows[i]["Deliver_Quantity"]);
                    objBillingDelivertDetailEL.Delivery_Detail_Id = Convert.ToInt32(dt.Rows[i]["Delivery_Detail_Id"]);
                    objBillingDelivertDetailEL.Delivery_Id = Convert.ToInt32(dt.Rows[i]["Delivery_Id"]);
                    objBillingDelivertDetailEL.Delivery_No = dt.Rows[i]["Delivery_No"].ToString();
                    objBillingDelivertDetailEL.Delivery_Date = Convert.ToDateTime(dt.Rows[i]["Delivery_Date"]);
                    objBillingDelivertDetailEL.Item_Quantity = Convert.ToInt32(dt.Rows[i]["Item_Quantity"]);
                    objBillingDelivertDetailEL.Purchase_Order_Detail_Id = Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]);
                    objBillingDelivertDetailEL.Purchases_Order_Id = Convert.ToInt32(dt.Rows[i]["Purchases_Order_Id"]);
                    objBillingDelivertDetailEL.Total_Deliver_Quantity = Convert.ToInt32(dt.Rows[i]["Total_Deliver_Quantity"]);
                    objBillingDelivertDetailEL.Purchases_Order_No = dt.Rows[i]["Purchases_Order_No"].ToString();
                    objBillingDelivertDetailEL.PURCHASES_ORDER_Date = Convert.ToDateTime(dt.Rows[i]["PURCHASES_ORDER_Date"]);
                    lstBillingDelivertDetail.Add(objBillingDelivertDetailEL);
                }

            }
            return lstBillingDelivertDetail;
        }
    }
}
