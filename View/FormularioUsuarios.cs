using TuSaludEnTusHuesos.Controlador;
using TuSaludEnTusHuesos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuSaludEnTusHuesos.View
{
    public partial class FormularioUsuarios : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public FormularioUsuarios()
        {
            InitializeComponent();
            CargarUsuariosEnDataGridView();
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            TipoUser();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la operación si hay campos vacíos
            }
            // Guardando los valores desde las txt
            switch (cbbRol.SelectedIndex+1)
            {
                case 1:
                    Administrador administrador = new Administrador();
                    administrador.Nombre = txtNombre.Text;
                    administrador.Apellido = txtApellido.Text;
                    administrador.Direccion = txtDireccion.Text;
                    administrador.Telefono = txtTelefono.Text;
                    administrador.Email = txtEmail.Text;
                    administrador.IdRol = 1;
                    administrador.Usuario = txtUsuario.Text;
                    administrador.Contrasena = txtContrasena.Text;

                    usuarioController.InsertarAdministrador(administrador);
                    break;
                case 2:
                    Doctor doctor = new Doctor();
                    doctor.Nombre = txtNombre.Text;
                    doctor.Apellido = txtApellido.Text;
                    doctor.Direccion = txtDireccion.Text;
                    doctor.Telefono = txtTelefono.Text;
                    doctor.Email = txtEmail.Text;
                    doctor.IdRol = 2;
                    doctor.Usuario = txtUsuario.Text;
                    doctor.Contrasena = txtContrasena.Text;
                    doctor.Especialidad = cbbEspecialidad.Text;
                    usuarioController.InsertarDoctor(doctor);
                    break;
                case 3:
                    Recepcionista recepcionista = new Recepcionista();
                    recepcionista.Nombre = txtNombre.Text;
                    recepcionista.Apellido = txtApellido.Text;
                    recepcionista.Direccion = txtDireccion.Text;
                    recepcionista.Telefono = txtTelefono.Text;
                    recepcionista.Email = txtEmail.Text;
                    recepcionista.IdRol = 3;
                    recepcionista.Usuario = txtUsuario.Text;
                    recepcionista.Contrasena = txtContrasena.Text;

                    usuarioController.InsertarRecepcionista(recepcionista);
                    break;
                default:
                    break;
            }

            // Limpiar los controles después de la inserción.
            Limpiar();

            // Mostrar un mensaje de "Agregado exitosamente".
            MessageBox.Show("Usuario agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llamar al método para cargar y mostrar los usuarios en el DataGridView.
            CargarUsuariosEnDataGridView();
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtContrasena.Text = string.Empty;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            cbbEspecialidad.Enabled = true;
            txtContrasena.Enabled = true;
        }

        private void CargarUsuariosEnDataGridView()
        {
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpia el DataGridView antes de cargar los datos.
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear(); // Limpia las columnas 

            // Evitar que se agregue automáticamente una fila en blanco al final
            dgvUsuarios.AllowUserToAddRows = false;

            List<UsuariosModel> listaUsuarios = usuarioController.ObtenerUsuarios();

            // Agrega las columnas al DataGridView
            dgvUsuarios.Columns.Add("Id", "ID");
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Usuario", "Usuario");
            dgvUsuarios.Columns.Add("Rol", "Rol");
            // Ocultar la columna "ID" y la columna de Pass para la contra
            dgvUsuarios.Columns["Id"].Visible = false;

            foreach (UsuariosModel usuario in listaUsuarios)
            {
                dgvUsuarios.Rows.Add(usuario.id, usuario.nombre, usuario.usuario, usuario.rol);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            //// Verificar si se ha seleccionado una fila en el DataGridView.
            //if (dgvUsuarios.SelectedRows.Count > 0)
            //{
            //    // Obtener el usuario seleccionado.
            //    DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

            //    // Obtener los datos del usuario desde las celdas del DataGridView.
            //    int usuarioId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            //    string usuario = filaSeleccionada.Cells["Nombre"].Value.ToString();
            //    string rol = filaSeleccionada.Cells["Rol"].Value.ToString();

            //    // Cargar los datos del usuario en los TextBox para edición.
            //    txtNombre.Text = usuario;
            //    txtUsuario.Text = usuarioId.ToString();
            //    //txtRol.Text = rol;

            //    // Habilitar los TextBox para edición.
            //    txtNombre.Enabled = true;
            //    txtUsuario.Enabled = true;
            //    //txtRol.Enabled = true;
            //}
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el usuario seleccionado.
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                // Obtener los datos del usuario desde las celdas del DataGridView.
                string usuario = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string NombreUsuario = filaSeleccionada.Cells["Usuario"].Value.ToString();
                string rol = filaSeleccionada.Cells["Rol"].Value.ToString();

                // Cargar los datos del usuario en los TextBox para edición.
                txtNombre.Text = usuario;
                txtUsuario.Text = NombreUsuario;
                switch (rol)
                {
                    case "Administrador":
                        cbbRol.SelectedIndex = 0;
                        break;
                    case "Doctor":
                        cbbRol.SelectedIndex = 1;
                        break;
                    case "Recepcionista":
                        cbbRol.SelectedIndex = 2;
                        break;
                    default:
                        cbbRol.SelectedIndex = 0;
                        break;
                }

                // Habilitar los TextBox para edición.
                txtNombre.Enabled = false;
                txtUsuario.Enabled = true;

                txtApellido.Enabled = false;
                txtDireccion.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefono.Enabled = false;
                txtContrasena.Enabled = false;
                cbbEspecialidad.Enabled = false;
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado.
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                // Crear un objeto usuarioModel con los datos modificados.
                UsuariosModel usuarioModificado = new UsuariosModel
                {
                    id = usuarioId,
                    nombre = txtNombre.Text,
                    usuario = txtUsuario.Text,
                    rol = cbbRol.SelectedIndex.ToString()
                };

                //Verificar si algún campo está vacío
                if (string.IsNullOrEmpty(usuarioModificado.nombre) || string.IsNullOrEmpty(usuarioModificado.usuario))
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener la operación si hay campos vacíos
                }

                // Llamar al método del controlador para actualizar el usuario.
                usuarioController.ActualizarUsuarios(usuarioModificado);

                Limpiar();

                // Mostrar un mensaje de "Cambios guardados exitosamente".
                MessageBox.Show("Cambios guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de usuarios en el DataGridView después de la edición.
                CargarUsuariosEnDataGridView();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado.
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                // Crear un objeto usuarioModel con los datos modificados.
                UsuariosModel usuarioEliminar = new UsuariosModel
                {
                    id = usuarioId,
                    rol = cbbRol.SelectedIndex.ToString()
                };

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el cliente.
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cbbRol.SelectedIndex == 1)
                {
                    MessageBox.Show("No puedes eliminar el doctor por que tiene citas asignadas", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método del controlador para eliminar el cliente.
                    usuarioController.EliminarUsuario(usuarioEliminar);

                    // Mostrar un mensaje de "Cliente eliminado exitosamente".
                    MessageBox.Show("Usuario eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de clientes en el DataGridView después de la eliminación.
                    CargarUsuariosEnDataGridView();
                }
            }
        }

        private void dgvClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el cliente seleccionado.
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                // Obtener los datos del usuario desde las celdas del DataGridView.
                int usuarioId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string usuario = filaSeleccionada.Cells["Usuario"].Value.ToString();
                string pass = filaSeleccionada.Cells["Pass"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string rol = filaSeleccionada.Cells["Rol"].Value.ToString();

                // Cargar los datos del cliente en los TextBox para edición.
                txtNombre.Text = usuario;
                txtUsuario.Text = pass;

                //txtRol.Text = rol;

                // Habilitar los TextBox para edición.
                txtNombre.Enabled = true;
                txtUsuario.Enabled = true;

                //txtRol.Enabled = true;
            }
        }
        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsuarios.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cbbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void TipoUser()
        {
            if (cbbRol.SelectedIndex == 1)
            {
                cbbEspecialidad.Visible = true;
                label9.Visible = true;
            }
            else
            {
                cbbEspecialidad.Visible = false;
                label9.Visible = false;
            }
        }

        private void cbbEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoUser();
        }
    }
}
