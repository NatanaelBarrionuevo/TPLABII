using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private RazonSocial razon;
        private Barrio barrio;
        private string calle;
        private int altura;//No esta en BD

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }


        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }


        public RazonSocial Razon
        {
            get { return razon; }
            set { razon = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Proveedor(int id, string nombre, RazonSocial razon, Barrio barrio)
        {
            Id = id;
            Nombre = nombre;
            Barrio = barrio;
        }
        public Proveedor()
        {
            
        }

    }
}
