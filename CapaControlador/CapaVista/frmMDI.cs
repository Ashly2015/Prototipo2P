using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinea frmLinea = new frmLinea();
            frmLinea.MdiParent = this.MdiParent;

            frmLinea.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca();
            frmMarca.MdiParent = this.MdiParent;

            frmMarca.Show();
        }
    }
}
