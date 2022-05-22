using hhhhhhhhhhhhhhhhh;
using Hotel_system;
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

namespace SearchUpdateDelete
{
    public partial class SearchForm : Form
    {
        public void clearfun()
        {
            txtID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            comboGender.Text = "";
            combotype.Text = "";
            txtRnum.Text = "";
        }
        public SearchForm()
        {
            InitializeComponent();
        }
        public string sa;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("plase enter client id",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            vale1 = "";
            panel2.Enabled = false;

            try
            {
                if (txtID.Text != "")
                {
                    StreamReader st = new StreamReader("DateClient.txt");
                    var info = "";
                    while (info != null)
                    {
                        info = st.ReadLine();
                        if (info != null)
                        {
                            string[] infoDate = info.Split(";");
                            if (info != "" && (infoDate[0] == txtID.Text || infoDate[3] == txtPhone.Text))
                            {
                                sa = info;
                            }
                            else if (info != "")
                            {
                                vale1 += Convert.ToString(info) + "<*>";
                            }
                        }
                    }
                    st.Close();
                    StreamWriter st1 = new StreamWriter("DateClient.txt");
                    string[] vale = vale1.Split("<*>");
                    foreach (string a in vale)
                    {
                        st1.WriteLine();
                        st1.WriteLine(a);
                    }
                    st1.WriteLine(
                        txtID.Text + ";"
                        + txtFname.Text + ";"
                        + txtLname.Text + ";"
                        + txtPhone.Text + ";"
                        + txtAddress.Text + ";"
                        + comboGender.Text + ";"
                        + combotype.Text + ";"
                        + txtRnum.Text + ";"
                        + sa[8] + ";"
                        + sa[9] + ";"
                        );
                    st1.Close();
                }
            }
            catch {}
            if (txtPhone.Text != "")
            {
                MessageBox.Show("The Chanages have been Saved");
            }
            clearfun();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("plase enter client id",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            panel2.Enabled = false;
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
                        if (infoDate[0] == txtID.Text)
                        {
                            txtFname.Text = infoDate[1];
                            txtLname.Text = infoDate[2];
                            txtPhone.Text = infoDate[3];
                            txtRnum.Text = infoDate[7];
                            comboGender.Text = infoDate[5];
                            combotype.Text = infoDate[6];
                            txtAddress.Text = infoDate[4];
                            break;
                        }
                    }
                }
                st.Close();

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            recform recf = new recform();
            recf.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            CheckOut chf = new CheckOut();
            chf.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bookingFormForm bookf = new bookingFormForm();
            bookf.Show();
            this.Hide();
        }
        public string vale1="";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("plase enter client id",
                "Error action",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
            }
            panel2.Enabled = false;
            try
            {
                StreamReader st = new StreamReader("DateClient.txt");
                var info = "";
                while (info != null)
                {
                    info = st.ReadLine();
                    if (info != null)
                    {
                        string[] infoDate = info.Split(";");
                        if (infoDate[0] != txtID.Text && info != "")
                        {
                            vale1 += Convert.ToString(info) + "<*>";
                        }
                        else if (info != ""&&txtID.Text!="")
                        {
                            MessageBox.Show("The Client has been removed");
                        }
                    }

                }
                st.Close();
                StreamWriter st1 = new StreamWriter("DateClient.txt");
                string[] vale = vale1.Split("<*>");
                foreach (string a in vale)
                {
                    st1.WriteLine();
                    st1.WriteLine(a);
                }
                st1.Close();
            }
            catch { }
            clearfun();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "")
            {
                panel2.Enabled = true;
            }
            else
            {
              
                    MessageBox.Show("plase enter client id",
                    "Error action",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                     );
               
            }
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.DarkSeaGreen;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Label la = (Label)sender;
            la.BackColor = Color.White;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            string s =LoginforRe.namelogin;
            int n = LoginforRe.checkthemanager;
            if (n == 1)
            {
                nameloginform.Text = "welcome "+s;
            }
            else
            {
                nameloginform.Text = "welcome " + s;
                label15.Visible = false;
            }
            
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkSeaGreen;
        }
    }
}
