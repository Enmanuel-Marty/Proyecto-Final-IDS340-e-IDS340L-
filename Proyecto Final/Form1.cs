using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Metodos_productos;



namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";
        public Form1()
        {
            InitializeComponent();

        }

        public void LimpiarCampos()
        {
            Nom_Producto.Clear();
            Codigo_producto.Clear();
            Precio.Clear();
            Cantidad.Clear();
            Categoria.Clear();
            id_producto.Clear();
            Proveedor.Clear();
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
       
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                Nombre = Nom_Producto.Text,
                IdProducto = Convert.ToInt32(id_producto.Text),
               
               
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nom_Producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos han sido llenados
            if (string.IsNullOrWhiteSpace(Nom_Producto.Text) ||
                string.IsNullOrWhiteSpace(Codigo_producto.Text) ||
                string.IsNullOrWhiteSpace(Precio.Text) ||
                string.IsNullOrWhiteSpace(Cantidad.Text) ||
                string.IsNullOrWhiteSpace(Categoria.Text) ||
                string.IsNullOrWhiteSpace(Proveedor.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, llene todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            string nombreProducto = Nom_Producto.Text;
            string codigoProducto = Codigo_producto.Text;
            double precio = double.Parse(Precio.Text);
            int existencia = int.Parse(Cantidad.Text);
            int idCategoria = int.Parse(Categoria.Text);
            int idProveedor = int.Parse(Proveedor.Text);
            int idproducto = int.Parse(id_producto.Text);

            // Llamar al método para agregar el producto en la base de datos
            Operaciones_Producto editar = new Operaciones_Producto();
            editar.Editar_Producto(idproducto,nombreProducto, codigoProducto, idCategoria, precio, existencia, idProveedor);

            // Mostrar mensaje de éxito
            MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

            llenar_tabla();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Verificar si todos los campos han sido llenados
            if (string.IsNullOrWhiteSpace(Nom_Producto.Text) ||
                string.IsNullOrWhiteSpace(Codigo_producto.Text) ||
                string.IsNullOrWhiteSpace(Precio.Text) ||
                string.IsNullOrWhiteSpace(Cantidad.Text) ||
                string.IsNullOrWhiteSpace(Categoria.Text) ||
                string.IsNullOrWhiteSpace(Proveedor.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, llene todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            string nombreProducto = Nom_Producto.Text;
            string codigoProducto = Codigo_producto.Text;
            double precio = double.Parse(Precio.Text);
            int existencia = int.Parse(Cantidad.Text);
            int idCategoria = int.Parse(Categoria.Text);
            int idProveedor = int.Parse(Proveedor.Text);

            // Llamar al método para agregar el producto en la base de datos
            Operaciones_Producto agregar = new Operaciones_Producto();
            agregar.Agregar_Producto(nombreProducto, codigoProducto, idCategoria, precio, existencia, idProveedor);

            // Mostrar mensaje de éxito
            MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

            llenar_tabla();
        }

        private void Nom_Producto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos han sido llenados
            if (string.IsNullOrWhiteSpace(id_producto.Text))
            {
                
                MessageBox.Show("Por favor, ponga el id del producto que desea eliminar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }
            Operaciones_Producto eliminar = new Operaciones_Producto();

            eliminar.Eliminar_Producto(Convert.ToInt32(id_producto.Text));
            MessageBox.Show("Producto borrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

            llenar_tabla();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Codigo_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
  
    
}
