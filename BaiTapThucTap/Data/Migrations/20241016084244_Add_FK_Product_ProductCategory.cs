using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class Add_FK_Product_ProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_San_Pham",
                columns: table => new
                {
                    Ma_San_Pham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_San_Pham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loai_San_Pham_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_San_Pham", x => x.Ma_San_Pham);
                    table.ForeignKey(
                        name: "FK_tbl_DM_San_Pham_tbl_DM_Loai_San_Pham_Loai_San_Pham_ID",
                        column: x => x.Loai_San_Pham_ID,
                        principalTable: "tbl_DM_Loai_San_Pham",
                        principalColumn: "Ma_LSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DM_San_Pham_Loai_San_Pham_ID",
                table: "tbl_DM_San_Pham",
                column: "Loai_San_Pham_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_San_Pham");
        }
    }
}
