using System.Collections.Generic;

namespace Wijsheid.Repository.Contracts.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IList<T> Get();
    }
}
