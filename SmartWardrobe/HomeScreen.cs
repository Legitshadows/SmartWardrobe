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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarRopa s1 = new BuscarRopa();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenOutfit s1 = new GenOutfit();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void addCloset_Click(object sender, EventArgs e)
        {
            AddCloset s1 = new AddCloset();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void eliminarCloset_Click(object sender, EventArgs e)
        {
            DelCloset s1 = new DelCloset();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }
    }
}
