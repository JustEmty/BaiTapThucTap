using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_Nhap_Kho_Raw_Data")]
    public class EntryStorageFormRawData
    {
        [Key]
        public int Id { get; set; }

        [Column("Nhap_Kho_ID")]
        [ForeignKey(nameof(EntryStorageForm))]
        public int EntryStorageFormId { get; set; }
        public EntryStorageForm? EntryStorageForm { get; set; }

        [Column("San_Pham_ID")]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Column("SL_Nhap")]
        public int? Quantities { get; set; }

        [Column("Don_Gia_Nhap", TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
    }
}
