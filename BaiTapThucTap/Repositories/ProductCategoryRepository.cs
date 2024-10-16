using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductCategoryRepository(ApplicationDbContext applicationDbContext) =>
            this.applicationDbContext = applicationDbContext;

        public async Task CreateAsync(ProductCategory productCategory)
        {
            await applicationDbContext.ProductCategories.AddAsync(productCategory);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(ProductCategory productCategory)
        {
            applicationDbContext.ProductCategories.Remove(productCategory);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<ProductCategory>> GetAllAsync()
        {
            return await applicationDbContext.ProductCategories.ToListAsync();
        }

        public async Task<ProductCategory?> GetAsync(int id)
        {
            return await applicationDbContext.ProductCategories.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(ProductCategory productCategory)
        {
            applicationDbContext.ProductCategories.Update(productCategory);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
