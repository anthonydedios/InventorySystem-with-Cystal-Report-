namespace CheckVoucher
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.accountview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.usernametxbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.passwordtxbx = new MetroFramework.Controls.MetroTextBox();
            this.codetxbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.addaccountbtn = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteaccountbtn = new MetroFramework.Controls.MetroButton();
            this.cancelbtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountview
            // 
            this.accountview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.accountview.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountview.Location = new System.Drawing.Point(23, 63);
            this.accountview.Name = "accountview";
            this.accountview.Size = new System.Drawing.Size(556, 227);
            this.accountview.TabIndex = 0;
            this.accountview.UseCompatibleStateImageBehavior = false;
            this.accountview.View = System.Windows.Forms.View.Details;
            this.accountview.ItemActivate += new System.EventHandler(this.accountview_ItemActivate);
            this.accountview.SelectedIndexChanged += new System.EventHandler(this.accountview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code";
            this.columnHeader3.Width = 150;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "USERNAME:";
            // 
            // usernametxbx
            // 
            this.usernametxbx.Lines = new string[0];
            this.usernametxbx.Location = new System.Drawing.Point(100, 21);
            this.usernametxbx.MaxLength = 32767;
            this.usernametxbx.Name = "usernametxbx";
            this.usernametxbx.PasswordChar = '\0';
            this.usernametxbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametxbx.SelectedText = "";
            this.usernametxbx.Size = new System.Drawing.Size(300, 23);
            this.usernametxbx.TabIndex = 2;
            this.usernametxbx.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "PASSWORD:";
            // 
            // passwordtxbx
            // 
            this.passwordtxbx.Lines = new string[0];
            this.passwordtxbx.Location = new System.Drawing.Point(100, 59);
            this.passwordtxbx.MaxLength = 32767;
            this.passwordtxbx.Name = "passwordtxbx";
            this.passwordtxbx.PasswordChar = '*';
            this.passwordtxbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtxbx.SelectedText = "";
            this.passwordtxbx.Size = new System.Drawing.Size(300, 23);
            this.passwordtxbx.TabIndex = 4;
            this.passwordtxbx.UseSelectable = true;
            // 
            // codetxbx
            // 
            this.codetxbx.Lines = new string[0];
            this.codetxbx.Location = new System.Drawing.Point(100, 99);
            this.codetxbx.MaxLength = 32767;
            this.codetxbx.Name = "codetxbx";
            this.codetxbx.PasswordChar = '\0';
            this.codetxbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codetxbx.SelectedText = "";
            this.codetxbx.Size = new System.Drawing.Size(300, 23);
            this.codetxbx.TabIndex = 6;
            this.codetxbx.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "CODE:";
            // 
            // addaccountbtn
            // 
            this.addaccountbtn.Location = new System.Drawing.Point(458, 354);
            this.addaccountbtn.Name = "addaccountbtn";
            this.addaccountbtn.Size = new System.Drawing.Size(121, 23);
            this.addaccountbtn.TabIndex = 7;
            this.addaccountbtn.Text = "Add Account";
            this.addaccountbtn.UseSelectable = true;
            this.addaccountbtn.Click += new System.EventHandler(this.addaccountbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codetxbx);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.usernametxbx);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.passwordtxbx);
            this.groupBox1.Location = new System.Drawing.Point(23, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Account:";
            // 
            // deleteaccountbtn
            // 
            this.deleteaccountbtn.Location = new System.Drawing.Point(458, 325);
            this.deleteaccountbtn.Name = "deleteaccountbtn";
            this.deleteaccountbtn.Size = new System.Drawing.Size(121, 23);
            this.deleteaccountbtn.TabIndex = 9;
            this.deleteaccountbtn.Text = "Delete Account";
            this.deleteaccountbtn.UseSelectable = true;
            this.deleteaccountbtn.Click += new System.EventHandler(this.deleteaccountbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(458, 383);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(121, 23);
            this.cancelbtn.TabIndex = 12;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseSelectable = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(23, 17);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(55, 40);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 460);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.deleteaccountbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addaccountbtn);
            this.Controls.Add(this.accountview);
            this.Name = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView accountview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox usernametxbx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox passwordtxbx;
        private MetroFramework.Controls.MetroTextBox codetxbx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton addaccountbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton deleteaccountbtn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton cancelbtn;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}