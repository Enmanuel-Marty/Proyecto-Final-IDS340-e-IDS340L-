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
using Proyecto_Final.Clases;
using Proyecto_Final.Metodos;
using Proyecto_Final.Metodos_productos;

namespace Proyecto_Final
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }
        private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";
        public void llenar_tabla()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Proveedores";

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
            Nom_empresa.Clear();
            contacto.Clear();
            direccion.Clear();  
            telefono.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(id_proveedor.Text) ||
               string.IsNullOrWhiteSpace(Nom_empresa.Text) ||
               string.IsNullOrWhiteSpace(contacto.Text) ||
               string.IsNullOrWhiteSpace(direccion.Text) ||
               string.IsNullOrWhiteSpace(telefono.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, llene todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            int idproveedor = Convert.ToInt32(id_proveedor.Text);
            string Nombre_empresa = Nom_empresa.Text;
            string Contacto = contacto.Text;
            string Direccion = direccion.Text;
            string Telefono = telefono.Text;


          
           

           Metodos_proveedor agregar = new Metodos_proveedor();
           agregar.AgregarProveedor(idproveedor, Nombre_empresa, Contacto, Direccion, Telefono);

            // Mostrar mensaje de éxito
            MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

            llenar_tabla();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(id_proveedor.Text)||
                string.IsNullOrWhiteSpace(Nom_empresa.Text) ||
                string.IsNullOrWhiteSpace(contacto.Text) ||
                string.IsNullOrWhiteSpace(direccion.Text) ||
                string.IsNullOrWhiteSpace(telefono.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, ponga el id de la categoria que desea editar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            int idproveedor = Convert.ToInt32(id_proveedor.Text);
            string Nombre_empresa = Nom_empresa.Text;
            string Contacto = contacto.Text;
            string Direccion = direccion.Text;
            string Telefono = telefono.Text;





            Metodos_proveedor editar = new Metodos_proveedor();
            editar.EditarCategoria(idproveedor, Nombre_empresa, Contacto, Direccion, Telefono);

            // Mostrar mensaje de éxito
            MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

            llenar_tabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(id_proveedor.Text))
            {
                // Mostrar mensaje si algún campo está vacío
                MessageBox.Show("Por favor, poner id para borrar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }


            int idproveedor = Convert.ToInt32(id_proveedor.Text);
            





            Metodos_proveedor eliminar = new Metodos_proveedor();
            eliminar.EliminarCategoria(idproveedor);

            // Mostrar mensaje de éxito
            MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

            llenar_tabla();
        }
    }
}
