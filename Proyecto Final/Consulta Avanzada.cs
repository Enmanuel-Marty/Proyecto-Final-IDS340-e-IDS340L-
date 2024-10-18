using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Consulta_Avanzada : Form
    {
        private string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";
        public Consulta_Avanzada()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            nom_producto.Clear();
            id_producto.Clear();
        }
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
        private void Consulta_Avanzada_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_producto.Text) && string.IsNullOrEmpty(nom_producto.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, ponga el Id de la categoria o el nombre del producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }
            string nombreProducto = nom_producto.Text;
            string codigoProducto = id_producto.Text;

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                string query = @"
            SELECT 
            a.nombre_empresa AS 'Nombre Empresa', 
            a.contacto AS 'Nombre Contacto', 
            a.telefono, 
            b.nombre AS 'Nombre del Producto', 
            '$' || printf('%.2f', b.precio) AS 'Precio del producto', 
            b.existencia AS 'Cantidad de producto'
            FROM Proveedores a
            JOIN Productos b ON a.id_proveedor = b.id_proveedor
            WHERE b.nombre IN (@nombreProducto) OR b.id_producto IN (@codigoProducto)";

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    
                    command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                    command.Parameters.AddWithValue("@codigoProducto", codigoProducto);


                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            LimpiarCampos();

        }
    }
}
