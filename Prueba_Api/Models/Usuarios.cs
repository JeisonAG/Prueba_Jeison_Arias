using System;

namespace Prueba_Api.Models
{
    public class Usuarios
    {
        public int? IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public string PaisResidencia { get; set; }
        public bool Contacto { get; set; }
    }
}
