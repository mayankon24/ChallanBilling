namespace PurchasesChallan
{
    partial class DeliveryOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPurchasesOrderNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delivery_Detail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_Item_Deliver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deliver_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Order_Detail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printing = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxjkj3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDeliveryOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textDeliveryOrderNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ListDeliveryOrder = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxjkj3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPurchasesOrderNo);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lbCompanyName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBoxjkj3);
            this.panel1.Controls.Add(this.ListDeliveryOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 676);
            this.panel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleName = "SetStyle3";
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(782, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 35);
            this.btnPrint.TabIndex = 95;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "WhiteColor";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "Purchases Order No";
            // 
            // lbPurchasesOrderNo
            // 
            this.lbPurchasesOrderNo.AccessibleName = "WhiteColor";
            this.lbPurchasesOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPurchasesOrderNo.AutoSize = true;
            this.lbPurchasesOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPurchasesOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPurchasesOrderNo.Location = new System.Drawing.Point(454, 35);
            this.lbPurchasesOrderNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPurchasesOrderNo.Name = "lbPurchasesOrderNo";
            this.lbPurchasesOrderNo.Size = new System.Drawing.Size(45, 25);
            this.lbPurchasesOrderNo.TabIndex = 93;
            this.lbPurchasesOrderNo.Text = "hhh";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "SetStyle1";
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(382, 624);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 28);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "Delete This Order";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "SetStyle1";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(159, 624);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 91;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "SetStyle1";
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(255, 624);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 28);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update This Order";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AccessibleName = "WhiteColor";
            this.lbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCompanyName.Location = new System.Drawing.Point(378, 9);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(45, 25);
            this.lbCompanyName.TabIndex = 65;
            this.lbCompanyName.Text = "hhh";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "SetStyle1";
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(43, 624);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Add New Order";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(14, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 462);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery Order Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeight = 70;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delivery_Detail_Id,
            this.IS_Item_Deliver,
            this.Item_Name,
            this.Item_Quantity,
            this.Item_Rate,
            this.Total_Amount,
            this.Deliver_Quantity,
            this.Purchase_Order_Detail_Id,
            this.Printing});
            this.dataGridView1.Location = new System.Drawing.Point(9, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(696, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delivery_Detail_Id
            // 
            this.Delivery_Detail_Id.HeaderText = "Delivery_Detail_Id";
            this.Delivery_Detail_Id.Name = "Delivery_Detail_Id";
            this.Delivery_Detail_Id.ReadOnly = true;
            this.Delivery_Detail_Id.Visible = false;
            // 
            // IS_Item_Deliver
            // 
            this.IS_Item_Deliver.HeaderText = "IS Item Deliver";
            this.IS_Item_Deliver.MinimumWidth = 60;
            this.IS_Item_Deliver.Name = "IS_Item_Deliver";
            this.IS_Item_Deliver.Width = 60;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 150;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 150;
            // 
            // Item_Quantity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            this.Item_Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.Item_Quantity.HeaderText = "Item Quantity";
            this.Item_Quantity.MinimumWidth = 100;
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.ReadOnly = true;
            // 
            // Item_Rate
            // 
            this.Item_Rate.HeaderText = "Item Rate";
            this.Item_Rate.MinimumWidth = 50;
            this.Item_Rate.Name = "Item_Rate";
            this.Item_Rate.ReadOnly = true;
            this.Item_Rate.Width = 60;
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Total Amount";
            this.Total_Amount.MinimumWidth = 80;
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.ReadOnly = true;
            this.Total_Amount.Width = 80;
            // 
            // Deliver_Quantity
            // 
            this.Deliver_Quantity.HeaderText = "Deliver Quantity";
            this.Deliver_Quantity.Name = "Deliver_Quantity";
            // 
            // Purchase_Order_Detail_Id
            // 
            this.Purchase_Order_Detail_Id.HeaderText = "Purchase_Order_Detail_Id";
            this.Purchase_Order_Detail_Id.Name = "Purchase_Order_Detail_Id";
            this.Purchase_Order_Detail_Id.ReadOnly = true;
            this.Purchase_Order_Detail_Id.Visible = false;
            // 
            // Printing
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Printing.DefaultCellStyle = dataGridViewCellStyle2;
            this.Printing.HeaderText = "Packaging  Detail";
            this.Printing.Name = "Printing";
            this.Printing.Text = "Add";
            this.Printing.Width = 80;
            // 
            // groupBoxjkj3
            // 
            this.groupBoxjkj3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxjkj3.Controls.Add(this.dateTimePickerDeliveryOrderDate);
            this.groupBoxjkj3.Controls.Add(this.label2);
            this.groupBoxjkj3.Controls.Add(this.textDeliveryOrderNo);
            this.groupBoxjkj3.Controls.Add(this.label18);
            this.groupBoxjkj3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxjkj3.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBoxjkj3.Location = new System.Drawing.Point(14, 72);
            this.groupBoxjkj3.Name = "groupBoxjkj3";
            this.groupBoxjkj3.Size = new System.Drawing.Size(714, 70);
            this.groupBoxjkj3.TabIndex = 81;
            this.groupBoxjkj3.TabStop = false;
            this.groupBoxjkj3.Text = "Delivery Order";
            // 
            // dateTimePickerDeliveryOrderDate
            // 
            this.dateTimePickerDeliveryOrderDate.CustomFormat = "dd / MM / yyyy";
            this.dateTimePickerDeliveryOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDeliveryOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeliveryOrderDate.Location = new System.Drawing.Point(83, 31);
            this.dateTimePickerDeliveryOrderDate.Name = "dateTimePickerDeliveryOrderDate";
            this.dateTimePickerDeliveryOrderDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDeliveryOrderDate.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(283, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Delivery Order No ";
            // 
            // textDeliveryOrderNo
            // 
            this.textDeliveryOrderNo.BackColor = System.Drawing.Color.PowderBlue;
            this.textDeliveryOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDeliveryOrderNo.ForeColor = System.Drawing.Color.Black;
            this.textDeliveryOrderNo.Location = new System.Drawing.Point(430, 32);
            this.textDeliveryOrderNo.Margin = new System.Windows.Forms.Padding(2);
            this.textDeliveryOrderNo.Name = "textDeliveryOrderNo";
            this.textDeliveryOrderNo.Size = new System.Drawing.Size(137, 23);
            this.textDeliveryOrderNo.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(26, 34);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 17);
            this.label18.TabIndex = 63;
            this.label18.Text = "Date";
            // 
            // ListDeliveryOrder
            // 
            this.ListDeliveryOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDeliveryOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDeliveryOrder.FormattingEnabled = true;
            this.ListDeliveryOrder.ItemHeight = 20;
            this.ListDeliveryOrder.Location = new System.Drawing.Point(734, 42);
            this.ListDeliveryOrder.Name = "ListDeliveryOrder";
            this.ListDeliveryOrder.Size = new System.Drawing.Size(211, 624);
            this.ListDeliveryOrder.TabIndex = 79;
            // 
            // DeliveryOrder
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 676);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "DeliveryOrder";
            this.Text = "DeliveryOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxjkj3.ResumeLayout(false);
            this.groupBoxjkj3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxjkj3;
        private System.Windows.Forms.TextBox textDeliveryOrderNo;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox ListDeliveryOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryOrderDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbPurchasesOrderNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Detail_Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IS_Item_Deliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deliver_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Order_Detail_Id;
        private System.Windows.Forms.DataGridViewButtonColumn Printing;
    }
}