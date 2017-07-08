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


namespace PurchasesChallan
{
    public partial class Challan_MDI_Admin : Form
    {
        CompanyEL companyEL = null;

        #region Constructtor 
        public Challan_MDI_Admin()
        {
            InitializeComponent();
        }
        public Challan_MDI_Admin(CompanyEL _CompanyEL)
            : this()
        {
            companyEL = _CompanyEL;
            this.Text = "Challan                 ....            " + companyEL.company_name;
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
        private void purchasesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForms();
            PurchasesOrder objPurchasesOrder = new PurchasesOrder(companyEL);
            showControl(objPurchasesOrder);
        }
        private void challanOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForms();
            BalanceSheet objBalanceSheet = new BalanceSheet(companyEL);
            showControl(objBalanceSheet);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        

        
    }
}
