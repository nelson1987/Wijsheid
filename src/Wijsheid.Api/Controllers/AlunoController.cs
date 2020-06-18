using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WijSheid.Application.Models;
using Wijsheid.Application.Contracts.Interfaces;
namespace Wijsheid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        // GET api/aluno
        [HttpGet]
        public ActionResult<IEnumerable<AlunoListagemDto>> Get()
        {
            return new AlunoListagemDto[] { };
        }

        // POST api/aluno
        [HttpPost]
        public void Post([FromServices] IAlunoApplicationService application,
                        [FromBody]AlunoCriacaoDto aluno)
        {

        }
    }
}
