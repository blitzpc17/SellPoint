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
    public partial class catImpuestos : Form
    {
        private catImpuestosLogica contexto;

        public catImpuestos()
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
            contexto = new catImpuestosLogica();
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
            dgvRegistros.Columns[2].HeaderText = "Porcentaje(%)";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tsTotalRegistros.Text = contexto.LstImpuesto.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.Listar();
            dgvRegistros.DataSource = contexto.LstImpuesto;
            Apariencias();
        }

        private void Guardar()
        {
            if (contexto.ObjImpuesto == null)
            {
                contexto.InstanciarEstado();
            }
            if (string.IsNullOrEmpty(txtImpuesto.Text))
            {
                MessageBox.Show("El campo PORCENTAJE es obligatorio..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contexto.ObjImpuesto.Nombre = txtNombre.Text;
            contexto.ObjImpuesto.Porcentaje = Convert.ToDecimal(txtImpuesto.Text);

            contexto.Guardar();

            MessageBox.Show("Registro guardado correctamente.", "Aciso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarForm();

        }


        private void EliminarRegistro()
        {
            contexto.ObjImpuesto = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);
            contexto.Eliminar(contexto.ObjImpuesto);
            contexto.Guardar();
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setData()
        {
            if (contexto.ObjImpuesto != null)
            {
                txtNombre.Text = contexto.ObjImpuesto.Nombre;
                txtImpuesto.Text = contexto.ObjImpuesto.Porcentaje.ToString("N2");
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
            dgvRegistros.DataSource = contexto.LstImpuesto;
            Apariencias();
        }

        private void catImpuestos_Load(object sender, EventArgs e)
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

        private void catImpuestos_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            contexto.ObjImpuesto = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);

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
