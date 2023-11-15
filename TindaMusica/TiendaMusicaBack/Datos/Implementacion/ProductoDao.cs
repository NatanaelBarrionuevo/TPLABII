using PresupuestosBack.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Datos.Interfaz;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Implementacion
{
    public class ProductoDao: IProductoDao
    {
        public ProductoDao() { }
        public Producto ConsultarProducto(int id)
        {
            Producto producto = new Producto();
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_CONSULTAR_PRODUCTO";
            parametros.Add(new Parametro("@id", id));

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            //List<Producto> lista = new List<Producto>();
            foreach (DataRow row in tabla.Rows)
            {
                producto = new Producto() {
                    Id = Convert.ToInt32(row["ID_PRODUCTO"]),
                    Nombre = row["NOMBRE"].ToString(),
                    Precio = (float)Convert.ToDecimal(row["Precio"].ToString()),
                    Tipo_prod = new TipoCaracteristica() { Id = Convert.ToInt32(row["ID_T_PRODUCTO"]), Tipo = row["TIPO"].ToString() }
                    };

            }

            return producto;
        }
    }
}
