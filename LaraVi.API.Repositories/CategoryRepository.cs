using LaraVi.API.Data;
using LaraVi.API.Entities;
using LaraVi.API.Repositories.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaraVi.API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;
         
        public CategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Category> Add(Category category)
        {
            _dataContext.Categories.Add(category);
            await _dataContext.SaveChangesAsync();
            return category;
        }

        public async Task Delete(int id)
        {
            var category = await _dataContext.Categories.FindAsync(id);
            _dataContext.Categories.Remove(category);
            await _dataContext.SaveChangesAsync();

        }

        public async Task Edit(Category category)
        {
            _dataContext.Entry(category).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _dataContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _dataContext.Categories.FindAsync(id);
        }
    }
}
