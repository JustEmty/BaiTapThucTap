using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class EntryStorageFormRepository : IEntryStorageFormRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EntryStorageFormRepository(ApplicationDbContext applicationDbContext) =>
            this.applicationDbContext = applicationDbContext;

        public async Task CreateAsync(EntryStorageForm entryStorageForm)
        {
            await applicationDbContext.EntryStorageForms.AddAsync(entryStorageForm);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<EntryStorageForm>> GetAllAsync()
        {
            return await applicationDbContext.EntryStorageForms.ToListAsync();
        }

        public async Task<EntryStorageForm?> GetAsync(int id)
        {
            return await applicationDbContext.EntryStorageForms.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(EntryStorageForm entryStorageForm)
        {
            applicationDbContext.EntryStorageForms.Update(entryStorageForm);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
