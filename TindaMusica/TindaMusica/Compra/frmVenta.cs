using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TindaMusica;

namespace TindaMusica.Venta
{
    public partial class frmVenta : Form
    {
        frmVentaProductos formProd;

        frmVentaServicios formServ;
        public frmVenta()
        {
            InitializeComponent();

            formProd = new frmVentaProductos();
            formProd.TopLevel = false;
            formProd.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formProd);



            formServ = new frmVentaServicios();
            formServ.TopLevel = false;
            formServ.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formServ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formProd.Hide();
            //this.Contro/*ls.Remove(formProd);*/

            //this.Controls.Add(formServ);
            formServ.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

            formProd.Show();


            //frmVentaProductos form = new frmVentaProductos();


            //form.MdiParent = this;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;
            //form.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {


            formServ.Hide();
            //this.Controls.Remove(formServ);

            //this.Controls.Add(formProd);
            formProd.Show();
        }
    }

}
