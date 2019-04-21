using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GlobleLibrary; 

namespace PurchasesChallan.DataLayer
{
    class DeliveryOrderDL
    {

        #region property

        public string DeliveryOrderNo { get; set; }
        public int companyId { get; set; }
        public DateTime DeliveryDate { get; set; }
       
        #endregion

        public DeliveryOrderDL()
        {
            DeliveryOrderNo = string.Empty;
            companyId = -1;
            DeliveryDate = DateTime.Now;
        }

        public void Insert(SqlTransaction objSqlTransaction, int companyId, int companyTypeId, int purchasesOrderId, DateTime date, string DeliveryOrderNo, DataTable dt)
        {

            SQLHelper objSQLHelper = new SQLHelper();
            int DeliveryOrderId = objSQLHelper.ExecuteInsertProcedure("InsertDelivery", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Company_id", companyId, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Company_Type_Id", companyTypeId, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@purchases_order_id", purchasesOrderId, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@delivery_date", date, SqlDbType.DateTime)
                                                     , objSQLHelper.SqlParam("@delivery_no", DeliveryOrderNo, SqlDbType.NVarChar)
                                                    );


            if (DeliveryOrderId > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int PuchasesOrderDetailId = objSQLHelper.ExecuteInsertProcedure("InsertDeliveryDetail", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Delivery_Id", DeliveryOrderId, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Purchase_Order_Detail_Id", Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]), SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Deliver_Quantity", Convert.ToDouble(dt.Rows[i]["Deliver_Quantity"]), SqlDbType.Float)
                                                     , objSQLHelper.SqlParam("@Gst_Rate", Convert.ToDouble(dt.Rows[i]["Gst_Rate"]), SqlDbType.Float)
                                                    );
                }
            }
            else 
            {
                throw new Exception();
            }

        }
        public void Update(SqlTransaction objSqlTransaction, int deliveryOrderId, DataTable dt)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int DeliveryDetailId = Convert.ToInt32(dt.Rows[i]["Delivery_Detail_Id"]);
                int IsItemDeliver = Convert.ToInt32(dt.Rows[i]["IS_Item_Deliver"]);
                int PurchaseOrderDetailId = Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]);
                double DeliverQuantity = Convert.ToDouble(dt.Rows[i]["Deliver_Quantity"]);
                double GstRate = Convert.ToDouble(dt.Rows[i]["Gst_Rate"]);
               

                if (IsItemDeliver == 1)
                {
                    if (DeliveryDetailId == 0)
                    {
                        objSQLHelper.ExecuteInsertProcedure("InsertDeliveryDetail", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Delivery_Id", deliveryOrderId, SqlDbType.Int)
                                                         , objSQLHelper.SqlParam("@Purchase_Order_Detail_Id", PurchaseOrderDetailId, SqlDbType.Int)
                                                         , objSQLHelper.SqlParam("@Deliver_Quantity", DeliverQuantity, SqlDbType.Float)
                                                         , objSQLHelper.SqlParam("@Gst_Rate", GstRate, SqlDbType.Float)
                                                        );
                    }
                    else if (DeliveryDetailId > 0)
                    {


                        objSQLHelper.ExecuteUpdateProcedure("UpdateDeliveryDetails", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Deliver_Quantity", DeliverQuantity, SqlDbType.Float)
                                                         , objSQLHelper.SqlParam("@Delivery_Detail_Id", DeliveryDetailId, SqlDbType.Int)
                                                         , objSQLHelper.SqlParam("@Gst_Rate", GstRate, SqlDbType.Float)
                                                        );
                    }
                }
                else if (IsItemDeliver == 0 && DeliveryDetailId > 0)
                {
                    objSQLHelper.ExecuteDeleteProcedure("DeletePackagingDetails_By_DeliveryDetailId", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Delivery_Detail_Id", DeliveryDetailId, SqlDbType.Int)
                                                    );


                    objSQLHelper.ExecuteDeleteProcedure("DeleteDeliveryDetailsById", objSqlTransaction
                                           , objSQLHelper.SqlParam("@Delivery_Detail_Id", DeliveryDetailId, SqlDbType.Int)
                                           );

                }

            }
        }
        public void Delete(SqlTransaction objSqlTransaction, int deliveryOrderId)
        {

            SQLHelper objSQLHelper = new SQLHelper();

            int PuchasesOrderDetailId = objSQLHelper.ExecuteDeleteProcedure("DeleteAllPackaging_of_Delivery", objSqlTransaction
                                          , objSQLHelper.SqlParam("@Delivery_Id", deliveryOrderId, SqlDbType.Int)
                                          );


            int PuchasesOrderDetailId1 = objSQLHelper.ExecuteDeleteProcedure("DeleteDeliveryDetails", objSqlTransaction
                                          , objSQLHelper.SqlParam("@Delivery_Id", deliveryOrderId, SqlDbType.Int)
                                          );

            int PuchasesOrderId = objSQLHelper.ExecuteDeleteProcedure("DeleteDelivery", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Delivery_Id", deliveryOrderId, SqlDbType.Int)
                                                    );



           
        }
        public void DeletePurchassOrderDetail(SqlTransaction objSqlTransaction, DataTable dt)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objSQLHelper.ExecuteDeleteProcedure("DeletePurchasesOrderDetail_ById", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Purchase_Order_Detail_Id", Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]), SqlDbType.Int)
                                                    );
            }
        }

        public DataTable GetPurchasesDeliveryOrder(int companyId, int purcharesOrderId)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetDeliveryOrderByPurchasesOrderId"
                                                    , objSQLHelper.SqlParam("@Company_id", companyId, SqlDbType.Int)
                                                    , objSQLHelper.SqlParam("@Purchases_Order_Id", purcharesOrderId, SqlDbType.Int)                                                    
                                                    );
            return dt;
        }
        public DataTable GetDeliveryOrderDetail(int DeliveryOrderId, int purchasesOrderId)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            if (DeliveryOrderId > 0)
            {
                DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectDeliveryById"
                                                        , objSQLHelper.SqlParam("@Deliver_Id", DeliveryOrderId, SqlDbType.Int)
                                                        );


                if (dt != null && dt.Rows.Count > 0)
                {
                    DeliveryOrderNo = dt.Rows[0]["Delivery_no"].ToString();
                    DeliveryDate = Convert.ToDateTime(dt.Rows[0]["Delivery_Date"]);
                }

            }

            DataTable dt1 = objSQLHelper.ExecuteSelectProcedure("GetDeliveryDetailByDeliveryOrderId"
                                                    , objSQLHelper.SqlParam("@Delivery_Id", DeliveryOrderId, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Purchases_Order_Id", purchasesOrderId, SqlDbType.Int)
                                                    );
            return dt1;
        }


    }
}