using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

public class VendaRepository : IVendaRepository
{
    private List<Venda> _vendas;
    private int _nextId = 1;

    public VendaRepository()
    {
        _vendas = new List<Venda>();
    }

    public void RegistrarVenda(Venda venda)
    {
        venda.Id = _nextId++;
        venda.Data = DateTime.Now;
        _vendas.Add(venda);
        Console.WriteLine("Venda registrada com sucesso.");
    }

    public List<Venda> ConsultarVendasPorCliente(int clienteId)
    {
        return _vendas.FindAll(v => v.ClienteId == clienteId);
    }

    public List<Venda> ConsultarVendasDiarias()
    {
        // Implementação para consultar vendas diárias
        throw new NotImplementedException();
    }

    public List<Venda> ConsultarVendasMensais()
    {
        // Implementação para consultar vendas mensais
        throw new NotImplementedException();
    }

    public List<Product> ProdutosMaisVendidos()
    {
        // Implementação para consultar os produtos mais vendidos
        throw new NotImplementedException();
    }
}
