using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

public class ProductManager
{
    private readonly IProductRepository _productRepository;

    public ProductManager(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void RegisterNewProduct(int id, string name, decimal price, string description, string supplier, DateTime expiryDate)
    {
        var product = new Product(id, name, price, description, supplier, expiryDate);
        _productRepository.AddProduct(product);
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }

    public List<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }

    public void UpdateProduct(int id, string name, decimal price, string description, string supplier, DateTime expiryDate)
    {
        var existingProduct = _productRepository.GetProductById(id);
        if (existingProduct != null)
        {
            existingProduct.Name = name;
            existingProduct.Price = price;
            existingProduct.Description = description;
            existingProduct.Supplier = supplier;
            existingProduct.ExpiryDate = expiryDate;
            _productRepository.UpdateProduct(existingProduct);
        }
        else
        {
            Console.WriteLine("Product not found with ID: " + id);
        }
    }

    public void DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
    }
}
