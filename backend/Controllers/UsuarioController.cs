using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using backend.Models;


namespace backend.Controllers
{
    [Route("api/usuario/")]
     public class UsuarioController : Controller
     {

         [HttpGet]
         public IActionResult ListarUsuarios(){
             return Ok(new List<Usuario>{
               new Usuario(){
                nome = "charles",
                idade = 20
               },
               new Usuario(){
                  nome = "cleber",
                  idade = 23
               },

             });
         }

        [HttpGet("{idUsuario}")]
        public IActionResult ListarUsuarios(int IdUsuario){
             return Ok({'idUsuario': IdUsuario});
         }
         
     }
}