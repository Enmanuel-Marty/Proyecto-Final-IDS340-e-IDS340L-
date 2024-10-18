using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Metodos
{
    public class Metodos_proveedor
    {
        private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";
        // Métodos para editar tabla de proveedores
        public void AgregarProveedor(int id, string nombreEmpresa, string contacto, string direccion, string telefono)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "INSERT INTO Proveedores (id_proveedor, nombre_empresa, contacto, direccion, telefono) VALUES (@id, @nombreEmpresa, @contacto, @direccion, @telefono)";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("id", id);  
                    command.Parameters.AddWithValue("@nombreEmpresa", nombreEmpresa);
                    command.Parameters.AddWithValue("@contacto", contacto);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditarCategoria(int idproveedor, string nuevoNombre, string nuevocontacto, string telefono, string direccion)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "UPDATE Proveedores SET nombre_empresa = @nuevoNombre, contacto = @nuevocontacto, direccion = @nuevadireccion, telefono = @nuevotelefono WHERE id_proveedor = @idproveedor";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                    command.Parameters.AddWithValue("@nuevocontacto", nuevocontacto);  
                    command.Parameters.AddWithValue("@nuevadireccion", direccion);    
                    command.Parameters.AddWithValue("@nuevotelefono", telefono);      
                    command.Parameters.AddWithValue("@idproveedor", idproveedor);     
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCategoria(int idproveedor)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "DELETE FROM Proveedores WHERE id_proveedor = @idproveedor";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idproveedor", idproveedor);
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
