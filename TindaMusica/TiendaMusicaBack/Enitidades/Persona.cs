using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int telefono;
        private string email;
        private Barrio barrio;
        private string calle;
        private int altura;

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

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Persona(string apellido, string nombre)
        {
            Apellido = apellido;
            Nombre = nombre;
            Barrio = null;
            Email = string.Empty;
        }
        public Persona(string apellido, string nombre, Barrio barrio)
        {
            Apellido = apellido;
            Nombre = nombre;
            Barrio = barrio;
            Email = string.Empty;
        }


    }
}
