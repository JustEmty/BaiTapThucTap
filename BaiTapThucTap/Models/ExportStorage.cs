using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
	[Table("tbl_DM_Xuat_Kho")]
	public class ExportStorage
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Số phiếu xuất không được rỗng")]
		[Column("So_Phieu_Xuat_Kho")]
		public string ExportStorageName { get; set; }

		[ForeignKey(nameof(Storage))]
		[Required(ErrorMessage = "Kho không được rổng")]
		[Column("Kho_ID")]
		public int StorageId { get; set; }
		public Storage? Storage { get; set; }

		[Required(ErrorMessage = "Ngày xuất kho không được rỗng")]
		[Column("Ngay_Xuat_Kho")]
		public DateOnly ExportStorageDate { get; set; }

		public string? Note {  get; set; }
	}
}
