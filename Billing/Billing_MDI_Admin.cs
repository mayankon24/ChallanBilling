using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Billing.Entity;

namespace Billing
{
    public partial class Billing_MDI_Admin : Form
    {
        CompanyEL companyEL = null;

        #region Constructtor 
        public Billing_MDI_Admin()
        {
            InitializeComponent();
        }
        public Billing_MDI_Admin(CompanyEL _CompanyEL):this()
        {
            companyEL = _CompanyEL;
            this.Text = "Billing                 ....            " + companyEL.company_name;
        }

        #endregion 

        #region private Method
        private void showControl(Form frm)
        {
            if (this.MdiChildren.Contains(frm))
            {
                frm.ShowDialog();//.BringToFront();
            }
            else
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.Location = new Point(0, 0);
            }
        }
        private void showControl_Middel(Form frm)
        {
            int width = (this.Width - frm.Width) / 2;
            int height = (this.Height - frm.Height) / 2;

            frm.MdiParent = this;
            //frm.Location = new Point(width, height - 10);
            frm.Location = new Point(width, 5);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
        private void closeChildForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        #endregion 

        #region Menubar Click Event
        private void scanConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //closeChildForms();
            //ScanConfigurationForm objScanConfigurationForm = new ScanConfigurationForm();
            //showControl_Middel(objScanConfigurationForm);
        }
        private void createBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForms();            
            CreateBill objPurchasesOrder = new CreateBill(companyEL, null);
            showControl(objPurchasesOrder);
        }
        private void billReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForms();
            BillList objBillReport = new BillList(companyEL);
            showControl(objBillReport);
        }
        private void billQuantityReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForms();
            BillingQuantityReportByPeriod objBillingQuantityReportByPeriod = new BillingQuantityReportByPeriod(companyEL);
            showControl(objBillingQuantityReportByPeriod);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        
        
    }
}
