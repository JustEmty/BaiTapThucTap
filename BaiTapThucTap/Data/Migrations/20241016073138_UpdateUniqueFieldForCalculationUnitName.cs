using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUniqueFieldForCalculationUnitName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ten_Don_Vi_Tinh",
                table: "tbl_DM_Don_Vi_Tinh",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Don_Vi_Tinh_Ten_Don_Vi_Tinh",
                table: "tbl_DM_Don_Vi_Tinh",
                column: "Ten_Don_Vi_Tinh",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Don_Vi_Tinh_Ten_Don_Vi_Tinh",
                table: "tbl_DM_Don_Vi_Tinh");

            migrationBuilder.AlterColumn<string>(
                name: "Ten_Don_Vi_Tinh",
                table: "tbl_DM_Don_Vi_Tinh",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
