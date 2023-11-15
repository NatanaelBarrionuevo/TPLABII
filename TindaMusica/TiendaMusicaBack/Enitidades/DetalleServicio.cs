using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class DetalleServicio
    {
		private int id;
		private Luthier luthier;
		private TipoServicio tipoServ;
		private double precioHora;
		private int horas;

		public int Horas
		{
			get { return horas; }
			set { horas = value; }
		}


		public double PrecioHora
		{
			get { return precioHora; }
			set { precioHora = value; }
		}

		public TipoServicio TipoServ
		{
			get { return tipoServ; }
			set { tipoServ = value; }
		}

		public Luthier Luthier
		{
			get { return luthier; }
			set { luthier = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public DetalleServicio(int id, Luthier luthier, TipoServicio tipo)
		{
			Id = id;
			Luthier = luthier;
			TipoServ = tipo;
		}

		
	}
}
