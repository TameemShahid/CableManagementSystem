namespace CableMangementSystem
{
    partial class SignUpForm
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
            this.name_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(86, 64);
            this.name_box.Margin = new System.Windows.Forms.Padding(2);
            this.name_box.MaxLength = 20;
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(363, 20);
            this.name_box.TabIndex = 0;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(86, 99);
            this.email_box.Margin = new System.Windows.Forms.Padding(2);
            this.email_box.MaxLength = 50;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(363, 20);
            this.email_box.TabIndex = 1;
            // 
            // pwd_box
            // 
            this.pwd_box.Location = new System.Drawing.Point(86, 133);
            this.pwd_box.Margin = new System.Windows.Forms.Padding(2);
            this.pwd_box.MaxLength = 10;
            this.pwd_box.Name = "pwd_box";
            this.pwd_box.PasswordChar = '*';
            this.pwd_box.Size = new System.Drawing.Size(363, 20);
            this.pwd_box.TabIndex = 2;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(86, 168);
            this.phone_box.Margin = new System.Windows.Forms.Padding(2);
            this.phone_box.MaxLength = 11;
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(363, 20);
            this.phone_box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign Me Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telephone";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.pwd_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.name_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}