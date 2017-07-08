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
    class DeliveryDL
    {
        public List<DeliveryEL> GetDelivery()
        {
            DeliveryEL objDeliveryEL;
            List<DeliveryEL> lstDeliveryEL = new List<DeliveryEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("B_SelectDeliveryAll");

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objDeliveryEL = new DeliveryEL();
                    objDeliveryEL.company_id = (int)dt.Rows[i]["company_id"];
                    objDeliveryEL.Delivery_Date = Convert.ToDateTime(dt.Rows[i]["Delivery_Date"]);
                    objDeliveryEL.Delivery_Id = (int)dt.Rows[i]["Delivery_Id"];
                    objDeliveryEL.Delivery_no = dt.Rows[i]["Delivery_no"].ToString();
                    objDeliveryEL.Purchases_Order_Id = (int)dt.Rows[i]["Purchases_Order_Id"];
                    lstDeliveryEL.Add(objDeliveryEL);
                }
            }
            return lstDeliveryEL;
        }
        public List<DeliveryEL> GetDeliveryOrderByBillId(int BillId)
        {
            DeliveryEL objDeliveryEL;
            List<DeliveryEL> lstDeliveryEL = new List<DeliveryEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetDeliveryOrderByBillId"
                                                               , objSQLHelper.SqlParam("@Bill_Id", BillId, SqlDbType.Int)
                                                               );

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objDeliveryEL = new DeliveryEL();
                    objDeliveryEL.company_id = (int)dt.Rows[i]["company_id"];
                    objDeliveryEL.Delivery_Date = Convert.ToDateTime(dt.Rows[i]["Delivery_Date"]);
                    objDeliveryEL.Delivery_Id = (int)dt.Rows[i]["Delivery_Id"];
                    objDeliveryEL.Delivery_no = dt.Rows[i]["Delivery_no"].ToString();
                    objDeliveryEL.Purchases_Order_Id = (int)dt.Rows[i]["Purchases_Order_Id"];
                    lstDeliveryEL.Add(objDeliveryEL);
                }
            }
            return lstDeliveryEL;
        }
        
    }
}
