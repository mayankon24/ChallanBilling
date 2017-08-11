using System;
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
using Billing.Entity;
using Billing.DataLayer;
using Billing.Utility;
using GlobleLibrary;
using System.Data.SqlClient;

namespace Billing
{
    public partial class CreateBill : Form
    {
        #region Property
        public TaxAmountEL SelectedTax
        {
            get
            {
                //return (TaxAmountEL)cmbTaxAmount.SelectedItem;
                int TaxAmountId = Convert.ToInt32(cmbTaxAmount.SelectedValue.ToString());
                TaxAmountDL _TaxAmountDL = new TaxAmountDL();
                TaxAmountEL objTaxAmountEL = _TaxAmountDL.GetTaxAmountById(TaxAmountId);
                return objTaxAmountEL;
            }
        }

        public TaxAmountEL CentralSelectedTax
        {
            get
            {
                //return (TaxAmountEL)cmbTaxAmount.SelectedItem;
                int TaxAmountId = Convert.ToInt32(cmbCentralTaxAmount.SelectedValue.ToString());
                TaxAmountDL _TaxAmountDL = new TaxAmountDL();
                TaxAmountEL objTaxAmountEL = _TaxAmountDL.GetTaxAmountById(TaxAmountId);
                return objTaxAmountEL;
            }
        }

        #endregion

        #region Variavle
        CompanyEL objCompanyEL;
        BillEL GlobalBillEL;

        List<BillingDelivertDetailEL> lstBillingDelivertDetail = null;
        List<PurchasesOrderDetailEL> lstPurchasesOrderDetail = null;
        #endregion     

        #region Constructor
        private CreateBill()
        {          
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);
        }
        public CreateBill(CompanyEL _objCompanyEL, BillEL _objBillEL)
            : this()
        {
            if (Properties.Settings.Default.Bill_No_Mannual == 1)
            {
                textInvoiceNo.ReadOnly = false;
            }
            else
            {
                textInvoiceNo.ReadOnly = true;
            }


            this.objCompanyEL = _objCompanyEL;
            this.GlobalBillEL = _objBillEL;
            label1.Text = objCompanyEL.company_name;

            BindGrid();
            FillComboBox();
            if (_objBillEL != null)
            {                
                SetControlvalue(_objBillEL);
                btnCreateBill.Visible = false;
                btnNewBill.Visible = false;
                btnUpdate.Visible = true;
                cmbTaxAmount.Visible = false;
                cmbCentralTaxAmount.Visible = false;
                txtTaxAmount.Visible = true;
                txtCentralTaxAmount.Visible = true;
                txtTaxName.Visible = true;
                txtCentralTaxName.Visible = true;
                cmbBillType.Enabled = false;
                lblBillNo.Visible = true;
                textInvoiceNo.Visible = false;
            }
            else
            {
                btnCreateBill.Visible = true;
                btnNewBill.Visible = false;
                btnUpdate.Visible = false;
                cmbTaxAmount.Visible = true;
                cmbCentralTaxAmount.Visible = true;
                txtTaxAmount.Visible = false;
                txtCentralTaxAmount.Visible = false;
                txtTaxName.Visible = false;
                txtCentralTaxName.Visible = false;
                lblBillNo.Visible = false;
                textInvoiceNo.Visible = true;
            }
        }

        #endregion

        #region Grid Operation

        #region PurchasesOrder DataGrid operation
        void PurchasesOrderGridBind()
        {
            try
            {
                PurchaseOrderDL _PurchaseOrderDL = new PurchaseOrderDL();
                List<int> lstCompletePurchaseOrder = _PurchaseOrderDL.GetCompletePurchasesOrder(objCompanyEL.Company_id);
                var Query = from b in lstBillingDelivertDetail
                            select new { b.Purchases_Order_Id, b.Purchases_Order_No, b.PURCHASES_ORDER_Date  };
               
                grdPurchasesOrder.CellValueChanged -= new DataGridViewCellEventHandler(grdPurchasesOrder_CellValueChanged);
                
                grdPurchasesOrder.Rows.Clear();
                foreach (var pro in Query.Distinct())
                {
                   int index = grdPurchasesOrder.Rows.Add();
                   grdPurchasesOrder.Rows[index].Cells["Purchases_Order_No"].Value = pro.Purchases_Order_No;
                   grdPurchasesOrder.Rows[index].Cells["Date"].Value = pro.PURCHASES_ORDER_Date.ToString("dd-MM-yyyy");
                   grdPurchasesOrder.Rows[index].Cells["Purchases_Order_Id"].Value = pro.Purchases_Order_Id;
                   grdPurchasesOrder.Rows[index].Cells["Select"].Value = false;
                   if (lstCompletePurchaseOrder.Exists(r => pro.Purchases_Order_Id == r))
                   {
                       grdPurchasesOrder.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
                       grdPurchasesOrder.Rows[index].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                   }

                }

                #region purchases order operation
                if (GlobalBillEL != null)
                {
                    List<PurchaseOrderEL> lstPurchaseOrder = _PurchaseOrderDL.GetPurchasesOrderByBillId(GlobalBillEL.Bill_Id);

                    int flag = 0;
                    for (int i = 0; i < lstPurchaseOrder.Count; i++)
                    {
                        flag = 0;
                        for (int j = 0; j < grdPurchasesOrder.Rows.Count; j++)
                        {
                            if ((int)grdPurchasesOrder.Rows[j].Cells["Purchases_Order_Id"].Value == lstPurchaseOrder[i].Purchases_Order_Id)
                            {
                                flag = 1;
                                grdPurchasesOrder.Rows[j].Cells["Select"].Value = true;
                                grdPurchasesOrder.Rows[j].Cells["Select"].ReadOnly = true;
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            int index = grdPurchasesOrder.Rows.Add();
                            grdPurchasesOrder.Rows[index].Cells["Purchases_Order_No"].Value = lstPurchaseOrder[i].Purchases_Order_No;
                            grdPurchasesOrder.Rows[index].Cells["Date"].Value = lstPurchaseOrder[i].Date.ToString("dd-MM-yyyy");
                            grdPurchasesOrder.Rows[index].Cells["Purchases_Order_Id"].Value = lstPurchaseOrder[i].Purchases_Order_Id;
                            grdPurchasesOrder.Rows[index].Cells["Select"].Value = true;
                            grdPurchasesOrder.Rows[index].Cells["Select"].ReadOnly = true;
                            if (lstCompletePurchaseOrder.Exists(r => lstPurchaseOrder[i].Purchases_Order_Id == r))
                            {
                                grdPurchasesOrder.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
                                grdPurchasesOrder.Rows[index].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                            }
                        }
                    }
                }
                #endregion

                grdPurchasesOrder.CellValueChanged += new DataGridViewCellEventHandler(grdPurchasesOrder_CellValueChanged);
            }
            catch
            {
            }           
        }
        private void grdPurchasesOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewButtonCell objButton = (DataGridViewButtonCell)grdPurchasesOrder.Rows[e.RowIndex].Cells["ColBtnDetail"];
            objButton.Value = "Detail";
            //objButton.Style.ForeColor = Color.Purple;
        }
        private void grdPurchasesOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    PurchaseOrderEL objPurchaseOrderEL = new PurchaseOrderEL();
                    objPurchaseOrderEL.Purchases_Order_Id = Convert.ToInt32(grdPurchasesOrder.Rows[e.RowIndex].Cells["Purchases_Order_Id"].Value);
                    objPurchaseOrderEL.Purchases_Order_No = grdPurchasesOrder.Rows[e.RowIndex].Cells["Purchases_Order_No"].Value.ToString();

