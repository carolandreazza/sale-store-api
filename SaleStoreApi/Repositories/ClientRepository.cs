
using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

namespace SaleStoreApi.Repositories
{

    public class ClientRepository : IClientRepository
    {
        private List<Client> _clients;
        private int _nextId = 1;

        public ClientRepository()
        {
            _clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            client.Id = _nextId++;
            _clients.Add(client);
            Console.WriteLine("Client added to system: " + client.Name);
        }

        public Client GetClientById(int id)
        {
            return _clients.Find(c => c.Id == id);
        }

        public List<Client> GetAllClients()
        {
            return _clients;
        }

        public void UpdateClient(Client client)
        {
            var existingClient = _clients.FindIndex(c => c.Id == client.Id);
            if (existingClient != -1)
            {
                _clients[existingClient] = client;
                Console.WriteLine("Client updated: " + client.Name);
            }
            else
            {
                Console.WriteLine("Client not found with ID: " + client.Id);
            }
        }

        public void DeleteClient(int id)
        {
            var clientToRemove = _clients.Find(c => c.Id == id);
            if (clientToRemove != null)
            {
                _clients.Remove(clientToRemove);
                Console.WriteLine("Client deleted with ID: " + id);
            }
            else
            {
                Console.WriteLine("Client not found with ID: " + id);
            }
        }
    }

}
