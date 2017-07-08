using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Billing.Entity;

namespace Billing.DataLayer
{
    class CompanyTypeDL
    {
        public List<CompanyTypeEL> GetCompanyTypeList()
        {
            CompanyTypeEL objCompanyTypeEL;
            List<CompanyTypeEL> lstCompanyTypeEL = new List<CompanyTypeEL>();

            objCompanyTypeEL = new CompanyTypeEL();
            objCompanyTypeEL.CompanyType_Id = 1;
            objCompanyTypeEL.Company_Type_Name = "Delhi";      
            lstCompanyTypeEL.Add(objCompanyTypeEL);

            objCompanyTypeEL = new CompanyTypeEL();
            objCompanyTypeEL.CompanyType_Id = 2;
            objCompanyTypeEL.Company_Type_Name = "Noida";
            lstCompanyTypeEL.Add(objCompanyTypeEL);

            return lstCompanyTypeEL;
        }
    }
}
