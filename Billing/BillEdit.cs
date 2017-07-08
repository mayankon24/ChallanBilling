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
    public partial class BillEdit : Form
    {
        #region Variable
        BillEL _BillEL = null;

        #endregion
        
        #region constractor
        private BillEdit()
        {          
            InitializeComponent();                   
        }
        public BillEdit(BillEL objBillEL)
            : this()
        {
            _BillEL = objBillEL;
            lbItemName.Text = _BillEL.Bill_No;
            FillComboBox();
            SetControlvalue();

        }

        #endregion

        #region Event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BillEL objBillEL = new BillEL();
            BillDL _BillDL = new BillDL();           
            try
            {
                objBillEL.Bill_Id = _BillEL.Bill_Id;            
                objBillEL.Bill_Date = datePkrBilldate.Value;               
                objBillEL.Bill_Type_Id = Convert.ToInt32(cmbBillType.SelectedValue);               
                objBillEL.Is_Tax_Inclusive = chkTaxInclusive.Checked == true ? (int)enumTaxinclusive.Yes : (int)enumTaxinclusive.No;
                objBillEL.Tax_Percentage = Convert.ToDecimal(txtTaxAnount.Text);
                               
                if (_BillDL.Update(objBillEL))
                {                   
                    Common.MessageUpdate();
                }
            }
            catch (Exception)
            { 
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private function
        private void FillComboBox()
        {            
            BillTypeDL objBillTypeDL = new BillTypeDL();
            cmbBillType.DataSource = objBillTypeDL.GetBillTypeELList();
            cmbBillType.DisplayMember = "Bill_Type_Name";
            cmbBillType.ValueMember = "BillType_Id";           
        }
        private void SetControlvalue()
        {
            BillDL _BillDL = new BillDL();
            BillEL ObjBillEL = _BillDL.GetBillById(_BillEL.Bill_Id);
            datePkrBilldate.Value = ObjBillEL.Bill_Date;
            cmbBillType.SelectedValue = ObjBillEL.Bill_Type_Id;
            txtTaxAnount.Text = ObjBillEL.Tax_Percentage.ToString();
            chkTaxInclusive.Checked = ObjBillEL.Is_Tax_Inclusive == (int)enumTaxinclusive.Yes ? true : false;
        }

        #endregion
    } 
}
