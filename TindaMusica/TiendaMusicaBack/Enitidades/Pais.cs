using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Pais
    {
		private int id;
		private string nombre;

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

        public Pais(int id, string nombre)
        {
			Id = id;
			Nombre = nombre;
        }
        public Pais()
        {
            
        }

    }
}
