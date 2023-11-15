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
    public class ProductoDao : IProductoDao
    {
        public ProductoDao() { }

        public bool CargarCaracteristica(Caracteristica oCaracteristica)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@DETALLE", oCaracteristica.Detalle),
                new Parametro("@TIPO_CARACTERISTICA", oCaracteristica.Tio_carac.Id),
                new Parametro("@PRODUCTO", oCaracteristica.Producto.Id)
            };
            string sp = "SP_INSERT_CARACTERISTICAS";


            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, parametros);

            if (afectadas == 1)
            {
                return true;
            }

            return false;
        }

        public bool CargarProducto(Producto oProducto)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_PRODUCTO", oProducto.Id),
                new Parametro("@NOMBRE", oProducto.Nombre),
                new Parametro("@DESCRIPCION", oProducto.Descripcion),
                new Parametro("@TIPO_PRODUCTO", oProducto.Tipo_prod.Id),
                new Parametro("@MARCA", oProducto.Marca.Id),
                new Parametro("@PROVEEDOR", oProducto.Proveedor.Id),
                new Parametro("@PAIS", oProducto.Pais.Id),
                new Parametro("@STOCK", oProducto.Stock),
                new Parametro("@PRECIO", oProducto.Precio)
            };
            string sp = "SP_INSERT_PRODUCTO";


            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, parametros);

            if (afectadas == 1)
            {
                return true;
            }

            return false;
        }

        public List<Marca> ConsultarMarcas()
        {
            Marca marca;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_MARCAS";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Marca> lista = new List<Marca>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    marca = new Marca()
                    {
                        Id = Convert.ToInt32(row["ID_MARCA"]),
                        Nombre = row["MARCA"].ToString()
                    };
                    lista.Add(marca);
                }

                return lista;
            }

            return null;
        }

        public List<Pais> ConsultarPaises()
        {
            Pais pais;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_PAISES";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Pais> lista = new List<Pais>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    pais = new Pais()
                    {
                        Id = Convert.ToInt32(row["ID_PAIS"]),
                        Nombre = row["PAIS"].ToString()
                    };
                    lista.Add(pais);
                }

                return lista;
            }

            return null;
        }

        public Producto ConsultarProducto(int id)
        {
            Producto producto = new Producto();
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_CONSULTAR_PRODUCTO";
            parametros.Add(new Parametro("@id", id));

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            //List<Producto> lista = new List<Producto>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    producto = new Producto()
                    {
                        Id = Convert.ToInt32(row["ID_PRODUCTO"]),
                        Nombre = row["NOMBRE"].ToString(),
                        Precio = (float)Convert.ToDecimal(row["Precio"].ToString()),
                        Tipo_prod = new TipoCaracteristica() { Id = Convert.ToInt32(row["ID_T_PRODUCTO"]), Tipo = row["TIPO"].ToString() }
                    };

                }

                return producto;
            }

            return null;

        }

        public List<Proveedor> ConsultarProveedores()
        {
            Proveedor proveedor;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_PROVEEDOR";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Proveedor> lista = new List<Proveedor>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    proveedor = new Proveedor()
                    {
                        Id = Convert.ToInt32(row["ID_PROVEEDOR"]),
                        Nombre = row["NOMBRE"].ToString()
                    };
                    lista.Add(proveedor);
                }

                return lista;
            }

            return null;
        }
    }
}
