using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly AppOption _option;
        private readonly TesteInjecaoDependencia _testeInjecao;
        public ProjectsController(IOptions<AppOption> option, TesteInjecaoDependencia testeInjecao)
        {
            _option = option.Value;
            testeInjecao.Mensagem = "Alterado no /projects";
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teste");
        }
    }
}
