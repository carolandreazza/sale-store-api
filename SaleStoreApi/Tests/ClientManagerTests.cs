using NUnit.Framework;
using SaleStoreApi.Models;
using SaleStoreApi.Repositories;
using SaleStoreApi.Services;
using System;

//criado mas contém erros
namespace SaleStoreApi.Tests
{   
    /*
    [TestFixture]
    public class ClientManagerTests
    {
        private ClientManager _clientManager;

        [SetUp]
        public void Setup()
        {
            var clientRepository = new ClientRepository();
            _clientManager = new ClientManager(clientRepository);
        }

        [Test]
        public void RegisterNewClient_ShouldRegisterClient()
        {
            // Arrange
            var newClient = new Client("New Client", "New Address", "New Phone");

            // Act
            _clientManager.RegisterNewClient(newClient);

            // Assert
            var registeredClient = _clientManager.GetClientByName("New Client");
            Assert.NotNull(registeredClient);
            Assert.AreEqual("New Client", registeredClient.Name);
            Assert.AreEqual("New Address", registeredClient.Address);
            Assert.AreEqual("New Phone", registeredClient.Phone);
        }

        [Test]
        public void GetAllClients_ShouldReturnAllClients()
        {
            // Arrange
            var client1 = new Client("Client 1", "Address 1", "Phone 1");
            var client2 = new Client("Client 2", "Address 2", "Phone 2");
            var client3 = new Client("Client 3", "Address 3", "Phone 3");

            _clientManager.RegisterNewClient(client1);
            _clientManager.RegisterNewClient(client2);
            _clientManager.RegisterNewClient(client3);

            // Act
            var allClients = _clientManager.GetAllClients();

            // Assert
            Assert.AreEqual(3, allClients.Count);
            Assert.Contains(client1, allClients);
            Assert.Contains(client2, allClients);
            Assert.Contains(client3, allClients);
        }

        [Test]
        public void UpdateClient_ShouldUpdateClient()
        {
            // Arrange
            var existingClient = new Client("Existing Client", "Existing Address", "Existing Phone");
            _clientManager.RegisterNewClient(existingClient);

            // Act
            _clientManager.UpdateClient("Existing Client", "Updated Address", "Updated Phone");

            // Assert
            var updatedClient = _clientManager.GetClientByName("Existing Client");
            Assert.AreEqual("Updated Address", updatedClient.Address);
            Assert.AreEqual("Updated Phone", updatedClient.Phone);
        }

        [Test]
        public void DeleteClient_ShouldDeleteClient()
        {
            // Arrange
            var existingClient = new Client("Client to Delete", "Address", "Phone");
            _clientManager.RegisterNewClient(existingClient);

            // Act
            _clientManager.DeleteClient("Client to Delete");

            // Assert
            var deletedClient = _clientManager.GetClientByName("Client to Delete");
            Assert.IsNull(deletedClient);
        }
    }
    */
}
