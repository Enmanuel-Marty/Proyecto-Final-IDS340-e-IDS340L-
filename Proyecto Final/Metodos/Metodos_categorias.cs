using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Metodos
{
    public class Metodos_categorias
    {
        private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";

        // Método para agregar un nuevo registro a la tabla Categorias
        public void AgregarCategoria(string nombreCategoria, string descripcion, int id)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "INSERT INTO Categorias (id_categoria, nombre_categoria, descripcion) VALUES (@id, @nombreCategoria, @descripcion)";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para editar un registro en la tabla Categorias
        public void EditarCategoria(int idCategoria, string nuevoNombre, string nuevaDescripcion)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "UPDATE Categorias SET nombre_categoria = @nuevoNombre, descripcion = @nuevaDescripcion WHERE id_categoria = @idCategoria";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                    command.Parameters.AddWithValue("@nuevaDescripcion", nuevaDescripcion);
                    command.Parameters.AddWithValue("@idCategoria", idCategoria);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un registro de la tabla Categorias
        public void EliminarCategoria(int idCategoria)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "DELETE FROM Categorias WHERE id_categoria = @idCategoria";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idCategoria", idCategoria);
                    command.ExecuteNonQuery();
                }
            }
        }

       
        
    }
}
