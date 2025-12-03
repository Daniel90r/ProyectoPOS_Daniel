using ProyectoPOS_1CA_B.CapaEntidades;
using ProyectoPOS_1CA_B.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_1CA_B
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

            /// Control básico por rol
//Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

            }


        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            //cuando de clic, abrira el formulario de productos
            FrmProductos frm = new FrmProductos();
            frm.Show();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarClave frm = new FrmCambiarClave();
            frm.ShowDialog();
        }
    }
}
