using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
	public interface IExportStorageRepository
	{
		public Task<List<ExportStorage>> GetAllAsync();
		public Task<ExportStorage?> GetAsync(int id);
		public Task CreateAsync(ExportStorage exportStorage);
		public Task DeleteAsync(ExportStorage exportStorage);
	}
}
