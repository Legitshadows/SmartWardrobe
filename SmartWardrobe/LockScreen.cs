using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWardrobe
{
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label2.Text = DateTime.Now.ToString("dddd, MMM dd");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value >= 100)
            {
                HomeScreen s1 = new HomeScreen();
                s1.Location = this.Location;
                s1.StartPosition = FormStartPosition.Manual;
                s1.FormClosing += delegate { this.Show(); };
                s1.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
