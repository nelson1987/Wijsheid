using System.Collections.Generic;
using Wijsheid.Domain;

namespace Wijsheid.Repository.Contracts.Interfaces
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        IList<Aluno> GetAll();
    }
}
