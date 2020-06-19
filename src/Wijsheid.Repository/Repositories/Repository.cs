using System.Collections.Generic;
using Wijsheid.Domain;
using Wijsheid.Repository.Contracts.Interfaces;

namespace Wijsheid.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public IList<T> Get()
        {
            return new List<T>();
        }
    }
}
