namespace Library.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.GrbAddUser = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearchUser = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.DgvAddUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUserMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.GrbAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbAddUser
            // 
            this.GrbAddUser.Controls.Add(this.BtnUpdate);
            this.GrbAddUser.Controls.Add(this.BtnDelete);
            this.GrbAddUser.Controls.Add(this.BtnSearchUser);
            this.GrbAddUser.Controls.Add(this.BtnAddUser);
            this.GrbAddUser.Controls.Add(this.DgvAddUsers);
            this.GrbAddUser.Controls.Add(this.label5);
            this.GrbAddUser.Controls.Add(this.TxtUserPassword);
            this.GrbAddUser.Controls.Add(this.label3);
            this.GrbAddUser.Controls.Add(this.TxtUserMail);
            this.GrbAddUser.Controls.Add(this.label2);
            this.GrbAddUser.Controls.Add(this.TxtUserSurname);
            this.GrbAddUser.Controls.Add(this.label1);
            this.GrbAddUser.Controls.Add(this.TxtUserName);
            this.GrbAddUser.Location = new System.Drawing.Point(3, 1);
            this.GrbAddUser.Name = "GrbAddUser";
            this.GrbAddUser.Size = new System.Drawing.Size(795, 446);
            this.GrbAddUser.TabIndex = 1;
            this.GrbAddUser.TabStop = false;
            this.GrbAddUser.Text = "Yeni İstifadəçi";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(31, 358);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(162, 32);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Məlumatı yenilə";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(31, 320);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(162, 32);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearchUser
            // 
            this.BtnSearchUser.Location = new System.Drawing.Point(31, 281);
            this.BtnSearchUser.Name = "BtnSearchUser";
            this.BtnSearchUser.Size = new System.Drawing.Size(162, 32);
            this.BtnSearchUser.TabIndex = 14;
            this.BtnSearchUser.Text = "Axtar";
            this.BtnSearchUser.UseVisualStyleBackColor = true;
            this.BtnSearchUser.Click += new System.EventHandler(this.BtnSearchUser_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(31, 237);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(162, 35);
            this.BtnAddUser.TabIndex = 13;
            this.BtnAddUser.Text = "Əlavə et";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // DgvAddUsers
            // 
            this.DgvAddUsers.AllowUserToAddRows = false;
            this.DgvAddUsers.AllowUserToDeleteRows = false;
            this.DgvAddUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAddUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvAddUsers.Location = new System.Drawing.Point(235, 20);
            this.DgvAddUsers.Name = "DgvAddUsers";
            this.DgvAddUsers.ReadOnly = true;
            this.DgvAddUsers.Size = new System.Drawing.Size(528, 332);
            this.DgvAddUsers.TabIndex = 12;
            this.DgvAddUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddUsers_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyadı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "E-poçt";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Parol";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vəzifəsi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "İstifadəçi parolu";
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.Location = new System.Drawing.Point(31, 199);
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.Size = new System.Drawing.Size(162, 20);
            this.TxtUserPassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-poçt ünvanı";
            // 
            // TxtUserMail
            // 
            this.TxtUserMail.Location = new System.Drawing.Point(31, 148);
            this.TxtUserMail.Name = "TxtUserMail";
            this.TxtUserMail.Size = new System.Drawing.Size(162, 20);
            this.TxtUserMail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı";
            // 
            // TxtUserSurname
            // 
            this.TxtUserSurname.Location = new System.Drawing.Point(31, 97);
            this.TxtUserSurname.Name = "TxtUserSurname";
            this.TxtUserSurname.Size = new System.Drawing.Size(162, 20);
            this.TxtUserSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(31, 46);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(162, 20);
            this.TxtUserName.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "İstifadəçi";
            this.GrbAddUser.ResumeLayout(false);
            this.GrbAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrbAddUser;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearchUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.DataGridView DgvAddUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUserMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserName;
    }
}