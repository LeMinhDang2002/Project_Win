namespace DoAn_1
{
    partial class Form_Saving
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
            this.dgv_Saving = new System.Windows.Forms.DataGridView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Saving)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Saving
            // 
            this.dgv_Saving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Saving.Location = new System.Drawing.Point(341, 43);
            this.dgv_Saving.Name = "dgv_Saving";
            this.dgv_Saving.RowHeadersWidth = 51;
            this.dgv_Saving.RowTemplate.Height = 29;
            this.dgv_Saving.Size = new System.Drawing.Size(447, 395);
            this.dgv_Saving.TabIndex = 0;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(3, 2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(94, 38);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.Text = "button1";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sổ";
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(23, 237);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(276, 57);
            this.btn_Withdraw.TabIndex = 4;
            this.btn_Withdraw.Text = "Rút Sổ";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(23, 323);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(276, 57);
            this.btn_Create.TabIndex = 5;
            this.btn_Create.Text = "Tạo Sổ Mới";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // Form_Saving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.dgv_Saving);
            this.Name = "Form_Saving";
            this.Text = "Form_Saving";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Saving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Saving;
        private Button btn_Return;
        private TextBox textBox1;
        private Label label1;
        private Button btn_Withdraw;
        private Button btn_Create;
    }
}