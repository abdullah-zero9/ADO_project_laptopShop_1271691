namespace Laptop_Emporium
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryWithTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicLaptopReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.laptopToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(89, 35);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(185, 36);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click_1);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(185, 36);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click_1);
            // 
            // laptopToolStripMenuItem
            // 
            this.laptopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryWithTransactionToolStripMenuItem,
            this.detailsEntryToolStripMenuItem,
            this.updateDeleteToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.laptopToolStripMenuItem.Name = "laptopToolStripMenuItem";
            this.laptopToolStripMenuItem.Size = new System.Drawing.Size(100, 35);
            this.laptopToolStripMenuItem.Text = "Laptop";
            // 
            // entryWithTransactionToolStripMenuItem
            // 
            this.entryWithTransactionToolStripMenuItem.Name = "entryWithTransactionToolStripMenuItem";
            this.entryWithTransactionToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.entryWithTransactionToolStripMenuItem.Text = "Entry with transaction";
            this.entryWithTransactionToolStripMenuItem.Click += new System.EventHandler(this.entryWithTransactionToolStripMenuItem_Click);
            // 
            // detailsEntryToolStripMenuItem
            // 
            this.detailsEntryToolStripMenuItem.Name = "detailsEntryToolStripMenuItem";
            this.detailsEntryToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.detailsEntryToolStripMenuItem.Text = "Details Entry";
            this.detailsEntryToolStripMenuItem.Click += new System.EventHandler(this.detailsEntryToolStripMenuItem_Click_1);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.updateDeleteToolStripMenuItem.Text = "Update/Delete";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click_1);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processorToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(120, 35);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // processorToolStripMenuItem
            // 
            this.processorToolStripMenuItem.Name = "processorToolStripMenuItem";
            this.processorToolStripMenuItem.Size = new System.Drawing.Size(201, 36);
            this.processorToolStripMenuItem.Text = "processor";
            this.processorToolStripMenuItem.Click += new System.EventHandler(this.processorToolStripMenuItem_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicLaptopReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(96, 35);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // basicLaptopReportToolStripMenuItem
            // 
            this.basicLaptopReportToolStripMenuItem.Name = "basicLaptopReportToolStripMenuItem";
            this.basicLaptopReportToolStripMenuItem.Size = new System.Drawing.Size(306, 36);
            this.basicLaptopReportToolStripMenuItem.Text = "Basic Laptop Report";
            this.basicLaptopReportToolStripMenuItem.Click += new System.EventHandler(this.basicLaptopReportToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 669);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laptopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryWithTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicLaptopReportToolStripMenuItem;
    }
}