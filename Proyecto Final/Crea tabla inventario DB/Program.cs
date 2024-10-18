
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Data.SQLite;
using Proyecto_Final.Clases;


namespace GestionProductos
{
    public class DatabaseInitializer
    {
       private static string connectionString = @"Data Source=C:\Users\Enmanuel Marty B\source\repos\Prueba base de datos\Inventario.db";
       

        public void CrearTablas()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                // Crear tabla de Categorías
                string queryCategorias = @"
                    CREATE TABLE IF NOT EXISTS Categorias (
                        id_categoria INTEGER PRIMARY KEY AUTOINCREMENT,
                        nombre_categoria TEXT NOT NULL,
                        descripcion TEXT
                    )"
                ;

                using (SQLiteCommand command = new SQLiteCommand(queryCategorias, conexion))
                {
                    command.ExecuteNonQuery();
                }

                // Crear tabla de Proveedores
                string queryProveedores = @"
                    CREATE TABLE IF NOT EXISTS Proveedores (
                        id_proveedor INTEGER PRIMARY KEY AUTOINCREMENT,
                        nombre_empresa TEXT NOT NULL,
                        contacto TEXT,
                        direccion TEXT,
                        telefono TEXT
                    )"
                ;

                using (SQLiteCommand command = new SQLiteCommand(queryProveedores, conexion))
                {
                    command.ExecuteNonQuery();
                }

                // Crear tabla de Productos
                string queryProductos = @"
                    CREATE TABLE IF NOT EXISTS Productos (
                        id_producto INTEGER PRIMARY KEY AUTOINCREMENT,
                        nombre TEXT NOT NULL,
                        codigo_producto TEXT NOT NULL,
                        id_categoria INTEGER,
                        precio REAL,
                        existencia INTEGER,
                        id_proveedor INTEGER,
                        FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria),
                        FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor)
                    )"
                ;

                using (SQLiteCommand command = new SQLiteCommand(queryProductos, conexion))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

/*
namespace GestionProductos
{
    class Program
    {
       
        static void Main(string[] args)
        {
             

            try
            {
                // Inicializar la base de datos y crear las tablas
                DatabaseInitializer dbInit = new DatabaseInitializer();
                dbInit.CrearTablas();

                Console.WriteLine("Las tablas fueron creadas exitosamente.");

                
            }
               //Mostrar cualquier posible error al crear las tablas
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }

   
}

*/


