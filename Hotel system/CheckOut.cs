using hhhhhhhhhhhhhhhhh;
using SearchUpdateDelete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hotel_system
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.White;
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            label14.BackColor = Color.White;
            txtid.PlaceholderText = "Plase Enter The ID of Client";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_MouseLeave_1(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.DarkSeaGreen;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkSeaGreen;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            bookingFormForm bookf = new bookingFormForm();
            bookf.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            SearchForm fo = new SearchForm();
            fo.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            recform recf = new recform();
            recf.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            LoginforRe logf = new LoginforRe();
            logf.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("plase enter client id",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            try
            {
                StreamReader st = new StreamReader("DateClient.txt");
                string info = "";
                while (info != null)
                {
                    info = st.ReadLine();
                    if (info != null)
                    {
                        string[] infoDate = info.Split(";");
                        if (infoDate[0] == txtid.Text)
                        {
                            // date
                            txtcheckin.Text = infoDate[8];
                            txtcheckout.Text = infoDate[9];
                            var s = infoDate[8];
                            var s1 = infoDate[9];
                            var dnow = DateTime.Now;
                            var cheoutdate = Convert.ToDateTime(s1);
                            var remday = cheoutdate - dnow;
                           
                            txtrem.Text = Convert.ToString(remday.Days + " Days");
                            //payment 
                            textprice.Text = infoDate[10];
                            textpay.Text = infoDate[11];
                            double x = Convert.ToDouble(textprice.Text);
                            double x1 = Convert.ToDouble(textpay.Text);
                            textrempay.Text = Convert.ToString(x - x1);
                            break;
                        }
                    }
                }
                st.Close();
            }
            catch { }
        }

        private void pan2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            pan2.Visible = true;
            pan1.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pan2.Visible = false ;
            pan1.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
