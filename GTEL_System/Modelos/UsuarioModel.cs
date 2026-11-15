
namespace GTEL_System.Modelos
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int IntentosFallidos { get; set; }
        public bool Bloqueado { get; set; }
    }
}

