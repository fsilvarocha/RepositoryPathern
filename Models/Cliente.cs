using System;

namespace RepositoryPathern.Models
{
    public class Cliente : ModelBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
