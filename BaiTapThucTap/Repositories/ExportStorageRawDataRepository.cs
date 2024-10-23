using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class ExportStorageRawDataRepository : IExportStorageRawDataRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ExportStorageRawDataRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task CreateAsync(ExportStorageRawData exportStorageRawData)
        {
            await applicationDbContext.ExportStorageRawDatas.AddAsync(exportStorageRawData);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(ExportStorageRawData exportStorageRawData)
        {
            applicationDbContext.ExportStorageRawDatas.Remove(exportStorageRawData);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<ExportStorageRawData>> GetAllAsync()
        {
            return await applicationDbContext.ExportStorageRawDatas.ToListAsync();
        }

        public async Task<ExportStorageRawData?> GetAsync(int id)
        {
            return await applicationDbContext.ExportStorageRawDatas.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(ExportStorageRawData exportStorageRawData)
        {
            applicationDbContext.ExportStorageRawDatas.Update(exportStorageRawData);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
