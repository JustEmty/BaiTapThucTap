using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_Kho")]
    public class Storage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên kho không được để trống")]
        [Column("Ten_Kho")]
        public string StorageName { get; set; }

        [Column("Ghi_Chu")]
        public string? Note { get; set; }
    }
}
