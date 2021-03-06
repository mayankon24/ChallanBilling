﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Billing.DataLayer;
using Billing.Entity;
using PurchasesChallan;
using GlobleLibrary;

namespace Billing
{
    public partial class Company : Form
    { 
        #region Property
        public CompanyEL DataGridViewSelectedCompany
        {
            get
            {
                CompanyEL objCompanyEL = new CompanyEL();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    objCompanyEL.Company_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["company_Id"].Value);
                    objCompanyEL.Company_Type_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Company_Type_Id"].Value);
                    objCompanyEL.company_name = dataGridView1.SelectedRows[0].Cells["company_name"].Value.ToString();
                    objCompanyEL.tin_no = dataGridView1.SelectedRows[0].Cells["tin_no"].Value.ToString();
                    objCompanyEL.pan_no = dataGridView1.SelectedRows[0].Cells["pan_no"].Value.ToString();
                    objCompanyEL.phone = dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
                    objCompanyEL.address1 = dataGridView1.SelectedRows[0].Cells["address1"].Value.ToString();
                    objCompanyEL.city = dataGridView1.SelectedRows[0].Cells["city"].Value.ToString();
                    objCompanyEL.state = dataGridView1.SelectedRows[0].Cells["state"].Value.ToString();
                    objCompanyEL.pincode = dataGridView1.SelectedRows[0].Cells["pincode"].Value.ToString();
                    objCompanyEL.email = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
                    objCompanyEL.phone = dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
                    objCompanyEL.Fax_No = dataGridView1.SelectedRows[0].Cells["Fax_No"].Value.ToString();
                    objCompanyEL.delivery_at = dataGridView1.SelectedRows[0].Cells["delivery_at"].Value.ToString();
                }
                return objCompanyEL;
            }
        }       
        public int SelectedCompanyType
        {
            get
            {
               return Convert.ToInt32(cmbCompanyType.SelectedValue);
            }            
        }
   
        #endregion

        #region Constructor
        public Company()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);
            if (Properties.Settings.Default.Super_Admin != 1 )
            {
                btnBilling.Visible = false;
            }

            BindComboBox();
            ControlClear();
            
        }
        #endregion

        #region Event
        private void Company_Load(object sender, EventArgs e)
        {
            GridBind();
        }

        #region Functionality Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textCompanyName.Text))
                {
                    Common.MessageAlert("First Enter Company Name");
                }
                else
                {
                    CompanyEL objCompanyEL = new CompanyEL();
                    CompanyDL objCompanyDL = new CompanyDL();

                    objCompanyEL.address1 = textAddress1.Text;
                    objCompanyEL.city = textCity.Text;
                    objCompanyEL.email = textEmail.Text;
                    objCompanyEL.Fax_No = textFaxNo.Text;
                    objCompanyEL.pan_no = textPan.Text;
                    objCompanyEL.tin_no = txtTin.Text;
                    objCompanyEL.phone = textPhone.Text;
                    objCompanyEL.pincode = textpinCode.Text;
                    objCompanyEL.state = textState.Text;
                    objCompanyEL.company_name = textCompanyName.Text;
                    objCompanyEL.Company_Type_Id = SelectedCompanyType;
                    objCompanyEL.delivery_at = textDelivertAt.Text; 
                   
                   
                    if (objCompanyDL.Insert(objCompanyEL))
                    {
                        Common.MessageSave();
                        GridBind();
                        ControlClear();
                    }
                    else
                    {

                    }
                }
            }
            catch
            {

            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControlClear();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textCompanyName.Text))
                {
                    Common.MessageAlert("First Enter Company Name");
                }
                else
                {
                    CompanyEL objCompanyEL = new CompanyEL();
                    CompanyDL objCompanyDL = new CompanyDL();

                    objCompanyEL.address1 = textAddress1.Text;
                    objCompanyEL.city = textCity.Text;
                    objCompanyEL.email = textEmail.Text;
                    objCompanyEL.Fax_No = textFaxNo.Text;
                    objCompanyEL.pan_no = textPan.Text;
                    objCompanyEL.tin_no = txtTin.Text;
                    objCompanyEL.phone = textPhone.Text;
                    objCompanyEL.pincode = textpinCode.Text;
                    objCompanyEL.state = textState.Text;
                    objCompanyEL.company_name = textCompanyName.Text;
                    objCompanyEL.delivery_at = textDelivertAt.Text; 
                    objCompanyEL.Company_Type_Id = SelectedCompanyType;
                    objCompanyEL.Company_id = DataGridViewSelectedCompany.Company_id;

                    if (objCompanyDL.Update(objCompanyEL))
                    {
                        Common.MessageUpdate();
                        GridBind();
                        ControlClear();
                    }
                    else
                    {

                    }
                }

            }
            catch
            {

            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Common.MessageConfim("Are You Want To Delete This "))
                {                
                    CompanyEL objCompanyEL = new CompanyEL();
                    CompanyDL objCompanyDL = new CompanyDL();

                    objCompanyEL.Company_id = DataGridViewSelectedCompany.Company_id;


                    if (objCompanyDL.Delete(objCompanyEL))
                    {
                        Common.MessageDelete();
                        GridBind();
                        ControlClear();
                    }
                    else
                    {

                    }
                }

            }
            catch
            {

            }

        }
       
        #endregion

        #region Nqavigation event
        private void cmbCompanyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridBind();
        }

        #endregion
        #endregion

        #region Private Method
        void ControlClear()
        {
            Common objCommon = new Common();
            objCommon.ClearControl(this);

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;                        
        }
        void BindControl()
        {
            try
            {
                CompanyEL objCompanyEL = DataGridViewSelectedCompany;
                textAddress1.Text = objCompanyEL.address1;
                textCity.Text = objCompanyEL.city;
                textEmail.Text = objCompanyEL.email;
                textFaxNo.Text = objCompanyEL.Fax_No;
                textPan.Text = objCompanyEL.pan_no;
                txtTin.Text = objCompanyEL.tin_no; 
                textPhone.Text = objCompanyEL.phone;
                textpinCode.Text = objCompanyEL.pincode;
                textState.Text = objCompanyEL.state;
                textCompanyName.Text = objCompanyEL.company_name;
                textDelivertAt.Text = objCompanyEL.delivery_at;  

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
            catch
            {
                ControlClear();
            }

        }
        private void BindComboBox()
        {
            CompanyTypeDL objCompanyTypeDL = new CompanyTypeDL();
            cmbCompanyType.DataSource = objCompanyTypeDL.GetCompanyTypeList();
            cmbCompanyType.DisplayMember = "Company_Type_Name";
            cmbCompanyType.ValueMember = "CompanyType_Id";
        }
     
        #endregion        

        #region DataGrid operation
        void GridBind()
        {
            try
            {
                CompanyDL objCompanyDL = new CompanyDL();
                PurchaseOrderDL _PurchaseOrderDL = new PurchaseOrderDL();
                BillingDelivertDetailDL objBillingDelivertDetailDL = new BillingDelivertDetailDL();
                List<CompanyEL> CompanyList = objCompanyDL.GetCompanyListByType(SelectedCompanyType);

                dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
                dataGridView1.Click-= dataGridView1_Click;
                dataGridView1.DataSource = CompanyList;
                dataGridView1.Columns["Company_id"].Visible = false;
                dataGridView1.Columns["Company_Type_Id"].Visible = false;              
                //BindControl();
                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
                dataGridView1.Click += dataGridView1_Click;


                #region SetGrid Color for panding bill creation 

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                { 
                    CompanyEL objCompanyEL = new CompanyEL();
                    objCompanyEL.Company_id = Convert.ToInt32(dataGridView1.Rows[i].Cells["company_Id"].Value);

                    List<BillingDelivertDetailEL> lstBillingDelivertDetail = objBillingDelivertDetailDL.GetUnProcessBillingDeliver(objCompanyEL);
                    lstBillingDelivertDetail = lstBillingDelivertDetail.Where(r => r.PURCHASES_ORDER_Date > Properties.Settings.Default.Create_Bill_Start_Date).ToList();

                    if (lstBillingDelivertDetail.Count > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    }
                }

                #endregion
            }
            catch
            {
            }
            ControlClear();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BindControl();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            BindControl();
        }

        #endregion        

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Billing_MDI_Admin newForm = new Billing_MDI_Admin(DataGridViewSelectedCompany);
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Location = new Point(0, 0);
            DialogResult result = newForm.ShowDialog();
            this.Visible = false;
            this.Hide();
            if (result == DialogResult.OK )
            {
                newForm.Close();
                newForm.Dispose();
                this.Show();
            }
        }

        private void btnChallan_Click(object sender, EventArgs e)
        {
            Challan_MDI_Admin newForm = new Challan_MDI_Admin(DataGridViewSelectedCompany);
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Location = new Point(0, 0);
            DialogResult result = newForm.ShowDialog();
            this.Visible = false;
            this.Hide();
            if (result == DialogResult.OK)
            {
                newForm.Close();
                newForm.Dispose();
                this.Show();
            }
        }

        private void btnItemPrice_Click(object sender, EventArgs e)
        {
            ItemPrice newForm = new ItemPrice(DataGridViewSelectedCompany);            
            DialogResult result = newForm.ShowDialog();
           
            if (result == DialogResult.OK)
            {
                newForm.Close();
                newForm.Dispose();
                this.Show();
            }
        }

       
    }
}

