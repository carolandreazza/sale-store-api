using SaleStoreApi.Models;
using System.Collections.Generic;

public interface IVendaRepository
{
    void RegistrarVenda(Venda venda);
    List<Venda> ConsultarVendasPorCliente(int clienteId);
    List<Venda> ConsultarVendasDiarias();
    List<Venda> ConsultarVendasMensais();
    List<Product> ProdutosMaisVendidos();
}
