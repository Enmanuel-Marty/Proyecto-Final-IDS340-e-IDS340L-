using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";

        public void llenar_tabla()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Productos";

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); 

                    dataGridView1.DataSource = dataTable; 
                }
            }
        }
        public void LimpiarCampos()
        {
            id_proveedor.Clear();
            Id_categoria.Clear();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                // Consulta para obtener los productos con cantidad menor a 10
                string query = "SELECT nombre, existencia FROM Productos WHERE existencia < 10";

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.HasRows)
                        {
                            
                            string mensaje = "Los siguientes productos tienen menos de 10 unidades:\n\n";

                            while (reader.Read())
                            {
                                string nombreProducto = reader["nombre"].ToString();
                                int existencia = Convert.ToInt32(reader["existencia"]);
                                mensaje += $"{nombreProducto}: {existencia} unidades\n";
                            }

                            
                            MessageBox.Show(mensaje, "Advertencia de stock bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            
                            MessageBox.Show("No hay productos con menos de 10 unidades.", "Stock suficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Id_categoria.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, ponga el Id de la categoria.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }

            // Consultar productos por categoría

            int idCategoria = Convert.ToInt32(Id_categoria.Text);

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                
                string query = "SELECT * FROM Productos WHERE id_categoria = @idCategoria";

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@idCategoria", idCategoria);
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); 

                    dataGridView1.DataSource = dataTable;
                }
            }

            LimpiarCampos();
           
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_proveedor.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, ponga el Id del proveedor.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }

            int idProveedor = Convert.ToInt32(id_proveedor.Text);

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                // Consulta por Proveedor
                string query = "SELECT * FROM Productos WHERE id_proveedor = @idProveedor";

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@idProveedor", idProveedor);
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); 

                    dataGridView1.DataSource = dataTable;
                }
            }

            LimpiarCampos();
           
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
