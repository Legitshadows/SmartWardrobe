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
    public partial class AddCloset : Form
    {
        public AddCloset()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarRopa s1 = new BuscarRopa();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DelCloset s1 = new DelCloset();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqllocalDb;Initial Catalog=SmartWardrobe;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Closet(Nombre, Marca, TipoRopa, UbicacionCloset) values ('" + txtNombre.Text + "','" + txtMarca.Text + "','" + cmbType.Text + "','" + cmbLocation.Text + "')", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Guardado!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            con.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.txtNombre.MaxLength = 20;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            this.txtMarca.MaxLength = 20;
        }
    }
}
