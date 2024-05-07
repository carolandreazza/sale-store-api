using Microsoft.AspNetCore.Mvc;
using SaleStoreApi.Models;
using System.Collections.Generic;

[ApiController]
[Route("api/vendas")]
public class VendasController : ControllerBase
{
    private readonly VendaManager _vendaManager;

    public VendasController(VendaManager vendaManager)
    {
        _vendaManager = vendaManager;
    }

    [HttpPost]
    public ActionResult RegistrarVenda(int clienteId, List<ItemVenda> itens)
    {
        _vendaManager.RegistrarVenda(clienteId, itens);
        return Ok("Venda registrada com sucesso.");
    }

    [HttpGet("{clienteId}")]
    public ActionResult<List<Venda>> ConsultarVendasPorCliente(int clienteId)
    {
        var vendas = _vendaManager.ConsultarVendasPorCliente(clienteId);
        return Ok(vendas);
    }

    [HttpGet("diarias")]
    public ActionResult<List<Venda>> ConsultarVendasDiarias()
    {
        var vendas = _vendaManager.ConsultarVendasDiarias();
        return Ok(vendas);
    }

    [HttpGet("mensais")]
    public ActionResult<List<Venda>> ConsultarVendasMensais()
    {
        var vendas = _vendaManager.ConsultarVendasMensais();
        return Ok(vendas);
    }

    [HttpGet("produtos-mais-vendidos")]
    public ActionResult<List<Product>> ProdutosMaisVendidos()
    {
        var produtos = _vendaManager.ProdutosMaisVendidos();
        return Ok(produtos);
    }
}
