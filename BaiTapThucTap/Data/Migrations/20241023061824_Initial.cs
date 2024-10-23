using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Don_Vi_Tinh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Don_Vi_Tinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Don_Vi_Tinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_Kho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Kho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_Loai_San_Pham",
                columns: table => new
                {
                    Ma_LSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_LSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Loai_San_Pham", x => x.Ma_LSP);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_NCC",
                columns: table => new
                {
                    Ma_NCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_NCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_NCC", x => x.Ma_NCC);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_Kho_User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_Dang_Nhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kho_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Kho_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_DM_Kho_User_tbl_DM_Kho_Kho_ID",
                        column: x => x.Kho_ID,
                        principalTable: "tbl_DM_Kho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_Xuat_Kho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    So_Phieu_Xuat_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kho_ID = table.Column<int>(type: "int", nullable: false),
                    Ngay_Xuat_Kho = table.Column<DateOnly>(type: "date", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Xuat_Kho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_DM_Xuat_Kho_tbl_DM_Kho_Kho_ID",
                        column: x => x.Kho_ID,
                        principalTable: "tbl_DM_Kho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_San_Pham",
                columns: table => new
                {
                    Ma_San_Pham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_San_Pham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loai_San_Pham_ID = table.Column<int>(type: "int", nullable: false),
                    Don_Vi_Tinh_ID = table.Column<int>(type: "int", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_San_Pham", x => x.Ma_San_Pham);
                    table.ForeignKey(
                        name: "FK_tbl_DM_San_Pham_tbl_DM_Don_Vi_Tinh_Don_Vi_Tinh_ID",
                        column: x => x.Don_Vi_Tinh_ID,
                        principalTable: "tbl_DM_Don_Vi_Tinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_DM_San_Pham_tbl_DM_Loai_San_Pham_Loai_San_Pham_ID",
                        column: x => x.Loai_San_Pham_ID,
                        principalTable: "tbl_DM_Loai_San_Pham",
                        principalColumn: "Ma_LSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_Nhap_Kho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    So_Phieu_Nhap_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kho_ID = table.Column<int>(type: "int", nullable: false),
                    NCC_ID = table.Column<int>(type: "int", nullable: false),
                    Ngay_Nhap_Kho = table.Column<DateOnly>(type: "date", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Nhap_Kho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_DM_Nhap_Kho_tbl_DM_Kho_Kho_ID",
                        column: x => x.Kho_ID,
                        principalTable: "tbl_DM_Kho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_DM_Nhap_Kho_tbl_DM_NCC_NCC_ID",
                        column: x => x.NCC_ID,
                        principalTable: "tbl_DM_NCC",
                        principalColumn: "Ma_NCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_XNK_Nhap_Kho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    So_Phieu_Nhap_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NCC_ID = table.Column<int>(type: "int", nullable: false),
                    Kho_ID = table.Column<int>(type: "int", nullable: false),
                    Ngay_Nhap_Kho = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_XNK_Nhap_Kho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_XNK_Nhap_Kho_tbl_DM_Kho_Kho_ID",
                        column: x => x.Kho_ID,
                        principalTable: "tbl_DM_Kho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_XNK_Nhap_Kho_tbl_DM_NCC_NCC_ID",
                        column: x => x.NCC_ID,
                        principalTable: "tbl_DM_NCC",
                        principalColumn: "Ma_NCC",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "tbl_DM_Xuat_Kho_Raw_Data",
                columns: table => new
                {
                    Xuat_Kho_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    San_Pham_ID = table.Column<int>(type: "int", nullable: false),
                    SL_Xuat = table.Column<int>(type: "int", nullable: false),
                    Don_Gia_Xuat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Xuat_Kho_Raw_Data", x => x.Xuat_Kho_ID);
                    table.ForeignKey(
                        name: "FK_tbl_DM_Xuat_Kho_Raw_Data_tbl_DM_San_Pham_San_Pham_ID",
                        column: x => x.San_Pham_ID,
                        principalTable: "tbl_DM_San_Pham",
                        principalColumn: "Ma_San_Pham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DM_Nhap_Kho_Raw_Data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryStorageFormId = table.Column<int>(type: "int", nullable: false),
                    Nhap_Kho_ID = table.Column<int>(type: "int", nullable: false),
                    San_Pham_ID = table.Column<int>(type: "int", nullable: false),
                    SL_Nhap = table.Column<int>(type: "int", nullable: false),
                    Don_Gia_Nhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EntryStorageFormId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Nhap_Kho_Raw_Data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Kho_Nhap_Kho_ID",
                        column: x => x.Nhap_Kho_ID,
                        principalTable: "tbl_DM_Kho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Nhap_Kho_EntryStorageFormId",
                        column: x => x.EntryStorageFormId,
                        principalTable: "tbl_DM_Nhap_Kho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_Nhap_Kho_EntryStorageFormId1",
                        column: x => x.EntryStorageFormId1,
                        principalTable: "tbl_DM_Nhap_Kho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_DM_Nhap_Kho_Raw_Data_tbl_DM_San_Pham_San_Pham_ID",
                        column: x => x.San_Pham_ID,
                        principalTable: "tbl_DM_San_Pham",
                        principalColumn: "Ma_San_Pham");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Don_Vi_Tinh_Ten_Don_Vi_Tinh",
                table: "tbl_DM_Don_Vi_Tinh",
                column: "Ten_Don_Vi_Tinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Kho_Ten_Kho",
                table: "tbl_DM_Kho",
                column: "Ten_Kho",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Loai_San_Pham_Ten_LSP",
                table: "tbl_DM_Loai_San_Pham",
                column: "Ten_LSP",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_NCC_Ten_NCC",
                table: "tbl_DM_NCC",
                column: "Ten_NCC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_Kho_ID",
                table: "tbl_DM_Nhap_Kho",
                column: "Kho_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_NCC_ID",
                table: "tbl_DM_Nhap_Kho",
                column: "NCC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_So_Phieu_Nhap_Kho",
                table: "tbl_DM_Nhap_Kho",
                column: "So_Phieu_Nhap_Kho",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_Raw_Data_EntryStorageFormId",
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                column: "EntryStorageFormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_Raw_Data_EntryStorageFormId1",
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                column: "EntryStorageFormId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_Raw_Data_Nhap_Kho_ID",
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                column: "Nhap_Kho_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Nhap_Kho_Raw_Data_San_Pham_ID",
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                column: "San_Pham_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_San_Pham_Don_Vi_Tinh_ID",
                table: "tbl_DM_San_Pham",
                column: "Don_Vi_Tinh_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_San_Pham_Loai_San_Pham_ID",
                table: "tbl_DM_San_Pham",
                column: "Loai_San_Pham_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Xuat_Kho_Kho_ID",
                table: "tbl_DM_Xuat_Kho",
                column: "Kho_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Xuat_Kho_So_Phieu_Xuat_Kho",
                table: "tbl_DM_Xuat_Kho",
                column: "So_Phieu_Xuat_Kho",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_Xuat_Kho_Raw_Data_San_Pham_ID",
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                column: "San_Pham_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_XNK_Nhap_Kho_Kho_ID",
                table: "tbl_XNK_Nhap_Kho",
                column: "Kho_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_XNK_Nhap_Kho_NCC_ID",
                table: "tbl_XNK_Nhap_Kho",
                column: "NCC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_XNK_Nhap_Kho_So_Phieu_Nhap_Kho",
                table: "tbl_XNK_Nhap_Kho",
                column: "So_Phieu_Nhap_Kho",
                unique: true);

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
                name: "tbl_DM_Kho_User");

            migrationBuilder.DropTable(
                name: "tbl_DM_Nhap_Kho_Raw_Data");

            migrationBuilder.DropTable(
                name: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropTable(
                name: "tbl_XNK_Nhap_Kho");

            migrationBuilder.DropTable(
                name: "tbl_XNK_Xuat_Kho");

            migrationBuilder.DropTable(
                name: "tbl_DM_Nhap_Kho");

            migrationBuilder.DropTable(
                name: "tbl_DM_San_Pham");

            migrationBuilder.DropTable(
                name: "tbl_DM_Xuat_Kho");

            migrationBuilder.DropTable(
                name: "tbl_DM_NCC");

            migrationBuilder.DropTable(
                name: "tbl_DM_Don_Vi_Tinh");

            migrationBuilder.DropTable(
                name: "tbl_DM_Loai_San_Pham");

            migrationBuilder.DropTable(
                name: "tbl_DM_Kho");
        }
    }
}
