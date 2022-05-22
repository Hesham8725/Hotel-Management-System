using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using hhhhhhhhhhhhhhhhh;

namespace Hotel_system
{
    public partial class LoginforRe : Form
    {
        public static string namelogin;
        public static int checkthemanager = 1;
        string text;
        int chek=0;
        public LoginforRe()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Parent = this;
            button1.BackColor = Color.Transparent;
        }

        private void labHide_Click(object sender, EventArgs e)
        {
            labShow.Visible = true;
            labHide.Visible = false;
            chek = 0;
            
        }

        private void labShow_Click(object sender, EventArgs e)
        {
            labShow.Visible = false;
            labHide.Visible = true;
            chek = 1;
            
        }
        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (labHide.Visible == false)
            {
                labShow.Visible = true;
            }      
        }

        private void timerpass_Tick(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                labShow.Visible = false;
                labHide.Visible = false;
            }

            if (chek==1)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else{
                txtpass.UseSystemPasswordChar = false;
            }
        }
        private void btnReLogin_Click(object sender, EventArgs e)
        {
            int sh = 0;

            // manager longin
            try
            {
                StreamReader st = new StreamReader("LoginDateManager.txt");
                string info = "";
                while (info != null)
                {
                    info = st.ReadLine();
                    if (info != null)
                    {
                        string[] infoDate = info.Split(";");
                        if (infoDate[0] == txtusername.Text && infoDate[1] == txtpass.Text)
                        {
                            checkthemanager = 1;
                            namelogin = "Mr " + txtusername.Text;
                            bookingFormForm bookformform = new bookingFormForm();
                            bookformform.Show();
                            this.Hide();
                            sh = 1;
                            break;
                        }
                        else if (infoDate[0] == txtusername.Text)
                        {
                            labError.Visible = true;
                            break;
                        }
                    }
                }
                st.Close();
                // rec login
                StreamReader st1 = new StreamReader("LoginDateRec.txt");
                string info1 = "";
                while (info1 != null)
                {
                    info1 = st1.ReadLine();
                    if (info1 != null)
                    {
                        string[] infoDate = info1.Split(";");
                        if (infoDate[0] == txtusername.Text && infoDate[1] == txtpass.Text)
                        {
                            checkthemanager = 0;
                            namelogin = txtusername.Text;
                            bookingFormForm bookformform = new bookingFormForm();
                            bookformform.Show();                         
                            this.Hide();
                            sh = 1;
                            break;
                        }
                        else if (infoDate[0] == txtusername.Text)
                        {
                            labError.Visible = true;
                            break;
                        }
                    }
                }
                st.Close();
                if (sh == 0)
                {
                    MessageBox.Show("Not found username");
                }
            }
            catch
            {
                if(txtusername.Text == "")
                {
                    MessageBox.Show("Plase Enter username and password to login");
                }
            }
        }

        private void LoginforRe_Load(object sender, EventArgs e)
        {
            txtusername.PlaceholderText = "Username";
            txtpass.PlaceholderText = "Password";
            
        }
        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReLogin.Focus();
            }
        }

        private void btnReLogin_MouseHover(object sender, EventArgs e)
        {
            btnReLogin.BackColor = Color.Blue;
            btnReLogin.ForeColor = Color.White;
        }

        private void btnReLogin_MouseLeave(object sender, EventArgs e)
        {
            btnReLogin.BackColor = Color.Silver;
            btnReLogin.ForeColor = Color.Blue;
        }
    }
}
