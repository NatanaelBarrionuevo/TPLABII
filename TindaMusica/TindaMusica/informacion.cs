using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace menuslide
{
    public partial class informacion : Form
    {
        public informacion()
        {
            InitializeComponent();
        }

        private void informacion_Load(object sender, EventArgs e)
        {
            lnk.Links.Add(0,lnk.Text.Length, "https://www.youtube.com/watch?v=mCdA4bJAGGk");
        }

        private void lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sinfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sinfo);

        }
    }
}
