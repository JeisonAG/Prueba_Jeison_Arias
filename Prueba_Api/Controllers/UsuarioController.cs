using Microsoft.AspNetCore.Mvc;
using Prueba_Api.Models;
using System.Collections.Generic;
using System.Web.Http;
using Prueba_Api.Data;

namespace Prueba_Api.Controllers
{
    
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public List<Usuarios> GetUsuarios()
        {
            return UsuarioDataAccess.GetUsuarios();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public bool InsertarUsuario([System.Web.Http.FromBody] Usuarios Usuario)
        {
            return UsuarioDataAccess.InsertarUsuario(Usuario);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public bool UpdateUsuario([System.Web.Http.FromBody] Usuarios Usuario)
        {
            return UsuarioDataAccess.UpdateUsuario(Usuario);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public List<Actividades> GetActividades()
        {
            return UsuarioDataAccess.GetActividades();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public bool EliminarUsuario(int id)
        {
            return UsuarioDataAccess.EliminarUsuario(id);
        }
    }
}
