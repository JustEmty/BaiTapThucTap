using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
    public class EntryStorageFormRawDataRepository : IEntryStorageFormRawDataRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EntryStorageFormRawDataRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task CreateAsync(EntryStorageFormRawData entryStorageFormRawData)
        {
            await applicationDbContext.EntryStorageFormRawDatas.AddAsync(entryStorageFormRawData);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(EntryStorageFormRawData entryStorageFormRawData)
        {
            applicationDbContext.EntryStorageFormRawDatas.Remove(entryStorageFormRawData);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<EntryStorageFormRawData>> GetAllSortedDataAsync(int entryStorageFormId)
        {
            return await applicationDbContext.EntryStorageFormRawDatas.Where(i => i.EntryStorageFormId == entryStorageFormId).ToListAsync();
        }

		public async Task<List<EntryStorageFormRawData>> GetAllAsync()
		{
			return await applicationDbContext.EntryStorageFormRawDatas.ToListAsync();
		}

		public async Task<EntryStorageFormRawData?> GetAsync(int id)
        {
            return await applicationDbContext.EntryStorageFormRawDatas.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(EntryStorageFormRawData entryStorageFormRawData)
        {
            applicationDbContext.EntryStorageFormRawDatas.Update(entryStorageFormRawData);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
