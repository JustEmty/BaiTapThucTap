using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExportStorageRawDataAndExportStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_San_Pham_San_Pham_ID",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.AddColumn<int>(
                name: "ExportStorageId",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExportStorageId1",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Xuat_Kho_Raw_Data_ExportStorageId",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "ExportStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Xuat_Kho_Raw_Data_ExportStorageId1",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "ExportStorageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_San_Pham_San_Pham_ID",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "San_Pham_ID",
                principalTable: "tbl_DM_San_Pham",
                principalColumn: "Ma_San_Pham");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_Xuat_Kho_ExportStorageId",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "ExportStorageId",
                principalTable: "tbl_DM_Xuat_Kho",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_Xuat_Kho_ExportStorageId1",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "ExportStorageId1",
                principalTable: "tbl_DM_Xuat_Kho",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_San_Pham_San_Pham_ID",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_Xuat_Kho_ExportStorageId",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_Xuat_Kho_ExportStorageId1",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Xuat_Kho_Raw_Data_ExportStorageId",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropIndex(
                name: "IX_tbl_DM_Xuat_Kho_Raw_Data_ExportStorageId1",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropColumn(
                name: "ExportStorageId",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropColumn(
                name: "ExportStorageId1",
                table: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_San_Pham_San_Pham_ID",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "San_Pham_ID",
                principalTable: "tbl_DM_San_Pham",
                principalColumn: "Ma_San_Pham",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
