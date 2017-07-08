namespace Billing
{
    partial class BillEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTaxInclusive = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.datePkrBilldate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.company_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases_Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases_Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaxAnount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtTaxAnount);
            this.panel1.Controls.Add(this.chkTaxInclusive);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.cmbBillType);
            this.panel1.Controls.Add(this.datePkrBilldate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbItemName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 238);
            this.panel1.TabIndex = 0;
            // 
            // chkTaxInclusive
            // 
            this.chkTaxInclusive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTaxInclusive.AutoSize = true;
            this.chkTaxInclusive.Location = new System.Drawing.Point(121, 159);
            this.chkTaxInclusive.Name = "chkTaxInclusive";
            this.chkTaxInclusive.Size = new System.Drawing.Size(89, 17);
            this.chkTaxInclusive.TabIndex = 111;
            this.chkTaxInclusive.Text = "Tax Inclusive";
            this.chkTaxInclusive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "SetStyle1";
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdate.Location = new System.Drawing.Point(13, 199);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 28);
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Tax Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Invoice No";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "SetStyle1";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.BurlyWood;
            this.btnClose.Location = new System.Drawing.Point(250, 199);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 28);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbBillType
            // 
            this.cmbBillType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Location = new System.Drawing.Point(121, 78);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(167, 21);
            this.cmbBillType.TabIndex = 107;
            // 
            // datePkrBilldate
            // 
            this.datePkrBilldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datePkrBilldate.Location = new System.Drawing.Point(121, 42);
            this.datePkrBilldate.Name = "datePkrBilldate";
            this.datePkrBilldate.Size = new System.Drawing.Size(149, 20);
            this.datePkrBilldate.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Bill type";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbItemName.Location = new System.Drawing.Point(101, 8);
            this.lbItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(32, 17);
            this.lbItemName.TabIndex = 66;
            this.lbItemName.Text = "hhh";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Date";
            // 
            // company_Id
            // 
            this.company_Id.HeaderText = "company_Id";
            this.company_Id.Name = "company_Id";
            this.company_Id.ReadOnly = true;
            this.company_Id.Visible = false;
            // 
            // Purchases_Order_Id
            // 
            this.Purchases_Order_Id.HeaderText = "Purchases_Order_Id";
            this.Purchases_Order_Id.Name = "Purchases_Order_Id";
            this.Purchases_Order_Id.ReadOnly = true;
            this.Purchases_Order_Id.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 250;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 250;
            // 
            // Purchases_Order_No
            // 
            this.Purchases_Order_No.HeaderText = "Purchases Order No";
            this.Purchases_Order_No.MinimumWidth = 300;
            this.Purchases_Order_No.Name = "Purchases_Order_No";
            this.Purchases_Order_No.ReadOnly = true;
            this.Purchases_Order_No.Width = 300;
            // 
            // txtTaxAnount
            // 
            this.txtTaxAnount.Location = new System.Drawing.Point(121, 124);
            this.txtTaxAnount.Name = "txtTaxAnount";
            this.txtTaxAnount.Size = new System.Drawing.Size(100, 20);
            this.txtTaxAnount.TabIndex = 112;
            // 
            // BillEdit
            // 
            this.AccessibleName = "SetStyle1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 238);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill item Narration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases_Order_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker datePkrBilldate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTaxInclusive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTaxAnount;
    }
}