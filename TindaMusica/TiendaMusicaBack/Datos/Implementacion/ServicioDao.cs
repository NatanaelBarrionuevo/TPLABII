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
    public class ServicioDao: IServicioDao
    {
        public List<TipoServicio> ObtenerTiposServicios()
        {
            List<TipoServicio> servicios = new List<TipoServicio>();
            
            string sp = "SP_CONSULTAR_TIPO_SERVICIOS";
            

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);


            
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    servicios.Add(new TipoServicio()
                    {
                        Id = Convert.ToInt32(row["ID_T_SERV"]),
                        Tipo = row["SERVICIO"].ToString()
                    });

                }

                return servicios;
            }

            return null;
        }

    }
}
