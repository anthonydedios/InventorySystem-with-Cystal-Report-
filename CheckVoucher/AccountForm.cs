using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace CheckVoucher
{
    public partial class AccountForm : MetroForm
    {
        MySqlCommand com;
        MySqlConnection con;
        MySqlDataReader data;
        

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            connection();
            selection();

            deleteaccountbtn.Enabled = false;
           
            cancelbtn.Enabled = false;
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; Database = db_voucher; UID = root; password = 0000");
        }


        public void selection()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_users", con);
            data = com.ExecuteReader();

            accountview.Items.Clear();

            while (data.Read())
            {

                ListViewItem lv = new ListViewItem(data.GetValue(0).ToString());
                lv.SubItems.Add(data.GetValue(1).ToString());
                lv.SubItems.Add(data.GetValue(2).ToString());
                accountview.Items.Add(lv);
            }
            con.Close();
        }

        public void disabletext()
        {
            usernametxbx.Enabled = false;
            passwordtxbx.Enabled = false;
            codetxbx.Enabled = false;


        }

        public void enabletext()
        {
            usernametxbx.Enabled = true;
            passwordtxbx.Enabled = true;
            codetxbx.Enabled = true;

        }

        public void itemactivate()
        {

            usernametxbx.Text = accountview.Items[accountview.SelectedItems[0].Index].Text;
            passwordtxbx.Text = accountview.Items[accountview.SelectedItems[0].Index].SubItems[1].Text;
            codetxbx.Text = accountview.Items[accountview.SelectedItems[0].Index].SubItems[2].Text;

        }

        private void accountview_ItemActivate(object sender, EventArgs e)
        {
           
            itemactivate();
            enabledbutton();
        }

        private void accountview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void disabledbutton()
        {
      
            deleteaccountbtn.Enabled = false;
            addaccountbtn.Enabled = false;

        }

        public void enabledbutton()
        {
           
            deleteaccountbtn.Enabled = true;
            cancelbtn.Enabled = true;
            addaccountbtn.Enabled = false;
        }

        private void addaccountbtn_Click(object sender, EventArgs e)
        {
            add();
        }

        public void add()
        {
            if (usernametxbx.Text == "" || passwordtxbx.Text == "" || codetxbx.Text == "")
            {
                MessageBox.Show("Please fill up all the field");

            }
            else 
            {
                clarify();
            }
        }

        public void clear()
        {
            usernametxbx.Text = "";
            passwordtxbx.Text = "";
            codetxbx.Text = "";
        }

        public void insert()
        {
            con.Open();
            com = new MySqlCommand("Insert into db_voucher.tbl_users(username,password,code) values ('" + usernametxbx.Text + "','" + passwordtxbx.Text + "','" + codetxbx.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();

        }

        public void updatex()
        {
            con.Open();
            com = new MySqlCommand("Update tbl_users set username = '" + usernametxbx.Text + "'and password = '" + passwordtxbx.Text + "'where code = '" + codetxbx.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
        }



        public void clarify()
        {
            int count = 0;

            con.Open();
            com = new MySqlCommand("Select * from tbl_users where username = '" + usernametxbx.Text + "'",con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                if (data.HasRows)
                {
                    MessageBox.Show("Username already exist");
                    count++;
                }
            }
            con.Close();

            if (count != 1)
            {
                insert();
                selection();
                clear();

            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
            deleteaccountbtn.Enabled = false;
           
            cancelbtn.Enabled = false;
            addaccountbtn.Enabled = true;
        }

        private void deleteaccountbtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Double check your work", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                delete();
                selection();
                clear();


                deleteaccountbtn.Enabled = false;
            
                cancelbtn.Enabled = false;
                addaccountbtn.Enabled = true;

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }


        public void delete()
        {
            con.Open();
            com = new MySqlCommand("Delete from tbl_users where username = '" + usernametxbx.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Account has been deleted");
        }

        public void update()
        {
            if (usernametxbx.Text == "" || passwordtxbx.Text == "" || codetxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the field");
            }
            else
            {
                int count = 0;

                con.Open();
                com = new MySqlCommand("Select * from tbl_users where username = '" + usernametxbx.Text + "'", con);
                data = com.ExecuteReader();

                while (data.Read())
                {
                    if (data.HasRows)
                    {
                        MessageBox.Show("Username already exist");
                        count++;
                    }
                }
                con.Close();

                if (count != 1)
                {

                    updatex();
                    selection();
                    clear();

                }





            }

        
        }

        private void updateaccountbtn_Click(object sender, EventArgs e)
        {
            update();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Hide();
        }


    }
}
