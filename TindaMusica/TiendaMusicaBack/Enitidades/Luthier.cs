using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Luthier : Persona
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public Luthier(string apellido, string nombre, int id) : base(apellido, nombre)
        {
            Id = id;
            
        }
    }
}
