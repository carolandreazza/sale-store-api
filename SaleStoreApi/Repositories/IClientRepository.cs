using SaleStoreApi.Models;

namespace SaleStoreApi.Repositories
{
    public interface IClientRepository
    {
        void AddClient(Client client);
        Client GetClientById(int id);
        List<Client> GetAllClients();
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}
