using CapaDatos.Entidades;
using CapaNegocios.Logicas.Busquedas;
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

namespace Presentacion.Busquedas
{
    public partial class busClientes : Form
    {
        private BusquedaClientesLogica contexto;
        public clsCLIENTE ObjEntidad;
        private int rowIndexSeleccionado = -1;
        public busClientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }        

        private void InicializarForm()
        {
            contexto = new BusquedaClientesLogica();
            Listar();
            ordenar(1);
        }

        public void Listar()
        {
            contexto.ListarRegistros();
        }

        private void filtrar(int column, string termino)
        {
            if (contexto.Filtrar(column, termino))
            {
                contexto.indexAux = contexto.index;
                dgvRegistros.Rows[contexto.index].Cells[column].Selected = true;
                dgvRegistros.FirstDisplayedScrollingRowIndex = contexto.index;
            }
        }

        private void ordenar(int column)
        {
            txtBuscar.Clear();
            txtBuscar.Focus();
            contexto.Ordenar(column);
            dgvRegistros.DataSource = contexto.LstClienteAux;
            Apariencias();
        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "CLAVE";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "MARCA";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].HeaderText = "PROVEEDOR";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[4].HeaderText = "ESTADO";
            dgvRegistros.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[5].Visible = false;

            tsTotalRegistros.Text = contexto.LstCliente.Count.ToString("N0");

        }

        private void busClientes_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;
            if (rowIndexSeleccionado == -1) return;
            rowIndexSeleccionado = (int)dgvRegistros.CurrentRow.Cells[0].Value;
            ObjEntidad = contexto.ObtenerRegistro(rowIndexSeleccionado);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count <= 0) return;

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                contexto.index = -1;
                return;
            }

            filtrar(contexto.Column, txtBuscar.Text);
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;
            rowIndexSeleccionado = (int)dgvRegistros.CurrentRow.Cells[0].Value;
            ObjEntidad = contexto.ObtenerRegistro(rowIndexSeleccionado);
            Close();
        }
    }
}
