using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface ISupplierRepository
    {
        public Task<List<Supplier>> GetAllAsync();
        public Task<Supplier?> GetAsync(int id);
        public Task CreateAsync(Supplier supplier);
        public Task UpdateAsync(Supplier supplier);
        public Task DeleteAsync(Supplier supplier);
    }
}
