using Microsoft.AspNetCore.Mvc;
using SaleStoreApi.Models;
using System;
using System.Collections.Generic;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    // GET: /api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAllProducts()
    {
        var products = _productRepository.GetAllProducts();
        return Ok(products);
    }

    // GET: /api/products/{id}
    [HttpGet("{id}")]
    public ActionResult<Product> GetProductById(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    // POST: /api/products
    [HttpPost]
    public ActionResult<Product> AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    // PUT: /api/products/{id}
    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id, Product product)
    {
        if (id != product.Id)
        {
            return BadRequest();
        }

        _productRepository.UpdateProduct(product);
        return NoContent();
    }

    // DELETE: /api/products/{id}
    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
        return NoContent();
    }
}
