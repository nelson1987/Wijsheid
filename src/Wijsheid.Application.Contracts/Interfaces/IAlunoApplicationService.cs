using System.Collections.Generic;
using WijSheid.Application.Models;

namespace Wijsheid.Application.Contracts.Interfaces
{
    public interface IAlunoApplicationService
    {
        List<AlunoListagemDto> Listar();
        void Criar(AlunoCriacaoDto entidade);
    }
}
