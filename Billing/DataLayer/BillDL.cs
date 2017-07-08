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
    class BillDL
    {
        public int Insert(BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                int Id = Insert(objSqlTransaction, objBillEL);
                objSqlTransaction.Commit();
                return Id;
            }
            catch(Exception)
            {
                objSqlTransaction.Rollback();
                throw;
            }

        }
        public bool Update(BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Update(objSqlTransaction, objBillEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }

        }
        public bool Delete(BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

            try
            {
                Delete(objSqlTransaction, objBillEL);
                objSqlTransaction.Commit();
                return true;
            }
            catch
            {
                objSqlTransaction.Rollback();
                return false;
            }
        }        
        
        public int Insert(SqlTransaction _objSqlTransaction, BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            int Id = objSQLHelper.ExecuteInsertProcedure("InsertBill", _objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Bill_Date", objBillEL.Bill_Date, SqlDbType.DateTime)
                                                     , objSQLHelper.SqlParam("@Bill_No", objBillEL.Bill_No, SqlDbType.NVarChar)
                                                     , objSQLHelper.SqlParam("@Bill_Type_Id", objBillEL.Bill_Type_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Company_id", objBillEL.Company_id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Is_Tax_Inclusive", objBillEL.Is_Tax_Inclusive, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Tax_Name", objBillEL.Tax_Name, SqlDbType.NVarChar)
                                                     , objSQLHelper.SqlParam("@Tax_Percentage", objBillEL.Tax_Percentage, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Cartage", objBillEL.Cartage, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Discount", objBillEL.Discount, SqlDbType.Decimal)
                                                   );

            return Id;

        }
        public void Update(SqlTransaction objSqlTransaction, BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            objSQLHelper.ExecuteUpdateProcedure("UpdateBill", objSqlTransaction
                                                     , objSQLHelper.SqlParam("@Bill_Date", objBillEL.Bill_Date, SqlDbType.DateTime)                                                    
                                                     , objSQLHelper.SqlParam("@Bill_Type_Id", objBillEL.Bill_Type_Id, SqlDbType.Int)                                                   
                                                     , objSQLHelper.SqlParam("@Is_Tax_Inclusive", objBillEL.Is_Tax_Inclusive, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Tax_Name", objBillEL.Tax_Name, SqlDbType.NVarChar)
                                                     , objSQLHelper.SqlParam("@Tax_Percentage", objBillEL.Tax_Percentage, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Cartage", objBillEL.Cartage, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Discount", objBillEL.Discount, SqlDbType.Decimal)
                                                     , objSQLHelper.SqlParam("@Bill_Id", objBillEL.Bill_Id, SqlDbType.Int)
                                                   );
        }
        public void Delete(SqlTransaction objSqlTransaction, BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            int cpmpanyId = objSQLHelper.ExecuteDeleteProcedure("DeleteBill", objSqlTransaction
                                                                , objSQLHelper.SqlParam("@Bill_Id", objBillEL.Bill_Id, SqlDbType.Int)
                                                               );
        }


        public List<BillEL> GetBillAll()
        {
            BillEL objBillEL;
            List<BillEL> lstBillEL = new List<BillEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectBillAll");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillEL = new BillEL();
                    objBillEL.Bill_Date = Convert.ToDateTime(dt.Rows[i]["Bill_Date"]);
                    objBillEL.Bill_Id = (int)dt.Rows[i]["Bill_Id"];
                    objBillEL.Bill_No = dt.Rows[i]["Bill_No"].ToString();
                    objBillEL.Bill_Type_Id = (int)dt.Rows[i]["Bill_Type_Id"];
                    objBillEL.Company_id = (int)dt.Rows[i]["Company_id"];
                    objBillEL.Is_Tax_Inclusive = Convert.ToInt32(dt.Rows[i]["Is_Tax_Inclusive"]);
                    objBillEL.Tax_Percentage = Convert.ToDecimal(dt.Rows[i]["Tax_Percentage"]);
                    objBillEL.Tax_Name = dt.Rows[i]["Tax_Name"].ToString();
                    objBillEL.Cartage = dt.Rows[i]["Cartage"].GetType() == typeof(DBNull) ? (decimal?)null : Convert.ToDecimal(dt.Rows[i]["Cartage"]);
                    objBillEL.Discount = dt.Rows[i]["Discount"].GetType() == typeof(DBNull) ? (decimal?)null : Convert.ToDecimal(dt.Rows[i]["Discount"]);
                    lstBillEL.Add(objBillEL);
                }

            }
            return lstBillEL;
        }
        public BillEL GetBillById(int BillId)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("SelectBillById"
                                                                    , objSQLHelper.SqlParam("@Bill_Id", BillId, SqlDbType.Int)
                                                                     );

            BillEL objBillEL = new BillEL();
            if (dt != null && dt.Rows.Count > 0)
            {
                objBillEL.Bill_Date = Convert.ToDateTime(dt.Rows[0]["Bill_Date"]);
                objBillEL.Bill_Id = (int)dt.Rows[0]["Bill_Id"];
                objBillEL.Bill_No = dt.Rows[0]["Bill_No"].ToString();
                objBillEL.Bill_Type_Id = (int)dt.Rows[0]["Bill_Type_Id"];
                objBillEL.Company_id = (int)dt.Rows[0]["Company_id"];
                objBillEL.Is_Tax_Inclusive = Convert.ToInt32(dt.Rows[0]["Is_Tax_Inclusive"]);
                objBillEL.Tax_Percentage = Convert.ToDecimal(dt.Rows[0]["Tax_Percentage"]);
                objBillEL.Tax_Name = dt.Rows[0]["Tax_Name"].ToString();
                objBillEL.Cartage = dt.Rows[0]["Cartage"].GetType() == typeof(DBNull) ? (decimal?)null : Convert.ToDecimal(dt.Rows[0]["Cartage"]);
                objBillEL.Discount = dt.Rows[0]["Discount"].GetType() == typeof(DBNull) ? (decimal?)null : Convert.ToDecimal(dt.Rows[0]["Discount"]);
            }
            return objBillEL;
        }
        public List<BillEL> GetBillByCompanyId(int companyId)
        {
            BillEL objBillEL;
            List<BillEL> lstBillEL = new List<BillEL>();

            SQLHelper objSQLHelper = new SQLHelper();
            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetBillByCompanyId"
                                                          , objSQLHelper.SqlParam("@Company_id", companyId, SqlDbType.Int)
                                                          );
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objBillEL = new BillEL();
                    objBillEL.Bill_Date = Convert.ToDateTime(dt.Rows[i]["Bill_Date"]);
                    objBillEL.Bill_Id = (int)dt.Rows[i]["Bill_Id"];
                    objBillEL.Bill_No = dt.Rows[i]["Bill_No"].ToString();
                    objBillEL.Bill_Type_Id = (int)dt.Rows[i]["Bill_Type_Id"];
                    objBillEL.Company_id = (int)dt.Rows[i]["Company_id"];
                    objBillEL.Is_Tax_Inclusive = Convert.ToInt32(dt.Rows[i]["Is_Tax_Inclusive"]);
                    objBillEL.Tax_Percentage = Convert.ToDecimal(dt.Rows[i]["Tax_Percentage"]);
                    objBillEL.Tax_Name = dt.Rows[i]["Tax_Name"].ToString();
                    objBillEL.Cartage = dt.Rows[i]["Cartage"].GetType() == typeof(DBNull) ? (decimal?)null : Convert.ToDecimal(dt.Rows[i]["Cartage"]);
                    objBillEL.Discount = dt.Rows[i]["Discount"].GetType() == typeof(DBNull) ? (decimal?)null : Convert.ToDecimal(dt.Rows[i]["Discount"]);
                   
                    lstBillEL.Add(objBillEL);
                }

            }
            return lstBillEL;
        }
        public DateTime GetLastBilldate(BillEL objBillEL)
        {           
            SQLHelper objSQLHelper = new SQLHelper();

            DataTable dt = objSQLHelper.ExecuteSelectProcedure("GetLastBilldate"
                                                     , objSQLHelper.SqlParam("@Bill_Date", objBillEL.Bill_Date, SqlDbType.DateTime)                                                   
                                                     , objSQLHelper.SqlParam("@Bill_Type_Id", objBillEL.Bill_Type_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Company_id", objBillEL.Company_id, SqlDbType.Int)
                                                   );

            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToDateTime(dt.Rows[0][0]);
            }
            else
            {
                return new DateTime(1900, 1, 1);
            }
        }
        public DataTable Get_Previous_Next_Billdate(BillEL objBillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();

            DataTable dt = objSQLHelper.ExecuteSelectProcedure("Get_Previous_Next_Billdate"
                                                     , objSQLHelper.SqlParam("@Bill_Id", objBillEL.Bill_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Bill_Date", objBillEL.Bill_Date, SqlDbType.DateTime)
                                                     , objSQLHelper.SqlParam("@Bill_Type_Id", objBillEL.Bill_Type_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Company_id", objBillEL.Company_id, SqlDbType.Int)
                                                   );

            return dt;
        }


        public DataSet GetBillReportData(CompanyEL _CompanyEL, BillEL _BillEL)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            DataSet ds = new DataSet();



            //DataTable dtBillBody = ds.Tables.Add("GetBillReportBody");
            //DataTable dtBillHeader = ds.Tables.Add("GetBillReportHeader");

            DataTable dtBillBody = objSQLHelper.ExecuteSelectProcedure("GetBillReportBody"
                                                     , objSQLHelper.SqlParam("@Bill_Id", _BillEL.Bill_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Company_id", _CompanyEL.Company_id, SqlDbType.Int)
                                                     );

            DataTable dtBillHeader = objSQLHelper.ExecuteSelectProcedure("GetBillReportHeader"
                                                     , objSQLHelper.SqlParam("@Bill_Id", _BillEL.Bill_Id, SqlDbType.Int)
                                                     , objSQLHelper.SqlParam("@Company_id", _CompanyEL.Company_id, SqlDbType.Int)
                                                     );

            dtBillHeader.TableName = "GetBillReportHeader";
            dtBillBody.TableName = "GetBillReportBody";

            ds.Tables.Add(dtBillBody);
            ds.Tables.Add(dtBillHeader);

            return ds;
        }

        //private void CopyRow(DataTable dtTemp, DataRow dr)
        //{
        //    //for (int i = 0; i < dr[; i++)
        //    //{
        //    //    dtTemp.Rows

        //    //}
        //    //dtTemp.Rows.Add(dr);
        //}
        public DataSet GetCreateBillItemByBillId(int BillId)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            DataSet ds = objSQLHelper.ExecuteSelectProcedureForDataSet("GetCreateBillItemByBillId"
                                                     , objSQLHelper.SqlParam("@Bill_Id", BillId, SqlDbType.Int)                                                    
                                                     );
            return ds;
        }
    }
}
