using LaraVi.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaraVi.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> Add(Product product);
        Task Delete(int id);
        Task Edit(Product product);
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetProduct();
    }
}
