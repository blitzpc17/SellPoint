using CapaNegocios.Logicas.Sistema;
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

namespace Presentacion.Sistema
{
    public partial class catPuestos : Form
    {
        private catPuestosLogica contexto;
        public catPuestos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }

        private void catPuestos_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void InicializarForm()
        {
            LimpiarControles();
            InstanciarContextos();
            ListarRegistros();
        }

        private void InstanciarContextos()
        {
            contexto = new catPuestosLogica();
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
            dgvRegistros.Columns[2].Visible = false;
            tsTotalRegistros.Text = contexto.LstPUESTO.Count.ToString("N0");

            contexto.Column = 1;

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.Listar();
            dgvRegistros.DataSource = contexto.LstPUESTO;
            Apariencias();
        }

        private void Guardar()
        {
            if (contexto.ObjPUESTO == null)
            {
                contexto.InstanciarPUESTO();
            }

            contexto.ObjPUESTO.Nombre = txtNombre.Text;

            contexto.Guardar();

            MessageBox.Show("Registro guardado correctamente.", "Aciso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarForm();

        }

        private void catPuestos_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
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
            contexto.Ordenar(column);
            dgvRegistros.DataSource = contexto.LstPUESTOAux;
            Apariencias();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count <= 0) return;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                contexto.index = -1;
                return;
            }

            filtrar(contexto.Column, txtNombre.Text);
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            contexto.ObjPUESTO = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);

            setData();
        }

        private void setData()
        {
            if (contexto.ObjPUESTO != null)
            {
                txtNombre.Text = contexto.ObjPUESTO.Nombre.ToString();
            }
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

        private void EliminarRegistro()
        {
            contexto.ObjPUESTO = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);
            contexto.Eliminar(contexto.ObjPUESTO);
            contexto.Guardar();
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
