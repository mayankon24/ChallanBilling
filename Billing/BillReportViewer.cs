using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PurchasesChallan.DataLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Billing.Entity;
using Billing.DataLayer;
using Billing.Utility;

namespace Billing
{
    public partial class BillReportViewer : Form
    {
        #region Variavle
        CompanyEL companyEL;
        BillEL billEL;
        CR_Bill objRpt = null;
        CR_Bill_Sale objRptSale = null;

        List<BillingDelivertDetailEL> lstBillingDelivertDetail = null;

        #endregion

        #region constractor
        private BillReportViewer()
        {
            InitializeComponent();
        }
        public BillReportViewer(CompanyEL _company, BillEL _BillEL)
            : this()
        {
            companyEL = _company;
            billEL = _BillEL;

            GetGlobalVariableData();
            BindComboBox();

            CreateReport(" ");
        }

        #endregion

        #region Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Dispose();
            lstBillingDelivertDetail = null;
            billEL = null;
            this.Close();
            this.Dispose();
        }
        private void cmbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = "";
            int selectedValue = Convert.ToInt32(cmbBillType.SelectedValue);
            if (selectedValue  == 1)
            {
                message = "(Original Copy)";
            }
             if (selectedValue  == 2)
            {
                message = "(Duplicate Copy)";
            }
             if (selectedValue  == 3)
            {
                message = "(Triplicate  - Office Copy)";
            }
             if (selectedValue  == 4)
            {
                message = "";
            }
            CreateReport(message);
        }

        #endregion

        #region Method
        private void GetGlobalVariableData()
        {
            BillingDelivertDetailDL objBillingDelivertDetailDL = new BillingDelivertDetailDL();
            lstBillingDelivertDetail = objBillingDelivertDetailDL.GetBillingDelivertDetail(companyEL);
        }
        void CreateReport(string billType)
        {
            DisposeReport();            
            string PurchasesOrderNo = "";
            string PurchasesOrderDate = "";
            string DeliveryNo = "";
            string DeliveryDate = "";

            BillDetailDL objBillDetailDL = new BillDetailDL();
            List<BillDetailEL> lstBillDetail = objBillDetailDL.GetBillDetailByBillId(billEL.Bill_Id);


            var qurPurchases = from b in lstBillingDelivertDetail
                               join bd in lstBillDetail on b.Delivery_Detail_Id equals bd.Delivery_Detail_Id
                               select new
                               {
                                   b.Purchases_Order_Id,
                                   b.PURCHASES_ORDER_Date,
                                   b.Purchases_Order_No
                               };

            var qurDelivary = from b in lstBillingDelivertDetail
                              join bd in lstBillDetail on b.Delivery_Detail_Id equals bd.Delivery_Detail_Id
                              select new
                              {
                                  b.Delivery_Id,
                                  b.Delivery_Date,
                                  b.Delivery_No
                              };

            foreach (var item in qurDelivary.Distinct())
            {
                DeliveryNo += ", " + item.Delivery_No.Trim();
                DeliveryDate += ", " + item.Delivery_Date.ToString("dd/MM/yyyy").Trim();
            }

            foreach (var item in qurPurchases.Distinct())
            {
                PurchasesOrderNo += ", " + item.Purchases_Order_No.Trim();
                PurchasesOrderDate += ", " + item.PURCHASES_ORDER_Date.ToString("dd/MM/yyyy").Trim();
            }
            if (qurDelivary.Distinct().Count() > 10)
            {
                DeliveryNo = ",As per attach challan copy";
                DeliveryDate = ",As per attach challan copy";
            }

            try
            {
                BillDL objBillDL = new BillDL();
                DataSet ds = objBillDL.GetBillReportData(companyEL, billEL);
               

                if ((int)ds.Tables["GetBillReportHeader"].Rows[0]["Bill_Type_Id"] == (int)enumBillType.RetailInvoice_Jobwork || (int)ds.Tables["GetBillReportHeader"].Rows[0]["Bill_Type_Id"] == (int)enumBillType.TaxInvoice_Jobwork)
                {
                    objRpt = new CR_Bill();
                    objRpt.SetDataSource(ds);

                    objRpt.SetParameterValue("Order_No", PurchasesOrderNo.Substring(1));
                    objRpt.SetParameterValue("Order_Date", PurchasesOrderDate.Substring(1));
                    objRpt.SetParameterValue("Challan_NO", DeliveryNo.Substring(1));
                    objRpt.SetParameterValue("Challan_Date", DeliveryDate.Substring(1));
                    objRpt.SetParameterValue("Bill_Type", billType);

                    if (companyEL.Company_Type_Id == (int)enumCompanyType.Delhi)
                    {
                        objRpt.SetParameterValue("Tin_No", " 07050294694");
                    }
                    else if (companyEL.Company_Type_Id == (int)enumCompanyType.Noida)
                    {
                        objRpt.SetParameterValue("Tin_No", " 09165703716");
                    }                   
                    crystalReportViewer1.ReportSource = objRpt;
                }
                else
                {
                    objRptSale = new CR_Bill_Sale();
                    objRptSale.SetDataSource(ds);

                    objRptSale.SetParameterValue("Order_No", PurchasesOrderNo.Substring(1));
                    objRptSale.SetParameterValue("Order_Date", PurchasesOrderDate.Substring(1));
                    objRptSale.SetParameterValue("Challan_NO", DeliveryNo.Substring(1));
                    objRptSale.SetParameterValue("Challan_Date", DeliveryDate.Substring(1));
                    objRptSale.SetParameterValue("Bill_Type", billType);

                    if (companyEL.Company_Type_Id == (int)enumCompanyType.Delhi)
                    {
                        objRptSale.SetParameterValue("Tin_No", " 07050294694");
                    }
                    else if (companyEL.Company_Type_Id == (int)enumCompanyType.Noida)
                    {
                        objRptSale.SetParameterValue("Tin_No", " 09165703716");
                    }                   
                    crystalReportViewer1.ReportSource = objRptSale;
                }
            }
            catch (Exception ex)
            {
                string dt = ex.Message;
            }
        }
        private void DisposeReport()
        {
            if (objRpt != null)
            {
                objRpt.Dispose();
            }
            if (objRptSale != null)
            {
                objRptSale.Dispose();
            }
        }
        private void BindComboBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(string));
            dt.Columns.Add("id", typeof(int));

            dt.Rows.Add("(None)", 4);
            dt.Rows.Add("(Original Copy)", 1);
            dt.Rows.Add("(Duplicate Copy)", 2);
            dt.Rows.Add("(Triplicate  - Office Copy)", 3);
            

            cmbBillType.SelectedIndexChanged -= cmbBillType_SelectedIndexChanged;
            cmbBillType.DataSource = dt;
            cmbBillType.ValueMember = "id";
            cmbBillType.DisplayMember = "value";
            cmbBillType.SelectedIndexChanged += cmbBillType_SelectedIndexChanged;
        }

        #endregion

        private void crystalReportViewer1_Click(object sender, EventArgs e)
        {

        }

        private void BillReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeReport();
           
        }         
    }
}
