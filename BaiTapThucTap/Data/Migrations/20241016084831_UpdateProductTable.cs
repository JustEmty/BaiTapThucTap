using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ghi_Chu",
                table: "tbl_DM_San_Pham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_San_Pham_Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham",
                column: "Don_Vi_Tinh_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_San_Pham_tbl_DM_Don_Vi_Tinh_Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham",
                column: "Don_Vi_Tinh_ID",
                principalTable: "tbl_DM_Don_Vi_Tinh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_San_Pham_tbl_DM_Don_Vi_Tinh_Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham");

            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_San_Pham_Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham");

            migrationBuilder.DropColumn(
                name: "Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham");

            migrationBuilder.DropColumn(
                name: "Ghi_Chu",
                table: "tbl_DM_San_Pham");
        }
    }
}
