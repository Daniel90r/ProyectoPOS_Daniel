namespace ProyectoPOS_1CA_B.CapaPresentacion
{
    partial class FrmRegistrarVenta
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarDetalle = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.btnNuevoCliente);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.cboTipoPago);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES DE LA VENTA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(996, 48);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(236, 34);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevoCliente.Location = new System.Drawing.Point(432, 42);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(112, 38);
            this.btnNuevoCliente.TabIndex = 6;
            this.btnNuevoCliente.Text = "NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(906, 47);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 28);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "FECHA:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(718, 46);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(182, 36);
            this.cboTipoPago.TabIndex = 3;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(550, 46);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(162, 28);
            this.lblPago.TabIndex = 2;
            this.lblPago.Text = "TIPO DE PAGO:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(112, 44);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(314, 36);
            this.cboCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(100, 28);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO POS - REGISTRO DE VENTAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarProducto);
            this.groupBox2.Controls.Add(this.btnAgregarProducto);
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.lblBuscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 383);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTOS";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(116, 42);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(310, 34);
            this.txtBuscarProducto.TabIndex = 10;
            this.txtBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyDown);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarProducto.Location = new System.Drawing.Point(40, 345);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(386, 38);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "AGRAGR PRODUCTO AL CARRITO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(44, 97);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(382, 222);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarProducto.Location = new System.Drawing.Point(432, 42);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(112, 38);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 42);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(103, 28);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "FILTRAR:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiarDetalle);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.dgvDetalles);
            this.groupBox3.Location = new System.Drawing.Point(588, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 372);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETALLES DE VENTA";
            // 
            // btnLimpiarDetalle
            // 
            this.btnLimpiarDetalle.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiarDetalle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDetalle.Location = new System.Drawing.Point(494, 220);
            this.btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            this.btnLimpiarDetalle.Size = new System.Drawing.Size(115, 88);
            this.btnLimpiarDetalle.TabIndex = 11;
            this.btnLimpiarDetalle.Text = "LIMPIAR TODO";
            this.btnLimpiarDetalle.UseVisualStyleBackColor = false;
            this.btnLimpiarDetalle.Click += new System.EventHandler(this.btnLimpiarDetalle_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Orange;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(494, 96);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(115, 88);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "QUITAR PRODUCTO";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(36, 67);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 62;
            this.dgvDetalles.RowTemplate.Height = 28;
            this.dgvDetalles.Size = new System.Drawing.Size(422, 278);
            this.dgvDetalles.TabIndex = 10;
            this.dgvDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellEndEdit);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(116, 593);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(322, 32);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Monto total: “Total: $0.00”";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(613, 581);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(250, 59);
            this.btnRegistrarVenta.TabIndex = 10;
            this.btnRegistrarVenta.Text = "REGISTRAR VENTA";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Location = new System.Drawing.Point(901, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 59);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1282, 707);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarVenta";
            this.Text = "FrmRegistrarVenta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnLimpiarDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtBuscarProducto;
    }
}