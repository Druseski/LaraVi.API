using LaraVi.API.Entities;
using LaraVi.API.Repositories.Interfaces;
using LaraVi.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaraVi.API.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Add(Product product)
        {
          await  _productRepository.Add(product);
            return product;
        }

        public async Task Delete(int id)
        {
           await _productRepository.Delete(id);
        }

        public async Task Edit(Product product)
        {
           await  _productRepository.Edit(product);
        }

        public async Task<Product> GetProductById(int id)
        {
            var result = await _productRepository.GetProductById(id);
            return result;
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            var result = await _productRepository.GetProduct();
            return result;
        }
    }
}
