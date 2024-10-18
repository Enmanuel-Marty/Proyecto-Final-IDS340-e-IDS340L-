using Proyecto_Final.Metodos_productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Metodos;
using Proyecto_Final.Clases;
using System.Data.SQLite;

namespace Proyecto_Final
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";
        public void LimpiarCampos()
        {
            id_categoria.Clear();
           Nom_categoria.Clear();
           descripcion_categoria.Clear();
        }
        public void llenar_tabla()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Categorias";

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); 

                    dataGridView1.DataSource = dataTable; 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos han sido llenados
            if (string.IsNullOrWhiteSpace(Nom_categoria.Text) ||
                string.IsNullOrWhiteSpace(descripcion_categoria.Text)||
                string.IsNullOrEmpty(id_categoria.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, llene todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            string nombre = Nom_categoria.Text;
            string descripcion = descripcion_categoria.Text;
            int id = Convert.ToInt32(id_categoria.Text);
            Metodos_categorias agregar = new Metodos_categorias();
            agregar.AgregarCategoria(nombre, descripcion, id);

            LimpiarCampos();
            llenar_tabla();//Refrescar la tabla luego de guardar

        }

        private void id_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Verificar si todos los campos han sido llenados
            if (string.IsNullOrWhiteSpace(Nom_categoria.Text) ||
                string.IsNullOrWhiteSpace(descripcion_categoria.Text) ||
                string.IsNullOrEmpty(id_categoria.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, llene todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            string nombre = Nom_categoria.Text;
            string descripcion = descripcion_categoria.Text;
            int id = Convert.ToInt32(id_categoria.Text);
            Metodos_categorias editar = new Metodos_categorias();
            editar.EditarCategoria(id, nombre, descripcion);

            LimpiarCampos();
            llenar_tabla();//Refrescar la tabla luego de ser guardada
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_categoria.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, llene todos los campos de id para borrar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            
            int id = Convert.ToInt32(id_categoria.Text);
            Metodos_categorias eliminar = new Metodos_categorias();
            eliminar.EliminarCategoria(id);

            LimpiarCampos();
            llenar_tabla();//Refrescar la tabla luego de ser guardada

        }
    }
}
