using Microsoft.AspNetCore.Mvc;
using SaleStoreApi.Models;
using SaleStoreApi.Repositories;
using System.Collections.Generic;

[ApiController]
[Route("api/clients")]
public class ClientsController : ControllerBase
{
    private readonly IClientRepository _clientRepository;

    public ClientsController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Client>> GetAllClients()
    {
        var clients = _clientRepository.GetAllClients();
        return Ok(clients);
    }

    [HttpGet("{id}")]
    public ActionResult<Client> GetClientById(int id)
    {
        var client = _clientRepository.GetClientById(id);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(client);
    }

    [HttpPost]
    public ActionResult<Client> AddClient(Client client)
    {
        _clientRepository.AddClient(client);
        return CreatedAtAction(nameof(GetClientById), new { id = client.Id }, client);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateClient(int id, Client client)
    {
        if (id != client.Id)
        {
            return BadRequest();
        }

        _clientRepository.UpdateClient(client);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteClient(int id)
    {
        _clientRepository.DeleteClient(id);
        return NoContent();
    }
}
