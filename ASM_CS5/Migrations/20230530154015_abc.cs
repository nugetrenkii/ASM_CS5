using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASM_CS5.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "KhachHang",
                type: "varchar(max)",
                unicode: false,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatKhau",
                table: "KhachHang",
                type: "varchar(max)",
                unicode: false,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "KhachHang");
        }
    }
}
