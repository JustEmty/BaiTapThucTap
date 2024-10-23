using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
	[Table("tbl_DM_Xuat_Kho_Raw_Data")]
	public class ExportStorageRawData
	{
		[Key]
		[Column("Xuat_Kho_ID")]
		public int Id { get; set; }

        public int ExportStorageId { get; set; }
        public ExportStorage? ExportStorage { get; set; }

        [ForeignKey(nameof(Product))]
		[Required]
		[Column("San_Pham_ID")]
		public int ProductId { get; set; }
		public Product? Product { get; set; }

		[Required(ErrorMessage = "Số lượng không được để trống")]
		[Column("SL_Xuat")]
		public int Quantities { get; set; }

		[Required(ErrorMessage = "Đơn giá không được để trống")]
		[Column("Don_Gia_Xuat", TypeName = "decimal(18,2)")]
		public decimal? Price { get; set; }
	}
}
