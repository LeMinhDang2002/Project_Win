namespace DoAn_1
{
    partial class Form_History_Transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.dgv_History_Transaction = new System.Windows.Forms.DataGridView();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Return_History_Transaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History_Transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Tài Khoản Thanh Toán";
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(99, 53);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(261, 27);
            this.txt_Account.TabIndex = 1;
            // 
            // dgv_History_Transaction
            // 
            this.dgv_History_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_History_Transaction.Location = new System.Drawing.Point(55, 229);
            this.dgv_History_Transaction.Name = "dgv_History_Transaction";
            this.dgv_History_Transaction.RowHeadersWidth = 51;
            this.dgv_History_Transaction.RowTemplate.Height = 29;
            this.dgv_History_Transaction.Size = new System.Drawing.Size(366, 529);
            this.dgv_History_Transaction.TabIndex = 2;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(55, 183);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(94, 40);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "02/2023";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(193, 183);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(94, 40);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "01/2023";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(327, 183);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(94, 40);
            this.btn_3.TabIndex = 5;
            this.btn_3.Text = "12/2022";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(99, 137);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(261, 27);
            this.txt_Balance.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Dư Khả Dụng";
            // 
            // btn_Return_History_Transaction
            // 
            this.btn_Return_History_Transaction.Location = new System.Drawing.Point(0, 0);
            this.btn_Return_History_Transaction.Name = "btn_Return_History_Transaction";
            this.btn_Return_History_Transaction.Size = new System.Drawing.Size(73, 40);
            this.btn_Return_History_Transaction.TabIndex = 8;
            this.btn_Return_History_Transaction.Text = "Trở Về";
            this.btn_Return_History_Transaction.UseVisualStyleBackColor = true;
            this.btn_Return_History_Transaction.Click += new System.EventHandler(this.btn_Return_History_Transaction_Click);
            // 
            // Form_History_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 770);
            this.Controls.Add(this.btn_Return_History_Transaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.dgv_History_Transaction);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.label1);
            this.Name = "Form_History_Transaction";
            this.Text = "Form_History_Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History_Transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Account;
        private DataGridView dgv_History_Transaction;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private TextBox txt_Balance;
        private Label label2;
        private Button btn_Return_History_Transaction;
    }
}