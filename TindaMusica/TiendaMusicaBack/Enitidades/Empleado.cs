using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Empleado : Persona
    {
        private int legajo;
        private Puesto puesto;
        private Sede sede;
        private DateTime fecha_ingreso;
        private bool activo;//No esta en BD
        private DateTime fecha_baja;//No esta en BD

        public DateTime Fecha_baja
        {
            get { return fecha_baja; }
            set { fecha_baja = value; }
        }


        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }


        public Sede Sede
        {
            get { return sede; }
            set { sede = value; }
        }


        public Puesto Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public Empleado(string apellido, string nombre, int legajo, DateTime fecha_ingreso) : base(apellido, nombre)
        {
            Legajo = legajo;
            Fecha_ingreso = fecha_ingreso;

        }
    }
}
