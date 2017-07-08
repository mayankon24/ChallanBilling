namespace Billing
{
    partial class BillingQuantityReportByPeriod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingQuantityReportByPeriod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdItem = new System.Windows.Forms.DataGridView();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Delivery_Detail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases_Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases_Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deliver_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Deliver_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Billing_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "StyleRosyBrown";
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.datePickerToDate);
            this.panel1.Controls.Add(this.datePickerFromDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 701);
            this.panel1.TabIndex = 0;
            // 
            // datePickerToDate
            // 
            this.datePickerToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerToDate.Location = new System.Drawing.Point(514, 61);
            this.datePickerToDate.Name = "datePickerToDate";
            this.datePickerToDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerToDate.TabIndex = 85;
            this.datePickerToDate.ValueChanged += new System.EventHandler(this.datePickerToDate_ValueChanged);
            // 
            // datePickerFromDate
            // 
            this.datePickerFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerFromDate.Location = new System.Drawing.Point(287, 61);
            this.datePickerFromDate.Name = "datePickerFromDate";
            this.datePickerFromDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerFromDate.TabIndex = 84;
            this.datePickerFromDate.ValueChanged += new System.EventHandler(this.datePickerFromDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AccessibleName = "WhiteColor";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Select Purchases Order Period";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.Location = new System.Drawing.Point(716, 41);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(27, 23);
            this.btnExcel.TabIndex = 82;
            this.btnExcel.Text = "button12";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(674, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleName = "StyleTransparent";
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grdItem);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 594);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Detail";
            // 
            // grdItem
            // 
            this.grdItem.AccessibleName = "rowSelection1WithoutSort";
            this.grdItem.AllowUserToAddRows = false;
            this.grdItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delivery_Detail_Id,
            this.Purchases_Order_No,
            this.Purchases_Order_Date,
            this.Item_Name,
            this.Item_Quantity,
            this.Delivery_no,
            this.Delivery_Date,
            this.Deliver_Quantity,
            this.Billing_Quantity,
            this.Total_Deliver_Quantity,
            this.Balance_Quantity,
            this.Total_Billing_Quantity,
            this.Billing_Status});
            this.grdItem.Location = new System.Drawing.Point(12, 24);
            this.grdItem.Name = "grdItem";
            this.grdItem.RowHeadersVisible = false;
            this.grdItem.Size = new System.Drawing.Size(712, 546);
            this.grdItem.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AccessibleName = "WhiteColor";
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(58, 22);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "label1";
            // 
            // Delivery_Detail_Id
            // 
            this.Delivery_Detail_Id.HeaderText = "Delivery_Detail_Id";
            this.Delivery_Detail_Id.Name = "Delivery_Detail_Id";
            this.Delivery_Detail_Id.ReadOnly = true;
            this.Delivery_Detail_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Delivery_Detail_Id.Visible = false;
            // 
            // Purchases_Order_No
            // 
            this.Purchases_Order_No.HeaderText = "Purchases Order No";
            this.Purchases_Order_No.Name = "Purchases_Order_No";
            this.Purchases_Order_No.ReadOnly = true;
            this.Purchases_Order_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Purchases_Order_Date
            // 
            this.Purchases_Order_Date.HeaderText = "Purchases Order Date";
            this.Purchases_Order_Date.Name = "Purchases_Order_Date";
            this.Purchases_Order_Date.ReadOnly = true;
            this.Purchases_Order_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 200;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Item_Quantity
            // 
            this.Item_Quantity.HeaderText = "Order Quantity";
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.ReadOnly = true;
            this.Item_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delivery_no
            // 
            this.Delivery_no.HeaderText = "Delivery No";
            this.Delivery_no.Name = "Delivery_no";
            this.Delivery_no.ReadOnly = true;
            this.Delivery_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.HeaderText = "Delivery Date";
            this.Delivery_Date.Name = "Delivery_Date";
            this.Delivery_Date.ReadOnly = true;
            this.Delivery_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Deliver_Quantity
            // 
            this.Deliver_Quantity.HeaderText = "Deliver Quantity";
            this.Deliver_Quantity.Name = "Deliver_Quantity";
            this.Deliver_Quantity.ReadOnly = true;
            this.Deliver_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Billing_Quantity
            // 
            this.Billing_Quantity.HeaderText = "Billing Quantity";
            this.Billing_Quantity.Name = "Billing_Quantity";
            this.Billing_Quantity.ReadOnly = true;
            this.Billing_Quantity.Visible = false;
            // 
            // Total_Deliver_Quantity
            // 
            this.Total_Deliver_Quantity.HeaderText = "Total Deliver Quantity";
            this.Total_Deliver_Quantity.Name = "Total_Deliver_Quantity";
            this.Total_Deliver_Quantity.ReadOnly = true;
            this.Total_Deliver_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Balance_Quantity
            // 
            this.Balance_Quantity.HeaderText = "Balance Quantity";
            this.Balance_Quantity.Name = "Balance_Quantity";
            this.Balance_Quantity.ReadOnly = true;
            this.Balance_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total_Billing_Quantity
            // 
            this.Total_Billing_Quantity.HeaderText = "Total Billing Quantity";
            this.Total_Billing_Quantity.Name = "Total_Billing_Quantity";
            this.Total_Billing_Quantity.ReadOnly = true;
            this.Total_Billing_Quantity.Visible = false;
            // 
            // Billing_Status
            // 
            this.Billing_Status.HeaderText = "Billing Creation Status";
            this.Billing_Status.Name = "Billing_Status";
            this.Billing_Status.ReadOnly = true;
            // 
            // BillingQuantityReportByPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BillingQuantityReportByPeriod";
            this.Text = "Create Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdItem;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker datePickerFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Detail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deliver_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Deliver_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Billing_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_Status;
    }
}