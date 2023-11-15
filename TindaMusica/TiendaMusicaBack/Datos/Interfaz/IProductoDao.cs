using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Interfaz
{
    public interface IProductoDao
    {
        Producto ConsultarProducto(int id);
        List<Marca> ConsultarMarcas();
        List<Pais> ConsultarPaises();
        List<Proveedor> ConsultarProveedores();
        bool CargarProducto(Producto oProducto);
        bool CargarCaracteristica(Caracteristica oCaracteristica);
    }
}
