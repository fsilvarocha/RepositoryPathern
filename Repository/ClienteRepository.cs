using Microsoft.EntityFrameworkCore;
using RepositoryPathern.Data;
using RepositoryPathern.Models;
using RepositoryPathern.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPathern.Repository
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes
                .AsNoTracking()
                .ToList();
        }

        public Cliente GetById(int id)
        {
            return _context.Clientes.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
