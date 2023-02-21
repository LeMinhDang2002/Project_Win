using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_1
{
    public partial class Form_Recharge : Form
    {
        public Form_Recharge()
        {
            InitializeComponent();
        }

        private void btn_Return_Recharge_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Home();
            myForm.Show();
            Hide();
        }

        private void btn_Phone_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Recharge_Phone();
            myForm.Show();
            Hide();
        }

        private void btn_TV_Click(object sender, EventArgs e)
        {
            var myForm = new Form_TV();
            myForm.Show();
            Hide();
        }

        private void btn_E_Wallet_Click(object sender, EventArgs e)
        {
            var myForm = new Form_TV();
            myForm.Show();
            Hide();
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Game();
            myForm.Show();
            Hide();
        }

        private void btn_E_W_Click(object sender, EventArgs e)
        {
            var myForm = new Form_E_W();
            myForm.Show();
            Hide();
        }
    }
}
