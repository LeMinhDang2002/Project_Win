namespace DoAn_1
{
    partial class Form_Recharge
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
            this.btn_Return_Recharge = new System.Windows.Forms.Button();
            this.btn_Phone = new System.Windows.Forms.Button();
            this.btn_TV = new System.Windows.Forms.Button();
            this.btn_E_Wallet = new System.Windows.Forms.Button();
            this.btn_Game = new System.Windows.Forms.Button();
            this.btn_E_W = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Return_Recharge
            // 
            this.btn_Return_Recharge.Location = new System.Drawing.Point(0, 0);
            this.btn_Return_Recharge.Name = "btn_Return_Recharge";
            this.btn_Return_Recharge.Size = new System.Drawing.Size(83, 33);
            this.btn_Return_Recharge.TabIndex = 0;
            this.btn_Return_Recharge.Text = "Trở Lại";
            this.btn_Return_Recharge.UseVisualStyleBackColor = true;
            this.btn_Return_Recharge.Click += new System.EventHandler(this.btn_Return_Recharge_Click);
            // 
            // btn_Phone
            // 
            this.btn_Phone.Location = new System.Drawing.Point(29, 112);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(153, 67);
            this.btn_Phone.TabIndex = 1;
            this.btn_Phone.Text = "Điện Thoại";
            this.btn_Phone.UseVisualStyleBackColor = true;
            this.btn_Phone.Click += new System.EventHandler(this.btn_Phone_Click);
            // 
            // btn_TV
            // 
            this.btn_TV.Location = new System.Drawing.Point(218, 112);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(153, 67);
            this.btn_TV.TabIndex = 2;
            this.btn_TV.Text = "Truyền Hình Cáp";
            this.btn_TV.UseVisualStyleBackColor = true;
            this.btn_TV.Click += new System.EventHandler(this.btn_TV_Click);
            // 
            // btn_E_Wallet
            // 
            this.btn_E_Wallet.Location = new System.Drawing.Point(416, 112);
            this.btn_E_Wallet.Name = "btn_E_Wallet";
            this.btn_E_Wallet.Size = new System.Drawing.Size(153, 67);
            this.btn_E_Wallet.TabIndex = 3;
            this.btn_E_Wallet.Text = "Ví Điện Tử";
            this.btn_E_Wallet.UseVisualStyleBackColor = true;
            this.btn_E_Wallet.Click += new System.EventHandler(this.btn_E_Wallet_Click);
            // 
            // btn_Game
            // 
            this.btn_Game.Location = new System.Drawing.Point(614, 112);
            this.btn_Game.Name = "btn_Game";
            this.btn_Game.Size = new System.Drawing.Size(153, 67);
            this.btn_Game.TabIndex = 4;
            this.btn_Game.Text = "Game";
            this.btn_Game.UseVisualStyleBackColor = true;
            this.btn_Game.Click += new System.EventHandler(this.btn_Game_Click);
            // 
            // btn_E_W
            // 
            this.btn_E_W.Location = new System.Drawing.Point(804, 112);
            this.btn_E_W.Name = "btn_E_W";
            this.btn_E_W.Size = new System.Drawing.Size(153, 67);
            this.btn_E_W.TabIndex = 5;
            this.btn_E_W.Text = "Điện Nước";
            this.btn_E_W.UseVisualStyleBackColor = true;
            this.btn_E_W.Click += new System.EventHandler(this.btn_E_W_Click);
            // 
            // Form_Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 287);
            this.Controls.Add(this.btn_E_W);
            this.Controls.Add(this.btn_Game);
            this.Controls.Add(this.btn_E_Wallet);
            this.Controls.Add(this.btn_TV);
            this.Controls.Add(this.btn_Phone);
            this.Controls.Add(this.btn_Return_Recharge);
            this.Name = "Form_Recharge";
            this.Text = "Form_Recharge";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Return_Recharge;
        private Button btn_Phone;
        private Button btn_TV;
        private Button btn_E_Wallet;
        private Button btn_Game;
        private Button btn_E_W;
    }
}