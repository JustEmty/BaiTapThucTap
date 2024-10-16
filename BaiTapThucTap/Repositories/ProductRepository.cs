using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext) => 
            this.applicationDbContext = applicationDbContext;

        public async Task CreateAsync(Product product)
        {
            await applicationDbContext.Products.AddAsync(product);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            applicationDbContext.Products.Remove(product);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await applicationDbContext.Products.ToListAsync();
        }

        public async Task<Product?> GetAsync(int id)
        {
            return await applicationDbContext.Products.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            applicationDbContext.Products.Update(product);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
