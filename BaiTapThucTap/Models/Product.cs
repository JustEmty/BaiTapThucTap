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

        [Column("Loai_San_Pham_ID")]
        [Required]
        [ForeignKey(nameof(ProductCategory))]
        public int ProductCategoryId { get; set; } 

        public ProductCategory? ProductCategory { get; set; }

        [Column("Don_Vi_Tinh_ID")]
        [Required]
        [ForeignKey(nameof(CalculationUnit))]
        public int CalculationUnitId { get; set; }

        public CalculationUnit? CalculationUnit { get; set; }

        [Column("Ghi_Chu")]
        public string? Note { get; set; }
    }
}
