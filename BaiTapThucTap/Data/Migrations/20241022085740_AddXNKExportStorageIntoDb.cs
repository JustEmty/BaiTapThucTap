using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class AddXNKExportStorageIntoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_XNK_Xuat_Kho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    So_Phieu_Xuat_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExportStorageId = table.Column<int>(type: "int", nullable: true),
                    Kho_ID = table.Column<int>(type: "int", nullable: false),
                    Ngay_Xuat_Kho = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_XNK_Xuat_Kho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_XNK_Xuat_Kho_tbl_DM_Kho_Kho_ID",
                        column: x => x.Kho_ID,
                        principalTable: "tbl_DM_Kho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_XNK_Xuat_Kho_tbl_DM_Xuat_Kho_ExportStorageId",
                        column: x => x.ExportStorageId,
                        principalTable: "tbl_DM_Xuat_Kho",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_XNK_Xuat_Kho_ExportStorageId",
                table: "tbl_XNK_Xuat_Kho",
                column: "ExportStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_XNK_Xuat_Kho_Kho_ID",
                table: "tbl_XNK_Xuat_Kho",
                column: "Kho_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_XNK_Xuat_Kho_So_Phieu_Xuat_Kho",
                table: "tbl_XNK_Xuat_Kho",
                column: "So_Phieu_Xuat_Kho",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_XNK_Xuat_Kho");
        }
    }
}
