using LaraVi.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaraVi.API.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> Add(Category category);
        Task Delete(int id);
        Task Edit(Category category);
        Task<Category> GetCategoryById(int id);
        Task<IEnumerable<Category>> GetCategory();
    }
}
