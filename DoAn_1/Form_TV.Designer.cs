namespace DoAn_1
{
    partial class Form_TV
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.txt_Number_Phone = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Account_1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số Tiền Phải Trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Từ Tài Khoản";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Tiếp Tục";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Trở Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(47, 303);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(370, 27);
            this.txt_Money.TabIndex = 12;
            // 
            // txt_Number_Phone
            // 
            this.txt_Number_Phone.Location = new System.Drawing.Point(47, 206);
            this.txt_Number_Phone.Name = "txt_Number_Phone";
            this.txt_Number_Phone.Size = new System.Drawing.Size(268, 27);
            this.txt_Number_Phone.TabIndex = 11;
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(235, 110);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(182, 27);
            this.txt_Account.TabIndex = 10;
            // 
            // txt_Account_1
            // 
            this.txt_Account_1.Location = new System.Drawing.Point(47, 110);
            this.txt_Account_1.Name = "txt_Account_1";
            this.txt_Account_1.Size = new System.Drawing.Size(182, 27);
            this.txt_Account_1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "Kiểm Tra";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form_TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.txt_Number_Phone);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.txt_Account_1);
            this.Name = "Form_TV";
            this.Text = "Form_TV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox txt_Money;
        private TextBox txt_Number_Phone;
        private TextBox txt_Account;
        private TextBox txt_Account_1;
        private Button button3;
    }
}