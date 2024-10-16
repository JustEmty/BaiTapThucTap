using BaiTapThucTap.Data;
using BaiTapThucTap.Models;
using BaiTapThucTap.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BaiTapThucTap.Repositories
{
	public class CalculationUnitRepository : ICalculationUnitRepository
	{
		private readonly ApplicationDbContext applicationDbContext;

		public CalculationUnitRepository(ApplicationDbContext applicationDbContext) =>
			this.applicationDbContext = applicationDbContext;


		public async Task CreateAsync(CalculationUnit calculationUnit)
		{
			await applicationDbContext.CalculationUnits.AddAsync(calculationUnit);
			await applicationDbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(CalculationUnit calculationUnit)
		{
			applicationDbContext.CalculationUnits.Remove(calculationUnit);
			await applicationDbContext.SaveChangesAsync();
		}

		public async Task<List<CalculationUnit>> GetAllAsync()
		{
			return await applicationDbContext.CalculationUnits.ToListAsync();
		}

		public Task<CalculationUnit?> GetAsync(int id)
		{
			return applicationDbContext.CalculationUnits.Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public async Task UpdateAsync(CalculationUnit calculationUnit)
		{
			applicationDbContext.CalculationUnits.Update(calculationUnit);
			await applicationDbContext.SaveChangesAsync();
		}
	}
}
