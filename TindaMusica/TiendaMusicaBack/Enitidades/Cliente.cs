using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Cliente : Persona
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public Cliente(string apellido, string nombre, Barrio barrio, int id): base(apellido, nombre, barrio)
        {
            Id = id;
        }

    }
}
