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
    public class LuthierDao:ILuthierDao
    {
        public List<Luthier> ObtenerLuthiers()
        {
            List<Luthier> luthiers = new List<Luthier>();

            string sp = "SP_CONSULTAR_LUTHIERS";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);



            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    luthiers.Add(new Luthier( row["APELLIDO"].ToString(), row["NOMBRE"].ToString(), Convert.ToInt32(row["ID_LUTHIER"])));
                   

                }

                return luthiers;
            }

            return null;
        }
    }
    }

