using Presentacion.Busquedas;
using Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Compras
{
    public partial class formOrdenCompra : Form
    {
        public formOrdenCompra()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }

        private void formOrdenCompra_Load(object sender, EventArgs e)
        {

        }

        private void formOrdenCompra_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            busPRODUCTOS buspro = new busPRODUCTOS();
            buspro.ShowDialog();
        }
    }
}
