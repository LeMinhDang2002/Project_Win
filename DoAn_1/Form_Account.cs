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
    public partial class Form_Account : Form
    {
        public Form_Account()
        {
            InitializeComponent();
        }

        private void btn_Return_Account_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Home();
            myForm.Show();
            Hide();
        }

        private void btn_History_Transaction_Click(object sender, EventArgs e)
        {
            var myForm = new Form_History_Transaction();
            myForm.Show();
            Hide();
        }
    }
}
