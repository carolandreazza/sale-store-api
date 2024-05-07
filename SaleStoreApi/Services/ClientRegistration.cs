
using SaleStoreApi.Models;
using SaleStoreApi.Repositories;
using System;
using System.Collections.Generic;

namespace SaleStoreApi.Services
{

    public class ClientRegistration
    {
        private readonly IClientRepository _clientRepository;

        public ClientRegistration(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void RegisterNewClient(string name, string address, string phone)
        {
            var client = new Client
            {
                Name = name,
                Address = address,
                Phone = phone
            };
            _clientRepository.AddClient(client);
        }
    }

}
