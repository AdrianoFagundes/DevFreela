using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        public UsersController(TesteInjecaoDependencia testeInjecao)
        {

        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Return Users");
        }
    }
}
