using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

public class VendaManager
{
    private readonly IVendaRepository _vendaRepository;

    public VendaManager(IVendaRepository vendaRepository)
    {
        _vendaRepository = vendaRepository;
    }

    public void RegistrarVenda(int clienteId, List<ItemVenda> itens)
    {
        var venda = new Venda
        {
            ClienteId = clienteId,
            Itens = itens
        };
        _vendaRepository.RegistrarVenda(venda);
    }

    public List<Venda> ConsultarVendasPorCliente(int clienteId)
    {
        return _vendaRepository.ConsultarVendasPorCliente(clienteId);
    }

    public List<Venda> ConsultarVendasDiarias()
    {
        return _vendaRepository.ConsultarVendasDiarias();
    }

    public List<Venda> ConsultarVendasMensais()
    {
        return _vendaRepository.ConsultarVendasMensais();
    }

    public List<Product> ProdutosMaisVendidos()
    {
        return _vendaRepository.ProdutosMaisVendidos();
    }
}
