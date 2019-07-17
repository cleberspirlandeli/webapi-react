using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using backend.Models;


namespace backend.Controllers
{
     public class UsuarioController : Controller
     {

         [HttpGet("v1/getUsuarios")]
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

     }
}