using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class AddStorageUserIntoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Kho_User");
        }
    }
}
