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
using MySql.Data.MySqlClient;

namespace CheckVoucher
{
    public partial class Login : MetroForm
    {
        MySqlCommand com;
        MySqlConnection con;
        MySqlDataReader data;

        public Login()
        {
            InitializeComponent();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; Database = db_voucher; UID = root; password = 0000");
        }


        private void Login_Load(object sender, EventArgs e)
        {
            connection();
        }

        public void selectusers()
        {
            int count = 0;
            con.Open();
            com = new MySqlCommand("Select * from tbl_users where username = '" + usernametxbx.Text + "'and password = '" + passwordtxbx.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {

                count++;

            }
            if (count == 1)
            {

                MainMenu cv = new MainMenu();
                cv.Show();
                this.Hide();
                MessageBox.Show("Welcome, Ma'am Jeanny Alarcon!");
            }
            else
            {

                MessageBox.Show("Wrong password or username");

            }
            con.Close();
        }



        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            selectusers();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
