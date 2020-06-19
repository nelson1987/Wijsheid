using System.Collections.Generic;
using Wijsheid.Application.Contracts.Interfaces;
using Wijsheid.Application.Mappers;
using Wijsheid.Domain;
using Wijsheid.Service.Contracts.Interfaces;
using WijSheid.Application.Models;

namespace Wijsheid.Application.Services
{
    public class AlunoApplicationService : IAlunoApplicationService
    {
        public AlunoApplicationService(IAlunoService servico)
        {
            _servico = servico;
        }

        private IAlunoService _servico { get; set; }
        
        public List<AlunoListagemDto> Listar()
        {
            List<AlunoListagemDto> c2 = ObjectMapper.Mapper.Map<List<AlunoListagemDto>>(_servico.Get());
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
