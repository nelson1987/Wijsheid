using System.Collections.Generic;
using Wijsheid.Application.Contracts.Interfaces;
using Wijsheid.Application.Mappers;
using Wijsheid.Domain;
using WijSheid.Application.Models;

namespace Wijsheid.Application.Services
{
    public class AlunoApplicationService : IAlunoApplicationService
    {
        public List<AlunoListagemDto> Listar()
        {
            List<Aluno> c1 = new List<Aluno>();
            List<AlunoListagemDto> c2 = ObjectMapper.Mapper.Map<List<AlunoListagemDto>>(c1);
            return c2;
        }

        public void Criar(AlunoCriacaoDto entidade)
        {
            Aluno aluno = ObjectMapper.Mapper.Map<Aluno>(entidade);
            if (!aluno.IsValid())
                throw new System.Exception();

        }
    }
}
