namespace DoAn_1
{
    partial class Form_Transfer
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
            this.txt_Account_1 = new System.Windows.Forms.TextBox();
            this.txt_Account_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Account_Dest = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Option = new System.Windows.Forms.ComboBox();
            this.btn_Return_Transfer = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Tài Khoản";
            // 
            // txt_Account_1
            // 
            this.txt_Account_1.Location = new System.Drawing.Point(31, 97);
            this.txt_Account_1.Name = "txt_Account_1";
            this.txt_Account_1.Size = new System.Drawing.Size(177, 27);
            this.txt_Account_1.TabIndex = 1;
            // 
            // txt_Account_2
            // 
            this.txt_Account_2.Location = new System.Drawing.Point(225, 97);
            this.txt_Account_2.Name = "txt_Account_2";
            this.txt_Account_2.Size = new System.Drawing.Size(193, 27);
            this.txt_Account_2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài Khoản Nhận";
            // 
            // txt_Account_Dest
            // 
            this.txt_Account_Dest.Location = new System.Drawing.Point(31, 196);
            this.txt_Account_Dest.Name = "txt_Account_Dest";
            this.txt_Account_Dest.Size = new System.Drawing.Size(387, 27);
            this.txt_Account_Dest.TabIndex = 4;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(31, 294);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(387, 27);
            this.txt_Amount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Tiền";
            // 
            // cb_Option
            // 
            this.cb_Option.FormattingEnabled = true;
            this.cb_Option.Location = new System.Drawing.Point(31, 376);
            this.cb_Option.Name = "cb_Option";
            this.cb_Option.Size = new System.Drawing.Size(387, 28);
            this.cb_Option.TabIndex = 7;
            // 
            // btn_Return_Transfer
            // 
            this.btn_Return_Transfer.Location = new System.Drawing.Point(2, 1);
            this.btn_Return_Transfer.Name = "btn_Return_Transfer";
            this.btn_Return_Transfer.Size = new System.Drawing.Size(79, 34);
            this.btn_Return_Transfer.TabIndex = 8;
            this.btn_Return_Transfer.Text = "Trở Về";
            this.btn_Return_Transfer.UseVisualStyleBackColor = true;
            this.btn_Return_Transfer.Click += new System.EventHandler(this.btn_Return_Transfer_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(67, 466);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(304, 60);
            this.btn_Continue.TabIndex = 9;
            this.btn_Continue.Text = "Tiếp Tục";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // Form_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 576);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_Return_Transfer);
            this.Controls.Add(this.cb_Option);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Account_Dest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Account_2);
            this.Controls.Add(this.txt_Account_1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Transfer";
            this.Text = "Form_Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Account_1;
        private TextBox txt_Account_2;
        private Label label2;
        private TextBox txt_Account_Dest;
        private TextBox txt_Amount;
        private Label label3;
        private ComboBox cb_Option;
        private Button btn_Return_Transfer;
        private Button btn_Continue;
    }
}