using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_system
{
    public partial class Welcomeform : Form
    {      
        private string s1,s2 ,s5;
        private int len1=0, len2=0, len5=0;

        public Welcomeform()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len1 < s1.Length)
            {
                label1.Text = label1.Text + s1.ElementAt(len1);
                len1++;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len2 < s2.Length)
            {
                label2.Text = label2.Text + s2.ElementAt(len2);
                len2++;
            }
            else
            {
                timer2.Stop();
                timer3.Start();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (len5 < s5.Length)
            {
                label5.Text = label5.Text + s5.ElementAt(len5);
                len5++;
            }
            else
            {
                timer3.Stop();
            }
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            LoginforRe fr = new LoginforRe();
            fr.Show();
            this.Hide();
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Parent = this;
            btnClose.BackColor = Color.Transparent;
        }
        private void btnmin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Welcomeform_Load(object sender, EventArgs e)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(3, 3, btnstart.Width - 10, btnstart.Height - 10);
            btnstart.Region = new Region(p);
            btnstart.BackColor = Color.Azure;
            s1 = label1.Text; 
            s2 = label2.Text;
            s5 = label5.Text;
            label1.Text = "";
            label2.Text = "";
            label5.Text = "";
            timer1.Start();
            timer2.Stop();
            timer3.Stop();
        }
    }
}
