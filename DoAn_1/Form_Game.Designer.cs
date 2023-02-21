namespace DoAn_1
{
    partial class Form_Game
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
            this.cb_suplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Return_Game = new System.Windows.Forms.Button();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.txt_Number_Phone = new System.Windows.Forms.TextBox();
            this.txt_Account_2 = new System.Windows.Forms.TextBox();
            this.txt_Account_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Chọn Nhà Cung Cấp";
            // 
            // cb_suplier
            // 
            this.cb_suplier.FormattingEnabled = true;
            this.cb_suplier.Location = new System.Drawing.Point(48, 203);
            this.cb_suplier.Name = "cb_suplier";
            this.cb_suplier.Size = new System.Drawing.Size(370, 28);
            this.cb_suplier.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nhập Số Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nhập Số Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Từ Tài Khoản";
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(77, 438);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(274, 49);
            this.btn_Continue.TabIndex = 36;
            this.btn_Continue.Text = "Tiếp Tục";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // btn_Return_Game
            // 
            this.btn_Return_Game.Location = new System.Drawing.Point(3, 2);
            this.btn_Return_Game.Name = "btn_Return_Game";
            this.btn_Return_Game.Size = new System.Drawing.Size(83, 40);
            this.btn_Return_Game.TabIndex = 35;
            this.btn_Return_Game.Text = "Trở Lại";
            this.btn_Return_Game.UseVisualStyleBackColor = true;
            this.btn_Return_Game.Click += new System.EventHandler(this.btn_Return_Game_Click);
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(48, 375);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(370, 27);
            this.txt_Money.TabIndex = 34;
            // 
            // txt_Number_Phone
            // 
            this.txt_Number_Phone.Location = new System.Drawing.Point(48, 292);
            this.txt_Number_Phone.Name = "txt_Number_Phone";
            this.txt_Number_Phone.Size = new System.Drawing.Size(370, 27);
            this.txt_Number_Phone.TabIndex = 33;
            // 
            // txt_Account_2
            // 
            this.txt_Account_2.Location = new System.Drawing.Point(236, 110);
            this.txt_Account_2.Name = "txt_Account_2";
            this.txt_Account_2.Size = new System.Drawing.Size(182, 27);
            this.txt_Account_2.TabIndex = 32;
            // 
            // txt_Account_1
            // 
            this.txt_Account_1.Location = new System.Drawing.Point(48, 110);
            this.txt_Account_1.Name = "txt_Account_1";
            this.txt_Account_1.Size = new System.Drawing.Size(182, 27);
            this.txt_Account_1.TabIndex = 31;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_suplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_Return_Game);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.txt_Number_Phone);
            this.Controls.Add(this.txt_Account_2);
            this.Controls.Add(this.txt_Account_1);
            this.Name = "Form_Game";
            this.Text = "Form_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private ComboBox cb_suplier;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Continue;
        private Button btn_Return_Game;
        private TextBox txt_Money;
        private TextBox txt_Number_Phone;
        private TextBox txt_Account_2;
        private TextBox txt_Account_1;
    }
}