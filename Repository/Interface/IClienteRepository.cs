using RepositoryPathern.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPathern.Repository.Interface
{
    public interface IClienteRepository : IBaseRepository
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
    }
}
