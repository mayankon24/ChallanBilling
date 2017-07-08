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
    class BillDetailDL
    {
        public int Insert(BillDetailEL objBillDetailEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int id = Insert(objSqlTransaction, objBillDetailEL);
                objSqlTransaction.Commit();
                return id;
            }
            catch(Exception)
            {
                objSqlTransaction.Rollback();
                throw;
            }

        }
        public bool Update(BillDetailEL objBillDetailEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                  objSQLHelper.ExecuteUpdateProcedure("UpdateBillDetail", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Bill_Item_Id", objBillDetailEL.Bill_Item_Id, SqlDbType.Int)
                                                         , objSQLHelper.SqlParam("@Delivery_Detail_Id", objBillDetailEL.Delivery_Detail_Id, SqlDbType.Int)
                                                         , objSQLHelper.SqlParam("@Quantity", objBillDetailEL.Quantity, SqlDbType.Float)
                                                         //, objSQLHelper.SqlParam("@Rate", objBillDetailEL.Rate, SqlDbType.Decimal)
                                                         //, objSQLHelper.SqlParam("@Color", objBillDetailEL.Color, SqlDbType.Int)
                                                         //, objSQLHelper.SqlParam("@Form", objBillDetailEL.Form, SqlDbType.Int)
                                                         , objSQLHelper.SqlParam("@Bill_Detail_Id", objBillDetailEL.Bill_Detail_Id, SqlDbType.Int)
                                                       );
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }

        }
        public bool Delete(BillDetailEL objBillDetailEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Delete(objSqlTransaction, objBillDetailEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }
        }
        public List<BillDetailEL> GetBillDetailByBillId(int BillId)
        {
            BillDetailEL objBillDetailEL;
            List<BillDetailEL> lstBillDetailEL = new List<BillDetailEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectBillDetailByBillId"
                                                                    , objSQLHelper.SqlParam("@Bill_Id", BillId, SqlDbType.Int)
                                                                     );
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillDetailEL = new BillDetailEL();
                    objBillDetailEL.Bill_Detail_Id = (int)dt.Rows[i]["Bill_Detail_Id"];
                    objBillDetailEL.Bill_Item_Id = (int)dt.Rows[i]["Bill_Item_Id"];
                    objBillDetailEL.Quantity = Convert.ToDouble(dt.Rows[i]["Quantity"].ToString());
                    objBillDetailEL.Delivery_Detail_Id = (int)dt.Rows[i]["Delivery_Detail_Id"];
                    //objBillDetailEL.Form = (int)dt.Rows[i]["Form"];                   
                    //objBillDetailEL.Color = (int)dt.Rows[i]["Color"];
                    //objBillDetailEL.Rate = Convert.ToDecimal(dt.Rows[i]["Rate"]);                
                    lstBillDetailEL.Add(objBillDetailEL);
                }

            }
            return lstBillDetailEL;
        }
        public List<BillDetailEL> GetBillDetailBy_BillItemId(int BillItemId)
        {
            BillDetailEL objBillDetailEL;
            List<BillDetailEL> lstBillDetailEL = new List<BillDetailEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectBillDetail_ByBillItemId"
                                                                    , objSQLHelper.SqlParam("@Bill_Item_Id", BillItemId, SqlDbType.Int)
                                                                     );
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillDetailEL = new BillDetailEL();
                    objBillDetailEL.Bill_Detail_Id = (int)dt.Rows[i]["Bill_Detail_Id"];
                    objBillDetailEL.Bill_Item_Id = (int)dt.Rows[i]["Bill_Item_Id"];
                    objBillDetailEL.Quantity = Convert.ToDouble(dt.Rows[i]["Quantity"].ToString());
                    objBillDetailEL.Delivery_Detail_Id = (int)dt.Rows[i]["Delivery_Detail_Id"];
                    //objBillDetailEL.Form = (int)dt.Rows[i]["Form"];                   
                    //objBillDetailEL.Color = (int)dt.Rows[i]["Color"];
                    //objBillDetailEL.Rate = Convert.ToDecimal(dt.Rows[i]["Rate"]);                
                    lstBillDetailEL.Add(objBillDetailEL);
                }

            }
            return lstBillDetailEL;
        }
        public DataTable GetPurchasesChallanNoByBillId(int BillId)
        {
           List<BillDetailEL> lstBillDetailEL = new List<BillDetailEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetPurchasesChallanNoByBillId"
                                                                    , objSQLHelper.SqlParam("@Bill_Id", BillId, SqlDbType.Int)
                                                                     );
            return dt;
        }
        


        public int Insert(SqlTransaction objSqlTransaction, BillDetailEL objBillDetailEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            int Id = objSQLHelper.ExecuteInsertProcedure("InsertBillDetail", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Bill_Item_Id", objBillDetailEL.Bill_Item_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Quantity", objBillDetailEL.Quantity, SqlDbType.Float)
                                                     , objSQLHelper.SqlParam("@Delivery_Detail_Id", objBillDetailEL.Delivery_Detail_Id, SqlDbType.Int)
                                                     //, objSQLHelper.SqlParam("@Form", objBillDetailEL.Form, SqlDbType.Int)
                                                     //, objSQLHelper.SqlParam("@Color", objBillDetailEL.Color, SqlDbType.Int)
                                                     //, objSQLHelper.SqlParam("@Rate", objBillDetailEL.Rate, SqlDbType.Decimal)
                                                   );

            return Id;


        }
        public void Delete(SqlTransaction objSqlTransaction, BillDetailEL objBillDetailEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            int cpmpanyId = objSQLHelper.ExecuteDeleteProcedure("DeleteBillDetail", objSqlTransaction
                                                                , objSQLHelper.SqlParam("@Bill_Detail_Id", objBillDetailEL.Bill_Detail_Id, SqlDbType.Int)
                                                               );
        }
    }
}
