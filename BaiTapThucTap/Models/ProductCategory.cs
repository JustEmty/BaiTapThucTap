using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_Loai_San_Pham")]
    public class ProductCategory
    {
        [Key]
        [Column("Ma_LSP")]
        public int Id { get; set; }

        [Column("Ten_LSP")]
        [Required(ErrorMessage = "Tên loại sản phẩm không được rỗng")]
        public string ProductCategoryName { get; set; }

        [Column("Ghi_Chu")]
        public string? Note { get; set; }
    }
}
