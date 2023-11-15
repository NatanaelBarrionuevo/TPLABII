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
    public class EmpleadoDao : IEmpleadoDao
    {
        public bool CargarEmpleado(Empleado oEmpleado)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@LEGAJO", oEmpleado.Legajo),
                new Parametro("@NOMBRE", oEmpleado.Nombre),
                new Parametro("@APELLIDO", oEmpleado.Apellido),
                new Parametro("@PUESTO", oEmpleado.Puesto.Id),
                new Parametro("@SEDE", oEmpleado.Sede.Id),
                new Parametro("@TELEFONO", oEmpleado.Telefono),
                new Parametro("@FECHAINGRESO", oEmpleado.Fecha_ingreso)               
            };
            string sp = "SP_INSERT_EMPLEADO";


            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, parametros);

            if (afectadas == 1)
            {
                return true;
            }

            return false;
        }

        public List<Puesto> ConsultarPuestos()
        {
            Puesto puesto;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_PUESTOS";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Puesto> lista = new List<Puesto>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    puesto = new Puesto()
                    {
                        Id = Convert.ToInt32(row["ID_PUESTO"]),
                        Descripcion = row["PUESTO"].ToString()
                    };
                    lista.Add(puesto);
                }

                return lista;
            }

            return null;
        }

        public List<Sede> ConsultarSedes()
        {
            Sede sede;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_SEDES";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Sede> lista = new List<Sede>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    sede = new Sede()
                    {
                        Id = Convert.ToInt32(row["ID_SEDE"]),
                        Nombre = row["NOMBRE"].ToString()
                    };
                    lista.Add(sede);
                }

                return lista;
            }

            return null;
        }
    }
}
