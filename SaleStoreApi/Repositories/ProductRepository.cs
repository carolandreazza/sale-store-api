using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

public class ProductRepository : IProductRepository
{
    private List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        Console.WriteLine("Product added to system: " + product.Name);
    }

    public Product GetProductById(int id)
    {
        return _products.Find(match: p => p.Id == id);
    }

    public Product GetProductByName(string name)
    {
        return _products.Find(match: p => p.Name == name);
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }

    public void UpdateProduct(Product product)
    {
        var existingProduct = _products.FindIndex(p => p.Id == product.Id);
        if (existingProduct != -1)
        {
            _products[existingProduct] = product;
            Console.WriteLine("Product updated: " + product.Name);
        }
        else
        {
            Console.WriteLine("Product not found with ID: " + product.Id);
        }
    }

    public void DeleteProduct(int id)
    {
        var productToRemove = _products.Find(match: p => p.Id == id);
        if (productToRemove != null)
        {
            _products.Remove(productToRemove);
            Console.WriteLine("Product deleted with ID: " + id);
        }
        else
        {
            Console.WriteLine("Product not found with ID: " + id);
        }
    }

    public void DeleteProduct(string name)
    {
        throw new NotImplementedException();
    }
}
