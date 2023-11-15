using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Factura
    {
		private int nro;
		private DateTime fecha;
		private Empleado empleado;
		private Cliente cliente;
		private FormaPago pago;
		private FormaEnvio envio;
		private List<DetalleFactura> detalleFactura;
		private List<DetalleServicio> detalleServicio;

		public List<DetalleServicio> DetalleServicio
		{
			get { return detalleServicio; }
			set { detalleServicio = value; }
		}


		public List<DetalleFactura> DetalleFactura
		{
			get { return detalleFactura; }
			set { detalleFactura = value; }
		}

		public FormaEnvio Envio
		{
			get { return envio; }
			set { envio = value; }
		}


		public FormaPago Pago
		{
			get { return pago; }
			set { pago = value; }
		}


		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}


		public Empleado Empleado
		{
			get { return empleado; }
			set { empleado = value; }
		}


		public DateTime MyProperty
		{
			get { return fecha; }
			set { fecha = value; }
		}

		public int Nro
		{
			get { return nro; }
			set { nro = value; }
		}

        public Factura(int nro, DateTime fecha, Empleado e, Cliente c, FormaPago pago, FormaEnvio envio, List<DetalleFactura> detFact, List<DetalleServicio> detServ)
        {
			Nro = nro;
			fecha = fecha;
			Empleado = e;
			Cliente = c;
			Pago = pago;
			Envio = envio;
			DetalleServicio = detServ;
			DetalleFactura = detFact;
        }
    }
}
