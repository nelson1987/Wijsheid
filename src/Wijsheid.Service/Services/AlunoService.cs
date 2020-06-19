using System.Collections.Generic;
using System.Linq;
using Wijsheid.Domain;
using Wijsheid.Repository.Contracts.Interfaces;
using Wijsheid.Service.Contracts.Interfaces;

namespace Wijsheid.Service.Services
{
    public class AlunoService : IAlunoService
    {
        public AlunoService(IAlunoRepository repository)
        {
            _repository = repository;
        }

        private IAlunoRepository _repository { get; set; }
        public List<Aluno> Get()
        {
           return _repository.GetAll().ToList();
        }
        public void Insert(Aluno entitie)
        {

        }
    }
}
