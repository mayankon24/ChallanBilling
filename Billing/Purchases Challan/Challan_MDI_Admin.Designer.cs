namespace PurchasesChallan
{
    partial class Challan_MDI_Admin
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
            this.PurchasesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challanOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PurchasesOrderToolStripMenuItem,
            this.challanOrderToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(821, 24);
            this.menuStrip.TabIndex = 53;
            this.menuStrip.Text = "MenuStrip";
            // 
            // PurchasesOrderToolStripMenuItem
            // 
            this.PurchasesOrderToolStripMenuItem.Name = "PurchasesOrderToolStripMenuItem";
            this.PurchasesOrderToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.PurchasesOrderToolStripMenuItem.Text = "Purchases Order";
            this.PurchasesOrderToolStripMenuItem.Click += new System.EventHandler(this.purchasesOrderToolStripMenuItem_Click);
            // 
            // challanOrderToolStripMenuItem
            // 
            this.challanOrderToolStripMenuItem.Name = "challanOrderToolStripMenuItem";
            this.challanOrderToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.challanOrderToolStripMenuItem.Text = "Challan Order";
            this.challanOrderToolStripMenuItem.Click += new System.EventHandler(this.challanOrderToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.closeToolStripMenuItem.Text = "Previous";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Challan_MDI_Admin
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
            this.Name = "Challan_MDI_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem PurchasesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challanOrderToolStripMenuItem;
    }
}

