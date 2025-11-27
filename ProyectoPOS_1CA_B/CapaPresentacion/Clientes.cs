using ProyectoPOS_1CA_B.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_1CA_B.CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        //creamos una lista de clientes
        private List<CapaEntidades.Clientes> listaClientes = new List<CapaEntidades.Clientes>();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

            if (!listaClientes.Any())
            {
                listaClientes.Add(new CapaEntidades.Clientes
                {
                    Id = 1,
                    Nombre = "Juan Carlos",
                    Apellido = "Vasquez Jiron",
                    Email = "juan845@gmail.com",
                    Telefono = "12345678",
                    Direccion = "Chalatenango"
                });

                listaClientes.Add(new CapaEntidades.Clientes
                {
                    Id = 2,
                    Nombre = "Maria Fernanda",
                    Apellido = "Lopez Perez",
                    Email = "maria.lopez@gmail.com",
                    Telefono = "87654321",
                    Direccion = "San Salvador"
                });

                listaClientes.Add(new CapaEntidades.Clientes
                {
                    Id = 3,
                    Nombre = "Carlos Eduardo",
                    Apellido = "Gonzalez Ruiz",
                    Email = "carlos.gonzalez@gmail.com",
                    Telefono = "13579246",
                    Direccion = "Santa Ana"
                });
            }
            // metodo para refrescar
            RefrescarlistaClientes();

        }
        private void RefrescarlistaClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                if (dgvClientes.CurrentRow == null) return;
                txtId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = dgvClientes.CurrentRow.Cells["Email"].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Validaciones basicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !Validaciones.EsCorreoValido(txtCorreo.Text))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo cliente y agregarlo a la lista
            int nuevoId = listaClientes.Any() ? listaClientes.Max(x => x.Id) + 1 : 1;
            var c = new CapaEntidades.Clientes
            {
                Id = nuevoId,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };
            listaClientes.Add(c);
            MessageBox.Show("Cliente agregado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarlistaClientes();
            //limpiar los controles
            LimpiarCampos();
        }
        // Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // evento para eliminar un cliente
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un cliente válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Cl = listaClientes.FirstOrDefault(x => x.Id == id);
            if (Cl == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }
            if (MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listaClientes.Remove(Cl);
                MessageBox.Show("Cliente eliminado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarlistaClientes();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validar que el ID sea correcto
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto valido para eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = listaClientes.FirstOrDefault(x => x.Id == id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado"); return;
            }
            //Validaciones basicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("EL nombre es obligartorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Actualizar el producto
            prod.Nombre = txtNombre.Text.Trim();
            prod.Apellido = txtApellido.Text.Trim();
            prod.Email = txtCorreo.Text.Trim();
            prod.Direccion = txtDireccion.Text.Trim();
            prod.Telefono = txtTelefono.Text.Trim();
            prod.Id = int.TryParse(txtId.Text.Trim(), out int nuevoId) ? nuevoId : prod.Id;
            MessageBox.Show("Cliente actualizado exitosamente.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarlistaClientes();
            LimpiarCampos();
        
        }
    }
}
