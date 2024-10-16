using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapThucTap.Models
{
    [Table("tbl_DM_San_Pham")]
    public class Product
    {
        [Key]
        [Column("Ma_San_Pham")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [Column("Ten_San_Pham")]
        public string ProductName { get; set; }
    }
}
