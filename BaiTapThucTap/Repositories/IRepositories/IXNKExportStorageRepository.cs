using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IXNKExportStorageRepository
    {
        public Task<List<XNKExportStorage>> GetAllAsync();
        public Task<XNKExportStorage?> GetAsync(string xnkExportStorageName);
        public Task CreateAsync(XNKExportStorage xnkExportStorage);
        public Task UpdateAsync(XNKExportStorage xnkExportStorage);
    }
}
