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
    public partial class DelCloset : Form
    {
        public DelCloset()
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSqllocalDb;Initial Catalog=SmartWardrobe;Integrated Security=True");

        private void btnEnter_Click(object sender, EventArgs e)
        {
            const string message =
                "Seguro que quieres eliminar esta prenda?";
            const string caption = "Eliminar Prenda";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete FROM Closet WHERE Nombre = '" + this.txtNombre.Text + "' AND Where Marca = '" + this.txtMarca + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eliminado!");

                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    con.Close();
                }
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Operacion abortada.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMarca.Clear();
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

        private void DelCloset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartWardrobeDataSet.Closet' table. You can move, or remove it, as needed.
            this.closetTableAdapter.Fill(this.smartWardrobeDataSet.Closet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        this.dataGridView1.GetClipboardContent());

                    // Replace the text box contents with the clipboard text.
                    this.txtNombre.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    this.txtNombre.Text =
                        "El Clipboard no pudo copiar la operacion.";
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        this.dataGridView1.GetClipboardContent());

                    // Replace the text box contents with the clipboard text.
                    this.txtMarca.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    this.txtMarca.Text =
                        "El Clipboard no pudo copiar la operacion.";
                }
            }
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
