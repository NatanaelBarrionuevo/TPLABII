using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class TipoProductos
    {
		private int id;
		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        public TipoProductos(int id, string tipo)
        {
			Id = id;
			Tipo = tipo;
        }
		public TipoProductos()
		{

		}
    }
}
