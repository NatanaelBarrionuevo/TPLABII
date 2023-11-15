using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class DetalleFactura
    {
		private int id;
		private Producto producto;
		private int cantidad;
		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}


		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		public Producto Producto
		{
			get { return producto; }
			set { producto = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public DetalleFactura(int id, Producto producto, int cantidad, double precio)
        {
			Id = id;
			Producto = producto;
			Cantidad = cantidad;
			Precio = precio;
        }
    }
}
