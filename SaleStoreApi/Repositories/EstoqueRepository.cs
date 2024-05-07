using System;
using System.Collections.Generic;
using SaleStoreApi.Models;

public class EstoqueRepository : IEstoqueRepository
{
    private Dictionary<int, (Product produto, int quantidade)> _estoque;

    public EstoqueRepository()
    {
        _estoque = new Dictionary<int, (Product produto, int quantidade)>();
    }

    public void AdicionarItemEstoque(Product produto, int quantidade)
    {
        if (_estoque.ContainsKey(produto.Id))
        {
            _estoque[produto.Id] = (produto, _estoque[produto.Id].quantidade + quantidade);
        }
        else
        {
            _estoque.Add(produto.Id, (produto, quantidade));
        }
        Console.WriteLine($"{quantidade} unidades do produto {produto.Name} adicionadas ao estoque.");
    }

    public void RetirarItemEstoque(int produtoId, int quantidade)
    {
        if (_estoque.ContainsKey(produtoId))
        {
            if (_estoque[produtoId].quantidade >= quantidade)
            {
                _estoque[produtoId] = (_estoque[produtoId].produto, _estoque[produtoId].quantidade - quantidade);
                Console.WriteLine($"{quantidade} unidades do produto ID {produtoId} retiradas do estoque.");
            }
            else
            {
                Console.WriteLine($"Quantidade insuficiente do produto ID {produtoId} em estoque.");
            }
        }
        else
        {
            Console.WriteLine($"Produto ID {produtoId} não encontrado em estoque.");
        }
    }

    public bool VerificarValidadeProduto(int produtoId)
    {
        // Implementação para verificar a validade do produto
        throw new NotImplementedException();
    }
}
