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

namespace Presentacion.Ventas
{
    public partial class formVenta : Form
    {
        public formVenta()
        {
            InitializeComponent(); 
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busVENTA bsVenta = new busVENTA();
            bsVenta.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            busClientes bsCliente = new busClientes();
            bsCliente.ShowDialog(); 
        }

        private void formVenta_Load(object sender, EventArgs e)
        {

        }

        private void formVenta_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            busPRODUCTOS buspro = new busPRODUCTOS();
            buspro.ShowDialog();
        }
    }
}
