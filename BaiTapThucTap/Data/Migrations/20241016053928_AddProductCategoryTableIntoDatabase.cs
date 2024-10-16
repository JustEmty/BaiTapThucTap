using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class AddProductCategoryTableIntoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Loai_San_Pham",
                columns: table => new
                {
                    Ma_LSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_LSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Loai_San_Pham", x => x.Ma_LSP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Loai_San_Pham");
        }
    }
}
