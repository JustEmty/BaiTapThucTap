using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IEntryStorageFormRepository
    {
        public Task<List<EntryStorageForm>> GetAllAsync();
        public Task<EntryStorageForm?> GetAsync(int id);
        public Task CreateAsync(EntryStorageForm entryStorageForm);
        public Task DeleteAsync(EntryStorageForm entryStorageForm);
    }
}
