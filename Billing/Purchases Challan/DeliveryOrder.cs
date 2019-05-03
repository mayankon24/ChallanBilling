using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PurchasesChallan.DataLayer;
using GlobleLibrary;
using Billing.Entity;

namespace PurchasesChallan
{
    public partial class DeliveryOrder : Form
    {
        DataTable dtDeletingDeliveryOrderDetail = new DataTable();
        CompanyEL companyEL;
        PurchaseOrderEL purchaseOrderEL;

        #region constractor
        public DeliveryOrder()
        {
            dtDeletingDeliveryOrderDetail.Columns.Add("Purchase_Order_Detail_Id", typeof(int));
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);           
        }
        public DeliveryOrder(CompanyEL _companyEL, PurchaseOrderEL _purchaseOrderEL)
            : this()
        {
            companyEL = _companyEL;
            purchaseOrderEL = _purchaseOrderEL;           

            lbCompanyName.Text = companyEL.company_name;
            lbPurchasesOrderNo.Text = purchaseOrderEL.Purchases_Order_No;           
            FillListBox();

            if (Billing.Properties.Settings.Default.Challan_No_Mannual == 1)
            {
                textDeliveryOrderNo.ReadOnly = false;
            }
            else
            {
                textDeliveryOrderNo.ReadOnly = true;
            }

        }

