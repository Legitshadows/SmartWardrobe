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
    public partial class BuscarRopa : Form
    {
        public BuscarRopa()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMarca.Clear();
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

        private void BuscarRopa_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqllocalDb;Initial Catalog=SmartWardrobe;Integrated Security=True");

            if (con.State == ConnectionState.Closed)

                con.Open();

            SqlCommand cmd = new SqlCommand("Select Nombre, Marca, TipoRopa, UbicacionCloset from Closet where Nombre LIKE '%" + txtNombre.Text + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();

            da.SelectCommand = cmd;

            dt.Clear();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
            this.txtNombre.MaxLength = 20;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCloset s1 = new AddCloset();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqllocalDb;Initial Catalog=SmartWardrobe;Integrated Security=True");

            if (con.State == ConnectionState.Closed)

                con.Open();

            SqlCommand cmd = new SqlCommand("Select Nombre, Marca, TipoRopa, UbicacionCloset from Closet where Marca LIKE '%" + txtMarca.Text + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();

            da.SelectCommand = cmd;

            dt.Clear();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
            this.txtMarca.MaxLength = 20;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            GenOutfit s1 = new GenOutfit();
            s1.Location = this.Location;
            s1.StartPosition = FormStartPosition.Manual;
            s1.FormClosing += delegate { this.Show(); };
            s1.Show();
            this.Hide();
        }
    }
}
