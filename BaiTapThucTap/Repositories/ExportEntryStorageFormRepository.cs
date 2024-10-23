using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class ExportEntryStorageFormRepository : IExportEntryStorageFormRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ExportEntryStorageFormRepository(ApplicationDbContext applicationDbContext) =>
            this.applicationDbContext = applicationDbContext;

		public async Task CreateAsync(ExportEntryStorageForm entryStorageForm)
		{
			await applicationDbContext.ExportEntryStorageForms.AddAsync(entryStorageForm);
            await applicationDbContext.SaveChangesAsync();
		}

        public async Task<List<ExportEntryStorageForm>> GetAllAsync()
        {
            return await applicationDbContext.ExportEntryStorageForms.ToListAsync();
        }

        public async Task<ExportEntryStorageForm> GetAsync(string entryStorageFormId)
		{
			return await applicationDbContext.ExportEntryStorageForms.Where(i => i.EntryStorageFormId == entryStorageFormId).FirstOrDefaultAsync();
		}

        public async Task UpdateAsync(ExportEntryStorageForm exportEntryStorageForm)
        {
            applicationDbContext.ExportEntryStorageForms.Update(exportEntryStorageForm);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
