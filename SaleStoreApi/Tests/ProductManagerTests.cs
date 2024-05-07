using NUnit.Framework;
using SaleStoreApi.Models;
using SaleStoreApi.Repositories;
using SaleStoreApi.Services;
using System;

//criado mas contém erros
namespace SaleStoreApi.Tests
{      
    /*
    [TestFixture]
    public class ProductManagerTests
    {
        private ProductManager _productManager;

        [SetUp]
        public void Setup()
        {
            var productRepository = new ProductRepository();
            _productManager = new ProductManager(productRepository);
        }

        [Test]
        public void RegisterNewProduct_ShouldRegisterProduct()
        {
            // Arrange
            var newProduct = new Product("New Product", 20.99m, "New Description", "New Supplier", DateTime.Now.AddDays(60));

            // Act
            _productManager.RegisterNewProduct(newProduct);

            // Assert
            var registeredProduct = _productManager.GetProductByName("New Product");
            Assert.NotNull(registeredProduct);
            Assert.AreEqual("New Product", registeredProduct.Name);
            Assert.AreEqual(20.99m, registeredProduct.Price);
            Assert.AreEqual("New Description", registeredProduct.Description);
            Assert.AreEqual("New Supplier", registeredProduct.Supplier);
            Assert.AreEqual(DateTime.Now.AddDays(60).Date, registeredProduct.ExpiryDate.Date);
        }

        [Test]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var product1 = new Product("Product 1", 15.99m, "Description 1", "Supplier 1", DateTime.Now.AddDays(30));
            var product2 = new Product("Product 2", 25.99m, "Description 2", "Supplier 2", DateTime.Now.AddDays(60));
            var product3 = new Product("Product 3", 35.99m, "Description 3", "Supplier 3", DateTime.Now.AddDays(90));

            _productManager.RegisterNewProduct(product1);
            _productManager.RegisterNewProduct(product2);
            _productManager.RegisterNewProduct(product3);

            // Act
            var allProducts = _productManager.GetAllProducts();

            // Assert
            Assert.AreEqual(3, allProducts.Count);
            Assert.Contains(product1, allProducts);
            Assert.Contains(product2, allProducts);
            Assert.Contains(product3, allProducts);
        }

        [Test]
        public void UpdateProduct_ShouldUpdateProduct()
        {
            // Arrange
            var existingProduct = new Product("Existing Product", 10.99m, "Existing Description", "Existing Supplier", DateTime.Now.AddDays(30));
            _productManager.RegisterNewProduct(existingProduct);

            // Act
            _productManager.UpdateProduct("Existing Product", 15.99m, "Updated Description", "Updated Supplier", DateTime.Now.AddDays(60));

            // Assert
            var updatedProduct = _productManager.GetProductByName("Existing Product");
            Assert.AreEqual(15.99m, updatedProduct.Price);
            Assert.AreEqual("Updated Description", updatedProduct.Description);
            Assert.AreEqual("Updated Supplier", updatedProduct.Supplier);
            Assert.AreEqual(DateTime.Now.AddDays(60).Date, updatedProduct.ExpiryDate.Date);
        }

        [Test]
        public void DeleteProduct_ShouldDeleteProduct()
        {
            // Arrange
            var existingProduct = new Product("Product to Delete", 10.99m, "Description", "Supplier", DateTime.Now.AddDays(30));
            _productManager.RegisterNewProduct(existingProduct);

            // Act
            _productManager.DeleteProduct("Product to Delete");

            // Assert
            var deletedProduct = _productManager.GetProductByName("Product to Delete");
            Assert.IsNull(deletedProduct);
        }
    }
    */
}
