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
using Billing;
using Billing.Utility;

namespace PurchasesChallan
{
    public partial class DeliveryReport : Form
    {
        #region Variable
        int CompanyId;
        int CompanyTypeId;
        int DeliveryOrderId;
        CR_ChallanNote objRpt = null;

        #endregion

        #region constractor
        private DeliveryReport()
        {
            InitializeComponent();
        }
        public DeliveryReport(int companyId, string compnayName, int companyTypeId, string companyTypeName, int deliveryOrderId)
            : this()
        {
            this.CompanyId = companyId;
            this.CompanyTypeId = companyTypeId;
            this.DeliveryOrderId = deliveryOrderId;
            
            BindComboBox();
            CreateReport();
        }

        #endregion

        #region Event
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.Dispose();
            objRpt = null;
            this.Close();
            this.Dispose();
        }
        private void cmbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateReport();
        }
        private void cb_jobworkNarration_CheckedChanged(object sender, EventArgs e)
        {
            CreateReport();
        }
        #endregion

        #region Method
        void CreateReport()
        {
            string Type = "";
            string jobworkNarration = "";
            if (cb_jobworkNarration.Checked == true)
            {
                jobworkNarration = "Not for Sale for Jobwork Only";
            }
            else
            {
                jobworkNarration = "";
            }

            int selectedValue = Convert.ToInt32(cmbBillType.SelectedValue);
            if (selectedValue == 1)
            {
                Type = "(Original Copy)";
            }
            if (selectedValue == 2)
            {
                Type = "(Duplicate Copy)";
            }
            if (selectedValue == 3)
            {
                Type = "(Triplicate  - Office Copy)";
            }
            if (selectedValue == 4)
            {
                Type = "";
            }
           
            DisposeReport();
            try
            {
                ReportDeliveryDL objReportDeliveryDL = new ReportDeliveryDL();
                DataSet ds = objReportDeliveryDL.GetDeliveryNoteDetail(CompanyId, DeliveryOrderId);

                objRpt = new CR_ChallanNote();
                objRpt.SetDataSource(ds);
                objRpt.SetParameterValue("Type", Type);
                objRpt.SetParameterValue("JobWork_Narration", jobworkNarration);
                if (this.CompanyTypeId == (int)enumCompanyType.Delhi)
                {
                    objRpt.SetParameterValue("Tin_No", " 07050294694");
                }
                else if (this.CompanyTypeId == (int)enumCompanyType.Noida)
                {
                    objRpt.SetParameterValue("Tin_No", " 09165703716 Dt 16.05.2005");
                }
                crystalReportViewer1.ReportSource = objRpt;
            }
            catch
            {
            }
        }
        private void DisposeReport()
        {
            if (objRpt != null)
            {
                objRpt.Dispose();
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

        
    }
}
