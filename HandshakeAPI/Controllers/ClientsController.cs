using HandshakeAPI.Entities;
using HandshakeAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HandshakeAPI.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientsController : ControllerBase
    {
        private readonly InMemClientsRepository repository;

        public ClientsController()
        {
            repository = new InMemClientsRepository();
        }

        [HttpGet]
        public IEnumerable<Client> GetClients()
        {
            var clients = repository.GetClients();
            return clients;
        }

        [HttpGet("{id}")]
        public ActionResult<Client> GetClient(long id)
        {
            var client = repository.GetClient(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }
    }
}
