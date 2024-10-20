using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IEntryStorageFormRawDataRepository
    {
        public Task<List<EntryStorageFormRawData>> GetAllAsync();
        public Task<EntryStorageFormRawData?> GetAsync(int id);
        public Task CreateAsync(EntryStorageFormRawData entryStorageFormRawData);
        public Task UpdateAsync(EntryStorageFormRawData entryStorageFormRawData);
        public Task DeleteAsync(EntryStorageFormRawData entryStorageFormRawData);
    }
}
