namespace DoAn_1
{
    partial class Form_Create_Saving
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
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Amount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Return_E_W = new System.Windows.Forms.Button();
            this.txt_Account_2 = new System.Windows.Forms.TextBox();
            this.txt_Account_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Period = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Renews = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Chọn Số Lượng Gửi Tiết Kiệm";
            // 
            // cb_Amount
            // 
            this.cb_Amount.FormattingEnabled = true;
            this.cb_Amount.Location = new System.Drawing.Point(47, 203);
            this.cb_Amount.Name = "cb_Amount";
            this.cb_Amount.Size = new System.Drawing.Size(370, 28);
            this.cb_Amount.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Từ Tài Khoản";
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(95, 463);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(274, 49);
            this.btn_Continue.TabIndex = 36;
            this.btn_Continue.Text = "Tiếp Tục";
            this.btn_Continue.UseVisualStyleBackColor = true;
            // 
            // btn_Return_E_W
            // 
            this.btn_Return_E_W.Location = new System.Drawing.Point(2, 2);
            this.btn_Return_E_W.Name = "btn_Return_E_W";
            this.btn_Return_E_W.Size = new System.Drawing.Size(83, 40);
            this.btn_Return_E_W.TabIndex = 35;
            this.btn_Return_E_W.Text = "Trở Lại";
            this.btn_Return_E_W.UseVisualStyleBackColor = true;
            // 
            // txt_Account_2
            // 
            this.txt_Account_2.Location = new System.Drawing.Point(235, 110);
            this.txt_Account_2.Name = "txt_Account_2";
            this.txt_Account_2.Size = new System.Drawing.Size(182, 27);
            this.txt_Account_2.TabIndex = 32;
            // 
            // txt_Account_1
            // 
            this.txt_Account_1.Location = new System.Drawing.Point(47, 110);
            this.txt_Account_1.Name = "txt_Account_1";
            this.txt_Account_1.Size = new System.Drawing.Size(182, 27);
            this.txt_Account_1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Chọn Kì Hạn";
            // 
            // cb_Period
            // 
            this.cb_Period.FormattingEnabled = true;
            this.cb_Period.Location = new System.Drawing.Point(47, 311);
            this.cb_Period.Name = "cb_Period";
            this.cb_Period.Size = new System.Drawing.Size(370, 28);
            this.cb_Period.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Chọn Tái Tục Hay Không";
            // 
            // cb_Renews
            // 
            this.cb_Renews.FormattingEnabled = true;
            this.cb_Renews.Location = new System.Drawing.Point(47, 409);
            this.cb_Renews.Name = "cb_Renews";
            this.cb_Renews.Size = new System.Drawing.Size(370, 28);
            this.cb_Renews.TabIndex = 45;
            // 
            // Form_Create_Saving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Renews);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Period);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_Return_E_W);
            this.Controls.Add(this.txt_Account_2);
            this.Controls.Add(this.txt_Account_1);
            this.Name = "Form_Create_Saving";
            this.Text = "Form_Create_Saving";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private ComboBox cb_Amount;
        private Label label1;
        private Button btn_Continue;
        private Button btn_Return_E_W;
        private TextBox txt_Account_2;
        private TextBox txt_Account_1;
        private Label label2;
        private ComboBox cb_Period;
        private Label label3;
        private ComboBox cb_Renews;
    }
}