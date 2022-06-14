using Microsoft.EntityFrameworkCore;
using RepositoryPathern.Models;

namespace RepositoryPathern.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
