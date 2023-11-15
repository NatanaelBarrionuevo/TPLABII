using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class DetalleServicio
    {
        public Luthier Luthier { get; set; }
        public TipoServicio Servicio { get; set; }
        public double PrecioPorHora { get; set; }
        public int CantHoras { get; set; }
    }
}
