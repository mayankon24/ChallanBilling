namespace PurchasesChallan
{
    partial class BalanceSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.Purchases_Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases_Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Purchase_Order_Detail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Deliver_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPurchaseOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.ListPurchaseOrder);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lbCompanyName);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 676);
            this.panel1.TabIndex = 0;
            // 
            // ListPurchaseOrder
            // 
            this.ListPurchaseOrder.AccessibleName = "rowSelection1";
            this.ListPurchaseOrder.AllowUserToAddRows = false;
            this.ListPurchaseOrder.AllowUserToDeleteRows = false;
            this.ListPurchaseOrder.AllowUserToOrderColumns = true;
            this.ListPurchaseOrder.AllowUserToResizeColumns = false;
            this.ListPurchaseOrder.AllowUserToResizeRows = false;
            this.ListPurchaseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPurchaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListPurchaseOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListPurchaseOrder.BackgroundColor = System.Drawing.Color.White;
            this.ListPurchaseOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListPurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListPurchaseOrder.ColumnHeadersHeight = 60;
            this.ListPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Purchases_Order_Id,
            this.Company_id,
            this.Purchases_Order_No,
            this.Date,
            this.ColBtnDetail});
            this.ListPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListPurchaseOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListPurchaseOrder.GridColor = System.Drawing.Color.Salmon;
            this.ListPurchaseOrder.Location = new System.Drawing.Point(606, 46);
            this.ListPurchaseOrder.MultiSelect = false;
            this.ListPurchaseOrder.Name = "ListPurchaseOrder";
            this.ListPurchaseOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListPurchaseOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListPurchaseOrder.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ListPurchaseOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListPurchaseOrder.RowTemplate.ReadOnly = true;
            this.ListPurchaseOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ListPurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListPurchaseOrder.Size = new System.Drawing.Size(330, 618);
            this.ListPurchaseOrder.TabIndex = 98;
            this.ListPurchaseOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ListPurchaseOrder_RowsAdded);
            this.ListPurchaseOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPurchaseOrder_CellContentClick);
            // 
            // Purchases_Order_Id
            // 
            this.Purchases_Order_Id.HeaderText = "Purchases_Order_Id";
            this.Purchases_Order_Id.Name = "Purchases_Order_Id";
            this.Purchases_Order_Id.ReadOnly = true;
            this.Purchases_Order_Id.Visible = false;
            // 
            // Company_id
            // 
            this.Company_id.HeaderText = "Company_id";
            this.Company_id.Name = "Company_id";
            this.Company_id.ReadOnly = true;
            this.Company_id.Visible = false;
            // 
            // Purchases_Order_No
            // 
            this.Purchases_Order_No.HeaderText = "Order No";
            this.Purchases_Order_No.Name = "Purchases_Order_No";
            this.Purchases_Order_No.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ColBtnDetail
            // 
            this.ColBtnDetail.HeaderText = "Detail";
            this.ColBtnDetail.Name = "ColBtnDetail";
            this.ColBtnDetail.ReadOnly = true;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleName = "SetStyle1";
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(462, 636);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 28);
            this.btnNext.TabIndex = 63;
            this.btnNext.Text = "Delivery Order";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AccessibleName = "WhiteColor";
            this.lbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCompanyName.Location = new System.Drawing.Point(452, 9);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(45, 25);
            this.lbCompanyName.TabIndex = 65;
            this.lbCompanyName.Text = "hhh";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(14, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 586);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance Sheet ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Purchase_Order_Detail_Id,
            this.Item_Name,
            this.Item_Quantity,
            this.Item_Rate,
            this.Total_Amount,
            this.Total_Deliver_Quantity,
            this.Total_Balance});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(9, 21);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Purple;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Size = new System.Drawing.Size(568, 557);
            this.dataGridView1.TabIndex = 0;
            // 
            // Purchase_Order_Detail_Id
            // 
            this.Purchase_Order_Detail_Id.HeaderText = "Purchase_Order_Detail_Id";
            this.Purchase_Order_Detail_Id.Name = "Purchase_Order_Detail_Id";
            this.Purchase_Order_Detail_Id.ReadOnly = true;
            this.Purchase_Order_Detail_Id.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 200;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 200;
            // 
            // Item_Quantity
            // 
            this.Item_Quantity.HeaderText = "Item Quantity";
            this.Item_Quantity.MinimumWidth = 100;
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.ReadOnly = true;
            // 
            // Item_Rate
            // 
            this.Item_Rate.HeaderText = "Item Rate";
            this.Item_Rate.MinimumWidth = 100;
            this.Item_Rate.Name = "Item_Rate";
            this.Item_Rate.ReadOnly = true;
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Total Amount";
            this.Total_Amount.MinimumWidth = 100;
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.ReadOnly = true;
            // 
            // Total_Deliver_Quantity
            // 
            this.Total_Deliver_Quantity.HeaderText = "Total Deliver Quantity";
            this.Total_Deliver_Quantity.Name = "Total_Deliver_Quantity";
            this.Total_Deliver_Quantity.ReadOnly = true;
            // 
            // Total_Balance
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple;
            this.Total_Balance.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total_Balance.HeaderText = "Balance";
            this.Total_Balance.Name = "Total_Balance";
            this.Total_Balance.ReadOnly = true;
            // 
            // BalanceSheet
            // 
            this.AccessibleName = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(948, 676);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "BalanceSheet";
            this.Text = "BalanceSheet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPurchaseOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView ListPurchaseOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Order_Detail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Deliver_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Balance;
    }
}