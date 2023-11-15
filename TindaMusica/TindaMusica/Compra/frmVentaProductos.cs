
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresupuestosBack.Datos;
using TiendaMusicaBack.Datos.Implementacion;
using TiendaMusicaBack.Datos.Interfaz;
using TiendaMusicaBack.Enitidades;



namespace TindaMusica.Venta
{

    public partial class frmVentaProductos : Form
    {
        List<DetaleFactura> detalleFactura;
        IProductoDao productoDao;
        public frmVentaProductos()
        {
            InitializeComponent();
            detalleFactura = new List<DetaleFactura>();
            productoDao = new ProductoDao();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtCodigo.Text != String.Empty)
                {
                    AgregarProducto(txtCodigo.Text);
                    txtCodigo.Text = String.Empty;
                }
                //MessageBox.Show("Pressed enter.");
            }
        }

        private void AgregarProducto(string codigo)
        {
            Producto prod = productoDao.ConsultarProducto(Convert.ToInt32(codigo));

            if (prod != null)
            {
                CargarDetalle(prod);
                ActualizarDgv();
            }
            
         



        }

        private void ActualizarDgv()
        {
            dataGridView1.Rows.Clear();
            foreach (DetaleFactura det in detalleFactura)
            {
                dataGridView1.Rows.Add(new object[] {

                    det.Product.Id,
                    det.Product.Nombre,
                    det.Precio,
                    det.Product.Tipo_prod.Tipo,
                    det.Cantidad
                    });

            }

        }



        private void CargarDetalle(Producto prod)
        {
            bool existe = false;
            if (prod !=null) {
                foreach (DetaleFactura det in detalleFactura)
                {
                    if (prod.Id == det.Product.Id)
                    {
                        det.Cantidad++;
                        existe = true;
                    }
                }

                if (!existe)
                {
                    detalleFactura.Add(new DetaleFactura()
                    {
                        Product = prod,
                        Cantidad = 1,
                        Precio = prod.Precio
                    });
                }
            }
            

        }

        private void frmVentaProductos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<DetaleFactura> GetDetaleFacturaList() { return detalleFactura; }
    }
}

