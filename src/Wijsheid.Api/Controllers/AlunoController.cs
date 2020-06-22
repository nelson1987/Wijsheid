using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WijSheid.Application.Models;
using Wijsheid.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System;

namespace Wijsheid.Api.Controllers
{
    /*
     * 200 - Sucesso
     * 400 - Requisição inválida
     * 401 - Não Autorizado(Autenticação)
     * 404 - Não encontrado
     * 500 - Erro de Aplicação
     */
    [EnableCors("DefaultPolicy")]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize("Bearer")]
    public class AlunoController : ControllerBase
    {
        // GET api/aluno
        [HttpGet]
        [Route("Consultar")]
        [ProducesResponseType(typeof(IEnumerable<AlunoListagemDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotImplemented)]
        public ActionResult<IEnumerable<AlunoListagemDto>> Get([FromServices] IAlunoApplicationService application)
        {
            try
            {
                var fundos = application.Listar();
                return Ok(application.Listar());
            }
            catch (Exception)
            {
                //TODO: Logar a exception
                return BadRequest("Erro ao listar Fundos.");
            }
        }

        // POST api/aluno
        [HttpPost]
        [Route("Cadastrar")]
        [ProducesResponseType(200)] //OK
        [ProducesResponseType(400)] //Requisição inválida
        [ProducesResponseType(500)] //Erro interno de servidor
        public ActionResult Post([FromServices] IAlunoApplicationService application,
                        [FromBody]AlunoCriacaoDto aluno)
        {
            //if (ModelState.IsValid)
            //    application.Criar(aluno);
            if (ModelState.IsValid)
            {
                try
                {
                    application.Criar(aluno);
                    return Ok($"Aluno {aluno.Nome}, cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    return StatusCode(500, e.Message);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
