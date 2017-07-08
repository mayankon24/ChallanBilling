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
    class BillItemNarrationDL
    {
        public int Insert(BillItemNarrationEL _BillItemNarrationEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int id = Insert(objSqlTransaction, _BillItemNarrationEL);
                objSqlTransaction.Commit();
                return id;
            }
            catch(Exception)
            {
                objSqlTransaction.Rollback();
                throw;
            }

        }
        public bool Update(BillItemNarrationEL _BillItemNarrationEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Update(objSqlTransaction, _BillItemNarrationEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }

        }
        public bool Delete(BillItemNarrationEL _BillItemNarrationEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Delete(objSqlTransaction, _BillItemNarrationEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }
        }
        public List<BillItemNarrationEL> GetBillItemNarrationBy_BillItemId(int BillItemId)
        {
            BillItemNarrationEL _BillItemNarrationEL;
            List<BillItemNarrationEL> lstBillItemNarration = new List<BillItemNarrationEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectBillItemNarration_ByBillitemId"
                                                                    , objSQLHelper.SqlParam("@Bill_Item_Id", BillItemId, SqlDbType.Int)
                                                                     );
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    _BillItemNarrationEL = new BillItemNarrationEL();
                    _BillItemNarrationEL.Bill_Item_Id = (int)dt.Rows[i]["Bill_Item_Id"];
                    _BillItemNarrationEL.BillItem_Narration_Id = (int)dt.Rows[i]["BillItem_Narration_Id"];
                    _BillItemNarrationEL.Narration =dt.Rows[i]["Narration"].ToString();                            
                    lstBillItemNarration.Add(_BillItemNarrationEL);
                }

            }
            return lstBillItemNarration;
        }

        public int Insert(SqlTransaction objSqlTransaction, BillItemNarrationEL _BillItemNarrationEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            int Id = objSQLHelper.ExecuteInsertProcedure("InsertBillItemNarration", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Bill_Item_Id", _BillItemNarrationEL.Bill_Item_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Narration", _BillItemNarrationEL.Narration, SqlDbType.NVarChar)                                                     
                                                   );

            return Id;


        }
        public void Delete(SqlTransaction objSqlTransaction, BillItemNarrationEL _BillItemNarrationEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            int cpmpanyId = objSQLHelper.ExecuteDeleteProcedure("DeleteBillItemNarration", objSqlTransaction
                                                                , objSQLHelper.SqlParam("@BillItem_Narration_Id", _BillItemNarrationEL.BillItem_Narration_Id, SqlDbType.Int)
                                                               );
        }
        public void Update(SqlTransaction objSqlTransaction, BillItemNarrationEL _BillItemNarrationEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            objSQLHelper.ExecuteUpdateProcedure("UpdateBillItemNarration", objSqlTransaction
                                                   , objSQLHelper.SqlParam("@Bill_Item_Id", _BillItemNarrationEL.Bill_Item_Id, SqlDbType.Int)
                                                   , objSQLHelper.SqlParam("@Narration", _BillItemNarrationEL.Narration, SqlDbType.NVarChar)
                                                   , objSQLHelper.SqlParam("@BillItem_Narration_Id", _BillItemNarrationEL.BillItem_Narration_Id, SqlDbType.Int)
                                                 );

        }
    }
}
