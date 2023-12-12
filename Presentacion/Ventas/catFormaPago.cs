using CapaNegocios.Logicas.Venta;
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
    public partial class catFormaPago : Form
    {
        private catFormaPagoLogica contexto;
        public catFormaPago()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }

        private void InicializarForm()
        {
            LimpiarControles();
            InstanciarContextos();
            ListarRegistros();
        }

        private void InstanciarContextos()
        {
            contexto = new catFormaPagoLogica();
        }

        private void LimpiarControles()
        {
            ThemeConfig.LimpiarControles(this);
        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "Nombre";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tsTotalRegistros.Text = contexto.LstFORMAPAGO.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.Listar();
            dgvRegistros.DataSource = contexto.LstFORMAPAGO;
            Apariencias();
        }

        private void Guardar()
        {
            if (contexto.ObjFORMAPAGO == null)
            {
                contexto.InstanciarFORMAPAGO();
            }

            contexto.ObjFORMAPAGO.Nombre = txtNombre.Text;

            contexto.Guardar();

            MessageBox.Show("Registro guardado correctamente.", "Aciso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarForm();

        }


        private void EliminarRegistro()
        {
            contexto.ObjFORMAPAGO = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);
            contexto.Eliminar(contexto.ObjFORMAPAGO);
            contexto.Guardar();
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setData()
        {
            if (contexto.ObjFORMAPAGO != null)
            {
                txtNombre.Text = contexto.ObjFORMAPAGO.Nombre;
            }
        }

        private void filtrar(int column, string termino)
        {
            if (contexto.Filtrar(column, termino))
            {
                contexto.IndexAux = contexto.Index;
                dgvRegistros.Rows[contexto.Index].Cells[column].Selected = true;
                dgvRegistros.FirstDisplayedScrollingRowIndex = contexto.Index;
            }
        }

        private void ordenar(int column)
        {
            contexto.Ordenar(column);
            dgvRegistros.DataSource = contexto.LstFORMAPAGOAux;
            Apariencias();
        }

        private void catFormaPago_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count <= 0) return;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                contexto.Index = -1;
                return;
            }

            filtrar(contexto.Column, txtNombre.Text);
        }

        private void catFormaPago_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            contexto.ObjFORMAPAGO = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);

            setData();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            if (MessageBox.Show("Se borrará el registro. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EliminarRegistro();
                InicializarForm();
            }
        }
    }
}
