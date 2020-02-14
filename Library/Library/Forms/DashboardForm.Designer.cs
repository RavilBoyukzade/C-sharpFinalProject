namespace Library.Forms
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.istifadəçiYaratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabYaratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müştəriYaratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qecikənlərinSiyahisıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabTəhviliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlDashboard = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem1,
            this.qecikənlərinSiyahisıToolStripMenuItem,
            this.kitabTəhviliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniToolStripMenuItem1
            // 
            this.yeniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istifadəçiYaratToolStripMenuItem,
            this.kitabYaratToolStripMenuItem,
            this.müştəriYaratToolStripMenuItem});
            this.yeniToolStripMenuItem1.Name = "yeniToolStripMenuItem1";
            this.yeniToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.yeniToolStripMenuItem1.Text = "Yeni";
            // 
            // istifadəçiYaratToolStripMenuItem
            // 
            this.istifadəçiYaratToolStripMenuItem.Name = "istifadəçiYaratToolStripMenuItem";
            this.istifadəçiYaratToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.istifadəçiYaratToolStripMenuItem.Text = "İstifadəçi yarat";
            this.istifadəçiYaratToolStripMenuItem.Click += new System.EventHandler(this.istifadəçiYaratToolStripMenuItem_Click);
            // 
            // kitabYaratToolStripMenuItem
            // 
            this.kitabYaratToolStripMenuItem.Name = "kitabYaratToolStripMenuItem";
            this.kitabYaratToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitabYaratToolStripMenuItem.Text = "Kitab yarat";
            this.kitabYaratToolStripMenuItem.Click += new System.EventHandler(this.kitabYaratToolStripMenuItem_Click);
            // 
            // müştəriYaratToolStripMenuItem
            // 
            this.müştəriYaratToolStripMenuItem.Name = "müştəriYaratToolStripMenuItem";
            this.müştəriYaratToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müştəriYaratToolStripMenuItem.Text = "Müştəri yarat";
            this.müştəriYaratToolStripMenuItem.Click += new System.EventHandler(this.müştəriYaratToolStripMenuItem_Click);
            // 
            // qecikənlərinSiyahisıToolStripMenuItem
            // 
            this.qecikənlərinSiyahisıToolStripMenuItem.Name = "qecikənlərinSiyahisıToolStripMenuItem";
            this.qecikənlərinSiyahisıToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.qecikənlərinSiyahisıToolStripMenuItem.Text = "Qecikənlərin siyahisı";
            // 
            // kitabTəhviliToolStripMenuItem
            // 
            this.kitabTəhviliToolStripMenuItem.Name = "kitabTəhviliToolStripMenuItem";
            this.kitabTəhviliToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.kitabTəhviliToolStripMenuItem.Text = "Kitab təhvili";
            this.kitabTəhviliToolStripMenuItem.Click += new System.EventHandler(this.kitabTəhviliToolStripMenuItem_Click);
            // 
            // PnlDashboard
            // 
            this.PnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDashboard.Location = new System.Drawing.Point(0, 24);
            this.PnlDashboard.Name = "PnlDashboard";
            this.PnlDashboard.Size = new System.Drawing.Size(793, 470);
            this.PnlDashboard.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 494);
            this.Controls.Add(this.PnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel PnlDashboard;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem istifadəçiYaratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabYaratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müştəriYaratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qecikənlərinSiyahisıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabTəhviliToolStripMenuItem;
    }
}