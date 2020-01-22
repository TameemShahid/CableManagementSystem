namespace CableMangementSystem
{
    partial class ReportForm
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
            this.GenReportBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchNameTxtBox = new System.Windows.Forms.TextBox();
            this.CheckBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.MonthCheckBox = new System.Windows.Forms.CheckBox();
            this.ReceiveCheckBox = new System.Windows.Forms.CheckBox();
            this.PaymentCheckBox = new System.Windows.Forms.CheckBox();
            this.HouseCheckBox = new System.Windows.Forms.CheckBox();
            this.UserNameCheckBox = new System.Windows.Forms.CheckBox();
            this.UserIdCheckBox = new System.Windows.Forms.CheckBox();
            this.HistoryIdCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchCustomerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CheckBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenReportBtn
            // 
            this.GenReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GenReportBtn.Location = new System.Drawing.Point(204, 596);
            this.GenReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenReportBtn.Name = "GenReportBtn";
            this.GenReportBtn.Size = new System.Drawing.Size(1201, 45);
            this.GenReportBtn.TabIndex = 2;
            this.GenReportBtn.Text = "Generate Report ";
            this.GenReportBtn.UseVisualStyleBackColor = true;
            this.GenReportBtn.Click += new System.EventHandler(this.GenReportBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1534, 366);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SelectionChanged);
            // 
            // SearchNameTxtBox
            // 
            this.SearchNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameTxtBox.Location = new System.Drawing.Point(37, 62);
            this.SearchNameTxtBox.Name = "SearchNameTxtBox";
            this.SearchNameTxtBox.Size = new System.Drawing.Size(1094, 26);
            this.SearchNameTxtBox.TabIndex = 4;
            // 
            // CheckBoxGroupBox
            // 
            this.CheckBoxGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxGroupBox.Controls.Add(this.StatusCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.MonthCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.ReceiveCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.PaymentCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.HouseCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.UserNameCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.UserIdCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.HistoryIdCheckBox);
            this.CheckBoxGroupBox.Location = new System.Drawing.Point(37, 114);
            this.CheckBoxGroupBox.Name = "CheckBoxGroupBox";
            this.CheckBoxGroupBox.Size = new System.Drawing.Size(1534, 64);
            this.CheckBoxGroupBox.TabIndex = 13;
            this.CheckBoxGroupBox.TabStop = false;
            this.CheckBoxGroupBox.Text = "Filters";
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.AutoSize = true;
            this.StatusCheckBox.Location = new System.Drawing.Point(1103, 25);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(86, 24);
            this.StatusCheckBox.TabIndex = 20;
            this.StatusCheckBox.Text = "Status ";
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // MonthCheckBox
            // 
            this.MonthCheckBox.AutoSize = true;
            this.MonthCheckBox.Location = new System.Drawing.Point(1002, 25);
            this.MonthCheckBox.Name = "MonthCheckBox";
            this.MonthCheckBox.Size = new System.Drawing.Size(80, 24);
            this.MonthCheckBox.TabIndex = 19;
            this.MonthCheckBox.Text = "Month";
            this.MonthCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReceiveCheckBox
            // 
            this.ReceiveCheckBox.AutoSize = true;
            this.ReceiveCheckBox.Location = new System.Drawing.Point(858, 25);
            this.ReceiveCheckBox.Name = "ReceiveCheckBox";
            this.ReceiveCheckBox.Size = new System.Drawing.Size(123, 24);
            this.ReceiveCheckBox.TabIndex = 18;
            this.ReceiveCheckBox.Text = "Recieved By";
            this.ReceiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaymentCheckBox
            // 
            this.PaymentCheckBox.AutoSize = true;
            this.PaymentCheckBox.Location = new System.Drawing.Point(740, 25);
            this.PaymentCheckBox.Name = "PaymentCheckBox";
            this.PaymentCheckBox.Size = new System.Drawing.Size(97, 24);
            this.PaymentCheckBox.TabIndex = 17;
            this.PaymentCheckBox.Text = "Payment\r\n";
            this.PaymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // HouseCheckBox
            // 
            this.HouseCheckBox.AutoSize = true;
            this.HouseCheckBox.Location = new System.Drawing.Point(637, 25);
            this.HouseCheckBox.Name = "HouseCheckBox";
            this.HouseCheckBox.Size = new System.Drawing.Size(82, 24);
            this.HouseCheckBox.TabIndex = 16;
            this.HouseCheckBox.Text = "House\r\n";
            this.HouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserNameCheckBox
            // 
            this.UserNameCheckBox.AutoSize = true;
            this.UserNameCheckBox.Location = new System.Drawing.Point(501, 25);
            this.UserNameCheckBox.Name = "UserNameCheckBox";
            this.UserNameCheckBox.Size = new System.Drawing.Size(115, 24);
            this.UserNameCheckBox.TabIndex = 15;
            this.UserNameCheckBox.Text = "User Name";
            this.UserNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.Location = new System.Drawing.Point(393, 25);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(87, 24);
            this.UserIdCheckBox.TabIndex = 14;
            this.UserIdCheckBox.Text = "User Id";
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // HistoryIdCheckBox
            // 
            this.HistoryIdCheckBox.AutoSize = true;
            this.HistoryIdCheckBox.Location = new System.Drawing.Point(270, 25);
            this.HistoryIdCheckBox.Name = "HistoryIdCheckBox";
            this.HistoryIdCheckBox.Size = new System.Drawing.Size(102, 24);
            this.HistoryIdCheckBox.TabIndex = 13;
            this.HistoryIdCheckBox.Text = "History Id";
            this.HistoryIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sql Query";
            // 
            // SearchCustomerBtn
            // 
            this.SearchCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCustomerBtn.Location = new System.Drawing.Point(1159, 53);
            this.SearchCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchCustomerBtn.Name = "SearchCustomerBtn";
            this.SearchCustomerBtn.Size = new System.Drawing.Size(423, 45);
            this.SearchCustomerBtn.TabIndex = 15;
            this.SearchCustomerBtn.Text = "Search Customer";
            this.SearchCustomerBtn.UseVisualStyleBackColor = true;
            this.SearchCustomerBtn.Click += new System.EventHandler(this.SearchCustomerBtn_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 740);
            this.Controls.Add(this.SearchCustomerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxGroupBox);
            this.Controls.Add(this.SearchNameTxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GenReportBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CheckBoxGroupBox.ResumeLayout(false);
            this.CheckBoxGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GenReportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchNameTxtBox;
        private System.Windows.Forms.GroupBox CheckBoxGroupBox;
        private System.Windows.Forms.CheckBox StatusCheckBox;
        private System.Windows.Forms.CheckBox MonthCheckBox;
        private System.Windows.Forms.CheckBox ReceiveCheckBox;
        private System.Windows.Forms.CheckBox PaymentCheckBox;
        private System.Windows.Forms.CheckBox HouseCheckBox;
        private System.Windows.Forms.CheckBox UserNameCheckBox;
        private System.Windows.Forms.CheckBox UserIdCheckBox;
        private System.Windows.Forms.CheckBox HistoryIdCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchCustomerBtn;
    }
}