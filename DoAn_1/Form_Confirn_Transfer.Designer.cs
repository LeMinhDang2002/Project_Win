namespace DoAn_1
{
    partial class Form_Confirn_Transfer
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
            this.txt_Code_Confirm = new System.Windows.Forms.TextBox();
            this.btn_Return_Confirm = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Xác Nhận";
            // 
            // txt_Code_Confirm
            // 
            this.txt_Code_Confirm.Location = new System.Drawing.Point(60, 108);
            this.txt_Code_Confirm.Name = "txt_Code_Confirm";
            this.txt_Code_Confirm.Size = new System.Drawing.Size(243, 27);
            this.txt_Code_Confirm.TabIndex = 1;
            // 
            // btn_Return_Confirm
            // 
            this.btn_Return_Confirm.Location = new System.Drawing.Point(12, 12);
            this.btn_Return_Confirm.Name = "btn_Return_Confirm";
            this.btn_Return_Confirm.Size = new System.Drawing.Size(82, 37);
            this.btn_Return_Confirm.TabIndex = 2;
            this.btn_Return_Confirm.Text = "Trở Lại";
            this.btn_Return_Confirm.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(60, 185);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(243, 36);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Xác Nhận";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // Form_Confirn_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 276);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Return_Confirm);
            this.Controls.Add(this.txt_Code_Confirm);
            this.Controls.Add(this.label1);
            this.Name = "Form_Confirn_Transfer";
            this.Text = "Form_Confirn_Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Code_Confirm;
        private Button btn_Return_Confirm;
        private Button btn_Confirm;
    }
}