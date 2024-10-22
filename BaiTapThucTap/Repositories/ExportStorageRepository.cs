using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
	public class ExportStorageRepository : IExportStorageRepository
	{
		private readonly ApplicationDbContext applicationDbContext;

        public ExportStorageRepository(ApplicationDbContext applicationDbContext) => 
			this.applicationDbContext = applicationDbContext;

		public async Task CreateAsync(ExportStorage exportStorage)
		{
			await applicationDbContext.ExportStorages.AddAsync(exportStorage);
			await applicationDbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(ExportStorage exportStorage)
		{
			applicationDbContext.ExportStorages.Remove(exportStorage);
			await applicationDbContext.SaveChangesAsync();
		}

		public async Task<List<ExportStorage>> GetAllAsync()
		{
			return await applicationDbContext.ExportStorages.ToListAsync();
		}

		public async Task<ExportStorage?> GetAsync(int id)
		{
			return await applicationDbContext.ExportStorages.Where(i => i.Id == id).FirstOrDefaultAsync();
		}
	}
}