        #endregion

        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();
            try
            {
                DeliveryOrderDL objDeliveryOrderDL = new DeliveryOrderDL();

                string DeliveryOrderNo = "";
                if (textDeliveryOrderNo.Text.Trim() != "")
                {
                    try
                    {
                        DeliveryOrderNo = Convert.ToInt64(textDeliveryOrderNo.Text).ToString();
                    }
                    catch (Exception)
                    {
                        Common.MessageAlert("Please enter integer value for Challan no");
                        return;
                    }                  
                }
                
                DateTime DeliveryOrderDate = dateTimePickerDeliveryOrderDate.Value;
                DataTable dt = new DataTable();
                dt.Columns.Add("Purchase_Order_Detail_Id", typeof(int));
                dt.Columns.Add("Deliver_Quantity", typeof(double));
                dt.Columns.Add("Gst_Rate", typeof(double));

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells["IS_Item_Deliver"].Value) == 1)
                    {
                        double PurchaseOrderDetailId = Convert.ToInt32(dataGridView1.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        double DeliverQuantity = Convert.ToDouble(dataGridView1.Rows[i].Cells["Deliver_Quantity"].Value);
                        double GstRate = Convert.ToDouble(dataGridView1.Rows[i].Cells["Gst_Rate"].Value);

                        if (DeliverQuantity > 0)
                        {
                            dt.Rows.Add(PurchaseOrderDetailId, DeliverQuantity, GstRate);
                        }
                        else
                        {
                            Common.MessageAlert("Can not deliver 0 or -ve quantity");
                            throw new Exception();
                        }
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    objDeliveryOrderDL.Insert(objSqlTransaction, companyEL.Company_id, companyEL.Company_Type_Id, purchaseOrderEL.Purchases_Order_Id, DeliveryOrderDate, DeliveryOrderNo, dt);
                    objSqlTransaction.Commit();
                    Common.MessageSave();
                    FillListBox();
                    ControlClear();
                }
                else
                {
                    Common.MessageAlert("Select at least one item to deliver ");
                }

            }
            catch
            {
                objSqlTransaction.Rollback();
                Common.MessageAlert("First enter data in correct format");
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControlClear();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLHelper objSQLHelper = new SQLHelper();
            SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();
            try
            {
                DeliveryOrderDL objDeliveryOrderDL = new DeliveryOrderDL();

                int DeliveryOrderId = Convert.ToInt32(ListDeliveryOrder.SelectedValue);
                string DeliveryOrderNo = textDeliveryOrderNo.Text.Trim();
                DateTime DeliveryOrderDate = dateTimePickerDeliveryOrderDate.Value;

                if (DeliveryOrderNo != "")
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Delivery_Detail_Id", typeof(int));
                    dt.Columns.Add("Purchase_Order_Detail_Id", typeof(int));
                    dt.Columns.Add("Deliver_Quantity", typeof(double));
                    dt.Columns.Add("Gst_Rate", typeof(double));
                    dt.Columns.Add("IS_Item_Deliver", typeof(int));

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        int DeliveryDetailId = Convert.ToInt32(dataGridView1.Rows[i].Cells["Delivery_Detail_Id"].Value);
                        int IsItemDeliver = Convert.ToInt32(dataGridView1.Rows[i].Cells["IS_Item_Deliver"].Value);
                        int PurchaseOrderDetailId = Convert.ToInt32(dataGridView1.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        double DeliverQuantity = Convert.ToDouble(dataGridView1.Rows[i].Cells["Deliver_Quantity"].Value);
                        double GstRate = Convert.ToDouble(dataGridView1.Rows[i].Cells["Gst_Rate"].Value);

                        if (DeliverQuantity <= 0 && IsItemDeliver == 1)
                        {
                            Common.MessageAlert("Can not deliver 0 or -ve quantity");
                            throw new Exception();
                        }
                        dt.Rows.Add(DeliveryDetailId, PurchaseOrderDetailId, DeliverQuantity, GstRate, IsItemDeliver);

                    }

                    if (dt.Rows.Count > 0)
                    {
                        objDeliveryOrderDL.Update(objSqlTransaction, DeliveryOrderId,  dt);
                        objSqlTransaction.Commit();
                        Common.MessageSave();
                        FillListBox();
                        ControlClear();
                    }
                    else
                    {
                        Common.MessageAlert("Select at least one item to deliver ");
                    }
                }
                else
                {
                    Common.MessageAlert("First enter Delivery Order No");
                }
            }
            catch
            {
                objSqlTransaction.Rollback();
                Common.MessageAlert("First enter data in correct format");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = MessageBox.Show("Are you want to delete this Company", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (str.Equals("Yes"))
            {
                SQLHelper objSQLHelper = new SQLHelper();
                SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();
                try
                {

                    DeliveryOrderDL objDeliveryOrderDL = new DeliveryOrderDL();
                    int DeliveryOrderId = Convert.ToInt32(ListDeliveryOrder.SelectedValue);
                    objDeliveryOrderDL.Delete(objSqlTransaction, DeliveryOrderId);


                    objSqlTransaction.Commit();
                    Common.MessageDelete();
                    FillListBox();
                    ControlClear();
                }
                catch
                {
                    objSqlTransaction.Rollback();
                }
            }

        }
      
       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int DeliveryOrderId = Convert.ToInt32(ListDeliveryOrder.SelectedValue);
                if (DeliveryOrderId > 0)
                {
                    DeliveryReport objDeliveryReport = new DeliveryReport(companyEL.Company_id, companyEL.company_name, companyEL.Company_Type_Id, companyEL.company_name, DeliveryOrderId);
                    objDeliveryReport.ShowDialog();
                    objDeliveryReport.Dispose();
                }
                else
                {
                    Common.MessageAlert("First Save Delivery Order");
                }
            }
            catch
            {

            }
        }      

        #endregion

        #region Method
        void ControlClear()
        {
            Common objCommon = new Common();
            objCommon.ClearControl(this);
            ListDeliveryOrder.SelectedValue = -1;
          
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        void BindControl()
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;

        }       

        #endregion

        #region ListBox operation
        void FillListBox()
        {
            try
            {
                DeliveryOrderDL objDeliveryOrderDL = new DeliveryOrderDL();
                DataTable dt = objDeliveryOrderDL.GetPurchasesDeliveryOrder(companyEL.Company_id, purchaseOrderEL.Purchases_Order_Id);
               
                ListDeliveryOrder.SelectedValueChanged -= ListPurchaseOrder_SelectedValueChanged;
                ListDeliveryOrder.DataSource = dt;
                ListDeliveryOrder.DisplayMember = "Delivery_No";
                ListDeliveryOrder.ValueMember = "Delivery_Id";
                GridBind();
                ListDeliveryOrder.SelectedValueChanged += ListPurchaseOrder_SelectedValueChanged;                
            }
            catch
            {
            }
        }
        private void ListPurchaseOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            GridBind();
        }

        #endregion

        #region grid operation
        void GridBind()
        {
            dtDeletingDeliveryOrderDetail.Rows.Clear();
            dataGridView1.Rows.Clear();
           
            try
            {
                int DeliveryOrderId = Convert.ToInt32(ListDeliveryOrder.SelectedValue);
                if (DeliveryOrderId <= 0 )
                {
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }
                else
                {
                    BindControl();
                }
                DeliveryOrderDL objDeliveryOrderDL = new DeliveryOrderDL();
                DataTable dt = objDeliveryOrderDL.GetDeliveryOrderDetail(DeliveryOrderId, purchaseOrderEL.Purchases_Order_Id);

                textDeliveryOrderNo.Text = objDeliveryOrderDL.DeliveryOrderNo;
                dateTimePickerDeliveryOrderDate.Value = objDeliveryOrderDL.DeliveryDate;



                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["IS_Item_Deliver"].Value = dt.Rows[i]["IS_Item_Deliver"];
                        dataGridView1.Rows[i].Cells["Delivery_Detail_Id"].Value = dt.Rows[i]["Delivery_Detail_Id"];
                        dataGridView1.Rows[i].Cells["Purchase_Order_Detail_Id"].Value = dt.Rows[i]["Purchase_Order_Detail_Id"];
                        dataGridView1.Rows[i].Cells["Item_Name"].Value = dt.Rows[i]["Item_Name"];
                        dataGridView1.Rows[i].Cells["Item_Quantity"].Value = dt.Rows[i]["Item_Quantity"];
                        dataGridView1.Rows[i].Cells["Item_Rate"].Value = dt.Rows[i]["Item_Rate"];
                        dataGridView1.Rows[i].Cells["Total_Amount"].Value = dt.Rows[i]["Total_Amount"];
                        dataGridView1.Rows[i].Cells["Deliver_Quantity"].Value = dt.Rows[i]["Deliver_Quantity"];
                        dataGridView1.Rows[i].Cells["Gst_Rate"].Value = dt.Rows[i]["Gst_Rate"];


                        if (Convert.ToInt32(dt.Rows[i]["IS_Item_Deliver"]) == 1)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.BurlyWood;
                            
                        }
                    }
                }
            }
            catch
            {
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int DeliveryDetailId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Delivery_Detail_Id"].Value);
                string ItemName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Item_Name"].Value);
                if (DeliveryDetailId > 0)
                {
                    PackagingDetail objPackagingDetail = new PackagingDetail(DeliveryDetailId, this.CompanyName, ItemName);
                    objPackagingDetail.ShowDialog();
                }
                else
                {
                    Common.MessageAlert("First Save This Item In Delivery Order");
                }

            }
        }
        #endregion

     
    }
}