using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_Kho_User")]
    public class StorageUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã đăng nhập không được để trống")]
        [Column("Ma_Dang_Nhap")]
        public string LoginCode { get; set; }

        [Required(ErrorMessage = "Kho không được để trống")]
        [Column("Kho_ID")]
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }
    }
}
