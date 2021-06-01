using LaraVi.API.Data;
using LaraVi.API.Entities;
using LaraVi.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaraVi.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Product> Add(Product product)
        {
            _dataContext.Products.Add(product);
            await _dataContext.SaveChangesAsync();
            return product;
        }

        public async Task Delete(int id)
        {
            var product = await _dataContext.Products.FindAsync(id);
            _dataContext.Products.Remove(product);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Edit(Product product)
        {
            _dataContext.Entry(product).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _dataContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dataContext.Products.FindAsync(id);
        }
    }
}
