using System;
using System.Collections.Generic;

public class Venda
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime Data { get; set; }
    public List<ItemVenda> Itens { get; set; }
}

public class ItemVenda
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}
