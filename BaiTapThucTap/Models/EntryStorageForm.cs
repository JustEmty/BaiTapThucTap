using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_Nhap_Kho")]
    public class EntryStorageForm
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Số phiếu nhập không được rỗng")]
        [Column("So_Phieu_Nhap_Kho")]
        public string EntryStorageFormId { get; set; }

        [Column("Kho_ID")]
        [Required]
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }

        [Column("NCC_ID")]
        [Required]
        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        [Column("Ngay_Nhap_Kho")]
        [Required(ErrorMessage = "Ngày nhập kho không được rỗng")]
        public DateTime EntryStorageFormDate { get; set; }

        [Column("Ghi_Chu")]
        public string? Note { get; set; }
    }
}
