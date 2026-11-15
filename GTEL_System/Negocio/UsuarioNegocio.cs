
using GTEL_System.Datos;
using GTEL_System.Modelos;

namespace GTEL_System.Negocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioData usuarioData = new UsuarioData();

        public UsuarioModel ValidarAcceso(
            string nombreUsuario,
            string contrasena,
            out int codigo,
            out string mensaje)
        {
            codigo = 0;
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                mensaje = "Ingrese el nombre de usuario.";
                return null;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "Ingrese la contraseña.";
                return null;
            }

            return usuarioData.ValidarAcceso(
                nombreUsuario.Trim(),
                contrasena,
                out codigo,
                out mensaje
            );
        }
    }
}

