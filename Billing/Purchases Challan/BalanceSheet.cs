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
using Billing.DataLayer;
using Billing;

namespace PurchasesChallan
{
    public partial class BalanceSheet : Form
    {       
        CompanyEL companyEL;
       
        #region constractor
        public BalanceSheet()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);           
        }
        public BalanceSheet(CompanyEL _companyEL)
            : this()
        {
            companyEL = _companyEL;
            
            lbCompanyName.Text = companyEL.company_name;           
            FillListBox();
        }

        #endregion       

        #region listBox Operation 
        void FillListBox()
        {
            dataGridView1.Rows.Clear();
            try
            {
                PurchaseOrderDL objPurchaseOrderDL = new PurchaseOrderDL();
                List<PurchaseOrderEL> lstPurchaseOrderEL = objPurchaseOrderDL.GetPurchasesOrderByComId(companyEL.Company_id);
                List<int> lstCompletePurchaseOrder = objPurchaseOrderDL.GetCompletePurchasesOrder(companyEL.Company_id);

                ListPurchaseOrder.SelectionChanged -= ListPurchaseOrder_SelectedIndexChanged;
                for (int i = 0; i < lstPurchaseOrderEL.Count; i++)
                {
                    ListPurchaseOrder.Rows.Add();
                    ListPurchaseOrder.Rows[i].Cells["Purchases_Order_Id"].Value = lstPurchaseOrderEL[i].Purchases_Order_Id;
                    ListPurchaseOrder.Rows[i].Cells["Company_id"].Value = lstPurchaseOrderEL[i].Company_id;
                    ListPurchaseOrder.Rows[i].Cells["Date"].Value = lstPurchaseOrderEL[i].Date.ToString("dd-MM-yyyy");
                    ListPurchaseOrder.Rows[i].Cells["Purchases_Order_No"].Value = lstPurchaseOrderEL[i].Purchases_Order_No;
                    if (lstCompletePurchaseOrder.Exists( r => lstPurchaseOrderEL[i].Purchases_Order_Id == r))
                    {
                        ListPurchaseOrder.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                        ListPurchaseOrder.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    }
                }
                //GridBind();
                ListPurchaseOrder.SelectionChanged += ListPurchaseOrder_SelectedIndexChanged;
            }
            catch
            {
            }
        }
        private void ListPurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridBind();
        }        
        private void ListPurchaseOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewButtonCell objButton = (DataGridViewButtonCell)ListPurchaseOrder.Rows[e.RowIndex].Cells["ColBtnDetail"];
            objButton.Value = "Detail";
            objButton.Style.ForeColor = Color.Purple;
        }
        private void ListPurchaseOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    PurchaseOrderEL objPurchaseOrderEL = new PurchaseOrderEL();
                    objPurchaseOrderEL.Purchases_Order_Id = Convert.ToInt32(ListPurchaseOrder.SelectedRows[0].Cells["Purchases_Order_Id"].Value);
                    objPurchaseOrderEL.Purchases_Order_No = ListPurchaseOrder.SelectedRows[0].Cells["Purchases_Order_No"].Value.ToString();

                    PurchasesDetailReport objPurchasesDetailReport = new PurchasesDetailReport(companyEL, objPurchaseOrderEL);
                    objPurchasesDetailReport.ShowDialog();
                }
            }
            catch
            {                
            }
        }

        #endregion

        #region grid operation
        void GridBind()
        {
            dataGridView1.Rows.Clear();
            try
            {
                int PurchasesOrderId = Convert.ToInt32(ListPurchaseOrder.SelectedRows[0].Cells["Purchases_Order_Id"].Value);
                PurchaseOrderDL objPurchaseOrderDL = new PurchaseOrderDL();
                DataTable dt = objPurchaseOrderDL.GetBalanceSheet(PurchasesOrderId);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Purchase_Order_Detail_Id"].Value = dt.Rows[i]["Purchase_Order_Detail_Id"];
                        dataGridView1.Rows[i].Cells["Item_Name"].Value = dt.Rows[i]["Item_Name"];
                        dataGridView1.Rows[i].Cells["Item_Quantity"].Value = dt.Rows[i]["Item_Quantity"];
                        dataGridView1.Rows[i].Cells["Item_Rate"].Value = dt.Rows[i]["Item_Rate"];
                        dataGridView1.Rows[i].Cells["Total_Amount"].Value = dt.Rows[i]["Total_Amount"];
                        dataGridView1.Rows[i].Cells["Total_Deliver_Quantity"].Value = dt.Rows[i]["Total_Deliver_Quantity"];
                        dataGridView1.Rows[i].Cells["Total_Balance"].Value = Convert.ToInt32(dt.Rows[i]["Total_Balance"])*-1;
                      
                    }
                }
            }
            catch
            {
            }
        }
        
        #endregion

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrderEL objPurchaseOrderEL = new PurchaseOrderEL();
                objPurchaseOrderEL.Purchases_Order_Id = Convert.ToInt32(ListPurchaseOrder.SelectedRows[0].Cells["Purchases_Order_Id"].Value);
                objPurchaseOrderEL.Purchases_Order_No = Convert.ToString(ListPurchaseOrder.SelectedRows[0].Cells["Purchases_Order_No"].Value);
                              
                DeliveryOrder objDeliveryOrder = new DeliveryOrder(companyEL, objPurchaseOrderEL);
                objDeliveryOrder.MdiParent = this.MdiParent;
                objDeliveryOrder.WindowState = FormWindowState.Maximized;
                objDeliveryOrder.Show();
                this.Dispose();
            }
            catch
            {

            }
        }
       
    }
}