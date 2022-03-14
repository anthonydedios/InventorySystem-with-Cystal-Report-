using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CheckVoucher
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckVoucherForm cv = new CheckVoucherForm();
            cv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Log-out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Logging out");
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be added soon!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be added soon!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be added soon!");
        }
    }
}
