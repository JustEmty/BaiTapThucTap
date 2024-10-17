using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IStorageUserRepository
    {
        public Task<List<StorageUser>> GetAllAsync();
        public Task CreateAsync(StorageUser storageUser);
    }
}
