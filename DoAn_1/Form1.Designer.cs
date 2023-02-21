namespace DoAn_1
{
    partial class Form_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_AddMoney = new System.Windows.Forms.Button();
            this.btn_Saving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Account
            // 
            this.btn_Account.Location = new System.Drawing.Point(72, 329);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(151, 65);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Tài Khoản";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(247, 329);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(151, 65);
            this.btn_Transfer.TabIndex = 1;
            this.btn_Transfer.Text = "Chuyển Khoản";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_AddMoney
            // 
            this.btn_AddMoney.Location = new System.Drawing.Point(432, 329);
            this.btn_AddMoney.Name = "btn_AddMoney";
            this.btn_AddMoney.Size = new System.Drawing.Size(151, 65);
            this.btn_AddMoney.TabIndex = 2;
            this.btn_AddMoney.Text = "Nạp Tiền";
            this.btn_AddMoney.UseVisualStyleBackColor = true;
            this.btn_AddMoney.Click += new System.EventHandler(this.btn_AddMoney_Click);
            // 
            // btn_Saving
            // 
            this.btn_Saving.Location = new System.Drawing.Point(614, 329);
            this.btn_Saving.Name = "btn_Saving";
            this.btn_Saving.Size = new System.Drawing.Size(151, 65);
            this.btn_Saving.TabIndex = 3;
            this.btn_Saving.Text = "Gửi Tiết Kiệm";
            this.btn_Saving.UseVisualStyleBackColor = true;
            this.btn_Saving.Click += new System.EventHandler(this.btn_Saving_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 452);
            this.Controls.Add(this.btn_Saving);
            this.Controls.Add(this.btn_AddMoney);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_Account);
            this.Name = "Form_Home";
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Account;
        private Button btn_Transfer;
        private Button btn_AddMoney;
        private Button btn_Saving;
    }
}