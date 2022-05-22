using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using hhhhhhhhhhhhhhhhh;
using SearchUpdateDelete;

namespace Hotel_system
{
    public partial class recform : Form
    {
        public recform()
        {
            InitializeComponent();
        }
        //  start btnClose ================================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
        //  end btnClose ================================================================
        private void recform_Load(object sender, EventArgs e)
        {
            string s = LoginforRe.namelogin;
            int n = LoginforRe.checkthemanager;
            if (n == 1)
            {
                nameloginform.Text = "welcome " + s;
            }
            else
            {
                nameloginform.Text = "welcome " + s;
                label15.Visible = false;
            }
        }
        private void label14_Click(object sender, EventArgs e)
        {
            CheckOut chas = new CheckOut();
            chas.Show();
            this.Hide();
        }
        private void label12_MouseHover(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.White;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            LoginforRe foo = new LoginforRe();
            foo.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label12_Click(object sender, EventArgs e)
        {
            bookingFormForm bookf = new bookingFormForm();
            bookf.Show();
            this.Hide();
        }
        private void label13_Click(object sender, EventArgs e)
        {
            SearchForm chf = new SearchForm();
            chf.Show();
            this.Hide();
        }
        private void label12_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Parent = panel1;
            btnClose.BackColor = Color.Transparent;
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            if (textFname.Text == "")
            {
                MessageBox.Show("plase enter client data",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                string message = "successful add";
                string title = "Add Reception";
                StreamReader st1 = new StreamReader("LoginDateRec.txt");
                string info = "";
                bool ok = true;
                while (info != null)
                {
                    info = st1.ReadLine();
                    if (info != null)
                    {
                        string[] infoDate = info.Split(";");
                        if (infoDate[0] == txtAddusername.Text)
                        {
                            ok = false;
                            string message1 = "This username found exactly";
                            string title1 = "Error";
                            DialogResult result1 = MessageBox.Show(message1, title1, buttons, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                st1.Close();
                if (ok == true)
                {
                    StreamWriter st = new StreamWriter("LoginDateRec.txt", true);
                    st.WriteLine();
                    st.WriteLine(txtAddusername.Text + ";" 
                                 + txtAddpassword.Text + ";"
                                 + textid.Text + ";"
                                 + textFname.Text + ";"
                                 + textLname.Text + ";"
                                 + textphone.Text + ";"
                                 + combogen.Text + ";"
                                 );
                    st.Close();
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
            }
            catch{}
        }
    }
}
