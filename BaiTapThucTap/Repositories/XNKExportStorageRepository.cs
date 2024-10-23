using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class XNKExportStorageRepository : IXNKExportStorageRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public XNKExportStorageRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task CreateAsync(XNKExportStorage xnkExportStorage)
        {
            await applicationDbContext.XNKExportStorages.AddAsync(xnkExportStorage);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<XNKExportStorage>> GetAllAsync()
        {
            return await applicationDbContext.XNKExportStorages.ToListAsync();
        }

        public async Task<XNKExportStorage?> GetAsync(string xnkExportStorageName)
        {
            return await applicationDbContext.XNKExportStorages.Where(i => i.ExportStorageName == xnkExportStorageName).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(XNKExportStorage xnkExportStorage)
        {
            applicationDbContext.XNKExportStorages.Update(xnkExportStorage);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
