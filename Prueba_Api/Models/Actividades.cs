using System;
namespace Prueba_Api.Models
{
    public class Actividades : Usuarios
    {
        public int? IdActividad { get; set; }
        public string Actividad { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
