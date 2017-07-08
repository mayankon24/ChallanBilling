using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GlobleLibrary; 

namespace PurchasesChallan.DataLayer
{
    class ReportDeliveryDL
    {
        public ReportDeliveryDL()
        {
            
        }

        public DataSet GetDeliveryNoteDetail(int companyId, int deliveryOrderId)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            
            DataSet ds = objSQLHelper.MyCustomExecuteSelectProcedureForDataSet("GetReportHeader", "GetReportBody"
                                                    , objSQLHelper.SqlParam("@Delivery_Id", deliveryOrderId, SqlDbType.Int)
                                                    , objSQLHelper.SqlParam("@Company_id", companyId, SqlDbType.NVarChar)
                                                    );

           
            return ds;
        }
    }
}