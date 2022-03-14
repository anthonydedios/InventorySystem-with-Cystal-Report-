namespace CheckVoucher
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.loginbtn = new MetroFramework.Controls.MetroButton();
            this.passwordtxbx = new MetroFramework.Controls.MetroTextBox();
            this.usernametxbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.passwordtxbx);
            this.groupBox1.Controls.Add(this.usernametxbx);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(239, 86);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 31);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Exit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(142, 86);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(91, 31);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Log-in";
            this.loginbtn.UseSelectable = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passwordtxbx
            // 
            this.passwordtxbx.Lines = new string[0];
            this.passwordtxbx.Location = new System.Drawing.Point(113, 57);
            this.passwordtxbx.MaxLength = 32767;
            this.passwordtxbx.Name = "passwordtxbx";
            this.passwordtxbx.PasswordChar = '*';
            this.passwordtxbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtxbx.SelectedText = "";
            this.passwordtxbx.Size = new System.Drawing.Size(217, 23);
            this.passwordtxbx.TabIndex = 3;
            this.passwordtxbx.UseSelectable = true;
            // 
            // usernametxbx
            // 
            this.usernametxbx.Lines = new string[0];
            this.usernametxbx.Location = new System.Drawing.Point(113, 25);
            this.usernametxbx.MaxLength = 32767;
            this.usernametxbx.Name = "usernametxbx";
            this.usernametxbx.PasswordChar = '\0';
            this.usernametxbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametxbx.SelectedText = "";
            this.usernametxbx.Size = new System.Drawing.Size(217, 23);
            this.usernametxbx.TabIndex = 2;
            this.usernametxbx.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton loginbtn;
        private MetroFramework.Controls.MetroTextBox passwordtxbx;
        private MetroFramework.Controls.MetroTextBox usernametxbx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}