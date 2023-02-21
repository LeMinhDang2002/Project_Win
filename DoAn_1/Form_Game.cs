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
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();
        }

        private void btn_Return_Game_Click(object sender, EventArgs e)
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
