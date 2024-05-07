using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

public interface IProductRepository
{
    void AddProduct(Product product);
    Product GetProductById(int id);
    Product GetProductByName(string name);
    List<Product> GetAllProducts();
    void UpdateProduct(Product product);
    void DeleteProduct(int id);
}
