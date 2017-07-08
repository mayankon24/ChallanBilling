namespace Billing
{
    partial class CreateBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.textInvoiceNo = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdPurchasesOrder = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Purchases_Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases_Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdChallan = new System.Windows.Forms.DataGridView();
            this.Select2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Purchases_Order_No2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdItem = new System.Windows.Forms.DataGridView();
            this.Select_Item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Purchases_Order_No3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_no2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Deliver_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processed_Billing_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Detail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Order_Detail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Item_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Narration = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.Label();
            this.txtCartage = new System.Windows.Forms.TextBox();
            this.chkTaxInclusive = new System.Windows.Forms.CheckBox();
            this.Cartage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTaxName = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.cmbTaxAmount = new System.Windows.Forms.ComboBox();
            this.lnkTaxEdit = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePkrBilldate = new System.Windows.Forms.DateTimePicker();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchasesOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChallan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblBillNo);
            this.panel1.Controls.Add(this.textInvoiceNo);
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 701);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AccessibleName = "WhiteColor";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Bill No";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AccessibleName = "WhiteColor";
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.BackColor = System.Drawing.Color.Maroon;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBillNo.Location = new System.Drawing.Point(19, 30);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(41, 13);
            this.lblBillNo.TabIndex = 84;
            this.lblBillNo.Text = "bill no";
            // 
            // textInvoiceNo
            // 
            this.textInvoiceNo.Location = new System.Drawing.Point(62, 9);
            this.textInvoiceNo.Name = "textInvoiceNo";
            this.textInvoiceNo.Size = new System.Drawing.Size(124, 20);
            this.textInvoiceNo.TabIndex = 86;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(11, 65);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(990, 529);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 83;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(990, 211);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdPurchasesOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 211);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchases Order";
            // 
            // grdPurchasesOrder
            // 
            this.grdPurchasesOrder.AccessibleName = "CellSelection1";
            this.grdPurchasesOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPurchasesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPurchasesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Purchases_Order_No,
            this.Date,
            this.Purchases_Order_Id,
            this.ColBtnDetail});
            this.grdPurchasesOrder.Location = new System.Drawing.Point(11, 24);
            this.grdPurchasesOrder.Name = "grdPurchasesOrder";
            this.grdPurchasesOrder.Size = new System.Drawing.Size(476, 164);
            this.grdPurchasesOrder.TabIndex = 0;
            this.grdPurchasesOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchasesOrder_CellContentClick);
            this.grdPurchasesOrder.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdPurchasesOrder_CurrentCellDirtyStateChanged);
            this.grdPurchasesOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdPurchasesOrder_RowsAdded);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 40;
            // 
            // Purchases_Order_No
            // 
            this.Purchases_Order_No.HeaderText = "Purchases Order No";
            this.Purchases_Order_No.Name = "Purchases_Order_No";
            this.Purchases_Order_No.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Purchases_Order_Id
            // 
            this.Purchases_Order_Id.HeaderText = "Purchases_Order_Id";
            this.Purchases_Order_Id.Name = "Purchases_Order_Id";
            this.Purchases_Order_Id.ReadOnly = true;
            this.Purchases_Order_Id.Visible = false;
            // 
            // ColBtnDetail
            // 
            this.ColBtnDetail.HeaderText = "Detail";
            this.ColBtnDetail.Name = "ColBtnDetail";
            this.ColBtnDetail.ReadOnly = true;
            this.ColBtnDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBtnDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdChallan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 211);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Challan";
            // 
            // grdChallan
            // 
            this.grdChallan.AccessibleName = "CellSelection1";
            this.grdChallan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdChallan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select2,
            this.Purchases_Order_No2,
            this.Delivery_no,
            this.Delivery_Date,
            this.Delivery_Id});
            this.grdChallan.Location = new System.Drawing.Point(12, 24);
            this.grdChallan.Name = "grdChallan";
            this.grdChallan.Size = new System.Drawing.Size(464, 164);
            this.grdChallan.TabIndex = 80;
            this.grdChallan.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdChallan_CurrentCellDirtyStateChanged);
            // 
            // Select2
            // 
            this.Select2.HeaderText = "Select";
            this.Select2.Name = "Select2";
            this.Select2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Purchases_Order_No2
            // 
            this.Purchases_Order_No2.HeaderText = "Purchases Order No";
            this.Purchases_Order_No2.Name = "Purchases_Order_No2";
            this.Purchases_Order_No2.ReadOnly = true;
            // 
            // Delivery_no
            // 
            this.Delivery_no.HeaderText = "Delivery No";
            this.Delivery_no.Name = "Delivery_no";
            this.Delivery_no.ReadOnly = true;
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.HeaderText = "Delivery Date";
            this.Delivery_Date.Name = "Delivery_Date";
            this.Delivery_Date.ReadOnly = true;
            // 
            // Delivery_Id
            // 
            this.Delivery_Id.HeaderText = "Delivery_Id";
            this.Delivery_Id.Name = "Delivery_Id";
            this.Delivery_Id.ReadOnly = true;
            this.Delivery_Id.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdItem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(990, 314);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Detail";
            // 
            // grdItem
            // 
            this.grdItem.AccessibleName = "CellSelection1";
            this.grdItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select_Item,
            this.Purchases_Order_No3,
            this.Delivery_no2,
            this.Item_Name,
            this.Item_Quantity,
            this.Item_Rate,
            this.Total_Amount,
            this.Total_Deliver_Quantity,
            this.Processed_Billing_Quantity,
            this.Delivery_Detail_Id,
            this.Form,
            this.Color,
            this.Rate,
            this.Bill_Quantity,
            this.Purchase_Order_Detail_Id,
            this.Bill_Item_Id,
            this.Sub_Item,
            this.Narration});
            this.grdItem.Location = new System.Drawing.Point(13, 24);
            this.grdItem.Name = "grdItem";
            this.grdItem.Size = new System.Drawing.Size(965, 280);
            this.grdItem.TabIndex = 0;
            this.grdItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItem_CellContentClick);
            this.grdItem.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdItem_RowsAdded);
            // 
            // Select_Item
            // 
            this.Select_Item.HeaderText = "Select";
            this.Select_Item.Name = "Select_Item";
            // 
            // Purchases_Order_No3
            // 
            this.Purchases_Order_No3.HeaderText = "Purchases Order No";
            this.Purchases_Order_No3.Name = "Purchases_Order_No3";
            this.Purchases_Order_No3.ReadOnly = true;
            this.Purchases_Order_No3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchases_Order_No3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delivery_no2
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Delivery_no2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delivery_no2.HeaderText = "Delivery Nos";
            this.Delivery_no2.Name = "Delivery_no2";
            this.Delivery_no2.ReadOnly = true;
            // 
            // Item_Name
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Item_Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Item_Quantity
            // 
            this.Item_Quantity.HeaderText = "Order Quantity";
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.ReadOnly = true;
            // 
            // Item_Rate
            // 
            this.Item_Rate.HeaderText = "Order Item Rate";
            this.Item_Rate.Name = "Item_Rate";
            this.Item_Rate.ReadOnly = true;
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Order Total Amount";
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.ReadOnly = true;
            // 
            // Total_Deliver_Quantity
            // 
            this.Total_Deliver_Quantity.HeaderText = "Total Deliver Quantity";
            this.Total_Deliver_Quantity.Name = "Total_Deliver_Quantity";
            this.Total_Deliver_Quantity.ReadOnly = true;
            // 
            // Processed_Billing_Quantity
            // 
            this.Processed_Billing_Quantity.HeaderText = "Processed Billing Quantity";
            this.Processed_Billing_Quantity.Name = "Processed_Billing_Quantity";
            this.Processed_Billing_Quantity.ReadOnly = true;
            this.Processed_Billing_Quantity.Visible = false;
            // 
            // Delivery_Detail_Id
            // 
            this.Delivery_Detail_Id.HeaderText = "Delivery_Detail_Id";
            this.Delivery_Detail_Id.Name = "Delivery_Detail_Id";
            this.Delivery_Detail_Id.ReadOnly = true;
            this.Delivery_Detail_Id.Visible = false;
            // 
            // Form
            // 
            this.Form.HeaderText = "form";
            this.Form.Name = "Form";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "rate";
            this.Rate.Name = "Rate";
            // 
            // Bill_Quantity
            // 
            this.Bill_Quantity.HeaderText = "Bill Quantity";
            this.Bill_Quantity.Name = "Bill_Quantity";
            // 
            // Purchase_Order_Detail_Id
            // 
            this.Purchase_Order_Detail_Id.HeaderText = "Purchase_Order_Detail_Id";
            this.Purchase_Order_Detail_Id.Name = "Purchase_Order_Detail_Id";
            this.Purchase_Order_Detail_Id.ReadOnly = true;
            this.Purchase_Order_Detail_Id.Visible = false;
            // 
            // Bill_Item_Id
            // 
            this.Bill_Item_Id.HeaderText = "Bill_Item_Id";
            this.Bill_Item_Id.Name = "Bill_Item_Id";
            this.Bill_Item_Id.ReadOnly = true;
            this.Bill_Item_Id.Visible = false;
            // 
            // Sub_Item
            // 
            this.Sub_Item.HeaderText = "Sub Item";
            this.Sub_Item.Name = "Sub_Item";
            this.Sub_Item.ReadOnly = true;
            // 
            // Narration
            // 
            this.Narration.HeaderText = "Narration";
            this.Narration.Name = "Narration";
            this.Narration.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDiscount);
            this.groupBox4.Controls.Add(this.Discount);
            this.groupBox4.Controls.Add(this.txtCartage);
            this.groupBox4.Controls.Add(this.chkTaxInclusive);
            this.groupBox4.Controls.Add(this.Cartage);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.datePkrBilldate);
            this.groupBox4.Controls.Add(this.cmbBillType);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(11, 600);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(990, 88);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create Bill";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Tax Inclusive";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiscount.Location = new System.Drawing.Point(448, 42);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 99;
            // 
            // Discount
            // 
            this.Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(471, 20);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(49, 13);
            this.Discount.TabIndex = 98;
            this.Discount.Text = "Discount";
            // 
            // txtCartage
            // 
            this.txtCartage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCartage.Location = new System.Drawing.Point(355, 42);
            this.txtCartage.Name = "txtCartage";
            this.txtCartage.Size = new System.Drawing.Size(80, 20);
            this.txtCartage.TabIndex = 96;
            // 
            // chkTaxInclusive
            // 
            this.chkTaxInclusive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTaxInclusive.AutoSize = true;
            this.chkTaxInclusive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTaxInclusive.Location = new System.Drawing.Point(580, 48);
            this.chkTaxInclusive.Name = "chkTaxInclusive";
            this.chkTaxInclusive.Size = new System.Drawing.Size(15, 14);
            this.chkTaxInclusive.TabIndex = 91;
            this.chkTaxInclusive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkTaxInclusive.UseVisualStyleBackColor = true;
            // 
            // Cartage
            // 
            this.Cartage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cartage.AutoSize = true;
            this.Cartage.Location = new System.Drawing.Point(367, 20);
            this.Cartage.Name = "Cartage";
            this.Cartage.Size = new System.Drawing.Size(44, 13);
            this.Cartage.TabIndex = 97;
            this.Cartage.Text = "Cartage";
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "StyleTransparent";
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnCreateBill);
            this.panel3.Controls.Add(this.btnNewBill);
            this.panel3.Location = new System.Drawing.Point(814, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 66);
            this.panel3.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "SetStyle1";
            this.btnUpdate.Location = new System.Drawing.Point(51, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 23);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.AccessibleName = "SetStyle1";
            this.btnCreateBill.Location = new System.Drawing.Point(-1, -1);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(107, 23);
            this.btnCreateBill.TabIndex = 81;
            this.btnCreateBill.Text = "Create Bill";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.AccessibleName = "SetStyle1";
            this.btnNewBill.Location = new System.Drawing.Point(-1, 25);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(107, 23);
            this.btnNewBill.TabIndex = 93;
            this.btnNewBill.Text = "New Bill";
            this.btnNewBill.UseVisualStyleBackColor = true;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "StyleTransparent";
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtTaxName);
            this.panel2.Controls.Add(this.txtTaxAmount);
            this.panel2.Controls.Add(this.cmbTaxAmount);
            this.panel2.Controls.Add(this.lnkTaxEdit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(635, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 68);
            this.panel2.TabIndex = 96;
            // 
            // txtTaxName
            // 
            this.txtTaxName.Location = new System.Drawing.Point(18, 25);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Size = new System.Drawing.Size(52, 20);
            this.txtTaxName.TabIndex = 96;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(95, 25);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(44, 20);
            this.txtTaxAmount.TabIndex = 95;
            // 
            // cmbTaxAmount
            // 
            this.cmbTaxAmount.FormattingEnabled = true;
            this.cmbTaxAmount.Location = new System.Drawing.Point(18, 25);
            this.cmbTaxAmount.Name = "cmbTaxAmount";
            this.cmbTaxAmount.Size = new System.Drawing.Size(121, 21);
            this.cmbTaxAmount.TabIndex = 87;
            // 
            // lnkTaxEdit
            // 
            this.lnkTaxEdit.AutoSize = true;
            this.lnkTaxEdit.Location = new System.Drawing.Point(15, 49);
            this.lnkTaxEdit.Name = "lnkTaxEdit";
            this.lnkTaxEdit.Size = new System.Drawing.Size(81, 13);
            this.lnkTaxEdit.TabIndex = 88;
            this.lnkTaxEdit.TabStop = true;
            this.lnkTaxEdit.Text = "Edit tax Amount";
            this.lnkTaxEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTaxEdit_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Tax";
            // 
            // datePkrBilldate
            // 
            this.datePkrBilldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datePkrBilldate.CustomFormat = "dd/MM/yyyy";
            this.datePkrBilldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePkrBilldate.Location = new System.Drawing.Point(13, 42);
            this.datePkrBilldate.Name = "datePkrBilldate";
            this.datePkrBilldate.Size = new System.Drawing.Size(149, 20);
            this.datePkrBilldate.TabIndex = 85;
            // 
            // cmbBillType
            // 
            this.cmbBillType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Location = new System.Drawing.Point(168, 42);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(167, 21);
            this.cmbBillType.TabIndex = 84;
            this.cmbBillType.SelectedIndexChanged += new System.EventHandler(this.cmbBillType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bill type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AccessibleName = "WhiteColor";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "CreateBill";
            this.Text = "Create Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchasesOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChallan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdPurchasesOrder;
        private System.Windows.Forms.DataGridView grdChallan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_No2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Id;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.DateTimePicker datePkrBilldate;
        private System.Windows.Forms.ComboBox cmbTaxAmount;
        private System.Windows.Forms.LinkLabel lnkTaxEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTaxInclusive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_Id;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDetail;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.TextBox textInvoiceNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_No3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_no2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Deliver_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processed_Billing_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Detail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Order_Detail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Item_Id;
        private System.Windows.Forms.DataGridViewButtonColumn Sub_Item;
        private System.Windows.Forms.DataGridViewButtonColumn Narration;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox txtCartage;
        private System.Windows.Forms.Label Cartage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaxName;
        private System.Windows.Forms.Label label7;
    }
}