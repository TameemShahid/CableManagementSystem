namespace CableMangementSystem
{
    partial class AddAddress
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.house_box = new System.Windows.Forms.TextBox();
            this.block_box = new System.Windows.Forms.ComboBox();
            this.area_box = new System.Windows.Forms.ComboBox();
            this.city_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit Address";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.house_box);
            this.panel1.Controls.Add(this.block_box);
            this.panel1.Controls.Add(this.area_box);
            this.panel1.Controls.Add(this.city_box);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(212, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 138);
            this.panel1.TabIndex = 3;
            // 
            // house_box
            // 
            this.house_box.Location = new System.Drawing.Point(65, 106);
            this.house_box.Name = "house_box";
            this.house_box.Size = new System.Drawing.Size(121, 20);
            this.house_box.TabIndex = 3;
            this.house_box.TextChanged += new System.EventHandler(this.house_box_TextChanged);
            // 
            // block_box
            // 
            this.block_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.block_box.FormattingEnabled = true;
            this.block_box.Location = new System.Drawing.Point(65, 75);
            this.block_box.Name = "block_box";
            this.block_box.Size = new System.Drawing.Size(121, 21);
            this.block_box.TabIndex = 6;
            this.block_box.SelectedIndexChanged += new System.EventHandler(this.block_box_SelectedIndexChanged);
            // 
            // area_box
            // 
            this.area_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area_box.FormattingEnabled = true;
            this.area_box.Location = new System.Drawing.Point(65, 45);
            this.area_box.Name = "area_box";
            this.area_box.Size = new System.Drawing.Size(121, 21);
            this.area_box.TabIndex = 5;
            this.area_box.SelectedIndexChanged += new System.EventHandler(this.area_box_SelectedIndexChanged);
            // 
            // city_box
            // 
            this.city_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city_box.FormattingEnabled = true;
            this.city_box.Location = new System.Drawing.Point(65, 14);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(121, 21);
            this.city_box.TabIndex = 4;
            this.city_box.SelectedIndexChanged += new System.EventHandler(this.city_box_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "House No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Block";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "AddAddress";
            this.Text = "AddAddress";
            this.Load += new System.EventHandler(this.AddAddress_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox house_box;
        private System.Windows.Forms.ComboBox block_box;
        private System.Windows.Forms.ComboBox area_box;
        private System.Windows.Forms.ComboBox city_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}