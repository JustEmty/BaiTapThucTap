using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
	public interface ICalculationUnitRepository
	{
		public Task<List<CalculationUnit>> GetAllAsync();
		public Task<CalculationUnit?> GetAsync(int id);
		public Task CreateAsync(CalculationUnit calculationUnit);
		public Task UpdateAsync(CalculationUnit calculationUnit);
		public Task DeleteAsync(CalculationUnit calculationUnit);
	}
}
