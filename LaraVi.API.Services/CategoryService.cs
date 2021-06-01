using LaraVi.API.Entities;
using LaraVi.API.Repositories.Interfaces;
using LaraVi.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaraVi.API.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> Add(Category category)
        {
           await _categoryRepository.Add(category);
            return category;
        }

        public  async Task Delete(int id)
        {
           await _categoryRepository.Delete(id);
        }

        public async Task Edit(Category category)
        {
          await  _categoryRepository.Edit(category);
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var result = await _categoryRepository.GetCategoryById(id);
            return result;
        }

        public async Task<IEnumerable<Category>> GetCategory()
        {
            var result = await _categoryRepository.GetCategory();
            return result;
        }
    }
}
