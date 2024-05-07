using Microsoft.AspNetCore.Mvc;
using SaleStoreApi.Models;

[ApiController]
[Route("api/estoque")]
public class EstoqueController : ControllerBase
{
    private readonly EstoqueManager _estoqueManager;

    public EstoqueController(EstoqueManager estoqueManager)
    {
        _estoqueManager = estoqueManager;
    }

    [HttpPost("adicionar")]
    public ActionResult AdicionarItemEstoque(Product produto, int quantidade)
    {
        _estoqueManager.AdicionarItemEstoque(produto, quantidade);
        return Ok($"Adicionado {quantidade} unidades do produto {produto.Name} ao estoque.");
    }

    [HttpPost("retirar")]
    public ActionResult RetirarItemEstoque(int produtoId, int quantidade)
    {
        _estoqueManager.RetirarItemEstoque(produtoId, quantidade);
        return Ok($"Retirado {quantidade} unidades do produto ID {produtoId} do estoque.");
    }

    [HttpGet("verificar-validade")]
    public ActionResult VerificarValidadeProduto(int produtoId)
    {
        var valido = _estoqueManager.VerificarValidadeProduto(produtoId);
        if (valido)
        {
            return Ok("Produto válido.");
        }
        else
        {
            return BadRequest("Produto expirado.");
        }
    }
}
