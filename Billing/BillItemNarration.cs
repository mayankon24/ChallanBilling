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
    public partial class BillItemNarration : Form
    {
        #region Variable
        List<BillItemNarrationEL> DeletedItemNarration = new List<BillItemNarrationEL>();
        BillItemEL _BillItemEL = null;

        #endregion
        
        #region constractor
        private BillItemNarration()
        {          
            InitializeComponent();                   
        }       
        public BillItemNarration(BillItemEL objBillItemEL)
            : this()
        {
            _BillItemEL = objBillItemEL;
            lbItemName.Text = _BillItemEL.Item_Name;
            GridBind();
        }

        #endregion

        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            BillItemNarrationEL _BillItemNarrationEL;
            BillItemNarrationDL _BillItemNarrationDL = new BillItemNarrationDL();
            List<BillItemNarrationEL> lstBillItemNarration = new List<BillItemNarrationEL>();
            try
            {


                for (int i = 0; i < dataGridView1.Rows.Count -1 ; i++)
                {
                    _BillItemNarrationEL = new BillItemNarrationEL();
                    _BillItemNarrationEL.Bill_Item_Id = _BillItemEL.Bill_Item_Id;
                    _BillItemNarrationEL.Narration = dataGridView1.Rows[i].Cells["Narration"].Value.ToString();

                    if ((dataGridView1.Rows[i].Cells["BillItem_Narration_Id"].Value != null))
                    {
                        _BillItemNarrationEL.BillItem_Narration_Id = Convert.ToInt32(dataGridView1.Rows[i].Cells["BillItem_Narration_Id"].Value);;
                    }
                    else
                    {
                        _BillItemNarrationEL.BillItem_Narration_Id = 0;
                    }
                    lstBillItemNarration.Add(_BillItemNarrationEL);
                }
            }
            catch (Exception)
            {

            }


            SQLHelper _SQLHelper = new SQLHelper();
            SqlTransaction transaction = _SQLHelper.BeginTrans();
            try
            {
                for (int i = 0; i < lstBillItemNarration.Count; i++)
                {
                    if (lstBillItemNarration[i].BillItem_Narration_Id == 0)
                    {
                        _BillItemNarrationDL.Insert(transaction, lstBillItemNarration[i]);
                    }
                    else
                    {
                        _BillItemNarrationDL.Update(transaction, lstBillItemNarration[i]);
                    }
                }

                DeletedItemNarration.ForEach(r => _BillItemNarrationDL.Delete(transaction, r));

                transaction.Commit();
                Common.MessageSave();
                GridBind();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region grid operation
        void GridBind()
        {
            dataGridView1.Rows.Clear();
            try
            {
                BillItemNarrationDL _BillItemNarrationDL = new BillItemNarrationDL();
                List<BillItemNarrationEL> lstBillItemNarration = _BillItemNarrationDL.GetBillItemNarrationBy_BillItemId(_BillItemEL.Bill_Item_Id);


                for (int i = 0; i < lstBillItemNarration.Count; i++)
                {
                   int index = dataGridView1.Rows.Add();
                   dataGridView1.Rows[index].Cells["Bill_Item_Id"].Value = lstBillItemNarration[i].Bill_Item_Id;
                   dataGridView1.Rows[index].Cells["BillItem_Narration_Id"].Value = lstBillItemNarration[i].BillItem_Narration_Id;
                   dataGridView1.Rows[index].Cells["Narration"].Value = lstBillItemNarration[i].Narration;
                }

            }
            catch
            {
            }
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int BillItemNarrationId;

            if (e.Row.Cells["BillItem_Narration_Id"].Value != null)
            {
                if (int.TryParse(e.Row.Cells["BillItem_Narration_Id"].Value.ToString(), out BillItemNarrationId))
                {
                    BillItemNarrationEL _BillItemNarrationEL = new BillItemNarrationEL();
                    _BillItemNarrationEL.BillItem_Narration_Id = BillItemNarrationId;
                    DeletedItemNarration.Add(_BillItemNarrationEL);
                }
            }
            e.Row.Visible = false;
        }

        #endregion

    } 
}
