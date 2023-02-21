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
    public partial class Form_Recharge_Phone : Form
    {
        public Form_Recharge_Phone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Recharge();
            myForm.Show();
            Hide();
        }

        private void txt_Account_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Number_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Money_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Account_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Confirn_Transfer();
            myForm.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
