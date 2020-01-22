namespace CableMangementSystem
{
    partial class ShowCityForm
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
            this.ShowCityListBox = new System.Windows.Forms.ListBox();
            this.ShowAreaListBox = new System.Windows.Forms.ListBox();
            this.ShowBlockListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ShowCityListBox
            // 
            this.ShowCityListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCityListBox.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCityListBox.FormattingEnabled = true;
            this.ShowCityListBox.ItemHeight = 24;
            this.ShowCityListBox.Location = new System.Drawing.Point(33, 46);
            this.ShowCityListBox.Name = "ShowCityListBox";
            this.ShowCityListBox.Size = new System.Drawing.Size(544, 172);
            this.ShowCityListBox.TabIndex = 0;
            this.ShowCityListBox.SelectedIndexChanged += new System.EventHandler(this.ShowCityListBox_SelectedIndexChanged);
            // 
            // ShowAreaListBox
            // 
            this.ShowAreaListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAreaListBox.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAreaListBox.FormattingEnabled = true;
            this.ShowAreaListBox.ItemHeight = 24;
            this.ShowAreaListBox.Location = new System.Drawing.Point(33, 246);
            this.ShowAreaListBox.Name = "ShowAreaListBox";
            this.ShowAreaListBox.Size = new System.Drawing.Size(544, 172);
            this.ShowAreaListBox.TabIndex = 1;
            this.ShowAreaListBox.SelectedIndexChanged += new System.EventHandler(this.ShowAreaListBox_SelectedIndexChanged);
            // 
            // ShowBlockListBox
            // 
            this.ShowBlockListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowBlockListBox.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBlockListBox.FormattingEnabled = true;
            this.ShowBlockListBox.ItemHeight = 24;
            this.ShowBlockListBox.Location = new System.Drawing.Point(33, 446);
            this.ShowBlockListBox.Name = "ShowBlockListBox";
            this.ShowBlockListBox.Size = new System.Drawing.Size(544, 172);
            this.ShowBlockListBox.TabIndex = 2;
            // 
            // ShowCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 664);
            this.Controls.Add(this.ShowBlockListBox);
            this.Controls.Add(this.ShowAreaListBox);
            this.Controls.Add(this.ShowCityListBox);
            this.Name = "ShowCityForm";
            this.Text = "Show Provider City ";
            this.Load += new System.EventHandler(this.ShowCityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShowCityListBox;
        private System.Windows.Forms.ListBox ShowAreaListBox;
        private System.Windows.Forms.ListBox ShowBlockListBox;
    }
}