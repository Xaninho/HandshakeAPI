using HandshakeAPI.Entities;

namespace HandshakeAPI.Repositories
{
    public class InMemClientsRepository
    {
        private readonly List<Client> clients = new()
        {
            new Client
            {
                Id = 1,
                Name = "John Cena",
                PhoneNumber = "+351 123 456 789",
                CreatedDate = DateTimeOffset.Now
            },
            new Client
            {
                Id = 2,
                Name = "Triple H",
                PhoneNumber = "+351 987 654 321",
                CreatedDate = DateTimeOffset.Now
            },
            new Client
            {
                Id = 3,
                Name = "Eddie Guerrero",
                PhoneNumber = "+351 123 321 123",
                CreatedDate = DateTimeOffset.Now
            },
        };

        public IEnumerable<Client> GetClients()
        {
            return clients;
        }

        public Client GetClient(long id)
        {
            return clients.SingleOrDefault(client => client.Id == id);
        }
    }
}
