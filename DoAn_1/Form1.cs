namespace DoAn_1
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Account();
            myForm.Show();
            Hide();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Transfer();
            myForm.Show();
            Hide();
        }

        private void btn_AddMoney_Click(object sender, EventArgs e)
        {
            var myForm = new Form_Recharge();
            myForm.Show();
            Hide();
        }

        private void btn_Saving_Click(object sender, EventArgs e)
        {

        }
    }
}