using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Wijsheid.Application.Contracts.Interfaces;
using WijSheid.Application.Models;

namespace Wijsheid.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        // GET api/aluno
        [HttpGet]
        public ActionResult<IEnumerable<AlunoListagemDto>> Get([FromServices] IAlunoApplicationService application)
        {
            return application.Listar();
        }

        // POST api/aluno
        [HttpPost]
        public void Post([FromServices] IAlunoApplicationService application,
                        [FromBody]AlunoCriacaoDto aluno)
        {
            if (ModelState.IsValid)
                application.Criar(aluno);
        }
    }
}
