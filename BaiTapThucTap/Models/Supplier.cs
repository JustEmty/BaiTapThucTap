using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_NCC")]
    public class Supplier
    {
        [Key]
        [Column("Ma_NCC")]
        public int Id { get; set; }

        [Column("Ten_NCC")]
        [Required(ErrorMessage = "Tên nhà cung cấp không được để trống và là duy nhất")]
        public string SupplierName { get; set; }

        [Column("Ghi_Chu")]
        public string? Note { get; set; }
    }
}
