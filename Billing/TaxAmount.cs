using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using GlobleLibrary;
using Billing.DataLayer;
using Billing.Entity;
using Billing.Utility;

namespace Billing
{
    public partial class TaxAmount : Form
    { 
        #region Constructor
        public TaxAmount()
        {
            InitializeComponent();
            Common objCommon = new Common();
            objCommon.SetStyle(this);

            GridBind();
            ControlClear();
        }

        #endregion

        #region Property
        public TaxAmountEL DataGridViewSelectedTax
        {
            get
            {
                TaxAmountEL objTaxAmountEL = new TaxAmountEL();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    objTaxAmountEL.Tax_Amout_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Tax_Amout_Id"].Value);
                    objTaxAmountEL.Tax_Amout = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Tax_Amout"].Value);
                    objTaxAmountEL.Tax_Name = dataGridView1.SelectedRows[0].Cells["Tax_Name"].Value.ToString();
                }
                return objTaxAmountEL;
            }
        }

        #endregion
       
        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTaxName.Text.Trim()))
                {
                    Common.MessageAlert("First Enter Tax Name");
                    return;
                }

                decimal TaxAmount;
                if (!decimal.TryParse(txtAmount.Text.Trim(), out TaxAmount))
                {
                    Common.MessageAlert("TaxAmount should be an integer");
                    return;
                }

                TaxAmountEL objTaxAmountEL = new TaxAmountEL();
                TaxAmountDL objTaxAmountDL = new TaxAmountDL();

                objTaxAmountEL.Tax_Name = txtTaxName.Text;
                objTaxAmountEL.Tax_Amout = TaxAmount;

                if (objTaxAmountDL.Insert(objTaxAmountEL))
                {
                    Common.MessageSave();
                    GridBind();
                    ControlClear();
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
                if (string.IsNullOrEmpty(txtTaxName.Text.Trim()))
                {
                    Common.MessageAlert("First Enter Tax Name");
                    return;
                }

                decimal TaxAmount;
                if (!decimal.TryParse(txtAmount.Text.Trim(), out TaxAmount))
                {
                    Common.MessageAlert("TaxAmount should be an integer");
                    return;
                }

                TaxAmountEL objTaxAmountEL = new TaxAmountEL();
                TaxAmountDL objTaxAmountDL = new TaxAmountDL();

                objTaxAmountEL.Tax_Name = txtTaxName.Text;
                objTaxAmountEL.Tax_Amout = TaxAmount;
                objTaxAmountEL.Tax_Amout_Id = DataGridViewSelectedTax.Tax_Amout_Id;

                if (objTaxAmountDL.Update(objTaxAmountEL))
                {
                    Common.MessageUpdate();
                    GridBind();
                    ControlClear();
                }
            }
            catch
            {
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Private Method
        void ControlClear()
        {
            Common objCommon = new Common();
            objCommon.ClearControl(this);
          
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }
        void BindControl()
        {
            try
            {
                TaxAmountEL objTaxAmountEL = DataGridViewSelectedTax;
                txtTaxName.Text = objTaxAmountEL.Tax_Name;
                txtAmount.Text = objTaxAmountEL.Tax_Amout.ToString();
               
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
            catch
            {
                ControlClear();
            }

        }
        #endregion

        #region DataGrid operation
        void GridBind()
        {
            try
            {                
                TaxAmountDL objTaxAmountDL = new TaxAmountDL();
                List<TaxAmountEL> lstTaxAmountEL = objTaxAmountDL.GetTaxAmountList();
                
                dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
                dataGridView1.Click -= dataGridView1_Click;
                dataGridView1.Rows.Clear();
                for (int i = 0; i < lstTaxAmountEL.Count; i++)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["Tax_Amout_Id"].Value = lstTaxAmountEL[i].Tax_Amout_Id.ToString();
                    dataGridView1.Rows[n].Cells["Tax_Amout"].Value = lstTaxAmountEL[i].Tax_Amout.ToString();
                    dataGridView1.Rows[n].Cells["Tax_Name"].Value = lstTaxAmountEL[i].Tax_Name; 
                }


                //dataGridView1.DataSource = lstTaxAmountEL;
                //dataGridView1.Columns["Tax_Amout_Id"].Visible = false;               
                //BindControl();
                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
                dataGridView1.Click += dataGridView1_Click;
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
    }
}