using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_XNK_Xuat_Kho")]
    public class XNKExportStorage
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ExportStorage.ExportStorageName))]
        [Required(ErrorMessage = "Số phiếu xuất không được rỗng")]
        [Column("So_Phieu_Xuat_Kho")]
        public string ExportStorageName { get; set; }
        public ExportStorage? ExportStorage { get; set; }

        [ForeignKey(nameof(Storage))]
        [Required(ErrorMessage = "Kho không được rổng")]
        [Column("Kho_ID")]
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }

        [Required(ErrorMessage = "Ngày xuất kho không được rỗng")]
        [Column("Ngay_Xuat_Kho")]
        public DateOnly ExportStorageDate { get; set; } 
    }
}
