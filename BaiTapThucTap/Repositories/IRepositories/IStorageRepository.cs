using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IStorageRepository
    {
        public Task<List<Storage>> GetAllAsync();
        public Task<Storage?> GetAsync(int id);
        public Task CreateAsync(Storage storage);
        public Task UpdateAsync(Storage storage);
        public Task DeleteAsync(Storage storage);
    }
}
