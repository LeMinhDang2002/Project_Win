namespace DoAn_1
{
    partial class Form_Account
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_History_Transaction = new System.Windows.Forms.Button();
            this.btn_Return_Account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Số Dư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Khoản Thanh Toán";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 27);
            this.textBox2.TabIndex = 3;
            // 
            // btn_History_Transaction
            // 
            this.btn_History_Transaction.Location = new System.Drawing.Point(107, 228);
            this.btn_History_Transaction.Name = "btn_History_Transaction";
            this.btn_History_Transaction.Size = new System.Drawing.Size(289, 67);
            this.btn_History_Transaction.TabIndex = 4;
            this.btn_History_Transaction.Text = "Xem Lịch Sử Giao Dịch";
            this.btn_History_Transaction.UseVisualStyleBackColor = true;
            this.btn_History_Transaction.Click += new System.EventHandler(this.btn_History_Transaction_Click);
            // 
            // btn_Return_Account
            // 
            this.btn_Return_Account.Location = new System.Drawing.Point(0, 0);
            this.btn_Return_Account.Name = "btn_Return_Account";
            this.btn_Return_Account.Size = new System.Drawing.Size(108, 41);
            this.btn_Return_Account.TabIndex = 5;
            this.btn_Return_Account.Text = "Trở Lại";
            this.btn_Return_Account.UseVisualStyleBackColor = true;
            this.btn_Return_Account.Click += new System.EventHandler(this.btn_Return_Account_Click);
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 382);
            this.Controls.Add(this.btn_Return_Account);
            this.Controls.Add(this.btn_History_Transaction);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Account";
            this.Text = "Form_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button btn_History_Transaction;
        private Button btn_Return_Account;
    }
}