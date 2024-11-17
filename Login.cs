using MySql.Data.MySqlClient;
using TuSaludEnTusHuesos.Controlador;
using TuSaludEnTusHuesos.Modelo;
using TuSaludEnTusHuesos.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TuSaludEnTusHuesos
{
    public partial class Login : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private MySqlConnection conexion; // Asegúrate de que esta variable esté configurada con tu conexión a la base de datos.
        private LoginController loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
            lblEstadoConexion.Visible = false;
            cbbRol.SelectedIndex = 0;
        }

        private void lblEstadoConexion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            try
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    lblEstadoConexion.Text = "Conexión exitosa";
                }
                else
                {
                    lblEstadoConexion.Text = "Error al conectar a la base de datos";
                }
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = "Error al conectar a la base de datos: " + ex.Message;
            }
        }

        private void btnCrudClientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de clientes
            FormularioExpediente1 formClientes = new FormularioExpediente1();

            // Mostrar el formulario de clientes (modal) - Bloquea Form1 hasta que se cierre el formulario de clientes
            formClientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de proveedores
            FormularioReportes formProveedores = new FormularioReportes();

            // Mostrar el formulario de proveedores
            formProveedores.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
            int rol = cbbRol.SelectedIndex +1;
            string roltext = string.Empty;
            switch (rol)
            {
                case 1:
                    roltext = "Administrador";
                    break;
                case 2:
                    roltext = "Doctor";
                    break;
                case 3:
                    roltext = "Recepcionista";
                    break;
                default:
                    roltext = "NoIndetificado";
                    break;
            }
            if (loginController.AutenticarUsuario(usuario, pass, rol))
            {
                Dashboard frmMenu = new Dashboard(usuario, roltext, txtUsuario.Text);
                frmMenu.ShowDialog();
                Limpiar();

            }
            else
            {
                MessageBox.Show("Usuario, contraseña o rol incorrectos. Por favor, inténtelo de nuevo.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Limpiar();
            }
        }
        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtPass.Text = string.Empty;
            cbbRol.SelectedIndex = 0;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            // Si el PasswordChar actual es '*', cambia a '\0'(sin censura).// De lo contrario, cambia de vuelta a '*' para ocultar la contraseña.
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0'; // Mostrar la contraseña sin censura
            }
            else
            {
                txtPass.PasswordChar = '*'; // Ocultar la contraseña con asteriscos
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}