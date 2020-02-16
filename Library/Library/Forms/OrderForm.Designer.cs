namespace Library.Forms
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpTake = new System.Windows.Forms.DateTimePicker();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBookCount = new System.Windows.Forms.TextBox();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPersonSearch = new System.Windows.Forms.Button();
            this.TxtSearchPerson = new System.Windows.Forms.TextBox();
            this.BtnBookSearch = new System.Windows.Forms.Button();
            this.TxtSearchBook = new System.Windows.Forms.TextBox();
            this.DgvPerson = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DtpTake);
            this.groupBox1.Controls.Add(this.BtnDeleteOrder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtBookCount);
            this.groupBox1.Controls.Add(this.BtnAddOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpDeadline);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnPersonSearch);
            this.groupBox1.Controls.Add(this.TxtSearchPerson);
            this.groupBox1.Controls.Add(this.BtnBookSearch);
            this.groupBox1.Controls.Add(this.TxtSearchBook);
            this.groupBox1.Controls.Add(this.DgvPerson);
            this.groupBox1.Controls.Add(this.DgvBooks);
            this.groupBox1.Controls.Add(this.DgvOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitab sifarişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Götürmə tarixi";
            // 
            // DtpTake
            // 
            this.DtpTake.Location = new System.Drawing.Point(334, 203);
            this.DtpTake.Name = "DtpTake";
            this.DtpTake.Size = new System.Drawing.Size(207, 20);
            this.DtpTake.TabIndex = 15;
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.Location = new System.Drawing.Point(589, 218);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(91, 36);
            this.BtnDeleteOrder.TabIndex = 14;
            this.BtnDeleteOrder.Text = "Sil";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kitabın Sayı";
            // 
            // TxtBookCount
            // 
            this.TxtBookCount.Location = new System.Drawing.Point(75, 227);
            this.TxtBookCount.Name = "TxtBookCount";
            this.TxtBookCount.Size = new System.Drawing.Size(167, 20);
            this.TxtBookCount.TabIndex = 12;
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.Location = new System.Drawing.Point(697, 218);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(91, 36);
            this.BtnAddOrder.TabIndex = 11;
            this.BtnAddOrder.Text = "Sifarişi yarat";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Qaytarma tarixi";
            // 
            // DtpDeadline
            // 
            this.DtpDeadline.Location = new System.Drawing.Point(334, 227);
            this.DtpDeadline.Name = "DtpDeadline";
            this.DtpDeadline.Size = new System.Drawing.Size(207, 20);
            this.DtpDeadline.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müştərinin adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitabın adı";
            // 
            // BtnPersonSearch
            // 
            this.BtnPersonSearch.Location = new System.Drawing.Point(697, 22);
            this.BtnPersonSearch.Name = "BtnPersonSearch";
            this.BtnPersonSearch.Size = new System.Drawing.Size(91, 20);
            this.BtnPersonSearch.TabIndex = 6;
            this.BtnPersonSearch.Text = "Axtar";
            this.BtnPersonSearch.UseVisualStyleBackColor = true;
            this.BtnPersonSearch.Click += new System.EventHandler(this.BtnPersonSearch_Click);
            // 
            // TxtSearchPerson
            // 
            this.TxtSearchPerson.Location = new System.Drawing.Point(530, 22);
            this.TxtSearchPerson.Name = "TxtSearchPerson";
            this.TxtSearchPerson.Size = new System.Drawing.Size(161, 20);
            this.TxtSearchPerson.TabIndex = 5;
            // 
            // BtnBookSearch
            // 
            this.BtnBookSearch.Location = new System.Drawing.Point(262, 21);
            this.BtnBookSearch.Name = "BtnBookSearch";
            this.BtnBookSearch.Size = new System.Drawing.Size(107, 20);
            this.BtnBookSearch.TabIndex = 4;
            this.BtnBookSearch.Text = "Axtar";
            this.BtnBookSearch.UseVisualStyleBackColor = true;
            this.BtnBookSearch.Click += new System.EventHandler(this.BtnBookSearch_Click);
            // 
            // TxtSearchBook
            // 
            this.TxtSearchBook.Location = new System.Drawing.Point(75, 21);
            this.TxtSearchBook.Name = "TxtSearchBook";
            this.TxtSearchBook.Size = new System.Drawing.Size(167, 20);
            this.TxtSearchBook.TabIndex = 3;
            // 
            // DgvPerson
            // 
            this.DgvPerson.AllowUserToAddRows = false;
            this.DgvPerson.AllowUserToDeleteRows = false;
            this.DgvPerson.AllowUserToResizeColumns = false;
            this.DgvPerson.AllowUserToResizeRows = false;
            this.DgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvPerson.Location = new System.Drawing.Point(455, 47);
            this.DgvPerson.Name = "DgvPerson";
            this.DgvPerson.ReadOnly = true;
            this.DgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPerson.Size = new System.Drawing.Size(333, 150);
            this.DgvPerson.TabIndex = 2;
            this.DgvPerson.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPerson_RowHeaderMouseClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Adı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Soyadı";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.AllowUserToResizeColumns = false;
            this.DgvBooks.AllowUserToResizeRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column15,
            this.Column4});
            this.DgvBooks.Location = new System.Drawing.Point(6, 47);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.Size = new System.Drawing.Size(363, 150);
            this.DgvBooks.TabIndex = 1;
            this.DgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitabın Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yazıçı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Sayı";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qiyməti";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.AllowUserToResizeColumns = false;
            this.DgvOrder.AllowUserToResizeRows = false;
            this.DgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column14,
            this.Column12,
            this.Column13});
            this.DgvOrder.Location = new System.Drawing.Point(1, 260);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.Size = new System.Drawing.Size(799, 190);
            this.DgvOrder.TabIndex = 0;
            this.DgvOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOrder_RowHeaderMouseClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Müştərinin adı";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Müştərinin soyaadı";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Kitabın adı";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Kitab sayı";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Götürmə tarixi";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Qaytarma tarixi";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPersonSearch;
        private System.Windows.Forms.TextBox TxtSearchPerson;
        private System.Windows.Forms.Button BtnBookSearch;
        private System.Windows.Forms.TextBox TxtSearchBook;
        private System.Windows.Forms.DataGridView DgvPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.TextBox TxtBookCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpTake;
    }
}