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
    public partial class CheckVoucherForm : MetroForm
    {

        MySqlCommand com;
        MySqlConnection con;
        MySqlDataReader data;

        int count = 0;

        public CheckVoucherForm()
        {
            InitializeComponent();
        }

        private void CheckVoucherForm_Load(object sender, EventArgs e)
        {
            NumberToWords();
            printrefresh();
            connection();
            delete();
            Voucherviewer.RefreshReport();
            generatecheckvoucherno();
            generatecheckno();
            genereteaccount();
        }

        public void genereteaccount()
        {
            con.Open();
            com = new MySqlCommand("Select Max(accountid) as maxaccountid from tbl_accountspayableno", con);
            data = com.ExecuteReader();
            data.Read();

            int x = data.GetInt32("maxaccountid");
            x++;
            String y = System.Convert.ToString(x);
            generateid.Text = y;

            con.Close();

        }

        public void insertaccountpayable()
        {
            con.Open();
            com = new MySqlCommand("Insert into db_voucher.tbl_accountpayable(Accountspayable2,Accountspayablename2,Accountspayable3,Accountspayablename3,Accountspayable4,Accountspayablename4,Accountspayable5,Accountspayablename5,Accountspayable6,Accountspayablename6,Accountspayable7,Accountspayablename7,Accountspayable8,Accountspayablename8,accountid) values ('" + payabletxbx1.Text + "','" + payablenametxbx1.Text + "','" + payabletxbx2.Text + "','" + payablenametxbx2.Text + "','" + payabletxbx3.Text + "','" + payablenametxbx3.Text + "','" + payabletxbx4.Text + "','" + payablenametxbx4.Text + "','" + payabletxbx5.Text + "','" + payablenametxbx5.Text + "','" + payabletxbx6.Text + "','" + payablenametxbx6.Text + "','" + payabletxbx7.Text + "','" + payablenametxbx7.Text + "','" + generateid.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }


        public string NumberToWords(int number = 0)
       {
           
           if (number == 0)
               return "Zero";

           if (number < 0)
               return "Minus " + NumberToWords(Math.Abs(number));

           string words = "";

      

           if ((number / 1000000) > 0)
           {
               words += NumberToWords(number / 1000000) + " Million ";
               number %= 1000000;
           }

           if ((number / 1000) > 0)
           {
               words += NumberToWords(number / 1000) + " Thousand ";
               number %= 1000;
           }

           if ((number / 100) > 0)
           {
               words += NumberToWords(number / 100) + " Hundred ";
               number %= 100;
           }





           if (number > 0)
           {
               if (words != "")
                   words += "and ";

               var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
               var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

               if (number < 20)
                   words += unitsMap[number];
               else
               {
                   words += tensMap[number / 10];
                   if ((number % 10) > 0)
                   words += "-" + unitsMap[number % 10];
               }
               
          }
            
           return words;         
       }
        public void generatecheckvoucherno()
        {
            con.Open();
            com = new MySqlCommand("Select MAX(checkvoucherno) as checknoid from tbl_number", con);
            data = com.ExecuteReader();
            data.Read();
            int x = data.GetInt32("checknoid");
            x++;

            String holder = System.Convert.ToString(x);

            haha.Text = holder;

            String result = holder.ToString().PadLeft(4, '0');

            String final = "11-" + result;

            voucherchecknoholder.Text = result;
            vouchercheckno.Text = final;
            con.Close();
        }

        public void generatecheckno()
        {
            con.Open();
            com = new MySqlCommand("Select MAX(checkno) as checkvouchertext from tbl_number", con);
            data = com.ExecuteReader();
            data.Read();

            int x = data.GetInt32("checkvouchertext");
            x++;

            String holder = System.Convert.ToString(x);

            checkno.Text = holder;
            
            con.Close();
        }

        public void insertcheckvoucher()
        {

            con.Open();
            com = new MySqlCommand("Insert into db_voucher.tbl_number(checkvoucherholder,checkvoucherno,checkno) values ('" + vouchercheckno.Text + "','" + voucherchecknoholder.Text + "','" + checkno.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }


        public void printrefresh()
        {

            CheckVoucherPrint objReport1 = new CheckVoucherPrint();
            Voucherviewer.ReportSource = objReport1;
        }

        public void four()
        {
            
            if (count == 6)
            {

                donebtn.Visible = true;
            }

            else
            {
                donebtn.Visible = false;
            }
        }

        public void connection()
        {

            con = new MySqlConnection("Server = localhost; Database = db_voucher; UID = root; password = 0000");
            con.Open();
            con.Close();
        }

        public void clearinfo1()
        {
            datetxbx.Text = "";
            payeetxbx.Text = "";
            amountinwordtxbx.Text = "";
        }

        public void clearpayment()
        {
            vattxbx.Text = "";
            witholdingtxbx.Text = "";
        }

        public void clearinfo2()
        {
            approvedbytxbx.Text = "";

        }

        public void clearinfo3()
        {
            banknametxbx.Text = "";
            receivedbytxbx.Text = "";

        }

        public void clearparticulars()
        {
            rfptxbx.Text = "";
            rfpdatetxbxrfpdatetxbx.Text = "";

        }

        public void disableinfo1()
        {
            datetxbx.Enabled = false;
            payeetxbx.Enabled = false;

        }


        public void disableparticulars()
        {
            rfptxbx.Enabled = false;
            rfpdatetxbxrfpdatetxbx.Enabled = false;

        }

        public void disablepayment()
        {
            amounttxbx.Enabled = false;
            accountspayabletxbx.Enabled = false;
            vattxbx.Enabled = false;
            witholdingtxbx.Enabled = false;

        }

        public void disableinfo2()
        {
            preparedbytxbx.Enabled = false;
            verifiedbytxbx.Enabled = false;
            approvedbytxbx.Enabled = false;
        }

        public void disableinfo3()
        {
            banknametxbx.Enabled = false;
            receivedbytxbx.Enabled = false;
        }


        public void enableinfo1()
        {
            datetxbx.Enabled = true;
            payeetxbx.Enabled = true;
            amountinwordtxbx.Enabled = true;

        }

        public void enablepayment()
        {
            amounttxbx.Enabled = true;
            accountspayabletxbx.Enabled = true;
            vattxbx.Enabled = true;
            witholdingtxbx.Enabled = true;

        }

        public void enableparticulars()
        {
            rfptxbx.Enabled = true;
            rfpdatetxbxrfpdatetxbx.Enabled = true;

        }


        public void enableinfo2()
        {
            preparedbytxbx.Enabled = true;
            verifiedbytxbx.Enabled = true;
            approvedbytxbx.Enabled = true;
        }

        public void enaableinfo3()
        {
            banknametxbx.Enabled = true;
            receivedbytxbx.Enabled = true;
        }
     
        public void checkinfo1()
        {

            if (datetxbx.Text == "" || payeetxbx.Text == "" || amountinwordtxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");
            }
            else
            {
                doneinfo1.Visible = true;
                 amounttxbx.Text = amountinwordtxbx.Text;
                disableinfo1();
                donebtninfo1.Enabled = false;
                cancelinfo1.Visible = true;
                count++;
                four();

                NumberToWords();
                amountinwordtxbx.Text = NumberToWords(Convert.ToInt32(amountinwordtxbx.Text));
            }
        }

        public void checkpayment()
        {

            if (amounttxbx.Text == "" || vattxbx.Text == "" || witholdingtxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");

            }
            else
            {
                donepayment2.Visible = true;
                disablepayment();
                donebtnpayment.Enabled = false;
                cancelpayment.Visible = true;
                count++;

                four();

            }
        }

        public void checkinfo2()
        {

            if (preparedbytxbx.Text == "" || verifiedbytxbx.Text == "")
            {
                MessageBox.Show("Please Fill up all the fields");

            }
            else
            {
                doneinfo2.Visible = true;
                disableinfo2();
                donebtninfo2.Enabled = false;
                cancelinfo2.Visible = true;
                count++;

                four();

            }
        }

        public void checkinfo3()
        {
            if (banknametxbx.Text == "" || receivedbytxbx.Text == "")
            {

                MessageBox.Show("Please Fill up all the fields");
            }
            else
            {
                doneinfo3.Visible = true;
                disableinfo3();
                donebtninfo3.Enabled = false;
                count++;
                cancelinfo3.Visible = true;
     
                four();
            }
           
        }

        public void checkparticulars()
        {
  
            if (rfptxbx.Text == "" || rfpdatetxbxrfpdatetxbx.Text == "")
            {
            
                MessageBox.Show("Please Fill up all the fields");

            }

            else
            {
                doneparticulars.Visible = true;
                disableparticulars();
                doneparticularsbtn.Enabled = false;
                count++;
                cancelparticulars.Visible = true;

                four();

            }
        }


        private void donebtninfo1_Click(object sender, EventArgs e)
        {
            
            checkinfo1();

            
    

            
        }

        private void donebtnpayment_Click(object sender, EventArgs e)
        {
            checkpayment();
           
            
        }

        public void computation()
        {

            double acctpayable1 = Convert.ToDouble(payabletxbx1.Text);
            double acctpayable2 = Convert.ToDouble(payabletxbx2.Text);
            double acctpayable3 = Convert.ToDouble(payabletxbx3.Text);
            double acctpayable4 = Convert.ToDouble(payabletxbx4.Text);
            double acctpayable5 = Convert.ToDouble(payabletxbx5.Text);
            double acctpayable6 = Convert.ToDouble(payabletxbx6.Text);
            double acctpayable7 = Convert.ToDouble(payabletxbx7.Text);

            double acctpayable = acctpayable1 + acctpayable2 + acctpayable3 + acctpayable4 + acctpayable5 + acctpayable6 + acctpayable7;

            double witholding = Convert.ToDouble(witholdingtxbx.Text);
            double vat = Convert.ToDouble(vattxbx.Text);

            double vat100 = vat / 100;

            double vatfinal = (vat100 * acctpayable); //Math.Round

            var f = vatfinal;

            f = Math.Truncate(f * 100) / 100;

            double vattotal = Math.Floor(f + acctpayable); //Math.Round

            String xy = System.Convert.ToString(acctpayable);

            cashinbankholder.Text = xy;

            String vatfinalst = System.Convert.ToString(vatfinal);
            String vatfinaltotal = System.Convert.ToString(vattotal);
            String vatfinaltotalplus = vatfinaltotal + ".00";



            //donewithaccountpayablewithtax

            double witholdingtax = witholding / 100;

            double witholdingxpayable = (witholdingtax * acctpayable); //Math.Round

            double trywith = witholdingxpayable;

            double minuswitholding = (acctpayable - witholdingxpayable); //Math.Round

            double x = vattotal - witholdingxpayable;

            String witholdingst = System.Convert.ToString(witholdingxpayable);

            String eto = System.Convert.ToString(x);


            //donewithwitholdingtax

            double cashinbank = Math.Floor(acctpayable - witholdingxpayable); //Math.Round


            String cashinbankst = System.Convert.ToString(cashinbank);

            double y = witholdingxpayable + x;

            String yy = System.Convert.ToString(y);

            String yytotal = yy + ".00";

            totalofvat.Text = vatfinaltotalplus;
            vatholder.Text = vatfinalst; //output
            witholdintaxholder.Text = witholdingst;
            cashinbankholder.Text = xy; //output
            witholdingfinaltext.Text = eto;
            credittxbx.Text = yytotal;

        }

        private void donebtninfo2_Click(object sender, EventArgs e)
        {
            checkinfo2();
        }

        private void donebtninfo3_Click(object sender, EventArgs e)
        {
            checkinfo3();
        }

        private void cancelinfo1_Click(object sender, EventArgs e)
        {
            doneinfo1.Visible = false;
            clearinfo1();
            enableinfo1();
            donebtninfo1.Enabled = true;
            count--;
            cancelinfo1.Visible = false;

            four();

       
        }

        private void cancelpayment_Click(object sender, EventArgs e)
        {
            donepayment2.Visible = false;
            clearpayment();
            enablepayment();
            donebtnpayment.Enabled = true;
            count--;
            cancelpayment.Visible = false;

            

            four();

        }

        private void cancelinfo2_Click(object sender, EventArgs e)
        {
            doneinfo2.Visible = false;
            clearinfo2();
            enableinfo2();
            donebtninfo2.Enabled = true;
            count--;
            cancelinfo2.Visible = false;

        

            four();

        }

        private void cancelinfo3_Click(object sender, EventArgs e)
        {
            doneinfo3.Visible = false;
            clearinfo3();
            enaableinfo3();
            donebtninfo3.Enabled = true;
            count--;
            cancelinfo3.Visible = false;

    
            four();
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (amountinwordtxbx.Text == "")
            {

                MessageBox.Show("Fill up all the field");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Double check your work", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                computation();        
                cancelfinalbtn.Visible = true;
                donebtn.Visible = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Visible = true;
                groupBox7.Enabled = false;
                printbtn.Visible = true;
                PARTICULARS.Enabled = false;
                deleteall.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

       
        }

        private void cashinbankholder_Click(object sender, EventArgs e)
        {

        }

        private void witholdintaxholder_Click(object sender, EventArgs e)
        {

        }

        private void vatholder_Click(object sender, EventArgs e)
        {

        }

        private void totalofvat_Click(object sender, EventArgs e)
        {

        }

        private void cancelfinalbtn_Click(object sender, EventArgs e)
        {

            if (payabletxbx2.Text == "")
            {
                payabletxbx2.Text = "0";
                payabletxbx3.Text = "0";
                payabletxbx4.Text = "0";
                payabletxbx5.Text = "0";
                payabletxbx6.Text = "0";
                payabletxbx7.Text = "0";
            }
            else if (payabletxbx3.Text == "")
            {
                payabletxbx3.Text = "0";
                payabletxbx4.Text = "0";
                payabletxbx5.Text = "0";
                payabletxbx6.Text = "0";
                payabletxbx7.Text = "0";
            }
            else if (payabletxbx4.Text == "")
            {
                payabletxbx4.Text = "0";
                payabletxbx5.Text = "0";
                payabletxbx6.Text = "0";
                payabletxbx7.Text = "0";
            }
            else if (payabletxbx5.Text == "")
            {
                payabletxbx5.Text = "0";
                payabletxbx6.Text = "0";
                payabletxbx7.Text = "0";
            }
            else if (payabletxbx6.Text == "")
            {
                payabletxbx6.Text = "0";
                payabletxbx7.Text = "0";
            }
            else if (payabletxbx7.Text == "")
            {
                payabletxbx7.Text = "0";
            }

            deleteall.Enabled = true;

            Voucherviewer.Enabled = false;
            cashinbankholder.Text = "";
            vatholder.Text = "";
            totalofvat.Text = "";
            witholdintaxholder.Text = "";
            witholdingfinaltext.Text = "";
            credittxbx.Text = "";
            cancelfinalbtn.Visible = false;
            donebtn.Visible = true;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Visible = false;
            groupBox7.Enabled = true;
            printbtn.Visible = false;
            PARTICULARS.Enabled = true;

        }


             public void insert()
        {
            con.Open();
            com = new MySqlCommand("Insert into db_voucher.tbl_voucher (Date,Payee,Amountinwords,Amount,Accountspayable,Vat,Witholdingtax,Preparedby,Verifiedby,Approvedby,Bankname,Receivedby,Totaldebit,Totalcredit,Cashinbank,rfa,rfadate) values ('" + datetxbx.Text + "','" + payeetxbx.Text + "','" + amountinwordtxbx.Text + "','" + amounttxbx.Text + "','" + accountspayabletxbx.Text + "','" + vatholder.Text + "','" + witholdingfinaltext.Text + "','" + preparedbytxbx.Text + "','" + verifiedbytxbx.Text + "','" + approvedbytxbx.Text + "','" + banknametxbx.Text + "','" + receivedbytxbx.Text + "','" + totalofvat.Text + "','" + credittxbx.Text + "','" + witholdintaxholder.Text + "','" + rfptxbx.Text + "','" + rfpdatetxbxrfpdatetxbx.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void delete()
        {
            con.Open();
            com = new MySqlCommand("Truncate table tbl_voucher", con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void deletenumber()
        {
            con.Open();
            com = new MySqlCommand("Truncate table tbl_number", con);
            com.ExecuteNonQuery();
            con.Close();

        }

        public void truncatex()
        {
            con.Open();
            com = new MySqlCommand("Truncate table tbl_accountpayable", con);
            com.ExecuteNonQuery();
            con.Close();

        }


           public void insertpay()
        {
            delete();
            deletenumber();
            truncatex();
         
            insert();
            insertcheckvoucher();
            insertaccountpayable();

            generatecheckvoucherno();
            generatecheckno();

            Voucherviewer.RefreshReport();
            Voucherviewer.Enabled = true;
           }



        private void printbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Double check your work", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int x = 0;
                if (payabletxbx2.Text == "0")
                {
                    payabletxbx2.Text = null;
                    payabletxbx3.Text = null;
                    payabletxbx4.Text = null;
                    payabletxbx5.Text = null;
                    payabletxbx6.Text = null;
                    payabletxbx7.Text = null;
                    x++;
                    insertpay();
 
                }

                    else if (payabletxbx3.Text == "0")
                    {

                        payabletxbx3.Text = null;
                        payabletxbx4.Text = null;
                        payabletxbx5.Text = null;
                        payabletxbx6.Text = null;
                        payabletxbx7.Text = null;
                        x++;
                        insertpay();
                  
                    }
                        else if (payabletxbx4.Text == "0")
                        {
                            payabletxbx4.Text = null;
                            payabletxbx5.Text = null;
                            payabletxbx6.Text = null;
                            payabletxbx7.Text = null;
                            x++;
                            insertpay();
                       
                        }
                            else if (payabletxbx5.Text == "0")
                            {
                                payabletxbx5.Text = null;
                                payabletxbx6.Text = null;
                                payabletxbx7.Text = null;
                                x++;
                                insertpay();
                             
                            }
                                else if (payabletxbx6.Text == "0")
                                {

                                    payabletxbx6.Text = null;
                                    payabletxbx7.Text = null;
                                    x++;
                                    insertpay();
                                }

                                    else if (payabletxbx7.Text == "0")
                                    {
                                        payabletxbx7.Text = null;
                                        x++;
                                        insertpay();
                                    }
                        
                }
                else if (dialogResult == DialogResult.No)
            {
                return;
            }
          
        }


     
        

   

        private void metroButton1_Click_2(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Hide();
        }

        private void doneparticularsbtn_Click(object sender, EventArgs e)
        {
            checkparticulars();
        }



        private void cancelparticulars_Click(object sender, EventArgs e)
        {
            doneparticulars.Visible = false;
            clearparticulars();
            enableparticulars();
            doneparticularsbtn.Enabled = true;
            count--;
            cancelparticulars.Visible = false;
            four();
        }

        private void amounttxbx_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }*/
        }

        private void vattxbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void witholdingtxbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void amountinwordtxbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }*/
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
  
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(voucherchecknoholder.Text);
            x++;

            x.ToString().PadLeft(4, '0');

            String y = System.Convert.ToString(x);
            voucherchecknoholder.Text = y;
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(voucherchecknoholder.Text);
            x--;

            x.ToString().PadLeft(4, '0');

            String y = System.Convert.ToString(x);
            voucherchecknoholder.Text = y;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            if (accountnametxbx.Text == "" || accountspayabletxbx.Text == "")
            {
                MessageBox.Show("Please fillup all the field");
            }
            else if (payablenametxbx7.Text != "")
            {

                addpaymentbtn.Enabled = false;
                MessageBox.Show("ad");

            }

            else
            {


                if (payablenametxbx7.Text != "")
                {

                    MessageBox.Show("You've reach the maximum limit");
                }


                DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + accountnametxbx.Text + "?", "Double check your work", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (payablenametxbx1.Text == "")
                    {
                        payablenametxbx1.Text = accountnametxbx.Text;
                        payabletxbx1.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Insert into db_voucher.tbl_accountpayable(Accountspayable2,Accountspayablename2,Accountspayable3,Accountspayablename3,Accountspayable4,Accountspayablename4,Accountspayable5,Accountspayablename5,Accountspayable6,Accountspayablename6,Accountspayable7,Accountspayablename7,Accountspayable8,Accountspayablename8,accountid) values ('" + payabletxbx1.Text + "','" + payablenametxbx1.Text + "','" + payabletxbx2.Text + "','" + payablenametxbx2.Text + "','" + payabletxbx3.Text + "','" + payablenametxbx3.Text + "','" + payabletxbx4.Text + "','" + payablenametxbx4.Text + "','" + payabletxbx5.Text + "','" + payablenametxbx5.Text + "','" + payabletxbx6.Text + "','" + payablenametxbx6.Text + "','" + payabletxbx7.Text + "','" + payablenametxbx7.Text + "','" + generateid.Text + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added1.Visible = true;

                        MessageBox.Show("*" + payablenametxbx1.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

              

                        return;
                    }
                    if (payablenametxbx2.Text == "")
                    {
                        payablenametxbx2.Text = accountnametxbx.Text;
                        payabletxbx2.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Update tbl_accountpayable set Accountspayable3 = '" + payabletxbx2.Text + "',Accountspayablename3 = '" + payablenametxbx2.Text + "' where accountid = " + generateid.Text + "", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added2.Visible = true;

                        MessageBox.Show("*" + payablenametxbx2.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

                       

                        return;

                    }
                    if (payablenametxbx3.Text == "")
                    {
                        payablenametxbx3.Text = accountnametxbx.Text;
                        payabletxbx3.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Update tbl_accountpayable set Accountspayable4 = '" + payabletxbx3.Text + "',Accountspayablename4 = '" + payablenametxbx3.Text + "' where accountid = " + generateid.Text + "", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added3.Visible = true;

                        MessageBox.Show("*" + payablenametxbx3.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

                   

                        return;
                    }
                    if (payablenametxbx4.Text == "")
                    {
                        payablenametxbx4.Text = accountnametxbx.Text;
                        payabletxbx4.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Update tbl_accountpayable set Accountspayable5 = '" + payabletxbx4.Text + "',Accountspayablename5 = '" + payablenametxbx4.Text + "' where accountid = " + generateid.Text + "", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added4.Visible = true;

                        MessageBox.Show("*" + payablenametxbx4.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

                        

                        return;
                    }
                    if (payablenametxbx5.Text == "")
                    {
                        payablenametxbx5.Text = accountnametxbx.Text;
                        payabletxbx5.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Update tbl_accountpayable set Accountspayable6 = '" + payabletxbx5.Text + "',Accountspayablename6 = '" + payablenametxbx5.Text + "' where accountid = " + generateid.Text + "", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added5.Visible = true;

                        MessageBox.Show("*" + payablenametxbx5.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

                      

                        return;
                    }
                    if (payablenametxbx6.Text == "")
                    {
                        payablenametxbx6.Text = accountnametxbx.Text;
                        payabletxbx6.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Update tbl_accountpayable set Accountspayable7 = '" + payabletxbx6.Text + "',Accountspayablename7 = '" + payablenametxbx6.Text + "' where accountid = " + generateid.Text + "", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added6.Visible = true;

                        MessageBox.Show("*" + payablenametxbx6.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

                       

                        return;
                    }
                    if (payablenametxbx7.Text == "")
                    {
                        payablenametxbx7.Text = accountnametxbx.Text;
                        payabletxbx7.Text = accountspayabletxbx.Text;

                        con.Open();
                        com = new MySqlCommand("Update tbl_accountpayable set Accountspayable8 = '" + payabletxbx7.Text + "',Accountspayablename8 = '" + payablenametxbx7.Text + "' where accountid = " + generateid.Text + "", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        added7.Visible = true;

                        MessageBox.Show("*" + payablenametxbx7.Text + "*" + " Added");

                        accountnametxbx.Text = "";
                        accountspayabletxbx.Text = "";

                       

                        return;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }




            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (payablenametxbx1.Text == "")
            {
                MessageBox.Show("Please add atleast 1 payable");

            }
            else {
            deleteall.Enabled = true;
            donepayment.Visible = true;
            accountspayabletxbx.Enabled = false;
            accountnametxbx.Enabled = false;
            paymentdone.Enabled = false;
            accountnametxbx.Text = "Done";
            accountspayabletxbx.Text = "Done";
            cancelbtnpayment.Visible = true;
            addpaymentbtn.Enabled = false;
            count++;
            four();
            }
            
        }

        private void cancelbtnpayment_Click(object sender, EventArgs e)
        {
            donepayment.Visible = false;
            count--;
            four();
            cancelbtnpayment.Visible = false;
            addpaymentbtn.Enabled = true;
            paymentdone.Enabled = true;
            accountnametxbx.Enabled = true;
            accountspayabletxbx.Enabled = true;
            accountnametxbx.Text = "";
            accountspayabletxbx.Text = "";
        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            payabletxbx1.Text = "0";
            payabletxbx2.Text = "0";
            payabletxbx3.Text = "0";
            payabletxbx4.Text = "0";
            payabletxbx5.Text = "0";
            payabletxbx6.Text = "0";
            payabletxbx7.Text = "0";
            payablenametxbx1.Text = "";
            payablenametxbx2.Text = "";
            payablenametxbx3.Text = "";
            payablenametxbx4.Text = "";
            payablenametxbx5.Text = "";
            payablenametxbx6.Text = "";
            payablenametxbx7.Text = "";
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            voucherchecknoholder.Enabled = true;
            editnotxbx.Visible = false;
            cancelnotxbx.Visible = true;

        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            checkno.Enabled = true;
            editcheckno.Visible = false;
            cancelcheckno.Visible = true;
        }

        private void metroButton3_Click_2(object sender, EventArgs e)
        {
            if (voucherchecknoholder.Text == "" || voucherchecknoholder.Text == "0")
            {

                MessageBox.Show("Please Fill up all the field");

            }
            else
            {
                cancelnotxbx.Visible = false;
                editnotxbx.Visible = true;
                voucherchecknoholder.Enabled = false;

            }

        
        }

        private void metroButton4_Click_2(object sender, EventArgs e)
        {
            if (cancelcheckno.Text == "" || cancelcheckno.Text == "0")
            {

                MessageBox.Show("Please Fill up all the field");
            }
            else
            {
                checkno.Enabled = true;
                editcheckno.Visible = true;
                checkno.Enabled = false;
                cancelcheckno.Visible = false;

            }

    
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {
          
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                com = new MySqlCommand("Truncate table tbl_accountpayable", con);
                com.ExecuteNonQuery();
                con.Close();

                deleteall.Enabled = false;
                MessageBox.Show("Deleted!");
                added1.Visible = false;
                added2.Visible = false;
                added3.Visible = false;
                added4.Visible = false;
                added5.Visible = false;
                added6.Visible = false;
                added7.Visible = false;
                count--;
                four();
                donepayment.Visible = false;
                cancelbtnpayment.Visible = false;
                addpaymentbtn.Enabled = true;
                paymentdone.Enabled = true;
                accountnametxbx.Enabled = true;
                accountspayabletxbx.Enabled = true;
                accountnametxbx.Text = "";
                accountspayabletxbx.Text = "";
                payablenametxbx1.Text = "";
                payablenametxbx2.Text = "";
                payablenametxbx3.Text = "";
                payablenametxbx4.Text = "";
                payablenametxbx5.Text = "";
                payablenametxbx6.Text = "";
                payablenametxbx7.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            
            
            
            
            
            
            
            
            
           
        }



    }
}
