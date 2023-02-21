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
    public partial class Form_History_Transaction : Form
    {
        public Form_History_Transaction()
        {
            InitializeComponent();
        }

        private void btn_Return_History_Transaction_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Account();
            myForm.Show();
            Hide();
        }
    }
}
