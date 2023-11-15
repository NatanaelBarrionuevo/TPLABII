using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class DetaleFactura
    {
        public Producto Product { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        
    }
}
