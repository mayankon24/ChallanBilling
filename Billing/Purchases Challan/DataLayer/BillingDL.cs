using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GlobleLibrary; 

namespace PurchasesChallan.DataLayer
{
    class BillingDL
    {
        public BillingDL()
        {
            
        }

        public DataTable GetCompletePurchasesOrder()
        {
            SQLHelper objSQLHelper = new SQLHelper();

            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetCompletePurchasesOrder");
            return dt;
        }
        public void Insert(int purchasesOrderId, DateTime date, string billNo)
        {

            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int cpmpanyId = objSQLHelper.ExecuteInsertProcedure("InsertBilling", objSqlTransaction
                                                                  , objSQLHelper.SqlParam("@Purchases_Order_Id", purchasesOrderId, SqlDbType.Int)
                                                                  , objSQLHelper.SqlParam("@Date", date, SqlDbType.DateTime)
                                                                  , objSQLHelper.SqlParam("@Bill_No", billNo, SqlDbType.NVarChar)
                                                                 
                                                                 );

                objSqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                objSqlTransaction.Rollback();
                throw ex;
            }

        }
        public void Update(int billId, DateTime date, string billNo)
        {

            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int cpmpanyId = objSQLHelper.ExecuteInsertProcedure("UpdateBilling", objSqlTransaction
                                                                  , objSQLHelper.SqlParam("@Bill_Id", billId, SqlDbType.Int)
                                                                  , objSQLHelper.SqlParam("@Date", date, SqlDbType.DateTime)
                                                                  , objSQLHelper.SqlParam("@Bill_No", billNo, SqlDbType.NVarChar)

                                                                 );

                objSqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                objSqlTransaction.Rollback();
                throw ex;
            }

        }


    }
}