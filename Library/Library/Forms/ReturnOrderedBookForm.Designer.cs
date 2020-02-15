namespace Library.Forms
{
    partial class ReturnOrderedBookForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtPersonSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBookReturn = new System.Windows.Forms.Button();
            this.TxtDebt = new System.Windows.Forms.TextBox();
            this.LblDebt = new System.Windows.Forms.Label();
            this.TxtLate = new System.Windows.Forms.TextBox();
            this.LblLate = new System.Windows.Forms.Label();
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.TxtPersonSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtPersonName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnBookReturn);
            this.groupBox1.Controls.Add(this.TxtDebt);
            this.groupBox1.Controls.Add(this.LblDebt);
            this.groupBox1.Controls.Add(this.TxtLate);
            this.groupBox1.Controls.Add(this.LblLate);
            this.groupBox1.Controls.Add(this.DgvOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitabı qaytar";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(627, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(161, 36);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "Axtar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtPersonSurname
            // 
            this.TxtPersonSurname.Location = new System.Drawing.Point(485, 32);
            this.TxtPersonSurname.Name = "TxtPersonSurname";
            this.TxtPersonSurname.Size = new System.Drawing.Size(129, 20);
            this.TxtPersonSurname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı";
            // 
            // TxtPersonName
            // 
            this.TxtPersonName.Location = new System.Drawing.Point(350, 32);
            this.TxtPersonName.Name = "TxtPersonName";
            this.TxtPersonName.Size = new System.Drawing.Size(129, 20);
            this.TxtPersonName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı";
            // 
            // BtnBookReturn
            // 
            this.BtnBookReturn.Location = new System.Drawing.Point(581, 393);
            this.BtnBookReturn.Name = "BtnBookReturn";
            this.BtnBookReturn.Size = new System.Drawing.Size(207, 45);
            this.BtnBookReturn.TabIndex = 5;
            this.BtnBookReturn.Text = "Kitabı qaytar";
            this.BtnBookReturn.UseVisualStyleBackColor = true;
            this.BtnBookReturn.Visible = false;
            this.BtnBookReturn.Click += new System.EventHandler(this.BtnBookReturn_Click);
            // 
            // TxtDebt
            // 
            this.TxtDebt.Location = new System.Drawing.Point(356, 406);
            this.TxtDebt.Name = "TxtDebt";
            this.TxtDebt.Size = new System.Drawing.Size(168, 20);
            this.TxtDebt.TabIndex = 4;
            this.TxtDebt.Visible = false;
            // 
            // LblDebt
            // 
            this.LblDebt.AutoSize = true;
            this.LblDebt.Location = new System.Drawing.Point(314, 409);
            this.LblDebt.Name = "LblDebt";
            this.LblDebt.Size = new System.Drawing.Size(35, 13);
            this.LblDebt.TabIndex = 3;
            this.LblDebt.Text = "Borcu";
            this.LblDebt.Visible = false;
            // 
            // TxtLate
            // 
            this.TxtLate.Location = new System.Drawing.Point(91, 406);
            this.TxtLate.Name = "TxtLate";
            this.TxtLate.Size = new System.Drawing.Size(168, 20);
            this.TxtLate.TabIndex = 2;
            this.TxtLate.Visible = false;
            // 
            // LblLate
            // 
            this.LblLate.AutoSize = true;
            this.LblLate.Location = new System.Drawing.Point(8, 409);
            this.LblLate.Name = "LblLate";
            this.LblLate.Size = new System.Drawing.Size(76, 13);
            this.LblLate.TabIndex = 1;
            this.LblLate.Text = "Gecikmə günü";
            this.LblLate.Visible = false;
            // 
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvOrder.Location = new System.Drawing.Point(7, 63);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.Size = new System.Drawing.Size(787, 314);
            this.DgvOrder.TabIndex = 0;
            this.DgvOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOrder_RowHeaderMouseClick);
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
            this.Column2.HeaderText = "Müştərinin adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Müştərinin soyadı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kitabın adı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kitabın sayı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Götürmə tarixi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qaytarma tarixi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Kitabın qiyməti";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // ReturnOrderedBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReturnOrderedBookForm";
            this.Text = "ReturnOrderedBookForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.Button BtnBookReturn;
        private System.Windows.Forms.TextBox TxtDebt;
        private System.Windows.Forms.Label LblDebt;
        private System.Windows.Forms.TextBox TxtLate;
        private System.Windows.Forms.Label LblLate;
        private System.Windows.Forms.TextBox TxtPersonSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}