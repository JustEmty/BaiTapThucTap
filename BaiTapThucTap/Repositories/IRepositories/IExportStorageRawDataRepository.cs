using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IExportStorageRawDataRepository
    {
        public Task<List<ExportStorageRawData>> GetAllSortedDataAsync(int exportStorageFormId);
        public Task<List<ExportStorageRawData>> GetAllAsync();
        public Task<ExportStorageRawData?> GetAsync(int id);
        public Task CreateAsync(ExportStorageRawData exportStorageRawData);
        public Task UpdateAsync(ExportStorageRawData exportStorageRawData);
        public Task DeleteAsync(ExportStorageRawData exportStorageRawData);
    }
}
