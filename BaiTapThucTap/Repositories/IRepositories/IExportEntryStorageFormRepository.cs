using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IExportEntryStorageFormRepository
    {
        public Task UpdateAsync(ExportEntryStorageForm exportEntryStorageForm);
    }
}
