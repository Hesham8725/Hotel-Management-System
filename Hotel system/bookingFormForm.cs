using Hotel_system;
using SearchUpdateDelete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hhhhhhhhhhhhhhhhh
{
    public partial class bookingFormForm : Form
    {
        public bookingFormForm()
        {
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }   
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label3_MouseHover(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.White;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                MessageBox.Show("plase enter client id",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (textFname.Text == "")
            {
                MessageBox.Show("plase enter client first name",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (textAddress.Text == "")
            {
                MessageBox.Show("plase enter client Adress",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (textPhone.Text == "")
            {
                MessageBox.Show("plase enter client phone",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (comboGender.Text == "")
            {
                MessageBox.Show("plase enter client Gender",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (comboRType.Text == "")
            {
                MessageBox.Show("plase enter client room type",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (textRnum.Text == "")
            {
                MessageBox.Show("plase enter client room number",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else if (textpay.Text == "")
            {
                MessageBox.Show("plase enter client pay information",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            else
            {
                try
                {
                    StreamWriter st = new StreamWriter("DateClient.txt", true);
                    st.WriteLine();
                    st.WriteLine(
                          textID.Text + ";"
                        + textFname.Text + ";"
                        + textLname.Text + ";"
                        + textPhone.Text + ";"
                        + textAddress.Text + ";"
                        + comboGender.Text + ";"
                        + comboRType.Text + ";"
                        + textRnum.Text + ";"
                        + dateTimePickCheckIn.Text + ";"
                        + dateTimePickCheckOut.Text + ";"
                        + textpay.Text + ";"
                        + textrempay.Text + ";"
                        );
                    MessageBox.Show("Secsseful Adding Client");
                    st.Close();
                }
                catch
                {
                    MessageBox.Show("",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SearchForm fo = new SearchForm();
            fo.Show();
            this.Hide();
        }
        private void bookingFormForm_Load(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
            string s = LoginforRe.namelogin;
            int n = LoginforRe.checkthemanager;
            if (n == 1)
            {
                labadd.Visible = true;
                nameloginform.Text = "welcome " + s;
            }
            else
            {
                labadd.Visible = false;
                nameloginform.Text = "welcome " + s;   
            }
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.DarkSeaGreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CheckOut chf = new CheckOut();
            chf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkSeaGreen;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pan1.Visible = true ;
            pan2.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            pan1.Visible = false;
            pan2.Visible = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            pan1.Visible = true;
            pan2.Visible = false;
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
