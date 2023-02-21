namespace DoAn_1
{
    partial class Form_Recharge_Phone
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
            this.txt_Account_1 = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Number_Phone = new System.Windows.Forms.TextBox();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Account_1
            // 
            this.txt_Account_1.Location = new System.Drawing.Point(45, 108);
            this.txt_Account_1.Name = "txt_Account_1";
            this.txt_Account_1.Size = new System.Drawing.Size(182, 27);
            this.txt_Account_1.TabIndex = 0;
            this.txt_Account_1.TextChanged += new System.EventHandler(this.txt_Account_1_TextChanged);
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(233, 108);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(182, 27);
            this.txt_Account.TabIndex = 1;
            this.txt_Account.TextChanged += new System.EventHandler(this.txt_Account_TextChanged);
            // 
            // txt_Number_Phone
            // 
            this.txt_Number_Phone.Location = new System.Drawing.Point(45, 204);
            this.txt_Number_Phone.Name = "txt_Number_Phone";
            this.txt_Number_Phone.Size = new System.Drawing.Size(370, 27);
            this.txt_Number_Phone.TabIndex = 2;
            this.txt_Number_Phone.TextChanged += new System.EventHandler(this.txt_Number_Phone_TextChanged);
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(45, 301);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(370, 27);
            this.txt_Money.TabIndex = 3;
            this.txt_Money.TextChanged += new System.EventHandler(this.txt_Money_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trở Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tiếp Tục";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Số Điện Thoại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập Số Tiền";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form_Recharge_Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.txt_Number_Phone);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.txt_Account_1);
            this.Name = "Form_Recharge_Phone";
            this.Text = "Form_Recharge_Phone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Account_1;
        private TextBox txt_Account;
        private TextBox txt_Number_Phone;
        private TextBox txt_Money;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}