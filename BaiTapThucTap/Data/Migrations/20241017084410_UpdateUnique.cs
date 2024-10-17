using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Kho_User_Kho_ID",
                table: "tbl_DM_Kho_User");

            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Kho_User_Ma_Dang_Nhap_Kho_ID",
                table: "tbl_DM_Kho_User");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Kho_User_Kho_ID",
                table: "tbl_DM_Kho_User",
                column: "Kho_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Kho_User_Ma_Dang_Nhap",
                table: "tbl_DM_Kho_User",
                column: "Ma_Dang_Nhap",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Kho_User_Kho_ID",
                table: "tbl_DM_Kho_User");

            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Kho_User_Ma_Dang_Nhap",
                table: "tbl_DM_Kho_User");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Kho_User_Kho_ID",
                table: "tbl_DM_Kho_User",
                column: "Kho_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Kho_User_Ma_Dang_Nhap_Kho_ID",
                table: "tbl_DM_Kho_User",
                columns: new[] { "Ma_Dang_Nhap", "Kho_ID" },
                unique: true);
        }
    }
}
