using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMusicaBack.Datos.Implementacion;
using TiendaMusicaBack.Datos.Interfaz;
using TiendaMusicaBack.Enitidades;

namespace TindaMusica.Venta
{
    public partial class frmVentaServicios : Form
    {
        IServicioDao servicioDao;
        public frmVentaServicios()
        {
            InitializeComponent();
            servicioDao = new ServicioDao();
        }

        private void frmVentaServicios_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboServicios.Items.Clear();
            List<TipoServicio> tipoServicios = servicioDao.ObtenerTiposServicios();
            foreach (TipoServicio servicio in  tipoServicios)
            {
                cboServicios.Items.Add(servicio);
            }
            cboServicios.SelectedIndex = 0;

        }
    }
}
