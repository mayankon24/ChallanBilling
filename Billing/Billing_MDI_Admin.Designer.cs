namespace Billing
{
    partial class Billing_MDI_Admin
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.createBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billQuantityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBillToolStripMenuItem,
            this.billReportToolStripMenuItem,
            this.billQuantityReportToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(821, 24);
            this.menuStrip.TabIndex = 53;
            this.menuStrip.Text = "MenuStrip";
            // 
            // createBillToolStripMenuItem
            // 
            this.createBillToolStripMenuItem.Name = "createBillToolStripMenuItem";
            this.createBillToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.createBillToolStripMenuItem.Text = "Create Bill";
            this.createBillToolStripMenuItem.Click += new System.EventHandler(this.createBillToolStripMenuItem_Click);
            // 
            // billReportToolStripMenuItem
            // 
            this.billReportToolStripMenuItem.Name = "billReportToolStripMenuItem";
            this.billReportToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.billReportToolStripMenuItem.Text = "Bill Report";
            this.billReportToolStripMenuItem.Click += new System.EventHandler(this.billReportToolStripMenuItem_Click);
            // 
            // billQuantityReportToolStripMenuItem
            // 
            this.billQuantityReportToolStripMenuItem.Name = "billQuantityReportToolStripMenuItem";
            this.billQuantityReportToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.billQuantityReportToolStripMenuItem.Text = "Bill Quantity Report";
            this.billQuantityReportToolStripMenuItem.Click += new System.EventHandler(this.billQuantityReportToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.closeToolStripMenuItem.Text = "Previous";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Billing_MDI_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(821, 668);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Billing_MDI_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem createBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billQuantityReportToolStripMenuItem;
    }
}

