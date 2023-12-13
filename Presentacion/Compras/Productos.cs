using CapaNegocios.Logicas.Compras;
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
    public partial class Productos : Form
    {
        private ProductosLogica contexto;
        private int idRegistroSeleccionado = -1;
        private int idMarcaSeleccionada = -1;
        private int idImpuestoSeleccionado = -1;

        public Productos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }      

        public void InicializarModulo()
        {
            LimpiarControles();
            InstanciarContexto();
            ListarCatalogos();
            ListarRegistros();
        }

        public void LimpiarControles()
        {
            ThemeConfig.LimpiarControles(this);
            dgvImpuestos.DataSource = null;
            tsTotalImpuestos.Text = @"0";
        }

        public void ListarCatalogos()
        {
            contexto.ListarCatalogos();
            cbxEstado.DataSource = contexto.LstEstado;
            cbxEstado.DisplayMember = "Nombre";
            cbxEstado.ValueMember = "Id";
            cbxEstado.SelectedIndex = -1;

            
            cbxImpuesto.DataSource = contexto.LstImpuesto;
            cbxImpuesto.DisplayMember = "Nombre";
            cbxImpuesto.ValueMember = "Id";
            cbxImpuesto.SelectedIndex = -1;

        }

        public void InstanciarContexto()
        {
            contexto = new ProductosLogica();
        }

        public void Guardar()
        {

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ESTADO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contexto.ObjProducto == null)
            {
                contexto.InstanciarProducto();
            }

            contexto.ObjProducto.Clave = txtClave.Text;
            contexto.ObjProducto.Nombre = txtNombre.Text;
            contexto.ObjProducto.CodigoBarras = txtCodigoBarras.Text;
            contexto.ObjProducto.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            contexto.ObjProducto.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            contexto.ObjProducto.FechaRegistro = DateTime.Now;
            contexto.ObjProducto.MARCAId = idMarcaSeleccionada;
            contexto.ObjProducto.ESTADOId = (int)cbxEstado.SelectedValue;
            contexto.Guardar();


            MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarModulo();

        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "CLAVE";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "NOMBRE";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].HeaderText = "CÓDIGO BARRAS";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[4].Visible = false;
            dgvRegistros.Columns[5].HeaderText = "MARCA";
            dgvRegistros.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[6].Visible = false;
            dgvRegistros.Columns[7].HeaderText = "PROVEEDOR";
            dgvRegistros.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[8].Visible = false;
            dgvRegistros.Columns[9].Visible = false;
            dgvRegistros.Columns[10].Visible = false;
            dgvRegistros.Columns[11].Visible = false;
            dgvRegistros.Columns[12].Visible = false;
            dgvRegistros.Columns[12].Visible = false;
            dgvRegistros.Columns[14].Visible = false;
            dgvRegistros.Columns[15].Visible = false;
            dgvRegistros.Columns[16].HeaderText = "ESTADO";
            dgvRegistros.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           


            tsTotalRegistros.Text = contexto.LstProducto.Count.ToString("N0");

        }
        private void AparienciasImpuestos()
        {            
            dgvImpuestos.Columns[0].Visible = false;
            dgvImpuestos.Columns[1].HeaderText = "NOMBRE";
            dgvImpuestos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImpuestos.Columns[2].HeaderText = "PORCENTAJE";
            dgvImpuestos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImpuestos.Columns[3].Visible = false;
            dgvImpuestos.Columns[4].HeaderText = "BAJA";
            dgvImpuestos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            

            tsTotalImpuestos.Text = contexto.LstImpuestosProducto.Count.ToString();
        }

    private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.ListarProductos();
            dgvRegistros.DataSource = contexto.LstProducto;
            Apariencias();
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
            dgvRegistros.DataSource = contexto.LstProductoAux;
            Apariencias();
        }

        private void Modificar()
        {
            if (dgvRegistros.DataSource == null) return;
            idRegistroSeleccionado = (int)dgvRegistros.CurrentRow.Cells[0].Value;
            contexto.ObjProducto = contexto.Obtener(idRegistroSeleccionado);
            if (contexto.ObjProducto != null)
            {
                txtClave.Text = contexto.ObjProducto.Clave;
                txtNombre.Text = contexto.ObjProducto.Nombre;
                txtCodigoBarras.Text = contexto.ObjProducto.CodigoBarras;
                txtPrecioCompra.Text = contexto.ObjProducto.PrecioCompra.ToString("N2");
                txtPrecioVenta.Text = contexto.ObjProducto.PrecioVenta.ToString("N2");
                cbxEstado.SelectedValue = contexto.ObjProducto.ESTADOId;
                txtMarca.Text = contexto.ObjProducto.MARCA.Nombre;
                idMarcaSeleccionada = contexto.ObjProducto.MARCAId;

                //listar impuestos si hay
                contexto.ListarImpuestosProducto(contexto.ObjProducto.Id);
                dgvImpuestos.DataSource = contexto.LstImpuestosProducto;
                tsTotalImpuestos.Text = contexto.LstImpuestosProducto.Count.ToString("N0");

            }
        }




        private void Productos_Load(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void Productos_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            var bus = new Busquedas.busMARCAS();
            bus.ShowDialog();
            if (bus.ObjEntidad == null)
            {
                MessageBox.Show("No se selecciono ningún registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (bus.ObjEntidad.EstadoId == 8)//esto varia segun la captura del registro
            {
                MessageBox.Show("El registro seleccionado esta DESACTIVADO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMarca.Text = bus.ObjEntidad.Marca;
            idMarcaSeleccionada = bus.ObjEntidad.Id;
        }

        private void btnImpuesto_Click(object sender, EventArgs e)
        {
            if (contexto.LstImpuestosProducto == null)
            {
                contexto.InstanciarListaImpuestos();
            }

            if(cbxImpuesto.SelectedValue!=null && cbxImpuesto.SelectedIndex > -1)
            {
                contexto.InstanciarProductoImpuesto();
                var impuesto = contexto.LstImpuesto.First(x => x.Id == (int)cbxImpuesto.SelectedValue);
                contexto.ObjProductoImpuestoAux.Baja = false;
                contexto.ObjProductoImpuestoAux.ImpuestoId = impuesto.Id;
                contexto.ObjProductoImpuestoAux.Nombre = impuesto.Nombre;
                contexto.ObjProductoImpuestoAux.Porcentaje = impuesto.Porcentaje;
                contexto.LstImpuestosProducto.Add(contexto.ObjProductoImpuestoAux);
                dgvImpuestos.DataSource = contexto.LstImpuestosProducto;
                AparienciasImpuestos();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado el impuesto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }


        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }

        private void quitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvImpuestos.DataSource == null) return;

            idImpuestoSeleccionado = (int)dgvImpuestos.CurrentRow.Cells[0].Value;
            contexto.LstImpuestosProducto.First(x => x.Id == idImpuestoSeleccionado).Baja = true;
                

        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }
    }
}
