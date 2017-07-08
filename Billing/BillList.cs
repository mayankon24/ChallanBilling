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
    public partial class BillList : Form
    {
        #region Variavle
        CompanyEL companyEL;
        #endregion     

        #region Constructor
        private BillList()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);
        }
        public BillList(CompanyEL _objCompanyEL)
            : this()
        {
            this.companyEL = _objCompanyEL;
            lblCompanyName.Text = companyEL.company_name;           
          
            GridBind();
        }

        #endregion
        
        #region Grid operation
        void GridBind()
        {
            BillDL objBillDL = new BillDL();
            List<BillEL> lstBill = objBillDL.GetBillByCompanyId(companyEL.Company_id);
           
            dataGridView1.Rows.Clear();
            try
            {
                for (int i = 0; i < lstBill.Count; i++)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["Bill_Date"].Value = lstBill[i].Bill_Date.ToString("dd-MM-yyyy");
                    dataGridView1.Rows[index].Cells["Bill_Id"].Value = lstBill[i].Bill_Id;
                    dataGridView1.Rows[index].Cells["Bill_No"].Value = lstBill[i].Bill_No;
                    dataGridView1.Rows[index].Cells["Is_Tax_Inclusive"].Value = lstBill[i].Is_Tax_Inclusive == (int)enumTaxinclusive.Yes ? "yes" : "No";
                    dataGridView1.Rows[index].Cells["Tax_Name"].Value = lstBill[i].Tax_Name;
                    dataGridView1.Rows[index].Cells["Tax_Percentage"].Value = lstBill[i].Tax_Percentage;
                    dataGridView1.Rows[index].Cells["Cartage"].Value = lstBill[i].Cartage;
                    dataGridView1.Rows[index].Cells["Discount"].Value = lstBill[i].Discount;

                    switch (lstBill[i].Bill_Type_Id)
                    {
                        case (int)enumBillType.RetailInvoice_Jobwork:
                            {
                                dataGridView1.Rows[index].Cells["Bill_Type_Id"].Value = "Retail Invoice Jobwork";
                                break;
                            }
                        case (int)enumBillType.RetailInvoice_Sale:
                            {
                                dataGridView1.Rows[index].Cells["Bill_Type_Id"].Value = "Retail Invoice Sale";
                                break;
                            }
                        case (int)enumBillType.TaxInvoice_Jobwork:
                            {
                                dataGridView1.Rows[index].Cells["Bill_Type_Id"].Value = "Tax Invoice Jobwork";
                                break;
                            }
                        case (int)enumBillType.TaxInvoice_Sale:
                            {
                                dataGridView1.Rows[index].Cells["Bill_Type_Id"].Value = "Tax Invoice Sale";
                                break;
                            }
                    }
                }
            }
            catch
            {
            }
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewButtonCell objButton = (DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells["Print"];
            objButton.Value = "Print";
            objButton.Style.ForeColor = Color.Purple;

            DataGridViewButtonCell ButDelete = (DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells["Delete"];
            ButDelete.Value = "Delete";
            ButDelete.Style.ForeColor = Color.Purple;

            DataGridViewButtonCell ButEditBill = (DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells["EditBill"];
            ButEditBill.Value = "Edit Bill";
            ButEditBill.Style.ForeColor = Color.Purple;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9) // for print
                {
                    BillEL objBillEL = new BillEL();
                    objBillEL.Bill_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Bill_Id"].Value);
                   
                    BillReportViewer objBillReportViewer = new BillReportViewer(companyEL, objBillEL);
                    objBillReportViewer.ShowDialog();
                    objBillReportViewer.Dispose();
                }
                if (e.ColumnIndex == 10) //For Delete
                {
                    if (Common.MessageConfim("Are You Want To Delete This "))
                    {
                        SQLHelper objSQLHelper = new SQLHelper();
                        SqlTransaction objSqlTransaction = objSQLHelper.BeginTrans();

                        BillDL objBillDL = new BillDL();
                        BillEL objBillEL = new BillEL();
                        objBillEL.Bill_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Bill_Id"].Value);

                        BillDetailDL objBillDetailDL = new BillDetailDL();
                        List<BillDetailEL> lstBillDetail = objBillDetailDL.GetBillDetailByBillId(objBillEL.Bill_Id);


                        BillItemDL objBillItemDL = new BillItemDL();
                        List<BillItemEL> lstBillItemEL = objBillItemDL.GetBillItemByBillId(objBillEL.Bill_Id);

                        BillItemNarrationDL _BillItemNarrationDL = new BillItemNarrationDL();
                        List<BillItemNarrationEL> lstBillItemNarration = new List<BillItemNarrationEL>();


                        try
                        {
                            lstBillItemEL.ForEach(r => lstBillItemNarration.AddRange(_BillItemNarrationDL.GetBillItemNarrationBy_BillItemId(r.Bill_Item_Id)));
                            
                            
                            lstBillItemNarration.ForEach(n => _BillItemNarrationDL.Delete(objSqlTransaction, n));
                            lstBillDetail.ForEach(r=> objBillDetailDL.Delete(objSqlTransaction, r));
                            lstBillItemEL.ForEach(r => objBillItemDL.Delete(objSqlTransaction, r));
                           
                            objBillDL.Delete(objSqlTransaction, objBillEL);

                            objSqlTransaction.Commit();
                            Common.MessageDelete();
                            GridBind();                           
                        }
                        catch (Exception)
                        {
                            objSqlTransaction.Rollback();
                        }
                    }
                }                
                if (e.ColumnIndex == 11)//For bill Edit
                {
                    BillDL _BillDL = new BillDL();
                    BillEL objBillEL = _BillDL.GetBillById(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Bill_Id"].Value));

                    CreateBill objCreateBill = new CreateBill(companyEL, objBillEL);
                    objCreateBill.ControlBox = true;
                    objCreateBill.MinimizeBox = false;

                    objCreateBill.ShowDialog();
                    GridBind();
                }
            }
            catch
            {
            }
        }
        
        #endregion               
    }
}
