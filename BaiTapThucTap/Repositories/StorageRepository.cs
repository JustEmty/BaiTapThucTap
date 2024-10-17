using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class StorageRepository : IStorageRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StorageRepository(ApplicationDbContext applicationDbContext) =>
            this.applicationDbContext = applicationDbContext;


        public async Task CreateAsync(Storage storage)
        {
            await applicationDbContext.Storages.AddAsync(storage);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Storage storage)
        {
            applicationDbContext.Storages.Remove(storage);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Storage>> GetAllAsync()
        {
            return await applicationDbContext.Storages.ToListAsync();
        }

        public async Task<Storage?> GetAsync(int id)
        {
            return await applicationDbContext.Storages.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Storage storage)
        {
            applicationDbContext.Storages.Update(storage);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
