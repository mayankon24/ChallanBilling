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
    class BillItemDL
    {
        public int Insert(BillItemEL objBillItemEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int id = Insert(objSqlTransaction, objBillItemEL);
                objSqlTransaction.Commit();
                return id;
            }
            catch(Exception)
            {
                objSqlTransaction.Rollback();
                throw;
            }

        }
        public bool Update(BillItemEL objBillItemEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Update(objSqlTransaction, objBillItemEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }

        }
        public bool Delete(BillItemEL objBillItemEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Delete(objSqlTransaction, objBillItemEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }
        }
        public List<BillItemEL> GetBillItemByBillId(int BillId)
        {
            BillItemEL objBillItemEL;
            List<BillItemEL> lstBillItemEL = new List<BillItemEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectBillItemByBillId"
                                                                    , objSQLHelper.SqlParam("@Bill_Id", BillId, SqlDbType.Int)
                                                                     );
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillItemEL = new BillItemEL();
                    objBillItemEL.Bill_Id = (int)dt.Rows[i]["Bill_Id"];
                    objBillItemEL.Item_Name = dt.Rows[i]["ItemName"].ToString();
                    objBillItemEL.Item_Id = dt.Rows[i]["Item_Id"].GetType() == typeof(DBNull) ? (int?)null : Convert.ToInt32(dt.Rows[i]["Item_Id"]); 
                    objBillItemEL.Bill_Item_Id = (int)dt.Rows[i]["Bill_Item_Id"];
                    objBillItemEL.Purchase_Order_Detail_Id = dt.Rows[i]["Purchase_Order_Detail_Id"].GetType() == typeof(DBNull) ? (int?)null : Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]);
                    objBillItemEL.Color = (int)dt.Rows[i]["Color"];                 
                    objBillItemEL.Form = Convert.ToDecimal(dt.Rows[i]["Form"]);
                    objBillItemEL.Quantity = Convert.ToDouble(dt.Rows[i]["Quantity"].ToString());
                    objBillItemEL.Rate = Convert.ToDecimal(dt.Rows[i]["Rate"]);
                    objBillItemEL.Parent_Id = dt.Rows[i]["Parent_Id"].GetType() == typeof(DBNull) ? (int?)null : Convert.ToInt32(dt.Rows[i]["Parent_Id"]);
                    lstBillItemEL.Add(objBillItemEL);
                }

            }
            return lstBillItemEL;
        }
        public List<BillItemEL> GetBillItemBy_ParentId(int Parent_Id)
        {
            BillItemEL objBillItemEL;
            List<BillItemEL> lstBillItemEL = new List<BillItemEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetBillItemBy_ParentId"
                                                                    , objSQLHelper.SqlParam("@Parent_Id", Parent_Id, SqlDbType.Int)
                                                                     );
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillItemEL = new BillItemEL();
                    objBillItemEL.Bill_Id = (int)dt.Rows[i]["Bill_Id"];
                    objBillItemEL.Item_Name = dt.Rows[i]["ItemName"].ToString();
                    objBillItemEL.Item_Id = Convert.ToInt32( dt.Rows[i]["Item_Id"]);
                    objBillItemEL.Bill_Item_Id = (int)dt.Rows[i]["Bill_Item_Id"];
                    objBillItemEL.Purchase_Order_Detail_Id = dt.Rows[i]["Purchase_Order_Detail_Id"].GetType() == typeof(DBNull) ? (int?)null : Convert.ToInt32(dt.Rows[i]["Purchase_Order_Detail_Id"]);
                    objBillItemEL.Color = (int)dt.Rows[i]["Color"];
                    objBillItemEL.Form = Convert.ToDecimal(dt.Rows[i]["Form"]);
                    objBillItemEL.Quantity = Convert.ToDouble(dt.Rows[i]["Quantity"].ToString());
                    objBillItemEL.Rate = Convert.ToDecimal(dt.Rows[i]["Rate"]);
                    objBillItemEL.Parent_Id = dt.Rows[i]["Parent_Id"].GetType() == typeof(DBNull) ? (int?)null : Convert.ToInt32(dt.Rows[i]["Parent_Id"]);
                    lstBillItemEL.Add(objBillItemEL);
                }

            }
            return lstBillItemEL;
        }
        


        public int Insert(SqlTransaction objSqlTransaction, BillItemEL objBillItemEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            int Id = objSQLHelper.ExecuteInsertProcedure("InsertBillItem", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Bill_Id", objBillItemEL.Bill_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Item_Name", objBillItemEL.Item_Name, SqlDbType.NVarChar)
                                                     , objSQLHelper.SqlParam("@Item_Id", objBillItemEL.Item_Id, SqlDbType.Int)  
                                                     , objSQLHelper.SqlParam("@Color", objBillItemEL.Color, SqlDbType.Int)                                                  
                                                     , objSQLHelper.SqlParam("@Form", objBillItemEL.Form, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Purchase_Order_Detail_Id", objBillItemEL.Purchase_Order_Detail_Id, SqlDbType.Float)
                                                     , objSQLHelper.SqlParam("@Quantity", objBillItemEL.Quantity, SqlDbType.Float)
                                                     , objSQLHelper.SqlParam("@Rate", objBillItemEL.Rate, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Parent_Id", objBillItemEL.Parent_Id, SqlDbType.Int)
                                                   );
            return Id;
        }
        public void Update(SqlTransaction objSqlTransaction, BillItemEL objBillItemEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            objSQLHelper.ExecuteUpdateProcedure("UpdateBilllItem", objSqlTransaction                                                    
                                                     , objSQLHelper.SqlParam("@Item_Name", objBillItemEL.Item_Name, SqlDbType.NVarChar)
                                                     , objSQLHelper.SqlParam("@Item_Id", objBillItemEL.Item_Id, SqlDbType.Int)  
                                                     , objSQLHelper.SqlParam("@Color", objBillItemEL.Color, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Form", objBillItemEL.Form, SqlDbType.Decimal)                                                    
                                                     , objSQLHelper.SqlParam("@Quantity", objBillItemEL.Quantity, SqlDbType.Float)
                                                     , objSQLHelper.SqlParam("@Rate", objBillItemEL.Rate, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Bill_Item_Id", objBillItemEL.Bill_Item_Id, SqlDbType.Decimal)
                                                   );                                                   
        }
        public void Delete(SqlTransaction objSqlTransaction, BillItemEL objBillItemEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            int cpmpanyId = objSQLHelper.ExecuteDeleteProcedure("DeleteBilllItem", objSqlTransaction
                                                                , objSQLHelper.SqlParam("@Bill_Item_Id", objBillItemEL.Bill_Item_Id, SqlDbType.Decimal)
                                                               );
        }
    }
}
