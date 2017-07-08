namespace PurchasesChallan
{
    partial class DeliveryReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.CR_Bill1 = new Billing.CR_Bill();
            this.cb_jobworkNarration = new System.Windows.Forms.CheckBox();
            this.CrystalReport11 = new Billing.CR_ChallanNote();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 664);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_jobworkNarration);
            this.groupBox1.Controls.Add(this.cmbBillType);
            this.groupBox1.Location = new System.Drawing.Point(21, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 40);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Type";
            // 
            // cmbBillType
            // 
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Items.AddRange(new object[] {
            "None",
            "Duplicate Copy",
            "Original Copy",
            "Triplicate  - Office Copy"});
            this.cmbBillType.Location = new System.Drawing.Point(6, 9);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(228, 21);
            this.cmbBillType.TabIndex = 109;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(21, 45);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(651, 607);
            this.crystalReportViewer1.TabIndex = 102;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(610, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 101;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // cb_jobworkNarration
            // 
            this.cb_jobworkNarration.AutoSize = true;
            this.cb_jobworkNarration.Checked = true;
            this.cb_jobworkNarration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_jobworkNarration.Location = new System.Drawing.Point(258, 13);
            this.cb_jobworkNarration.Name = "cb_jobworkNarration";
            this.cb_jobworkNarration.Size = new System.Drawing.Size(164, 17);
            this.cb_jobworkNarration.TabIndex = 110;
            this.cb_jobworkNarration.Text = "Not for Sale for Jobwork Only";
            this.cb_jobworkNarration.UseVisualStyleBackColor = true;
            this.cb_jobworkNarration.CheckedChanged += new System.EventHandler(this.cb_jobworkNarration_CheckedChanged);
            // 
            // DeliveryReport
            // 
            this.AccessibleName = "SetStyle1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 664);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Billing.CR_ChallanNote CrystalReport11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBillType;
        private Billing.CR_Bill CR_Bill1;
        private System.Windows.Forms.CheckBox cb_jobworkNarration;
    }
}