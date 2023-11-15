using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Producto
    {
		private int id;
		private string nombre;
		private string descripcion;
		private TipoCaracteristica tipo_prod;
		private Marca marca;
		private Proveedor proveedor;
		private Pais pais;
		private int stock;
		private double precio;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}


		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}


		public Pais Pais
		{
			get { return pais; }
			set { pais = value; }
		}


		public Proveedor Proveedor
		{
			get { return proveedor; }
			set { proveedor = value; }
		}


		public Marca Marca
		{
			get { return marca; }
			set { marca = value; }
		}


		public TipoCaracteristica Tipo_prod
		{
			get { return tipo_prod; }
			set { tipo_prod = value; }
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

        public Producto(int id, string nombre, Marca marca, Proveedor proveedor)
        {
			Id = id;
			Nombre = nombre;
			Marca = marca;
			Proveedor = proveedor;

        }
        public Producto()
        {
            
        }
    }
}
