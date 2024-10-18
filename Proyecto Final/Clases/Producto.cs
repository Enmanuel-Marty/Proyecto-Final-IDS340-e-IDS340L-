using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
     public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
        public int CategoriaId { get; set; } 
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int ProveedorId { get; set; } 
    }
}
