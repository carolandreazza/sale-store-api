using SaleStoreApi.Models;
using System.Collections.Generic;

public interface IEstoqueRepository
{
    void AdicionarItemEstoque(Product produto, int quantidade);
    void RetirarItemEstoque(int produtoId, int quantidade);
    bool VerificarValidadeProduto(int produtoId);
}
