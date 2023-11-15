
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
                AgregarProducto(txtCodigo.Text);
                txtCodigo.Text = String.Empty;
                //MessageBox.Show("Pressed enter.");
            }
        }

        private void AgregarProducto(string codigo)
        {
            Producto prod = productoDao.ConsultarProducto(Convert.ToInt32(codigo));

            CargarDetalle(prod);
             ActualizarDgv();


            //List<Parametro> parametros = new List<Parametro>();
            //string sp = "SP_CONSULTAR_PRODUCTO";
            //parametros.Add(new Parametro("@id", codigo));

            //DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);

            
            //List<Producto> lista = new List<Producto>();
            //foreach (DataRow row in tabla.Rows)
            //{

                
            //        dataGridView1.Rows.Add(new object[] {

            //        Convert.ToInt32(row["ID_PRODUCTO"]),
            //        row["NOMBRE"].ToString(),
            //        (float)Convert.ToDecimal(row["Precio"].ToString()),
            //        row["TIPO"].ToString()
            //        });
            //}
                

                
         }

        private void ActualizarDgv()
        {
            dataGridView1.Rows.Clear();
            foreach (DetaleFactura det in detalleFactura)
            {
                dataGridView1.Rows.Add(new object[] {

                    det.Product.Id,
                    det.Product.Nombre,
                    det.Product.Precio,
                    det.Product.Tipo_prod.Tipo
                    });

            }

        }

        private void ActualizarDetalle()
        {
            throw new NotImplementedException();
        }

        private void CargarDetalle(Producto prod)
        {
            foreach (DetaleFactura det in detalleFactura)
            {
                if (prod.Id == det.Product.Id)
                {
                    det.Cantidad++;
                }
            }
            
        }

        private void frmVentaProductos_Load(object sender, EventArgs e)
        {

        }
    }
    }

