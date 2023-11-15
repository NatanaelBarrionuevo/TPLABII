using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Empleado Emplead { get; set; }
        public Cliente Client { get; set; }
        public FormaPago Metodo { get; set; }
        public Sede Sede { get; set; }
        public MetodoEnvio Envio{ get; set; }
        public DetaleFactura DetaleFactura { get; set; }
        public DetalleServicio DetalleServicio { get; set; }

    }
}
