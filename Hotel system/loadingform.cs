using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_system
{
    public partial class loadingform : Form
    {
        public loadingform()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel1.Width <= 550)
            {
                panel1.Width += 20;
            }
            else
            {
                timer1.Stop();
                Welcomeform welf = new Welcomeform();
                welf.Show();
                this.Hide();
            }
        }
    }
}