                    PurchasesDetailReport objPurchasesDetailReport = new PurchasesDetailReport(objCompanyEL, objPurchaseOrderEL);
                    objPurchasesDetailReport.ShowDialog();
                }
            }
            catch
            {
            }
        }
        private void grdPurchasesOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChallanGridBind();
            ItemGridBind();
        }
        private void grdPurchasesOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (grdPurchasesOrder.IsCurrentCellDirty)
            {
                grdPurchasesOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
      

        #endregion        

        #region Challan DataGrid operation
        void ChallanGridBind()
        {
            try
            {
                List<int> SelectedPurchasesOrderId = new List<int>();
                for (int i = 0; i < grdPurchasesOrder.Rows.Count; i++)
                {
                    if ((bool)grdPurchasesOrder.Rows[i].Cells["Select"].Value == true)
                    {
                        SelectedPurchasesOrderId.Add(Convert.ToInt32( grdPurchasesOrder.Rows[i].Cells["Purchases_Order_Id"].Value));
                    }
                }

                var Query = from b in lstBillingDelivertDetail
                            where SelectedPurchasesOrderId.Contains(b.Purchases_Order_Id)
                            select new { b.Delivery_Id, Delivery_no = b.Delivery_No, Delivery_Date = b.Delivery_Date, Purchases_Order_No = b.Purchases_Order_No };


                grdChallan.CellValueChanged -= new DataGridViewCellEventHandler(grdChallan_CellValueChanged);
                grdChallan.Rows.Clear();
                foreach (var item in Query.Distinct())
                {
                    int index = grdChallan.Rows.Add();
                    grdChallan.Rows[index].Cells["Delivery_Id"].Value = item.Delivery_Id;
                    grdChallan.Rows[index].Cells["Delivery_no"].Value = item.Delivery_no;
                    grdChallan.Rows[index].Cells["Delivery_Date"].Value = item.Delivery_Date.ToString("dd/MM/yyyy");
                    grdChallan.Rows[index].Cells["Purchases_Order_No2"].Value = item.Purchases_Order_No;
                    grdChallan.Rows[index].Cells["Select2"].Value = false;
                }

                #region Delivery Operation
                if (GlobalBillEL != null)
                {

                    PurchaseOrderDL _PurchaseOrderDL = new PurchaseOrderDL();
                    DeliveryDL _DeliveryDL = new DeliveryDL();
                    List<DeliveryEL> lstDeliveryOrder = _DeliveryDL.GetDeliveryOrderByBillId(GlobalBillEL.Bill_Id);

                    for (int i = 0; i < lstDeliveryOrder.Count; i++)
                    {
                        int index = grdChallan.Rows.Add();
                        grdChallan.Rows[index].Cells["Delivery_Id"].Value = lstDeliveryOrder[i].Delivery_Id;
                        grdChallan.Rows[index].Cells["Delivery_no"].Value = lstDeliveryOrder[i].Delivery_no;
                        grdChallan.Rows[index].Cells["Delivery_Date"].Value = lstDeliveryOrder[i].Delivery_Date.ToString("dd/MM/yyyy");
                        grdChallan.Rows[index].Cells["Purchases_Order_No2"].Value = _PurchaseOrderDL.GetPurchasesOrderById(lstDeliveryOrder[i].Purchases_Order_Id).Purchases_Order_No;
                        grdChallan.Rows[index].Cells["Select2"].Value = true;
                        grdChallan.Rows[index].Cells["Select2"].ReadOnly = true;
                        grdChallan.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
                        grdChallan.Rows[index].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    
                    }
                }
                #endregion

                grdChallan.CellValueChanged += new DataGridViewCellEventHandler(grdChallan_CellValueChanged);
            }
            catch
            {
            }
        }
        private void grdChallan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ItemGridBind();
        }
        private void grdChallan_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (grdChallan.IsCurrentCellDirty)
            {
                grdChallan.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        
        #endregion        

        #region Item DataGrid operation
        void ItemGridBind()
        {
            try
            {
                List<int> SelectedDeliveryId = new List<int>();
                for (int i = 0; i < grdChallan.Rows.Count; i++)
                {
                    if ((bool)grdChallan.Rows[i].Cells["Select2"].Value == true)
                    {
                        SelectedDeliveryId.Add(Convert.ToInt32(grdChallan.Rows[i].Cells["Delivery_Id"].Value));
                    }
                }
                var Query1 = from b in lstBillingDelivertDetail
                             join pd in lstPurchasesOrderDetail on b.Purchase_Order_Detail_Id equals pd.Purchase_Order_Detail_Id
                             where SelectedDeliveryId.Contains(b.Delivery_Id)
                             select new
                             {
                                 b.Purchases_Order_No,
                                 b.Purchase_Order_Detail_Id,
                                 pd.Item_Name,
                                 pd.Item_Quantity,
                                 pd.Item_Rate,
                                 pd.Total_Amount,
                                 b.Challan_Billing_Quantity,
                                 b.Delivery_No,
                                 b.Delivery_Detail_Id,
                                 b.Deliver_Quantity
                             };

                var Query = from billItem in Query1.Distinct()
                            group billItem by new
                                                {
                                                    billItem.Purchase_Order_Detail_Id,
                                                    billItem.Purchases_Order_No,
                                                    billItem.Item_Name,
                                                    billItem.Item_Quantity,
                                                    billItem.Item_Rate,
                                                    billItem.Total_Amount
                                                }
                                into g
                                select new
                                {
                                    Purchase_Order_Detail_Id = g.Key.Purchase_Order_Detail_Id,
                                    Purchases_Order_No = g.Key.Purchases_Order_No,
                                    Item_Name = g.Key.Item_Name,
                                    Item_Quantity = g.Key.Item_Quantity,
                                    Item_Rate = g.Key.Item_Rate,
                                    Total_Amount = g.Key.Total_Amount,
                                    Total_Deliver_Quantity = g.Sum(r => r.Deliver_Quantity),
                                    DeliveryGroup = g
                                };
                
           
                grdItem.CellValueChanged -= new DataGridViewCellEventHandler(grdItem_CellValueChanged);
                grdItem.Rows.Clear();
                foreach (var item in Query)
                {
                    int index = grdItem.Rows.Add();
                    grdItem.Rows[index].Cells["Purchase_Order_Detail_Id"].Value = item.Purchase_Order_Detail_Id;
                    grdItem.Rows[index].Cells["Purchases_Order_No3"].Value = item.Purchases_Order_No;
                    grdItem.Rows[index].Cells["Item_Name"].Value = item.Item_Name;
                    grdItem.Rows[index].Cells["Item_Quantity"].Value = item.Item_Quantity;
                    grdItem.Rows[index].Cells["Item_Rate"].Value = item.Item_Rate;
                    grdItem.Rows[index].Cells["Total_Amount"].Value = item.Total_Amount;
                    grdItem.Rows[index].Cells["Total_Deliver_Quantity"].Value = item.Total_Deliver_Quantity;
                    grdItem.Rows[index].Cells["Select_Item"].Value = false;

                    string DeliveryNo = "";

                    foreach (var Delivery in item.DeliveryGroup)
                    {
                        DeliveryNo += Delivery.Delivery_No + ", ";
                    }
                    grdItem.Rows[index].Cells["Delivery_no2"].Value = DeliveryNo;
                   //grdItem.Rows[index].Cells["Processed_Billing_Quantity"].Value = item.Challan_Billing_Quantity;
                    //grdItem.Rows[index].Cells["Delivery_Detail_Id"].Value = item.Delivery_Detail_Id;
                }

                #region Item Operation
                if (GlobalBillEL != null)
                {
                    BillDL _BillDL = new BillDL();
                    DataSet ds = _BillDL.GetCreateBillItemByBillId(GlobalBillEL.Bill_Id);
                    DataTable dt = ds.Tables[0];

                    int flag = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        flag = 0;
                        for (int j = 0; j < grdItem.Rows.Count; j++)
                        {
                            if ((int)grdItem.Rows[j].Cells["Purchase_Order_Detail_Id"].Value == (int)dt.Rows[i]["Purchase_Order_Detail_Id"])
                            {
                                flag = 1;
                                grdItem.Rows[j].Cells["Form"].Value = dt.Rows[i]["Form"];
                                grdItem.Rows[j].Cells["Color"].Value = dt.Rows[i]["Color"];
                                grdItem.Rows[j].Cells["rate"].Value = dt.Rows[i]["rate"];
                                grdItem.Rows[j].Cells["Bill_Quantity"].Value = dt.Rows[i]["Bill_Quantity"];
                                grdItem.Rows[j].Cells["Select_Item"].Value = true;

                                string DeliveryNo = "";
                                int Total_Deliver_Quantity = 0;
                                DataTable dt1 = ds.Tables[1].Select("Bill_Item_Id = " + dt.Rows[i]["Bill_Item_Id"]).CopyToDataTable();
                                for (int k = 0; k < dt1.Rows.Count; k++)
                                {
                                    Total_Deliver_Quantity += Convert.ToInt32(dt1.Rows[k]["Deliver_Quantity"]);
                                    DeliveryNo += dt1.Rows[k]["Delivery_No"] + ", ";
                                }
                                grdItem.Rows[j].Cells["Delivery_no2"].Value = grdItem.Rows[j].Cells["Delivery_no2"].Value.ToString() + DeliveryNo;
                                grdItem.Rows[j].Cells["Total_Deliver_Quantity"].Value = (int)grdItem.Rows[j].Cells["Total_Deliver_Quantity"].Value + Total_Deliver_Quantity;
                                grdItem.Rows[j].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
                                grdItem.Rows[j].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            //for (int i = 0; i < dt.Rows.Count; i++)
                            //{
                            int index = grdItem.Rows.Add();
                            grdItem.Rows[index].Cells["Purchase_Order_Detail_Id"].Value = dt.Rows[i]["Purchase_Order_Detail_Id"];
                            grdItem.Rows[index].Cells["Bill_Item_Id"].Value = dt.Rows[i]["Bill_Item_Id"];
                            grdItem.Rows[index].Cells["Purchases_Order_No3"].Value = dt.Rows[i]["Purchases_Order_No"];
                            grdItem.Rows[index].Cells["Item_Name"].Value = dt.Rows[i]["Item_Name"];
                            grdItem.Rows[index].Cells["Item_Quantity"].Value = dt.Rows[i]["Item_Quantity"];
                            grdItem.Rows[index].Cells["Item_Rate"].Value = dt.Rows[i]["Item_Rate"];
                            grdItem.Rows[index].Cells["Total_Amount"].Value = dt.Rows[i]["Total_Amount"];
                            grdItem.Rows[index].Cells["Form"].Value = dt.Rows[i]["Form"];
                            grdItem.Rows[index].Cells["Color"].Value = dt.Rows[i]["Color"];
                            grdItem.Rows[index].Cells["rate"].Value = dt.Rows[i]["rate"];
                            grdItem.Rows[index].Cells["Bill_Quantity"].Value = dt.Rows[i]["Bill_Quantity"];
                            grdItem.Rows[index].Cells["Select_Item"].Value = true;

                            string DeliveryNo = "";
                            int Total_Deliver_Quantity = 0;
                            DataTable dt1 = ds.Tables[1].Select("Bill_Item_Id = " + dt.Rows[i]["Bill_Item_Id"]).CopyToDataTable();
                            for (int j = 0; j < dt1.Rows.Count; j++)
                            {
                                Total_Deliver_Quantity += Convert.ToInt32(dt1.Rows[j]["Deliver_Quantity"]);
                                DeliveryNo += dt1.Rows[j]["Delivery_No"] + ", ";
                            }
                            grdItem.Rows[index].Cells["Delivery_no2"].Value = DeliveryNo;
                            grdItem.Rows[index].Cells["Total_Deliver_Quantity"].Value = Total_Deliver_Quantity;
                            grdItem.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
                            grdItem.Rows[index].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                            //grdItem.Rows[index].Cells["Processed_Billing_Quantity"].Value = item.Challan_Billing_Quantity;
                            //grdItem.Rows[index].Cells["Delivery_Detail_Id"].Value = item.Delivery_Detail_Id;
                            //}
                        }
                    }
                }

                #endregion
                grdItem.CellValueChanged += new DataGridViewCellEventHandler(grdItem_CellValueChanged);
            }
            catch
            {
            }
        }
        private void grdItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewButtonCell objButton = (DataGridViewButtonCell)grdItem.Rows[e.RowIndex].Cells["Sub_Item"];
            objButton.Value = "Sub Item";

            DataGridViewButtonCell objBtnNarration = (DataGridViewButtonCell)grdItem.Rows[e.RowIndex].Cells["Narration"];
            objBtnNarration.Value = "Narration";
        }
        private void grdItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.ColumnIndex == 16)
                {
                    if (grdItem.Rows[e.RowIndex].Cells["Bill_Item_Id"].Value == null)
                    {
                        Common.MessageAlert("First Save This Item ");
                        return;
                    }
                    BillItemEL _BillItemEL = new BillItemEL();
                    _BillItemEL.Bill_Item_Id = Convert.ToInt32(grdItem.Rows[e.RowIndex].Cells["Bill_Item_Id"].Value);
                    _BillItemEL.Bill_Id = GlobalBillEL.Bill_Id;

                    Bill_SubItem objBill_SubItem = new Bill_SubItem(_BillItemEL, objCompanyEL);
                    objBill_SubItem.ShowDialog();
                }
                if (e.ColumnIndex == 17)
                {
                    if (grdItem.Rows[e.RowIndex].Cells["Bill_Item_Id"].Value == null)
                    {
                        Common.MessageAlert("First Save This Item ");
                        return;
                    }
                    BillItemEL _BillItemEL = new BillItemEL();
                    _BillItemEL.Bill_Item_Id = Convert.ToInt32(grdItem.Rows[e.RowIndex].Cells["Bill_Item_Id"].Value);
                    _BillItemEL.Item_Name = grdItem.Rows[e.RowIndex].Cells["Item_Name"].Value.ToString();
                    _BillItemEL.Bill_Id = GlobalBillEL.Bill_Id;        

                    BillItemNarration objBillItemNarration = new BillItemNarration(_BillItemEL);
                    objBillItemNarration.ShowDialog();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void grdItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // ChallanGridBind();
        }
       
        #endregion        

        #endregion

        #region Private Function
        private void GetGlobalVariableData()
        {            
            BillingDelivertDetailDL objBillingDelivertDetailDL = new BillingDelivertDetailDL();
            lstBillingDelivertDetail = objBillingDelivertDetailDL.GetUnProcessBillingDeliver(objCompanyEL);
            lstBillingDelivertDetail = lstBillingDelivertDetail.Where(r => r.PURCHASES_ORDER_Date > Properties.Settings.Default.Create_Bill_Start_Date).ToList();


            PurchasesOrderDetailDL objPurchasesOrderDetailDL = new PurchasesOrderDetailDL();
            lstPurchasesOrderDetail = objPurchasesOrderDetailDL.GetPurchasesOrderDetail();
        }
        private void FillComboBox()
        {
            cmbBillType.SelectedIndexChanged -= cmbBillType_SelectedIndexChanged;
            BillTypeDL objBillTypeDL = new BillTypeDL();
            cmbBillType.DataSource = objBillTypeDL.GetBillTypeELList();
            cmbBillType.DisplayMember = "Bill_Type_Name";
            cmbBillType.ValueMember = "BillType_Id";
            cmbBillType.SelectedIndexChanged += cmbBillType_SelectedIndexChanged;

            TaxAmountDL objTaxAmountDL = new TaxAmountDL();
            List<TaxAmountEL> lstTaxAmountEL = objTaxAmountDL.GetTaxAmountList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("TaxAmount", typeof(string));

            foreach (TaxAmountEL TaxAmount in lstTaxAmountEL)
            {
                //if (TaxAmount.Tax_Amout == null)
                //{
                //    dt.Rows.Add(TaxAmount.Tax_Amout, "Inclusive");
                //}
                //else
                //{
                    dt.Rows.Add(TaxAmount.Tax_Amout_Id, TaxAmount.Tax_Name.ToString()+ "  " + TaxAmount.Tax_Amout.ToString());
                //}
            }


            DataTable dt1 = dt.Copy();

            cmbTaxAmount.DataSource = dt;
            cmbTaxAmount.DisplayMember = "TaxAmount";
            cmbTaxAmount.ValueMember = "Id";


            cmbCentralTaxAmount.DataSource = dt1;
            cmbCentralTaxAmount.DisplayMember = "TaxAmount";
            cmbCentralTaxAmount.ValueMember = "Id";
        }
        private List<DeliveryDetailEL> GetDeliveryDetailList(int SelectedPurchase_Order_Detail_Id)
        {
            List<int> SelectedDeliveryId = new List<int>();
            for (int i = 0; i < grdChallan.Rows.Count; i++)
            {
                if ((bool)grdChallan.Rows[i].Cells["Select2"].Value == true)
                {
                    SelectedDeliveryId.Add(Convert.ToInt32(grdChallan.Rows[i].Cells["Delivery_Id"].Value));
                }
            }
            var Query = from b in lstBillingDelivertDetail
                        join pd in lstPurchasesOrderDetail on b.Purchase_Order_Detail_Id equals pd.Purchase_Order_Detail_Id
                        where SelectedDeliveryId.Contains(b.Delivery_Id) && (b.Purchase_Order_Detail_Id == SelectedPurchase_Order_Detail_Id)
                        select new
                        {
                            b.Purchases_Order_No,
                            b.Purchase_Order_Detail_Id,
                            pd.Item_Name,
                            pd.Item_Quantity,
                            pd.Item_Rate,
                            pd.Total_Amount,
                            b.Challan_Billing_Quantity,
                            b.Delivery_No,
                            b.Delivery_Detail_Id,
                            b.Deliver_Quantity,
                            b.Purchases_Order_Id,
                            b.Delivery_Id
                        };

            List<DeliveryDetailEL> lstDeliveryDetail = new List<DeliveryDetailEL>();
            DeliveryDetailEL objDeliveryDetailEL;

            foreach (var item in Query)
            {
                objDeliveryDetailEL = new DeliveryDetailEL();
                objDeliveryDetailEL.Delivery_Detail_Id = item.Delivery_Detail_Id;
                objDeliveryDetailEL.Deliver_Quantity = item.Deliver_Quantity;
                objDeliveryDetailEL.Delivery_Id = item.Delivery_Id;
                objDeliveryDetailEL.Purchase_Order_Detail_Id = item.Purchase_Order_Detail_Id;
                objDeliveryDetailEL.Purchases_Order_Id = item.Purchases_Order_Id;
                lstDeliveryDetail.Add(objDeliveryDetailEL);

            }
            return lstDeliveryDetail;


            //var Query = from billItem in Query1.Distinct()
            //            group billItem by new
            //            {
            //                billItem.Purchase_Order_Detail_Id,
            //                billItem.Purchases_Order_No,
            //                billItem.Item_Name,
            //                billItem.Item_Quantity,
            //                billItem.Item_Rate,
            //                billItem.Total_Amount
            //            }
            //                into g
            //                select new
            //                {
            //                    Purchase_Order_Detail_Id = g.Key.Purchase_Order_Detail_Id,
            //                    Purchases_Order_No = g.Key.Purchases_Order_No,
            //                    Item_Name = g.Key.Item_Name,
            //                    Item_Quantity = g.Key.Item_Quantity,
            //                    Item_Rate = g.Key.Item_Rate,
            //                    Total_Amount = g.Key.Total_Amount,
            //                    Total_Deliver_Quantity = g.Sum(r => r.Deliver_Quantity),
            //                    DeliveryGroup = g
            //                };
        }
        private void cmbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (  ((BillTypeEL)cmbBillType.SelectedItem).BillType_Id == (int)enumBillType.RetailInvoice)
            //{
            //    chkTaxApplicable.Checked = false;
            //    chkTaxApplicable.Enabled = false;
            //    textTaxPercentage.Text = "";
            //    textTaxPercentage.Enabled = false;
            //}
            //if (((BillTypeEL)cmbBillType.SelectedItem).BillType_Id == (int)enumBillType.TaxInvoice)
            //{
            //    chkTaxApplicable.Checked = false;
            //    chkTaxApplicable.Enabled = true;
            //    textTaxPercentage.Text = "";
            //    textTaxPercentage.Enabled = false;
            //}
        }
        private bool validateFinancialYear()
        {
            DateTime financialYearStartDate;
            if (GlobalBillEL.Bill_Date.Month >= 4)
            {
                financialYearStartDate = new DateTime(GlobalBillEL.Bill_Date.Year, 4, 1);
            }
            else
            {
                financialYearStartDate = new DateTime(GlobalBillEL.Bill_Date.Year - 1, 4, 1);
            }


            if (datePkrBilldate.Value >= financialYearStartDate && datePkrBilldate.Value <= new DateTime(financialYearStartDate.Year + 1, 3, 31))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clearControl()
        {
            btnCreateBill.Visible = true;
            btnNewBill.Visible = false;
            //btnUpdate.Visible = false;

            GetGlobalVariableData();
            grdItem.Rows.Clear();
            grdChallan.Rows.Clear();            
            PurchasesOrderGridBind();
            ChallanGridBind();
            ItemGridBind();
        }
        private void SetControlvalue(BillEL ObjBillEL)
        {
            lblBillNo.Text = "Bill No : " + ObjBillEL.Bill_No;
            datePkrBilldate.Value = ObjBillEL.Bill_Date;
            cmbBillType.SelectedValue = ObjBillEL.Bill_Type_Id;
            txtTaxAmount.Text = ObjBillEL.Tax_Percentage.ToString();
            txtCentralTaxAmount.Text = ObjBillEL.Central_Tax_Percentage.ToString();
            txtTaxName.Text = ObjBillEL.Tax_Name;
            txtCentralTaxName.Text = ObjBillEL.Central_Tax_Name;
            chkTaxInclusive.Checked = ObjBillEL.Is_Tax_Inclusive == (int)enumTaxinclusive.Yes ? true : false;
            txtCartage.Text = ObjBillEL.Cartage.ToString();
            txtDiscount.Text = ObjBillEL.Discount.ToString();
        }
        private void BindGrid()
        {
            GetGlobalVariableData();
            PurchasesOrderGridBind();
            ChallanGridBind();
            ItemGridBind();
        }

        #endregion

        #region Event
        #region Functionality Event 
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                BillEL objBillEL = new BillEL();
                BillDL objBillDL = new BillDL();
                BillItemDL objBillItemDL = new BillItemDL();
                BillItemEL objBillItemEL;
                BillDetailDL objBillDetailDL = new BillDetailDL();
                BillDetailEL objBillDetailEL = new BillDetailEL();

                List<BillItemEL> lstBillItemEL = new List<BillItemEL>();
                Dictionary<int, List<DeliveryDetailEL>> Dic_DeliveryGroup = new Dictionary<int, List<DeliveryDetailEL>>();

                for (int i = 0; i < grdItem.Rows.Count; i++)
                {
                    if ((bool)grdItem.Rows[i].Cells["Select_Item"].Value == true)
                    {
                        double billQuantity = Convert.ToDouble(grdItem.Rows[i].Cells["Bill_Quantity"].Value);
                        double TotalDeliverQuantity = Convert.ToDouble(grdItem.Rows[i].Cells["Total_Deliver_Quantity"].Value);
                        double Processed_Billing_Quantity = Convert.ToDouble(grdItem.Rows[i].Cells["Processed_Billing_Quantity"].Value);
                        string IteamName = grdItem.Rows[i].Cells["Item_Name"].Value.ToString();
                        if (billQuantity > TotalDeliverQuantity - Processed_Billing_Quantity)
                        {
                            //Common.MessageAlert("Bll Quantity is More Than Remaing Billing Quantity for Item " + IteamName);
                            //return;
                        }

                        int Purchase_Order_Detail_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        List<DeliveryDetailEL> DeliveryDetailGroup = GetDeliveryDetailList(Purchase_Order_Detail_Id);
                        Dic_DeliveryGroup.Add(Purchase_Order_Detail_Id, DeliveryDetailGroup);

                        objBillItemEL = new BillItemEL();
                        objBillItemEL.Purchase_Order_Detail_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        objBillItemEL.Quantity = billQuantity;
                        objBillItemEL.Rate = Convert.ToDecimal(grdItem.Rows[i].Cells["Rate"].Value);
                        objBillItemEL.Color = Convert.ToInt32(grdItem.Rows[i].Cells["Color"].Value);
                        objBillItemEL.Form = Convert.ToDecimal(grdItem.Rows[i].Cells["Form"].Value);
                        objBillItemEL.Parent_Id = null;
                        lstBillItemEL.Add(objBillItemEL);
                    }
                }
                if (lstBillItemEL.Count <= 0)
                {
                    Common.MessageAlert("Please Select Item From Item Grid");
                    return;
                }

                if (textInvoiceNo.Text.Trim() != "")
                {
                    try
                    {
                        objBillEL.Bill_No = Convert.ToInt32(textInvoiceNo.Text).ToString();
                    }
                    catch (Exception)
                    {
                        Common.MessageAlert("Please enter integer value for bill no");
                        return;
                    }                    
                }
                objBillEL.Bill_Date = datePkrBilldate.Value;                
                objBillEL.Bill_Type_Id = Convert.ToInt32(cmbBillType.SelectedValue);
                objBillEL.Company_id = objCompanyEL.Company_id;
                objBillEL.Is_Tax_Inclusive = chkTaxInclusive.Checked == true ? (int)enumTaxinclusive.Yes : (int)enumTaxinclusive.No;
                decimal Cartage;
                objBillEL.Cartage = decimal.TryParse(txtCartage.Text, out Cartage) == true ? Cartage : 0;
                decimal Discount;
                objBillEL.Discount = decimal.TryParse(txtDiscount.Text, out Discount) == true ? Discount : 0;// (decimal?)null;
                objBillEL.Tax_Percentage = SelectedTax.Tax_Amout;
                objBillEL.Central_Tax_Percentage = CentralSelectedTax.Tax_Amout;
                objBillEL.Tax_Name = SelectedTax.Tax_Name;
                objBillEL.Central_Tax_Name = CentralSelectedTax.Tax_Name;

                //decimal taxPercentage;
                //if (decimal.TryParse(cmbTaxAmount.Text, out taxPercentage))
                //{
                //    objBillEL.Tax_Percentage = taxPercentage;
                //}
                //else
                //{
                //    objBillEL.Tax_Percentage = null;
                //}

                SQLHelper objSQLHelper = new SQLHelper();
                SqlTransaction tran = objSQLHelper.BeginTrans();
                try
                {
                    DateTime billMaxDate = objBillDL.GetLastBilldate(objBillEL);
                    if (objBillEL.Bill_Date.Date < billMaxDate.Date  )
                    {
                        Common.MessageAlert("Bill date can not smaller than last bill date: " + billMaxDate.ToString("dd MMM, yyy"));
                        return;
                    }

                    int billid = objBillDL.Insert(tran, objBillEL);
                    objBillEL.Bill_Id = billid;

                    foreach (var BillItem in lstBillItemEL)
                    {
                        BillItem.Bill_Id = billid;
                        int BillItemId = objBillItemDL.Insert(tran, BillItem);
                        List<DeliveryDetailEL> lstDeliveryDetail = Dic_DeliveryGroup.First(r => r.Key == BillItem.Purchase_Order_Detail_Id).Value;

                        foreach (var DeliveryDetail in lstDeliveryDetail)
                        {
                            objBillDetailEL.Bill_Item_Id = BillItemId;
                            objBillDetailEL.Delivery_Detail_Id = DeliveryDetail.Delivery_Detail_Id;
                            objBillDetailEL.Quantity = DeliveryDetail.Deliver_Quantity;
                            objBillDetailDL.Insert(tran, objBillDetailEL);
                        }
                    }
                    tran.Commit();

                    GlobalBillEL = objBillEL;
                    BindGrid();
                    btnCreateBill.Visible = false;
                    btnNewBill.Visible = true;
                    Common.MessageSave();
                }
                catch
                {
                    tran.Rollback();
                }
            }
            catch (Exception)
            {

                Common.MessageAlert("Input data not in correct format ");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Close")
            {
                this.Close();
                return;
            }
            
            try
            {
                BillEL objBillEL = new BillEL();
                BillDL objBillDL = new BillDL();
                BillItemDL objBillItemDL = new BillItemDL();
                BillItemEL objBillItemEL;
                BillDetailDL objBillDetailDL = new BillDetailDL();
                BillDetailEL objBillDetailEL = new BillDetailEL();

                List<BillItemEL> lstInserting_BillItemEL = new List<BillItemEL>();
                List<BillItemEL> lstUpdating_BillItemEL = new List<BillItemEL>();
                List<BillItemEL> lstDeleting_BillItemEL = new List<BillItemEL>();
                Dictionary<int, List<DeliveryDetailEL>> Dic_DeliveryGroup = new Dictionary<int, List<DeliveryDetailEL>>();

                for (int i = 0; i < grdItem.Rows.Count; i++)
                {
                    if ((bool)grdItem.Rows[i].Cells["Select_Item"].Value == true &&  grdItem.Rows[i].Cells["Bill_Item_Id"].Value == null  )
                    {
                        double billQuantity = Convert.ToDouble(grdItem.Rows[i].Cells["Bill_Quantity"].Value);
                        double TotalDeliverQuantity = Convert.ToDouble(grdItem.Rows[i].Cells["Total_Deliver_Quantity"].Value);
                        double Processed_Billing_Quantity = Convert.ToDouble(grdItem.Rows[i].Cells["Processed_Billing_Quantity"].Value);
                        string IteamName = grdItem.Rows[i].Cells["Item_Name"].Value.ToString();
                        if (billQuantity > TotalDeliverQuantity - Processed_Billing_Quantity)
                        {
                            //Common.MessageAlert("Bll Quantity is More Than Remaing Billing Quantity for Item " + IteamName);
                            //return;
                        }

                        int Purchase_Order_Detail_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        List<DeliveryDetailEL> DeliveryDetailGroup = GetDeliveryDetailList(Purchase_Order_Detail_Id);
                        Dic_DeliveryGroup.Add(Purchase_Order_Detail_Id, DeliveryDetailGroup);

                        objBillItemEL = new BillItemEL();
                        objBillItemEL.Purchase_Order_Detail_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        objBillItemEL.Quantity = billQuantity;
                        objBillItemEL.Rate = Convert.ToDecimal(grdItem.Rows[i].Cells["Rate"].Value);
                        objBillItemEL.Color = Convert.ToInt32(grdItem.Rows[i].Cells["Color"].Value);
                        objBillItemEL.Form = Convert.ToDecimal(grdItem.Rows[i].Cells["Form"].Value);
                        objBillItemEL.Parent_Id = null;
                        lstInserting_BillItemEL.Add(objBillItemEL);
                    }
                    else if ((bool)grdItem.Rows[i].Cells["Select_Item"].Value == true && grdItem.Rows[i].Cells["Bill_Item_Id"].Value != null)
                    {
                        objBillItemEL = new BillItemEL();
                        objBillItemEL.Bill_Item_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Bill_Item_Id"].Value);
                        objBillItemEL.Purchase_Order_Detail_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        objBillItemEL.Quantity = Convert.ToDouble(grdItem.Rows[i].Cells["Bill_Quantity"].Value);
                        objBillItemEL.Rate = Convert.ToDecimal(grdItem.Rows[i].Cells["Rate"].Value);
                        objBillItemEL.Color = Convert.ToInt32(grdItem.Rows[i].Cells["Color"].Value);
                        objBillItemEL.Form = Convert.ToDecimal(grdItem.Rows[i].Cells["Form"].Value);
                        objBillItemEL.Parent_Id = null;
                        lstUpdating_BillItemEL.Add(objBillItemEL);
                    }
                    else if ((bool)grdItem.Rows[i].Cells["Select_Item"].Value == false && grdItem.Rows[i].Cells["Bill_Item_Id"].Value != null)
                    {
                        objBillItemEL = new BillItemEL();
                        objBillItemEL.Bill_Item_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Bill_Item_Id"].Value);
                        objBillItemEL.Purchase_Order_Detail_Id = Convert.ToInt32(grdItem.Rows[i].Cells["Purchase_Order_Detail_Id"].Value);
                        objBillItemEL.Quantity = Convert.ToDouble(grdItem.Rows[i].Cells["Bill_Quantity"].Value);
                        objBillItemEL.Rate = Convert.ToDecimal(grdItem.Rows[i].Cells["Rate"].Value);
                        objBillItemEL.Color = Convert.ToInt32(grdItem.Rows[i].Cells["Color"].Value);
                        objBillItemEL.Form = Convert.ToDecimal(grdItem.Rows[i].Cells["Form"].Value);
                        objBillItemEL.Parent_Id = null;
                        lstDeleting_BillItemEL.Add(objBillItemEL);  
                    }
                }
                if (lstInserting_BillItemEL.Count <= 0 && lstDeleting_BillItemEL.Count <= 0 && lstUpdating_BillItemEL.Count <= 0)
                {
                    Common.MessageAlert("Please Select Item From Item Grid");
                    return;
                }

                objBillEL.Bill_Date = datePkrBilldate.Value;
                objBillEL.Bill_No = textInvoiceNo.Text;
                objBillEL.Bill_Type_Id = Convert.ToInt32(cmbBillType.SelectedValue);
                objBillEL.Company_id = objCompanyEL.Company_id;
                objBillEL.Is_Tax_Inclusive = chkTaxInclusive.Checked == true ? (int)enumTaxinclusive.Yes : (int)enumTaxinclusive.No;
                objBillEL.Tax_Name = txtTaxName.Text.Trim();
                objBillEL.Central_Tax_Name = txtCentralTaxName.Text.Trim();
                try
                {
                    objBillEL.Tax_Percentage = Convert.ToDecimal(txtTaxAmount.Text);
                    objBillEL.Central_Tax_Percentage = Convert.ToDecimal(txtCentralTaxAmount.Text);
                }
                catch (Exception)
                {
                    Common.MessageAlert("Tax Amount not in decimal format");
                    return;
                }
               
                decimal Cartage;
                objBillEL.Cartage = decimal.TryParse(txtCartage.Text, out Cartage) == true ? Cartage : 0;
                decimal Discount;
                objBillEL.Discount = decimal.TryParse(txtDiscount.Text, out Discount) == true ? Discount : 0;


                #region Get Deleting list of narration, Item Detail, item SubItem
                BillItemNarrationDL _BillItemNarrationDL = new BillItemNarrationDL();
                List<BillDetailEL> lstDeleting_BillDetail = new List<BillDetailEL>();
                List<BillItemEL> lstSub_BillItem = new List<BillItemEL>();
                List<BillItemNarrationEL> latDeleting_BillItemNarration = new List<BillItemNarrationEL>();
                foreach (var BillItem in lstDeleting_BillItemEL)
                {
                    lstDeleting_BillDetail.AddRange(objBillDetailDL.GetBillDetailBy_BillItemId(BillItem.Bill_Item_Id));
                    lstSub_BillItem.AddRange(objBillItemDL.GetBillItemBy_ParentId(BillItem.Bill_Item_Id));
                }
                lstDeleting_BillItemEL.AddRange(lstSub_BillItem);
                foreach (var BillItem in lstDeleting_BillItemEL)
                {
                    latDeleting_BillItemNarration.AddRange(_BillItemNarrationDL.GetBillItemNarrationBy_BillItemId(BillItem.Bill_Item_Id));
                }

                #endregion

                SQLHelper objSQLHelper = new SQLHelper();
                SqlTransaction tran = objSQLHelper.BeginTrans();
                try
                {
                    objBillEL.Bill_Id = GlobalBillEL.Bill_Id;
                    // validate FinancialYear of bill 
                    if (!validateFinancialYear())
                    {
                        Common.MessageAlert("You can not change financial year of bill" );
                        return;
                    }
                    
                    // validate bill date bill 
                    DataTable dt = objBillDL.Get_Previous_Next_Billdate(objBillEL);
                    DateTime lowerDate = new DateTime(1900, 1, 1);
                    DateTime upperDate = new DateTime(objBillEL.Bill_Date.Year +1, 3, 31);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].GetType() != typeof(DBNull))
                        {
                            lowerDate = Convert.ToDateTime(dt.Rows[0][0]);
                        }
                        if (dt.Rows[0][1].GetType() != typeof(DBNull))
                        {
                            upperDate = Convert.ToDateTime(dt.Rows[0][1]);
                        }
                        
                    }

                    if (!(objBillEL.Bill_Date.Date >= lowerDate.Date && objBillEL.Bill_Date.Date <= upperDate.Date))
                    {
                        Common.MessageAlert("Bill date should be between range of " + lowerDate.ToString("dd MMM, yyy") + " to " +  upperDate.ToString("dd MMM, yyy") );
                        return;
                    }
                    // update bill 
                    
                    objBillDL.Update(tran, objBillEL);                  

                    //for insert bill item
                    foreach (var BillItem in lstInserting_BillItemEL)
                    {
                        BillItem.Bill_Id = GlobalBillEL.Bill_Id;
                        int BillItemId = objBillItemDL.Insert(tran, BillItem);
                        List<DeliveryDetailEL> lstDeliveryDetail = Dic_DeliveryGroup.First(r => r.Key == BillItem.Purchase_Order_Detail_Id).Value;

                        foreach (var DeliveryDetail in lstDeliveryDetail)
                        {
                            objBillDetailEL.Bill_Item_Id = BillItemId;
                            objBillDetailEL.Delivery_Detail_Id = DeliveryDetail.Delivery_Detail_Id;
                            objBillDetailEL.Quantity = DeliveryDetail.Deliver_Quantity;
                            objBillDetailDL.Insert(tran, objBillDetailEL);
                        }
                    }
                    //for update bill item
                    lstUpdating_BillItemEL.ForEach(r=> objBillItemDL.Update(tran, r));                    
                    
                    //For delete operation 
                    latDeleting_BillItemNarration.ForEach(r => _BillItemNarrationDL.Delete(tran, r));
                    lstDeleting_BillDetail.ForEach(r => objBillDetailDL.Delete(tran, r));
                    lstDeleting_BillItemEL.ForEach(r => objBillItemDL.Delete(tran, r));

                    tran.Commit();

                    btnUpdate.Text = "Close";
                    BindGrid();
                    Common.MessageUpdate();
                }
                catch
                {
                    tran.Rollback();
                }
            }
            catch (Exception)
            {
                Common.MessageAlert("Input data not in correct format ");
            }
        }

       
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            GlobalBillEL = null;
            BindGrid();
            btnNewBill.Visible = false;
            btnCreateBill.Visible = true; 
        }       
        #endregion

        private void lnkTaxEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaxAmount objTaxAmount = new TaxAmount();
            DialogResult = objTaxAmount.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                FillComboBox();
            }
        }

        #endregion
    }
}
