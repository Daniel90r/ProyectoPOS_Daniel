namespace ProyectoPOS_1CA_B.CapaPresentacion
{
    partial class FrmPruebas
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
            this.btnProbarStock = new System.Windows.Forms.Button();
            this.btnProbarClientes = new System.Windows.Forms.Button();
            this.btnProbarPagos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnValidarVenta = new System.Windows.Forms.Button();
            this.btnProbarVentaTransaccional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProbarStock
            // 
            this.btnProbarStock.Location = new System.Drawing.Point(73, 128);
            this.btnProbarStock.Name = "btnProbarStock";
            this.btnProbarStock.Size = new System.Drawing.Size(109, 55);
            this.btnProbarStock.TabIndex = 0;
            this.btnProbarStock.Text = "Stock";
            this.btnProbarStock.UseVisualStyleBackColor = true;
            this.btnProbarStock.Click += new System.EventHandler(this.btnProbarStock_Click);
            // 
            // btnProbarClientes
            // 
            this.btnProbarClientes.Location = new System.Drawing.Point(222, 128);
            this.btnProbarClientes.Name = "btnProbarClientes";
            this.btnProbarClientes.Size = new System.Drawing.Size(109, 55);
            this.btnProbarClientes.TabIndex = 1;
            this.btnProbarClientes.Text = "Clientes Activos";
            this.btnProbarClientes.UseVisualStyleBackColor = true;
            this.btnProbarClientes.Click += new System.EventHandler(this.btnProbarClientes_Click);
            // 
            // btnProbarPagos
            // 
            this.btnProbarPagos.Location = new System.Drawing.Point(361, 128);
            this.btnProbarPagos.Name = "btnProbarPagos";
            this.btnProbarPagos.Size = new System.Drawing.Size(109, 55);
            this.btnProbarPagos.TabIndex = 2;
            this.btnProbarPagos.Text = "Probar Pagos";
            this.btnProbarPagos.UseVisualStyleBackColor = true;
            this.btnProbarPagos.Click += new System.EventHandler(this.btnProbarPagos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(512, 128);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 55);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnValidarVenta
            // 
            this.btnValidarVenta.Location = new System.Drawing.Point(73, 229);
            this.btnValidarVenta.Name = "btnValidarVenta";
            this.btnValidarVenta.Size = new System.Drawing.Size(109, 55);
            this.btnValidarVenta.TabIndex = 4;
            this.btnValidarVenta.Text = "Validar Venta";
            this.btnValidarVenta.UseVisualStyleBackColor = true;
            this.btnValidarVenta.Click += new System.EventHandler(this.btnValidarVenta_Click);
            // 
            // btnProbarVentaTransaccional
            // 
            this.btnProbarVentaTransaccional.Location = new System.Drawing.Point(222, 229);
            this.btnProbarVentaTransaccional.Name = "btnProbarVentaTransaccional";
            this.btnProbarVentaTransaccional.Size = new System.Drawing.Size(109, 55);
            this.btnProbarVentaTransaccional.TabIndex = 5;
            this.btnProbarVentaTransaccional.Text = "Prurba de Venta Rapida";
            this.btnProbarVentaTransaccional.UseVisualStyleBackColor = true;
            this.btnProbarVentaTransaccional.Click += new System.EventHandler(this.btnProbarVentaTransaccional_Click);
            // 
            // FrmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProbarVentaTransaccional);
            this.Controls.Add(this.btnValidarVenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnProbarPagos);
            this.Controls.Add(this.btnProbarClientes);
            this.Controls.Add(this.btnProbarStock);
            this.Name = "FrmPruebas";
            this.Text = "FrmPruebas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProbarStock;
        private System.Windows.Forms.Button btnProbarClientes;
        private System.Windows.Forms.Button btnProbarPagos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnValidarVenta;
        private System.Windows.Forms.Button btnProbarVentaTransaccional;
    }
}