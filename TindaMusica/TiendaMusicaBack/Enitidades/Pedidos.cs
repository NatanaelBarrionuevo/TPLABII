using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Pedidos
    {
		private int id;
		private DateTime fecha;
		private Proveedor proveedor;
		private FormaPago formaPago;
		private FormaEnvio envio;
		private List<DetallePedido> detalle;

		public List<DetallePedido> Detalle
		{
			get { return detalle; }
			set { detalle = value; }
		}


		public FormaEnvio Forma
		{
			get { return envio; }
			set { envio = value; }
		}


		public FormaPago FprmaPago
		{
			get { return formaPago; }
			set { formaPago = value; }
		}


		public Proveedor Proveedor
		{
			get { return proveedor; }
			set { proveedor = value; }
		}


		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public Pedidos(int id, DateTime fecha, Proveedor proveedor, List<DetallePedido> detalle)
        {
			Id = id;
			Fecha = fecha;
			Proveedor = proveedor;
			Detalle = detalle;
        }
        public Pedidos()
        {
			Detalle = new List<DetallePedido>();
        }
        public void AgregarPedido(DetallePedido dp)
		{
			Detalle.Add(dp);
		}
        public void QuitarPedido(DetallePedido dp)
        {
            Detalle.RemoveAt(dp);
        }
    }
}
