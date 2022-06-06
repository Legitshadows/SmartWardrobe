using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartWardrobe
{
    public partial class GenOutfit : Form
    {
        public static string Cabeza = "";
        public static string Torso = "";
        public static string Piernas = "";
        public static string Accesorios = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqllocalDb;Initial Catalog=SmartWardrobe;Integrated Security=True");
        public GenOutfit()
        {
            InitializeComponent();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen s1 = new HomeScreen();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarRopa s1 = new BuscarRopa();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Cabeza = comboBox1.SelectedItem.ToString();
            Torso = comboBox2.SelectedItem.ToString();
            Piernas = cmbType.SelectedItem.ToString();
            Accesorios = cmbLocation.SelectedItem.ToString();

            ResultOutfit s1 = new ResultOutfit();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void GenOutfit_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
