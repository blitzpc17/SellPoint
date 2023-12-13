namespace Presentacion.Busquedas
{
    partial class busMARCAS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsTotalRegistros = new System.Windows.Forms.ToolStripLabel();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.dgvRegistros);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 341);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(200, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 91;
            this.label9.Text = "Buscar:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(321, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(225, 23);
            this.txtBuscar.TabIndex = 92;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsTotalRegistros});
            this.toolStrip1.Location = new System.Drawing.Point(3, 313);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "Total de registros:";
            // 
            // tsTotalRegistros
            // 
            this.tsTotalRegistros.Name = "tsTotalRegistros";
            this.tsTotalRegistros.Size = new System.Drawing.Size(13, 22);
            this.tsTotalRegistros.Text = "0";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(15, 63);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.RowTemplate.Height = 25;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(722, 234);
            this.dgvRegistros.TabIndex = 3;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellClick);
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.boton_eliminar1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(652, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "     Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Image = global::Presentacion.Properties.Resources.seleccione;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(536, 359);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSeleccionar.Size = new System.Drawing.Size(110, 40);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "     Seleccinar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // busMARCAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "busMARCAS";
            this.Text = "Búsqueda - Marcas";
            this.Load += new System.EventHandler(this.busMARCAS_Load);
            this.Shown += new System.EventHandler(this.busMARCAS_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtBuscar;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel tsTotalRegistros;
        private DataGridView dgvRegistros;
        private Button btnCancelar;
        private Button btnSeleccionar;
    }
}