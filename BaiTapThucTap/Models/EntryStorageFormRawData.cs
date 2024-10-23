using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_Nhap_Kho_Raw_Data")]
    public class EntryStorageFormRawData
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("So_Phieu_Nhap")]
        public int EntryStorageFormId { get; set; }
        public EntryStorageForm? EntryStorageForm { get; set; }

        [Column("Nhap_Kho_ID")]
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }

        [Column("San_Pham_ID")]
        [ForeignKey(nameof(Product))]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Column("SL_Nhap")]
		[Required(ErrorMessage = "Số lượng không được để trống")]
		public int? Quantities { get; set; }

        [Column("Don_Gia_Nhap", TypeName = "decimal(18,2)")]
		[Required(ErrorMessage = "Đơn giá không được để trống")]
		public decimal? Price { get; set; }
    }
}
