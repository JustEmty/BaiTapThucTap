using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product?> GetAsync(int id);
        public Task CreateAsync(Product product);
        public Task UpdateAsync(Product product);
        public Task DeleteAsync(Product product);
    }
}
