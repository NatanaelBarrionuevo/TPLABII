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
    public class ProveedorDao : IProveedorDao
    {
        public bool CargarProveedor(Proveedor oProveedor)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_PROVEEDOR", oProveedor.Id),
                new Parametro("@NOMBRE", oProveedor.Nombre),
                new Parametro("@RAZON", oProveedor.Razon.Id),
                new Parametro("@CALLE", oProveedor.Calle),
                new Parametro("@BARRIO", oProveedor.Barrio.Id)
            };
            string sp = "SP_INSERT_PROVEEDORES";


            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, parametros);

            if (afectadas == 1)
            {
                return true;
            }

            return false;
        }

        public List<RazonSocial> ConsultarRazones()
        {
            RazonSocial razon;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_RAZON";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<RazonSocial> lista = new List<RazonSocial>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    razon = new RazonSocial()
                    {
                        Id = Convert.ToInt32(row["ID_RAZON"]),
                        Nombre = row["DESCRIPCION"].ToString()
                    };
                    lista.Add(razon);
                }

                return lista;
            }

            return null;
        }
    }
}
