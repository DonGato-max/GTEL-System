using System;
using System.Windows.Forms;
using GTEL_System.Negocio;

namespace GTEL_System
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioNegocio usuarioNegocio =
            new UsuarioNegocio();

        public FrmLogin()
        {
            InitializeComponent();

            btnIniciarSesion.Click -= btnIniciarSesion_Click;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show(
                    "Ingrese su nombre de usuario.",
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingrese su contraseña.",
                    "GTEL SYSTEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();
                return;
            }

            try
            {
                int codigo;
                string mensaje;

                var usuario = usuarioNegocio.ValidarAcceso(
                    nombreUsuario,
                    contrasena,
                    out codigo,
                    out mensaje);

                if (codigo == 1 && usuario != null)
                {
                    MessageBox.Show(
                        mensaje,
                        "GTEL SYSTEM",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Hide();

                    using (FrmMenuPrincipal menu = new FrmMenuPrincipal(usuario))
                    {
                        menu.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        mensaje,
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo iniciar sesión.\n\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
