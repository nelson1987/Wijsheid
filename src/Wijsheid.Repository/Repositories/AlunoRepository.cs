using System.Collections.Generic;
using Wijsheid.Domain;
using Wijsheid.Repository.Contracts.Interfaces;

namespace Wijsheid.Repository.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public IList<Aluno> GetAll()
        {

            //IList<T> Get();
            throw new System.NotImplementedException();
        }
    }
}
