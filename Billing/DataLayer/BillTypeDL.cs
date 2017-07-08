using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Billing.Entity;
using System.Data;
using System.Data.SqlClient;

namespace Billing.DataLayer
{
    class BillTypeDL
    {
        public List<BillTypeEL> GetBillTypeELList()
        {
            BillTypeEL objBillTypeEL;
            List<BillTypeEL> lstBillTypeEL = new List<BillTypeEL>();

            objBillTypeEL = new BillTypeEL();
            objBillTypeEL.BillType_Id = 1;
            objBillTypeEL.Bill_Type_Name = "Sale Invoice";
            lstBillTypeEL.Add(objBillTypeEL);

            objBillTypeEL = new BillTypeEL();
            objBillTypeEL.BillType_Id = 2;
            objBillTypeEL.Bill_Type_Name = "Tax Invoice";
            lstBillTypeEL.Add(objBillTypeEL);

            objBillTypeEL = new BillTypeEL();
            objBillTypeEL.BillType_Id = 3;
            objBillTypeEL.Bill_Type_Name = "Sale Invoice Jobwork";
            lstBillTypeEL.Add(objBillTypeEL);

            objBillTypeEL = new BillTypeEL();
            objBillTypeEL.BillType_Id = 4;
            objBillTypeEL.Bill_Type_Name = "Tax Invoice Jobwork";
            lstBillTypeEL.Add(objBillTypeEL);

            objBillTypeEL = new BillTypeEL();
            objBillTypeEL.BillType_Id = 5;
            objBillTypeEL.Bill_Type_Name = "Retail Invoice";
            lstBillTypeEL.Add(objBillTypeEL);

            return lstBillTypeEL;
        }
    }
}
