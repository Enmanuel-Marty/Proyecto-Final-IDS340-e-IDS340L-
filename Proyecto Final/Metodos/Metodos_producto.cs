using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Final.Metodos_productos

{      // Métodos para agregar, editar y borrar productos
    public class Operaciones_Producto
    {
        private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";

       
       
        public void Agregar_Producto(string nombre, string codigoProducto, int idCategoria, double precio, int existencia, int idProveedor)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = @"
                INSERT INTO Productos (nombre, codigo_producto, id_categoria, precio, existencia, id_proveedor) 
                VALUES (@nombre, @codigoProducto, @idCategoria, @precio, @existencia, @idProveedor)";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                    command.Parameters.AddWithValue("@idCategoria", idCategoria);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@existencia", existencia);
                    command.Parameters.AddWithValue("@idProveedor", idProveedor);
                    command.ExecuteNonQuery();
                }

            }
        }

        public void Editar_Producto(int id_producto, string nombre, string codigoProducto, int idCategoria, double precio, int existencia, int idProveedor)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                
                string query = @"
                  UPDATE Productos 
                  SET nombre = @Nombre, 
                  codigo_producto = @CodigoProducto, 
                  id_categoria = @IdCategoria, 
                  precio = @Precio, 
                  existencia = @Existencia, 
                  id_proveedor = @IdProveedor 
                   WHERE id_producto = @id_producto";  

                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Existencia", existencia);
                    command.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    command.Parameters.AddWithValue("@id_producto", id_producto);  

                    
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar_Producto(int id_producto)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "DELETE FROM Productos WHERE id_producto = @id_producto";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("id_producto", id_producto);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void MostrarProductos()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Productos";
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id_producto"]}, Nombre: {reader["nombre"]}, Precio: {reader["precio"]}, Existencia: {reader["existencia"]}");
                    }
                }
            }
        }
    }
}


