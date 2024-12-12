using Microsoft.EntityFrameworkCore;
using MovieApp.DataAccess.Abstracts;
using MovieApp.DataAccess.Context;
using MovieApp.Entity.Models;

namespace MovieApp.DataAccess.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var ctg = await _context.Categories.ToListAsync();
            return ctg;
        }

        public async Task<Category> GetByIdCategoryAsync(int id)
        {
            var ctg = await _context.Categories.FindAsync(id);
            return ctg;
        }

        public async Task<Category> AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            var ctg = await GetByIdCategoryAsync(category.Id);
            ctg.Name = category.Name;
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteAsync(int id)
        {
            var ctg = await GetByIdCategoryAsync(id);
            _context.Categories.Remove(ctg);
            return ctg;
        }
    }
}
