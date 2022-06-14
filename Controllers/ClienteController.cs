using Microsoft.AspNetCore.Mvc;
using RepositoryPathern.Models;
using RepositoryPathern.Repository.Interface;
using System.Linq;

namespace RepositoryPathern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;

        public ClienteController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cliente = _repository.GetAll();
            return cliente.Any()
                ? Ok(cliente)
                : NotFound("Cliente não encontrado!");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cliente = _repository.GetById(id);
            return cliente != null
                ? Ok(cliente)
                : NotFound("Cliente não encontrado!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            _repository.Add(cliente);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            _repository.Update(cliente);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Cliente cliente)
        {
            _repository.Delete(cliente);
            return Ok();
        }
    }
}
