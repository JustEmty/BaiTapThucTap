using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class StorageUserRepository : IStorageUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StorageUserRepository(ApplicationDbContext applicationDbContext) => 
            this.applicationDbContext = applicationDbContext;

        public async Task CreateAsync(StorageUser storageUser)
        {
            await applicationDbContext.StorageUsers.AddAsync(storageUser);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<StorageUser>> GetAllAsync()
        {
            return await applicationDbContext.StorageUsers.ToListAsync();
        }
    }
}
