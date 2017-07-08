namespace Billing
{
    partial class BillList
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Bill_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Type_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is_Tax_Inclusive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax_Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cartage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBill = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 701);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 637);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "rowSelection1";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bill_No,
            this.Bill_Date,
            this.Bill_Type_Id,
            this.Is_Tax_Inclusive,
            this.Tax_Name,
            this.Tax_Percentage,
            this.Cartage,
            this.Discount,
            this.Bill_Id,
            this.Print,
            this.Delete,
            this.EditBill});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(725, 598);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AccessibleName = "WhiteColor";
            this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(351, 27);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(58, 22);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "label1";
            // 
            // Bill_No
            // 
            this.Bill_No.HeaderText = "Bill No";
            this.Bill_No.Name = "Bill_No";
            this.Bill_No.ReadOnly = true;
            this.Bill_No.Width = 120;
            // 
            // Bill_Date
            // 
            this.Bill_Date.HeaderText = "Bill Date";
            this.Bill_Date.Name = "Bill_Date";
            this.Bill_Date.ReadOnly = true;
            // 
            // Bill_Type_Id
            // 
            this.Bill_Type_Id.HeaderText = "Bill Type";
            this.Bill_Type_Id.Name = "Bill_Type_Id";
            this.Bill_Type_Id.ReadOnly = true;
            // 
            // Is_Tax_Inclusive
            // 
            this.Is_Tax_Inclusive.HeaderText = "Tax Inclusive";
            this.Is_Tax_Inclusive.Name = "Is_Tax_Inclusive";
            this.Is_Tax_Inclusive.ReadOnly = true;
            // 
            // Tax_Name
            // 
            this.Tax_Name.HeaderText = "Tax Name";
            this.Tax_Name.Name = "Tax_Name";
            this.Tax_Name.ReadOnly = true;
            // 
            // Tax_Percentage
            // 
            this.Tax_Percentage.HeaderText = "Tax Percentage";
            this.Tax_Percentage.Name = "Tax_Percentage";
            this.Tax_Percentage.ReadOnly = true;
            // 
            // Cartage
            // 
            this.Cartage.HeaderText = "Cartage";
            this.Cartage.Name = "Cartage";
            this.Cartage.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Bill_Id
            // 
            this.Bill_Id.HeaderText = "Bill_Id";
            this.Bill_Id.Name = "Bill_Id";
            this.Bill_Id.ReadOnly = true;
            this.Bill_Id.Visible = false;
            // 
            // Print
            // 
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // EditBill
            // 
            this.EditBill.HeaderText = "Edit Bill";
            this.EditBill.Name = "EditBill";
            // 
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BillList";
            this.Text = "Create Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Type_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Is_Tax_Inclusive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax_Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cartage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Id;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn EditBill;
    }
}