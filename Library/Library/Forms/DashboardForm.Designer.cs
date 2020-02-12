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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istifadəçiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müştəriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istifadeçiniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müştəriniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlDashboard = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istifadəçiToolStripMenuItem,
            this.müştəriToolStripMenuItem,
            this.kitabToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // istifadəçiToolStripMenuItem
            // 
            this.istifadəçiToolStripMenuItem.Name = "istifadəçiToolStripMenuItem";
            this.istifadəçiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.istifadəçiToolStripMenuItem.Text = "İstifadəçi";
            this.istifadəçiToolStripMenuItem.Click += new System.EventHandler(this.istifadəçiToolStripMenuItem_Click);
            // 
            // müştəriToolStripMenuItem
            // 
            this.müştəriToolStripMenuItem.Name = "müştəriToolStripMenuItem";
            this.müştəriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müştəriToolStripMenuItem.Text = "Müştəri";
            // 
            // kitabToolStripMenuItem
            // 
            this.kitabToolStripMenuItem.Name = "kitabToolStripMenuItem";
            this.kitabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitabToolStripMenuItem.Text = "Kitab";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istifadeçiniSilToolStripMenuItem,
            this.müştəriniSilToolStripMenuItem,
            this.kitabıSilToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // istifadeçiniSilToolStripMenuItem
            // 
            this.istifadeçiniSilToolStripMenuItem.Name = "istifadeçiniSilToolStripMenuItem";
            this.istifadeçiniSilToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.istifadeçiniSilToolStripMenuItem.Text = "İstifadeçini sil";
            // 
            // müştəriniSilToolStripMenuItem
            // 
            this.müştəriniSilToolStripMenuItem.Name = "müştəriniSilToolStripMenuItem";
            this.müştəriniSilToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.müştəriniSilToolStripMenuItem.Text = "Müştərini sil";
            // 
            // kitabıSilToolStripMenuItem
            // 
            this.kitabıSilToolStripMenuItem.Name = "kitabıSilToolStripMenuItem";
            this.kitabıSilToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.kitabıSilToolStripMenuItem.Text = "Kitabı sil";
            // 
            // PnlDashboard
            // 
            this.PnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDashboard.Location = new System.Drawing.Point(0, 24);
            this.PnlDashboard.Name = "PnlDashboard";
            this.PnlDashboard.Size = new System.Drawing.Size(783, 448);
            this.PnlDashboard.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 472);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istifadəçiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müştəriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istifadeçiniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müştəriniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabıSilToolStripMenuItem;
        private System.Windows.Forms.Panel PnlDashboard;
    }
}