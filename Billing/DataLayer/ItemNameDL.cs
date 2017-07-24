using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GlobleLibrary;
using Billing.Entity;

namespace Billing.DataLayer
{
    class ItemNameDL
    {
        public bool Insert(ItemNameEL objItemNameEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int Id = objSQLHelper.ExecuteInsertProcedure("InsertItemName", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Item_Name", objItemNameEL.Item_name, SqlDbType.NVarChar)
                                                         , objSQLHelper.SqlParam("@HSN_Code", objItemNameEL.HSN_Code, SqlDbType.NVarChar)
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
        public bool Update(ItemNameEL objItemNameEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int Id = objSQLHelper.ExecuteUpdateProcedure("UpdateItemName", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Item_Name", objItemNameEL.Item_name, SqlDbType.NVarChar)
                                                         , objSQLHelper.SqlParam("@HSN_Code", objItemNameEL.HSN_Code, SqlDbType.NVarChar)
                                                         , objSQLHelper.SqlParam("@Item_id", objItemNameEL.Item_id, SqlDbType.Int)
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
        public bool Delete(ItemNameEL objItemNameEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int cpmpanyId = objSQLHelper.ExecuteDeleteProcedure("DeleteItemName", objSqlTransaction
                                                                    , objSQLHelper.SqlParam("@Item_id", objItemNameEL.Item_id, SqlDbType.Int)
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
        public List<ItemNameEL> GetItemNameAll()
        {
            ItemNameEL objItemNameEL;
            List<ItemNameEL> lstInputFieldEL = new List<ItemNameEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectItemNameAll");
            
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objItemNameEL = new ItemNameEL();
                    objItemNameEL.Item_id = (int)dt.Rows[i]["Item_id"];
                    objItemNameEL.Item_name = dt.Rows[i]["Item_name"].ToString();
                    objItemNameEL.HSN_Code = dt.Rows[i]["HSN_Code"].ToString();
                    lstInputFieldEL.Add(objItemNameEL);
                }

            }
            return lstInputFieldEL;
        }       
        public ItemNameEL GetItemNameById(int ItemName_id)
        {
            ItemNameEL objItemNameEL = null;            
            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectItemNameById"
                                                                    , objSQLHelper.SqlParam("@Item_id", ItemName_id, SqlDbType.Int)
                                                                     );

            if (dt != null && dt.Rows.Count > 0)
            {
                objItemNameEL = new ItemNameEL();
                objItemNameEL.Item_id = (int)dt.Rows[0]["Item_id"];
                objItemNameEL.Item_name = dt.Rows[0]["Item_name"].ToString();
                
            }
            return objItemNameEL;
        }




        public List<ItemNameEL> GetItemPriceList(int CompanyId)
        {
            ItemNameEL objItemNameEL;
            List<ItemNameEL> lstInputFieldEL = new List<ItemNameEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetItemPriceList"
                                                        , objSQLHelper.SqlParam("@Company_Id", CompanyId, SqlDbType.Int)
                                                        );

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objItemNameEL = new ItemNameEL();
                    objItemNameEL.Item_id = Convert.ToInt32(dt.Rows[i]["Item_id"]);
                    objItemNameEL.Item_name = dt.Rows[i]["Item_name"].ToString();
                    objItemNameEL.Item_Price = Convert.ToDecimal(dt.Rows[i]["Item_Price"]);
                    objItemNameEL.Company_Item_Id = Convert.ToInt32(dt.Rows[i]["Company_Item_Id"]);
                    lstInputFieldEL.Add(objItemNameEL);
                }

            }
            return lstInputFieldEL;
        }
        public decimal GetItemPriceByCompany(int CompanyId, int ItemId)
        {            
            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetItemPrice_ByCompany"
                                                        , objSQLHelper.SqlParam("@Company_Id", CompanyId, SqlDbType.Int)
                                                        , objSQLHelper.SqlParam("@Item?_Id", CompanyId, SqlDbType.Int)
                                                        );

            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);

            }
            return 0; ;
        }
        public bool SaveItemPrice(DataTable udt_Company_Item_Price, int CompanyId)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                objSQLHelper.ExecuteUpdateProcedure("SaveItemPrice", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@udt_Company_Item_Price", udt_Company_Item_Price, SqlDbType.Structured)
                                                         , objSQLHelper.SqlParam("@Company_Id", CompanyId, SqlDbType.Int)                                                         
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
    }
}




