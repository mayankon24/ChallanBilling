using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GlobleLibrary; 


namespace PurchasesChallan.DataLayer
{
    class PackagingDetailDL
    {
        public PackagingDetailDL()
        {
            
        }

        public void Update(SqlTransaction objSqlTransaction, int deliveryDetailId, DataTable dt)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            if (deliveryDetailId > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int PackagingId = Convert.ToInt32(dt.Rows[i]["Packaging_Id"]);
                    string PackagingDescription = dt.Rows[i]["Packaging_Description"].ToString();

                    if (PackagingId > 0)
                    {

                        objSQLHelper.ExecuteUpdateProcedure("UpdatePackagingDetails", objSqlTransaction
                                                    , objSQLHelper.SqlParam("@Packaging_Description", PackagingDescription, SqlDbType.NVarChar)
                                                    , objSQLHelper.SqlParam("@Packaging_id", PackagingId, SqlDbType.Int)
                                                   );

                    }
                    else if (PackagingId == 0)
                    {
                        objSQLHelper.ExecuteInsertProcedure("InsertPackagingDetail", objSqlTransaction
                                                       , objSQLHelper.SqlParam("@Delivery_Detail_Id", deliveryDetailId, SqlDbType.Int)
                                                       , objSQLHelper.SqlParam("@Packaging_Description", PackagingDescription, SqlDbType.NVarChar)                                                      
                                                      );
                    }
                }
            }
            else
            {
                throw new Exception();
            }

        }
        public void DeletePackagingDetail(SqlTransaction objSqlTransaction, DataTable dt)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objSQLHelper.ExecuteDeleteProcedure("DeletePackagingDetails", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Packaging_Id", Convert.ToInt32(dt.Rows[i]["Packaging_Id"]), SqlDbType.Int)
                                                    );
            }
        }

        public DataTable GetPackingDetail(int deliveryDetailId)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectPackagingDetail_By_DeliveryDetailId"
                                                    , objSQLHelper.SqlParam("@Delivery_Detail_Id", deliveryDetailId, SqlDbType.Int)
                                                    );
            return dt;
        }
    }
}