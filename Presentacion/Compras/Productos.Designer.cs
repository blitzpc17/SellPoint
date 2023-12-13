namespace Presentacion.Compras
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsTotalRegistros = new System.Windows.Forms.ToolStripLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.cmsRegistros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsImpuestos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsTotalImpuestos = new System.Windows.Forms.ToolStripLabel();
            this.btnImpuesto = new System.Windows.Forms.Button();
            this.dgvImpuestos = new System.Windows.Forms.DataGridView();
            this.cbxImpuesto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.cmsRegistros.SuspendLayout();
            this.cmsImpuestos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.salvar1;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(921, 609);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "     Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.boton_eliminar1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1037, 609);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "     Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBusqueda);
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtFechaRegistro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(512, 29);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(225, 23);
            this.txtPrecioCompra.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(391, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 23);
            this.label10.TabIndex = 102;
            this.label10.Text = "Precio Venta:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(137, 120);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(225, 23);
            this.txtPrecioVenta.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 98;
            this.label4.Text = "Precio Compra:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Image = global::Presentacion.Properties.Resources.lupa2;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(713, 59);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(24, 24);
            this.btnBusqueda.TabIndex = 70;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(137, 91);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(225, 23);
            this.txtCodigoBarras.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 95;
            this.label6.Text = "Código Barras:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(512, 92);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(225, 23);
            this.cbxEstado.TabIndex = 90;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(512, 59);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(195, 23);
            this.txtMarca.TabIndex = 60;
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Location = new System.Drawing.Point(512, 121);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.ReadOnly = true;
            this.txtFechaRegistro.Size = new System.Drawing.Size(225, 23);
            this.txtFechaRegistro.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(391, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Fecha Registro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Clave:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(137, 33);
            this.txtClave.MaxLength = 35;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(225, 23);
            this.txtClave.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(391, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Marca:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(391, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.dgvRegistros);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 417);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsTotalRegistros});
            this.toolStrip1.Location = new System.Drawing.Point(3, 389);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1129, 25);
            this.toolStrip1.TabIndex = 97;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Total Registros:";
            // 
            // tsTotalRegistros
            // 
            this.tsTotalRegistros.Name = "tsTotalRegistros";
            this.tsTotalRegistros.Size = new System.Drawing.Size(13, 22);
            this.tsTotalRegistros.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(391, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 96;
            this.label9.Text = "Buscar:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(512, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(225, 23);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.ContextMenuStrip = this.cmsRegistros;
            this.dgvRegistros.Location = new System.Drawing.Point(16, 68);
            this.dgvRegistros.MultiSelect = false;
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.RowTemplate.Height = 25;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(1103, 311);
            this.dgvRegistros.TabIndex = 94;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellClick);
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // cmsRegistros
            // 
            this.cmsRegistros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.cmsRegistros.Name = "cmsRegistros";
            this.cmsRegistros.Size = new System.Drawing.Size(126, 26);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.editar;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // cmsImpuestos
            // 
            this.cmsImpuestos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitarToolStripMenuItem});
            this.cmsImpuestos.Name = "cmsImpuestos";
            this.cmsImpuestos.Size = new System.Drawing.Size(108, 26);
            // 
            // quitarToolStripMenuItem
            // 
            this.quitarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.borrar;
            this.quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            this.quitarToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.quitarToolStripMenuItem.Text = "Quitar";
            this.quitarToolStripMenuItem.Click += new System.EventHandler(this.quitarToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Controls.Add(this.btnImpuesto);
            this.groupBox3.Controls.Add(this.dgvImpuestos);
            this.groupBox3.Controls.Add(this.cbxImpuesto);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(778, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 168);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impuestos";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsTotalImpuestos});
            this.toolStrip2.Location = new System.Drawing.Point(3, 140);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(363, 25);
            this.toolStrip2.TabIndex = 111;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "Total Registros:";
            // 
            // tsTotalImpuestos
            // 
            this.tsTotalImpuestos.Name = "tsTotalImpuestos";
            this.tsTotalImpuestos.Size = new System.Drawing.Size(13, 22);
            this.tsTotalImpuestos.Text = "0";
            // 
            // btnImpuesto
            // 
            this.btnImpuesto.Image = global::Presentacion.Properties.Resources.plus_pequeno;
            this.btnImpuesto.Location = new System.Drawing.Point(334, 28);
            this.btnImpuesto.Name = "btnImpuesto";
            this.btnImpuesto.Size = new System.Drawing.Size(24, 24);
            this.btnImpuesto.TabIndex = 120;
            this.btnImpuesto.UseVisualStyleBackColor = true;
            this.btnImpuesto.Click += new System.EventHandler(this.btnImpuesto_Click);
            // 
            // dgvImpuestos
            // 
            this.dgvImpuestos.AllowUserToAddRows = false;
            this.dgvImpuestos.AllowUserToDeleteRows = false;
            this.dgvImpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuestos.ContextMenuStrip = this.cmsImpuestos;
            this.dgvImpuestos.Location = new System.Drawing.Point(11, 60);
            this.dgvImpuestos.MultiSelect = false;
            this.dgvImpuestos.Name = "dgvImpuestos";
            this.dgvImpuestos.ReadOnly = true;
            this.dgvImpuestos.RowHeadersVisible = false;
            this.dgvImpuestos.RowTemplate.Height = 25;
            this.dgvImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpuestos.Size = new System.Drawing.Size(346, 77);
            this.dgvImpuestos.TabIndex = 109;
            // 
            // cbxImpuesto
            // 
            this.cbxImpuesto.FormattingEnabled = true;
            this.cbxImpuesto.Location = new System.Drawing.Point(132, 28);
            this.cbxImpuesto.Name = "cbxImpuesto";
            this.cbxImpuesto.Size = new System.Drawing.Size(190, 23);
            this.cbxImpuesto.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(11, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 23);
            this.label11.TabIndex = 107;
            this.label11.Text = "Impuesto:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1175, 600);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.Shown += new System.EventHandler(this.Productos_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.cmsRegistros.ResumeLayout(false);
            this.cmsImpuestos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox txtCodigoBarras;
        private Label label6;
        private ComboBox cbxEstado;
        private TextBox txtMarca;
        private TextBox txtFechaRegistro;
        private Label label3;
        private Label label5;
        private TextBox txtClave;
        private Label label7;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPrecioCompra;
        private Label label10;
        private TextBox txtPrecioVenta;
        private Label label4;
        private Button btnBusqueda;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtBuscar;
        private DataGridView dgvRegistros;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel tsTotalRegistros;
        private ContextMenuStrip cmsImpuestos;
        private ToolStripMenuItem quitarToolStripMenuItem;
        private ContextMenuStrip cmsRegistros;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private GroupBox groupBox3;
        private Button btnImpuesto;
        private DataGridView dgvImpuestos;
        private ComboBox cbxImpuesto;
        private Label label11;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel tsTotalImpuestos;
    }
}