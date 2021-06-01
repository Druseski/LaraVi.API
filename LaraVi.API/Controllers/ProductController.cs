using LaraVi.API.Entities;
using LaraVi.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaraVi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet("GetProducts")]
        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _productService.GetProduct();
        }

        // GET api/<ProductController>/5
        [HttpGet("GetProductsById")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return await _productService.GetProductById(id);
        }

        // POST api/<ProductController>
        [HttpPost("PostProducts")]
        public async Task<ActionResult<Product>> Post([FromBody] Product product)
        {
            var newProduct = await _productService.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);
        }

        // PUT api/<ProductController>/5
        [HttpPut("PutProducts")]
        public async Task<ActionResult> PutProduct(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            await _productService.Edit(product);
            return NoContent();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("DeleteProducts")]
        public async Task<ActionResult> Delete(int id)
        {
            var productToDelete = await _productService.GetProductById(id);
            if (productToDelete == null)
                return NotFound();
            await _productService.Delete(productToDelete.Id);
            return NoContent();
        }
    }
}
