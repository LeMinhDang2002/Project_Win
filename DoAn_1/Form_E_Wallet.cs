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
    public partial class Form_E_Wallet : Form
    {
        public Form_E_Wallet()
        {
            InitializeComponent();
        }

        private void btn_Return_E_Wallet_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Recharge();
            myForm.Show();
            Hide();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Confirn_Transfer();
            myForm.Show();
            Hide();
        }
    }
}
