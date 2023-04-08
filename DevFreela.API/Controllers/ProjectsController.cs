using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    public class ProjectsController : ControllerBase
    {
        [Route ("api/projects")]
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
