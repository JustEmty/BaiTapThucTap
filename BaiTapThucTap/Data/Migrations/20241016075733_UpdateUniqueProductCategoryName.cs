using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUniqueProductCategoryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ten_LSP",
                table: "tbl_DM_Loai_San_Pham",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Loai_San_Pham_Ten_LSP",
                table: "tbl_DM_Loai_San_Pham",
                column: "Ten_LSP",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Loai_San_Pham_Ten_LSP",
                table: "tbl_DM_Loai_San_Pham");

            migrationBuilder.AlterColumn<string>(
                name: "Ten_LSP",
                table: "tbl_DM_Loai_San_Pham",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
