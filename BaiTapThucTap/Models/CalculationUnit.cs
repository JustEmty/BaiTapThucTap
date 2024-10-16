using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
	[Table("tbl_DM_Don_Vi_Tinh")]
	public class CalculationUnit
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Tên đơn vị tính không được rỗng")]
		[Column("Ten_Don_Vi_Tinh")]
		public string CalculationUnitName { get; set; }

		[Column("Ghi_Chu")]
		public string? Note { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
