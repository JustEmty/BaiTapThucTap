using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_XNK_Nhap_Kho")]
    public class ExportEntryStorageForm
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Số phiếu nhập không được rổng")]
        [Column("So_Phieu_Nhap_Kho")]
        public string EntryStorageFormId { get; set; }

        [Required]
        [Column("NCC_ID")]
        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        [Required]
        [Column("Kho_ID")]
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }

        [Required(ErrorMessage = "Ngày nhập kho không được rổng")]
        [Column("Ngay_Nhap_Kho")]
        public DateOnly EntryStorageFormDate { get; set; }
    }
}
