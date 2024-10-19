using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;

namespace BaiTapThucTap.Repositories
{
    public class ExportEntryStorageFormRepository : IExportEntryStorageFormRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ExportEntryStorageFormRepository(ApplicationDbContext applicationDbContext) =>
            this.applicationDbContext = applicationDbContext;

        public async Task UpdateAsync(ExportEntryStorageForm exportEntryStorageForm)
        {
            applicationDbContext.ExportEntryStorageForms.Update(exportEntryStorageForm);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
