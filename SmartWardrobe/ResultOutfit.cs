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
    public partial class ResultOutfit : Form
    {
        public ResultOutfit()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResultOutfit_Load(object sender, EventArgs e)
        {
            // Cabeza
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqllocalDb;Initial Catalog=SmartWardrobe;Integrated Security=True");

            if (con.State == ConnectionState.Closed)

                con.Open();

            SqlCommand cmd = new SqlCommand("Select Nombre, Marca, TipoRopa, UbicacionCloset from Closet where TipoRopa LIKE '%" + GenOutfit.Cabeza + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();

            da.SelectCommand = cmd;

            dt.Clear();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            // Torso
    

            SqlCommand cmd1 = new SqlCommand("Select Nombre, Marca, TipoRopa, UbicacionCloset from Closet where TipoRopa LIKE '%" + GenOutfit.Torso + "%'", con);

            SqlDataAdapter da1 = new SqlDataAdapter();

            DataTable dt1 = new DataTable();

            da1.SelectCommand = cmd1;

            dt1.Clear();

            da1.Fill(dt1);

            dataGridView2.DataSource = dt1;


            // Piernas
            SqlCommand cmd2 = new SqlCommand("Select Nombre, Marca, TipoRopa, UbicacionCloset from Closet where TipoRopa LIKE '%" + GenOutfit.Piernas + "%'", con);

            SqlDataAdapter da2 = new SqlDataAdapter();

            DataTable dt2 = new DataTable();

            da2.SelectCommand = cmd2;

            dt2.Clear();

            da2.Fill(dt2);

            dataGridView3.DataSource = dt2;


            // Accesorios
            SqlCommand cmd3 = new SqlCommand("Select Nombre, Marca, TipoRopa, UbicacionCloset from Closet where TipoRopa LIKE '%" + GenOutfit.Accesorios + "%'", con);

            SqlDataAdapter da3 = new SqlDataAdapter();

            DataTable dt3 = new DataTable();

            da3.SelectCommand = cmd3;

            dt3.Clear();

            da3.Fill(dt3);

            dataGridView4.DataSource = dt3;

            con.Close();
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
    }
}
