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
    class TaxAmountDL
    {
        public bool Insert(TaxAmountEL objTaxAmountEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int Id = objSQLHelper.ExecuteInsertProcedure("InsertTaxAmount", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Tax_Amout", objTaxAmountEL.Tax_Amout, SqlDbType.Decimal )
                                                         , objSQLHelper.SqlParam("@Tax_Name", objTaxAmountEL.Tax_Name, SqlDbType.NVarChar)
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
        public bool Update(TaxAmountEL objTaxAmountEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int Id = objSQLHelper.ExecuteUpdateProcedure("UpdateTaxAmount", objSqlTransaction
                                                         , objSQLHelper.SqlParam("@Tax_Amout", objTaxAmountEL.Tax_Amout, SqlDbType.Decimal)
                                                         , objSQLHelper.SqlParam("@Tax_Name", objTaxAmountEL.Tax_Name, SqlDbType.NVarChar)
                                                         , objSQLHelper.SqlParam("@Tax_Amout_Id", objTaxAmountEL.Tax_Amout_Id, SqlDbType.Int)
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
        public bool Delete(TaxAmountEL objTaxAmountEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int cpmpanyId = objSQLHelper.ExecuteDeleteProcedure("DeleteTaxAmount", objSqlTransaction
                                                                    , objSQLHelper.SqlParam("@Tax_Amout_Id", objTaxAmountEL.Tax_Amout_Id, SqlDbType.Int)
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
        public List<TaxAmountEL> GetTaxAmountList()
        {
            TaxAmountEL objTaxAmountEL;
            List<TaxAmountEL> lstTaxAmountEL = new List<TaxAmountEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectTaxAmountAll");

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objTaxAmountEL = new TaxAmountEL();
                    objTaxAmountEL.Tax_Amout_Id = (int)dt.Rows[i]["Tax_Amout_Id"];
                    objTaxAmountEL.Tax_Name = dt.Rows[i]["Tax_Name"].ToString();
                    decimal TaxAmount;
                    if (decimal.TryParse(dt.Rows[i]["Tax_Amout"].ToString(), out TaxAmount))
                    {
                        objTaxAmountEL.Tax_Amout = Convert.ToDecimal(dt.Rows[i]["Tax_Amout"]);
                    }
                    else 
                    {
                        objTaxAmountEL.Tax_Amout = null;
                    }
                    
                    lstTaxAmountEL.Add(objTaxAmountEL);

                }

            }
            return lstTaxAmountEL;
        }
        public TaxAmountEL GetTaxAmountById(int TaxAmoutId)
        {            
            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectTaxAmountById"
                                                          , objSQLHelper.SqlParam("@Tax_Amout_Id", TaxAmoutId, SqlDbType.Int)
                                                        );

            TaxAmountEL _TaxAmountEL = new TaxAmountEL();
            if (dt != null && dt.Rows.Count > 0)
            {

                _TaxAmountEL.Tax_Amout_Id = (int)dt.Rows[0]["Tax_Amout_Id"];
                _TaxAmountEL.Tax_Name = dt.Rows[0]["Tax_Name"].ToString();
                _TaxAmountEL.Tax_Amout = Convert.ToDecimal(dt.Rows[0]["Tax_Amout"]);               
            }
            return _TaxAmountEL;
        }
    }
}
