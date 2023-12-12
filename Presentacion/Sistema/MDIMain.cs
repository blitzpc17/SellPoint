using Presentacion.Compras;
using Presentacion.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Sistema
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }       

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catRoles cat = new catRoles();
            cat.MdiParent = this;
            cat.Show();
        }

        private void pUESTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catPuestos cat = new catPuestos();
            cat.MdiParent = this;
            cat.Show();
        }

        private void eSTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catEstados cat = new catEstados();
            cat.MdiParent = this;
            cat.Show();
        }

        private void capturaYConsultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Usuarios form = new Usuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void capturaYConsultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Empleado form = new Empleado();
            form.MdiParent = this;
            form.Show();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo form = new Modulo();
            form.MdiParent = this;
            form.Show();
        }

        private void moduloPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloPermisos form = new ModuloPermisos();
            form.MdiParent = this;
            form.Show();
        }

        private void controlPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPermisos form = new ControlPermisos();
            form.MdiParent = this;
            form.Show();
        }

        private void capturaYConsultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modulo form = new Modulo();
            form.MdiParent = this;
            form.Show();
        }

        private void tipoMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catTipoMovimiento form = new catTipoMovimiento();
            form.MdiParent = this;
            form.Show();
        }

        private void capturaYConsultaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Proveedores form = new Proveedores();
            form.MdiParent = this;
            form.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas form = new Marcas();
            form.MdiParent = this;
            form.Show();
        }
    }
}
