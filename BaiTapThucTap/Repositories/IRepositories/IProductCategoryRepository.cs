using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IProductCategoryRepository
    {
        public Task<List<ProductCategory>> GetAllAsync();
        public Task<ProductCategory?> GetAsync(int id);
        public Task CreateAsync(ProductCategory productCategory);
        public Task UpdateAsync(ProductCategory productCategory);
        public Task DeleteAsync(ProductCategory productCategory);
    }
}
