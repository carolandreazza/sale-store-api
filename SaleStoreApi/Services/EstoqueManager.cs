using SaleStoreApi.Models;
using System;

public class EstoqueManager
{
    private readonly IEstoqueRepository _estoqueRepository;

    public EstoqueManager(IEstoqueRepository estoqueRepository)
    {
        _estoqueRepository = estoqueRepository;
    }

    public void AdicionarItemEstoque(Product produto, int quantidade)
    {
        _estoqueRepository.AdicionarItemEstoque(produto, quantidade);
    }

    public void RetirarItemEstoque(int produtoId, int quantidade)
    {
        _estoqueRepository.RetirarItemEstoque(produtoId, quantidade);
    }

    public bool VerificarValidadeProduto(int produtoId)
    {
        return _estoqueRepository.VerificarValidadeProduto(produtoId);
    }
}
