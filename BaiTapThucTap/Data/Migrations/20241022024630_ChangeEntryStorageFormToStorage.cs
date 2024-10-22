using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEntryStorageFormToStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Nhap_Kho_Nhap_Kho_ID",
                table: "tbl_DM_Nhap_Kho_Raw_Data");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Kho_Nhap_Kho_ID",
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                column: "Nhap_Kho_ID",
                principalTable: "tbl_DM_Kho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Kho_Nhap_Kho_ID",
                table: "tbl_DM_Nhap_Kho_Raw_Data");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Nhap_Kho_Nhap_Kho_ID",
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                column: "Nhap_Kho_ID",
                principalTable: "tbl_DM_Nhap_Kho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
