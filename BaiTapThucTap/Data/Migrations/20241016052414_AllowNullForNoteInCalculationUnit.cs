using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapThucTap.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullForNoteInCalculationUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ghi_Chu",
                table: "tbl_DM_Don_Vi_Tinh",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ghi_Chu",
                table: "tbl_DM_Don_Vi_Tinh",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
